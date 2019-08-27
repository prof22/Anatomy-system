Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Public Class FrmLogin
    Dim SQL As New SQLConnect
    Dim uName As String
    Dim uPassword As String
    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Call Login()
        FrmSplashScreen.TmrSplashScreen.Stop()
    End Sub

    Private Sub BtbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtbExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtPassword.Clear()
    End Sub
    Private Sub Login()
        Try
            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Dim cb As String = "SELECT * FROM users WHERE Username='" & CmbUser.Text & "' AND Password='" & TxtPassword.Text & "'"
            SQL.cmd = New OleDbCommand(cb)
            SQL.cmd.Connection = SQL.con
            SQL.rdr = SQL.cmd.ExecuteReader()

            While (SQL.rdr.Read)
                uName = SQL.rdr.Item("Username")
                uPassword = SQL.rdr.Item("Password")
            End While
            SQL.rdr.Close()
            '==========================================================================================================================
            If CmbUser.Text = Nothing Or TxtPassword.Text = Nothing Or TxtVarify.Text = Nothing Then
                MsgBox("Username Or Password Or Verify Code are required", MsgBoxStyle.Critical, "Input Error")
                CmbUser.Focus()
                'Exit Sub

            ElseIf (uName <> CmbUser.Text.ToString) Or (uPassword <> TxtPassword.Text.ToString) Or (TxtVarify.Text.ToString <> TxtCode.Text.ToString) Then
                MsgBox("Invalid Username Or Password Or Verify Code", MsgBoxStyle.Critical, "Access Denied")
                TxtPassword.Clear()
                TxtVarify.Clear()
                CmbUser.Focus()
                
            Else

                If (uName = CmbUser.Text.ToString) And (uPassword = TxtPassword.Text.ToString) And (TxtVarify.Text.ToString = TxtCode.Text.ToString) Then
                    MsgBox("Access Granted" & vbNewLine & "<< To  " & CmbUser.Text & " >>", MsgBoxStyle.Information, "Access Granted")
                    TxtPassword.Clear()
                    TxtVarify.Clear()
                    TxtCode.Clear()
                    Me.Hide()
                    FrmMainM.LblUser.Text = CmbUser.Text()
                    FrmMainM.Show()
                End If
                'SQL.con.Close()
                End If
            SQL.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        FrmNewUsers.TxtFulname.Focus()
        FrmNewUsers.TxtUser.Clear()
        FrmNewUsers.TxtPassword.Clear()
        FrmNewUsers.Show()
    End Sub

    Private Sub TxtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsUpper(e.KeyChar) Then
            CmbUser.SelectedText = Char.ToLower(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ================='To generating random numbers
        Dim Code As New Random
        Dim numbers As Integer = Code.Next(1, 12345678)
        Dim digits As String = numbers.ToString("00000")
        TxtCode.Text = digits
        TxtVarify.Focus()

        Try
            If SQL.con.State = ConnectionState.Closed Then
                SQL.con.Open()
            End If
            Using cmd As New OleDbCommand("SELECT distinct (Username) FROM users", SQL.con)
                cmd.CommandType = CommandType.Text
                Using sda As New OleDbDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        For Each drow As DataRow In dt.Rows
                            CmbUser.Items.Add(drow(0).ToString())
                        Next
                    End Using
                End Using
            End Using
            SQL.con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PicRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicRefresh.Click
        ' ================='To generating random numbers
        Dim Code As New Random
        Dim numbers As Integer = Code.Next(1, 12345678)
        Dim digits As String = numbers.ToString("00000")
        TxtCode.Text = digits
        TxtVarify.Focus()
    End Sub

    Private Sub TxtVarify_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVarify.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
End Class