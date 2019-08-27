
Imports System.IO
Imports System.Text
Imports System.Data.OleDb

Public Class FrmDiagnosisSystem
    Dim cat As String
    Dim SQL As New SQLConnect

    Private Sub diagonise()

        Try
            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If

            Dim cd As String = "SELECT * FROM diagnosis WHERE Age ='" & TxtAge.Text & "'"
            SQL.cmd = New OleDbCommand(cd)
            SQL.cmd.Connection = SQL.con
            SQL.rdr = SQL.cmd.ExecuteReader

            If SQL.rdr.HasRows Then
                SQL.rdr.Read()
                MsgBox("Sorry you have a Malaria", MsgBoxStyle.Information, "Malaria")
                LblCure.Text = SQL.rdr.Item("Cure").ToString
                SQL.rdr.Close()
            End If
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtEnterPID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtEnterPID.TextChanged

        Try
            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim cd As String = "SELECT * FROM patient_reg WHERE Patient_ID ='" & TxtEnterPID.Text & "'"
            SQL.cmd = New OleDbCommand(cd)
            SQL.cmd.Connection = SQL.con
            SQL.rdr = SQL.cmd.ExecuteReader

            If SQL.rdr.HasRows Then
                SQL.rdr.Read()
                LblName.Text = SQL.rdr.Item("Fullname").ToString
                TxtAge.Text = SQL.rdr.Item("Age").ToString
                TxtAge.Enabled = False
                SQL.rdr.Close()
            End If
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If CmbTemperature.Text = Nothing Or CmbHeadache.Text = Nothing Or
            CmbSoreThroat.Text = Nothing Or CmbLossAppetite.Text = Nothing Or
            CmbJoinPain.Text = Nothing Or CmbAbdominalP.Text = Nothing Or
            CmbNausea.Text = Nothing Or CmbVomiting.Text = Nothing Or
            CmbDizzy.Text = Nothing Or CmbBodyWeak.Text = Nothing Or
            LblCategory.Text = Nothing Or TxtAge.Text = Nothing Or LblName.Text = Nothing Then

            MsgBox("All field are required...........Check", MsgBoxStyle.Information, "Field")
            Exit Sub
        End If

        Try

            If CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "NO" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()
                ' MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid ", MsgBoxStyle.Information, "INFORMATION")
                diagonise()


            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                diagonise()
                MsgBox("You have a Malaria and thyfoid ", MsgBoxStyle.Information, "INFORMATION")
            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "NO" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "NO" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()
            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "LOW" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "NO" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "LOW" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
     CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
    CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "LOW" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "LOW" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()


            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "LOW" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()


            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()


            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                diagonise()


            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "LOW" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                diagonise()


            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "LOW" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "LOW" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()


            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "YES" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "YES" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "LOW" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                MsgBox("YOU HAVE MALARIA. ")

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                diagonise()


            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                diagonise()


            ElseIf CmbTemperature.Text = "HIGH" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "NO" And
             CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "NO" Then
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "YES" And CmbSoreThroat.Text = "YES" And CmbLossAppetite.Text = "YES" And CmbJoinPain.Text = "YES" And
       CmbAbdominalP.Text = "YES" And CmbNausea.Text = "NO" And CmbVomiting.Text = "YES" And CmbDizzy.Text = "YES" And CmbBodyWeak.Text = "YES" Then
                MsgBox("You have a Malaria and thyfoid", MsgBoxStyle.Information, "INFORMATION")
                diagonise()

            ElseIf CmbTemperature.Text = "NORMAL" And CmbHeadache.Text = "NO" And CmbSoreThroat.Text = "NO" And CmbLossAppetite.Text = "NO" And CmbJoinPain.Text = "NO" And
         CmbAbdominalP.Text = "NO" And CmbNausea.Text = "NO" And CmbVomiting.Text = "NO" And CmbDizzy.Text = "NO" And CmbBodyWeak.Text = "NO" Then
                MsgBox("You dont have a Malaria ", MsgBoxStyle.Information, "Good")
            Else
                diagonise()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Clear()
        CmbAbdominalP.Text = Nothing
        TxtAge.Text = Nothing
        CmbBodyWeak.Text = Nothing
        CmbDizzy.Text = Nothing
        CmbHeadache.Text = Nothing
        CmbJoinPain.Text = Nothing
        CmbLossAppetite.Text = Nothing
        CmbNausea.Text = Nothing
        CmbSoreThroat.Text = Nothing
        TxtEnterPID.Text = Nothing
        CmbTemperature.Text = Nothing
        CmbVomiting.Text = Nothing
        LblCategory.Text = Nothing
        LblCure.Text = Nothing
        LblName.Text = Nothing
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        If CmbAbdominalP.Text = Nothing Or TxtAge.Text = Nothing Or
            CmbBodyWeak.Text = Nothing Or CmbDizzy.Text = Nothing Or CmbHeadache.Text = Nothing Or
            CmbJoinPain.Text = Nothing Or CmbLossAppetite.Text = Nothing Or
            CmbNausea.Text = Nothing Or CmbSoreThroat.Text = Nothing Or
            TxtEnterPID.Text = Nothing Or
            CmbTemperature.Text = Nothing Or CmbVomiting.Text = Nothing Then

            MsgBox("All fields are required.........Check", MsgBoxStyle.Critical, "Check")
            Exit Sub
        End If

        Try

            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim ct As String = "SELECT * FROM patient_diagnosis_rec WHERE Patient_ID = @Patient_ID"
            SQL.cmd = New OleDbCommand(ct)
            SQL.cmd.Connection = SQL.con
            SQL.cmd.Parameters.Add(New OleDbParameter("@Patient_ID", "Patient_ID"))
            SQL.cmd.Parameters("@Patient_ID").Value = TxtEnterPID.Text()
            SQL.rdr = SQL.cmd.ExecuteReader()

            If SQL.rdr.Read Then
                MsgBox("The Patient ID is Already Exist", MsgBoxStyle.Critical, "Input Error")
                TxtEnterPID.Clear()
                TxtEnterPID.Focus()

            Else

                SQL.rdr.Close()

                Dim cb As String = "INSERT INTO patient_diagnosis_rec(Patient_ID, Symptom1, Symptom2, Symptom3, Symptom4, Symptom5, Symptom6, Symptom7, Symptom8, Symptom9, Symptom10, Cure, Age, Category, Date) VALUES (@Patient_ID, @Symptom1, @Symptom2, @Symptom3, @Symptom4, @Symptom5, @Symptom6, @Symptom7, @Symptom8, @Symptom9, @Symptom10, @Cure, @Age, @Category, @Date)"
                SQL.cmd = New OleDbCommand(cb)
                SQL.cmd.Connection = SQL.con

                SQL.cmd.Parameters.AddWithValue("@Patient_ID", TxtEnterPID.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom1", CmbTemperature.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom2", CmbHeadache.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom3", CmbSoreThroat.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom4", CmbLossAppetite.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom5", CmbJoinPain.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom6", CmbBodyWeak.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom7", CmbDizzy.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom8", CmbVomiting.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom9", CmbNausea.Text)
                SQL.cmd.Parameters.AddWithValue("@Symptom10", CmbAbdominalP.Text)
                SQL.cmd.Parameters.AddWithValue("@Cure", LblCure.Text)
                SQL.cmd.Parameters.AddWithValue("@Age", TxtAge.Text)
                SQL.cmd.Parameters.AddWithValue("@Category", LblCategory.Text)
                SQL.cmd.Parameters.AddWithValue("@Date", DateTimePicker1.Text)

                SQL.cmd.ExecuteNonQuery()

                MsgBox("Diagnosis Infomation" & vbNewLine & "Saved Successfully", MsgBoxStyle.Information, "Save")
                Call Clear()
            End If
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Hide()
    End Sub

    Private Sub ToolStripBtnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub TxtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAge.TextChanged
        If Val(TxtAge.Text) < 18 Then
            LblCategory.Text = "You Are An Adolescent"
        End If
        If Val(TxtAge.Text) > 17 Then
            LblCategory.Text = "You Are A Youth"
        End If
        If Val(TxtAge.Text) > 29 Then
            LblCategory.Text = "You Are An Adult"
        End If
    End Sub

    Private Sub FrmDiagnosisSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class