Public Class IMSS_REGISTER
    Public _IMSS_EDIT_PASSWORD As Boolean = False
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If _IMSS_EDIT_PASSWORD = False Then
            Application.Exit()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub _IMSS_Unlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_REGISTER.Click
        If (_IMSS_PASSWORD_TextBox.Text = _IMSS_CONFRIMPASSWORD_TextBox.Text) = True Then
            My.Settings._IMSS_Password = _IMSS_PASSWORD_TextBox.Text
            My.Settings.Save()
            If _IMSS_EDIT_PASSWORD = False Then
                'MainWindow.Show()
                'MainWindow.WindowState = FormWindowState.Normal
                'MainWindow.Focus()
                'MainWindow.Activate()
                Application.Restart()
            Else
                Me.Close()
            End If
        End If
    End Sub
End Class