
Imports System.IO
Imports System.Text
Imports System.Data.OleDb

Public Class FrmNewUsers
    Dim SQL As New SQLConnect
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Try
            If TxtFulname.Text = Nothing Or TxtUser.Text = Nothing Or TxtPassword.Text = Nothing Then
                MsgBox("All Fields Are Required........Check", MsgBoxStyle.Critical, "Check")

            Else
                If SQL.con.State = ConnectionState.Closed Then
                    SQL.con.Open()
                End If

                Dim cb As String = "INSERT INTO users (Fullname, Username, Password) VALUES (@Fullname,@Username,@Password)"
                SQL.cmd = New OleDbCommand(cb)
                SQL.cmd.Connection = SQL.con

                SQL.cmd.Parameters.AddWithValue("@Fullname", TxtFulname.Text)
                SQL.cmd.Parameters.AddWithValue("@Username", TxtUser.Text)
                SQL.cmd.Parameters.AddWithValue("@Password", TxtPassword.Text)

                SQL.cmd.ExecuteNonQuery()
                MsgBox("User Created Successfully")
                TxtFulname.Clear()
                TxtUser.Clear()
                TxtPassword.Clear()
                TxtFulname.Focus()

                SQL.con.Close()
            End If
        Catch ex As Exception
            ex.ToString()
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        FrmLogin.Show()
        FrmLogin.CmbUser.Focus()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class