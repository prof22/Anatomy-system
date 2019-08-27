
Imports System.IO
Imports System.Text
Imports System.Data.OleDb

Public Class FrmPatientReg
    Dim SQL As New SQLConnect

    Public Sub New()

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.connect()
        BindGrid()

    End Sub
    Private Sub BindGrid()
        Using cmd As New OleDbCommand("select * from patient_reg", SQL.con)
            cmd.CommandType = CommandType.Text
            Using sda As New OleDbDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Private Sub ToolStripBtnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click

        If TxtPatientID.Text = "" Or TxtName.Text = "" Or TxtAge.Text = "" Or TxtAddress.Text = "" Or TxtPhoneNo.Text = "" Then
            MsgBox("All Fields are Required..............Check", MsgBoxStyle.Critical, "Check")
            Exit Sub
        End If

        Try

            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim ct As String = "SELECT * FROM patient_reg WHERE PhoneNo = @PhoneNo"
            SQL.cmd = New OleDbCommand(ct)
            SQL.cmd.Connection = SQL.con
            SQL.cmd.Parameters.Add(New OleDbParameter("@PhoneNo", "PhoneNo"))
            SQL.cmd.Parameters("@PhoneNo").Value = TxtPhoneNo.Text()
            SQL.rdr = SQL.cmd.ExecuteReader()

            If SQL.rdr.Read Then
                MsgBox("The Phone Number is Already Exist", MsgBoxStyle.Critical, "Input Error")
                TxtPhoneNo.Clear()
                TxtPhoneNo.Focus()

            Else

                SQL.rdr.Close()

                Dim cb As String = "INSERT INTO patient_reg(Patient_ID, Fullname, Age, PhoneNo, Address) VALUES (@Patient_ID,@Fullname,@Age,@PhoneNo,@Address)"
                SQL.cmd = New OleDbCommand(cb)
                SQL.cmd.Connection = SQL.con

                SQL.cmd.Parameters.AddWithValue("@Patient_ID", TxtPatientID.Text)
                SQL.cmd.Parameters.AddWithValue("@Fullname", TxtName.Text)
                SQL.cmd.Parameters.AddWithValue("@Age", TxtAge.Text)
                SQL.cmd.Parameters.AddWithValue("@PhoneNo", TxtPhoneNo.Text)
                SQL.cmd.Parameters.AddWithValue("@Address", TxtAddress.Text)

                SQL.cmd.ExecuteNonQuery()
                MsgBox("Registration successfully saved!", MsgBoxStyle.Information, "Saved")
                BindGrid()

                'SQL.con.Close()
                clear()
                FrmPatientReg_Load(sender, e)
            End If
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            TxtPatientID.Text = DataGridView1.Item(0, i).Value.ToString
            TxtName.Text = DataGridView1.Item(1, i).Value.ToString
            TxtAge.Text = DataGridView1.Item(2, i).Value.ToString
            TxtAddress.Text = DataGridView1.Item(3, i).Value.ToString
            TxtPhoneNo.Text = DataGridView1.Item(4, i).Value.ToString
            TxtPatientID.Enabled = False
            TxtName.Enabled = False
            TxtAddress.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub DataGridView1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub clear()

        TxtPatientID.Clear()
        TxtName.Clear()
        TxtAge.Clear()
        TxtAddress.Clear()
        TxtPhoneNo.Clear()

    End Sub


    Private Sub ToolStripBtnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Try
            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If

            Dim cb As String = "delete from patient_reg where Patient_ID ='" & TxtPatientID.Text & "'"
            SQL.cmd = New OleDbCommand(cb, SQL.con)
            SQL.cmd.Connection = SQL.con
            SQL.cmd.ExecuteNonQuery()

            MsgBox("Patient Record" & vbNewLine & "Deleted Successfully", MsgBoxStyle.Information, "Delete")
            TxtName.Focus()
            BindGrid()
            clear()
            FrmPatientReg_Load(sender, e)
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ToolStripBtnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton3.Click

        Try
            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim Upate As String = "UPDATE patient_reg SET Age ='" & TxtAge.Text & "', PhoneNo ='" & TxtPhoneNo.Text & "', Address ='" & TxtAddress.Text & "' where Patient_ID='" & TxtPatientID.Text & "'"
            SQL.cmd = New OleDbCommand(Upate, SQL.con)
            SQL.cmd.Connection = SQL.con
            SQL.cmd.ExecuteNonQuery()

            MsgBox("Patient Record" & vbNewLine & "Updated Successfully", MsgBoxStyle.Information, "Update")
            TxtName.Focus()
            BindGrid()
            clear()
            FrmPatientReg_Load(sender, e)
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.Close()
    End Sub

    Private Sub FrmPatientReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ================='To generating random numbers

        Dim PatientID As New Random
        Dim numbers As Integer = PatientID.Next(1, 12345)
        Dim digits As String = numbers.ToString("00000")
        TxtPatientID.Text = "PI-" & digits
    End Sub

    Private Sub TxtPhoneNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPhoneNo.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAge.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TxtPhoneNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPhoneNo.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class