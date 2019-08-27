Imports System.IO
Imports System.Text
Imports System.Data.OleDb

Public Class FrmAddDiagnosis
    Dim SQL As New SQLConnect
    Public Sub New()

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.connect()
        BindGrid()

    End Sub
    Private Sub BindGrid()
        Using cmd As New OleDbCommand("SELECT * FROM diagnosis", SQL.con)
            cmd.CommandType = CommandType.Text
            Using sda As New OleDbDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub TxtAge_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtAge.TextChanged
        If Val(TxtAge.Text) > 11 Then
            TxtCategory.Text = " Adolesent"
        End If
        If Val(TxtAge.Text) > 17 Then
            TxtCategory.Text = " Youth"
        End If
        If Val(TxtAge.Text) > 29 Then
            TxtCategory.Text = " Adult"
        End If

    End Sub

    Private Sub clear()
        CmbSymp1.Text = Nothing
        TxtAge.Text = Nothing
        CmbSymp2.Text = Nothing
        CmbSymp3.Text = Nothing
        CmbSymp4.Text = Nothing
        CmbSymp5.Text = Nothing
        CmbSymp6.Text = Nothing
        CmbSymp7.Text = Nothing
        CmbSymp8.Text = Nothing
        CmbSymp9.Text = Nothing
        CmbSymp10.Text = Nothing
        RichTextBoxCure.Text = Nothing
        TxtAge.Text = Nothing
        TxtCategory.Text = Nothing
        TxtPID.Text = Nothing
    End Sub
    Private Sub ToolStripBtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If CmbSymp1.Text = Nothing Or CmbSymp2.Text = Nothing Or
            CmbSymp3.Text = Nothing Or CmbSymp4.Text = Nothing Or
            CmbSymp5.Text = Nothing Or CmbSymp6.Text = Nothing Or
            CmbSymp7.Text = Nothing Or CmbSymp8.Text = Nothing Or
            CmbSymp9.Text = Nothing Or CmbSymp10.Text = Nothing Or
            RichTextBoxCure.Text = Nothing Or TxtAge.Text = Nothing Or
            TxtCategory.Text = Nothing Or TxtPID.Text = Nothing Then

            MsgBox("All fields are required.........Check", MsgBoxStyle.Critical, "Check")
            Exit Sub
        End If

        If TxtAge.Text.Count > 1 And Val(TxtAge.Text) < 11 Then
            TxtCategory.Text = TxtAge.Text.Count
            MsgBox("Age Must Be Greater Than 11", MsgBoxStyle.Critical, "Input Error")
            Exit Sub
        End If

        Try

            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim ct As String = "SELECT * FROM diagnosis WHERE Patient_ID = @Patient_ID"
            SQL.cmd = New OleDbCommand(ct)
            SQL.cmd.Connection = SQL.con
            SQL.cmd.Parameters.Add(New OleDbParameter("@Patient_ID", "Patient_ID"))
            SQL.cmd.Parameters("@Patient_ID").Value = TxtPID.Text()
            SQL.rdr = SQL.cmd.ExecuteReader()

            If SQL.rdr.Read Then
                MsgBox("The Patient ID is already Exit", MsgBoxStyle.Critical, "Input Error")
                TxtPID.Clear()
                TxtPID.Focus()

            Else

                SQL.rdr.Close()

                Dim cb As String = "INSERT INTO diagnosis(Patient_ID, Symptom1, Symptom2, Symptom3, Symptom4, Symptom5, Symptom6, Symptom7, Symptom8, Symptom9, Symptom10, Cure, Age, Category) VALUES (@Patient_ID, @Symptom1, @Symptom2, @Symptom3, @Symptom4, @Symptom5, @Symptom6, @Symptom7, @Symptom8, @Symptom9, @Symptom10, @Cure, @Age, @Category)"
                SQL.cmd = New OleDbCommand(cb)
                SQL.cmd.Connection = SQL.con

                SQL.cmd.Parameters.AddWithValue("@Patient_ID", TxtPID.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom1", CmbSymp1.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom2", CmbSymp2.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom3", CmbSymp3.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom4", CmbSymp4.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom5", CmbSymp5.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom6", CmbSymp6.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom7", CmbSymp7.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom8", CmbSymp8.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom9", CmbSymp9.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom10", CmbSymp10.Text)
                SQL.cmd.Parameters.AddWithValue("@Cure", RichTextBoxCure.Text)
                SQL.cmd.Parameters.AddWithValue("@Age", TxtAge.Text)
                SQL.cmd.Parameters.AddWithValue("@Category", TxtCategory.Text)

                SQL.cmd.ExecuteNonQuery()
                MsgBox("Diagnosis Infomation" & vbNewLine & "Saved Successfully", MsgBoxStyle.Information)
                Call clear()
                BindGrid()
                'SQL.con.Close()
            End If
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Hide()
        FrmMainM.Show()
    End Sub

    Private Sub TxtPID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPID.TextChanged

        Try

            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim cd As String = "SELECT * FROM patient_reg WHERE Patient_ID ='" & TxtPID.Text & "'"
            SQL.cmd = New OleDbCommand(cd)
            SQL.cmd.Connection = SQL.con
            SQL.rdr = SQL.cmd.ExecuteReader

            If SQL.rdr.HasRows Then
                SQL.rdr.Read()
                TxtAge.Text = SQL.rdr.Item("Age").ToString
                TxtAge.Enabled = False
                TxtCategory.Enabled = False
                SQL.rdr.Close()
            End If
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FrmAddDiagnosis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
