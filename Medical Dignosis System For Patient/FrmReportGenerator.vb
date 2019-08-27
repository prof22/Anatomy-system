
Imports System.IO
Imports System.Text
Imports System.Data.OleDb

Public Class FrmReportGenerator
    Dim SQL As New SQLConnect
    Dim uPatientID As String

    Private Sub ToolStripBtnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If TxtEnterPID.Text = Nothing Then
            MsgBox("Patient ID is requied", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Try
            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim cd As String = "SELECT * FROM patient_diagnosis_rec WHERE Patient_ID ='" & TxtEnterPID.Text & "'"
            SQL.cmd = New OleDbCommand(cd)
            SQL.cmd.Connection = SQL.con
            SQL.rdr = SQL.cmd.ExecuteReader

            If SQL.rdr.HasRows Then
                SQL.rdr.Read()

                FrmDiagnosisReport.Label17.Text = SQL.rdr.Item("Symptom1").ToString
                FrmDiagnosisReport.Label21.Text = SQL.rdr.Item("Symptom2").ToString
                FrmDiagnosisReport.Label20.Text = SQL.rdr.Item("Symptom3").ToString
                FrmDiagnosisReport.Label19.Text = SQL.rdr.Item("Symptom4").ToString
                FrmDiagnosisReport.Label26.Text = SQL.rdr.Item("Symptom5").ToString
                FrmDiagnosisReport.Label27.Text = SQL.rdr.Item("Symptom6").ToString
                FrmDiagnosisReport.Label22.Text = SQL.rdr.Item("Symptom7").ToString
                FrmDiagnosisReport.Label23.Text = SQL.rdr.Item("Symptom8").ToString
                FrmDiagnosisReport.Label24.Text = SQL.rdr.Item("Symptom9").ToString
                FrmDiagnosisReport.Label25.Text = SQL.rdr.Item("Symptom10").ToString
                FrmDiagnosisReport.Label18.Text = SQL.rdr.Item("Cure").ToString
                FrmDiagnosisReport.Label30.Text = SQL.rdr.Item("Age").ToString
                FrmDiagnosisReport.Label28.Text = SQL.rdr.Item("Patient_ID").ToString
                FrmDiagnosisReport.Label31.Text = SQL.rdr.Item("Category").ToString

                Me.Hide()
                FrmDiagnosisReport.ShowDialog()
                SQL.rdr.Close()
            End If
            SQL.con.Close()

            '================================================================================================

            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim cb As String = "SELECT * FROM patient_reg WHERE Patient_ID ='" & TxtEnterPID.Text & "'"
            SQL.cmd = New OleDbCommand(cb)
            SQL.cmd.Connection = SQL.con
            SQL.rdr = SQL.cmd.ExecuteReader()

            If SQL.rdr.HasRows Then
                SQL.rdr.Read()

                FrmDiagnosisReport.Label29.Text = SQL.rdr.Item("Fullname").ToString

                Me.Hide()
                FrmDiagnosisReport.Show()
                SQL.rdr.Close()
            Else

                MsgBox("Sorry Patient ID does not exit.........Check", MsgBoxStyle.Critical, "Error")
                TxtEnterPID.Focus()
                TxtEnterPID.SelectAll()
            End If
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        If TxtEnterPID.Text = Nothing Then
            MsgBox("Patient ID is requied", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Try
            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim cb As String = "SELECT * FROM patient_reg WHERE Patient_ID ='" & TxtEnterPID.Text & "'"
            SQL.cmd = New OleDbCommand(cb)
            SQL.cmd.Connection = SQL.con
            SQL.rdr = SQL.cmd.ExecuteReader()

            While (SQL.rdr.Read)
                uPatientID = SQL.rdr.Item("Patient_ID")
            End While
            SQL.rdr.Close()

            If (uPatientID <> TxtEnterPID.Text.ToString) Then
                MsgBox("Wrong ID....Please check and try again", MsgBoxStyle.Critical, "Check")
                TxtEnterPID.Clear()
                TxtEnterPID.Focus()

            Else

                Dim cd As String = "SELECT Patient_ID, Date FROM patient_diagnosis_rec WHERE Patient_ID ='" & TxtEnterPID.Text & "'"
                SQL.cmd = New OleDbCommand(cd)
                SQL.cmd.Connection = SQL.con
                Dim sda As OleDbDataAdapter = New OleDbDataAdapter(SQL.cmd)
                Dim ds As DataSet = New DataSet()
                sda.Fill(ds, "patient_diagnosis_rec")
                DataGridView1.DataSource = ds.Tables("patient_diagnosis_rec").DefaultView
                SQL.con.Close()


                'Dim da As New MySqlDataAdapter("SELECT Patient_ID, Date FROM patient_diagnosis_rec WHERE Patient_ID ='" & TxtEnterPID.Text & "'", SQL.con)
                'Dim dt As New DataTable
                'da.Fill(dt)
                'DataGridView1.DataSource = dt
                'SQL.con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FrmReportGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class