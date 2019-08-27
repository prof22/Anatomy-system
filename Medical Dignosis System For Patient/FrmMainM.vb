Public Class FrmMainM

    Private Sub switchform_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = "This Application Is Licensed To " & My.Computer.Name

        FrmReportGenerator.Top = 90
        FrmReportGenerator.Left = 370

        FrmDiagnosisReport.Top = 90
        FrmDiagnosisReport.Left = 370

        FrmDiagnosisSystem.Top = 90
        FrmDiagnosisSystem.Left = 320

        FrmPatientReg.Top = 90
        FrmPatientReg.Left = 370

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        'ToolStripLabel1.Text = Date.Now
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        FrmAddDiagnosis.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        FrmPatientReg.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmNewUsers.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        FrmDiagnosisSystem.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Me.Close()
        ' ================='To generating random numbers
        Dim Code As New Random
        Dim numbers As Integer = Code.Next(1, 12345678)
        Dim digits As String = numbers.ToString("00000")
        FrmLogin.TxtCode.Text = digits

        FrmLogin.CmbUser.Text = Nothing
        FrmLogin.TxtPassword.Clear()
        FrmLogin.TxtVarify.Clear()
        FrmLogin.TxtPassword.Focus()
        FrmLogin.Show()

    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        FrmReportGenerator.ShowDialog()
    End Sub
End Class