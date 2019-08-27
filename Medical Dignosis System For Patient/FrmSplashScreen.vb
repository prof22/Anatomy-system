Public Class FrmSplashScreen
    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 180
        Me.Left = 390
    End Sub

    Private Sub TmrSplashScreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrSplashScreen.Tick
        ProgressBar1.Increment(+1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            FrmLogin.Show()
        End If
        Label3.Text = ProgressBar1.Value & (" % ")
        LblTimeOfDay.Text = TimeOfDay
    End Sub
End Class