Public Class IMSS_UNLOCK

    Private Sub IMSS_UNLOCK_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.TaskManagerClosing Then
            MessageBox.Show("To show main window again press (CTRL + SHIFT + S) !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            If Not IMSS_PATHS._IMSS_EXIT_COMMAND = True Then
                If My.Settings._IMSS_RunOnStartup = True Then
                    e.Cancel = True
                    Me.Hide()
                    If Not MainWindow._IMSS_BACKGROUNDSYSTEMS_WORKER.IsBusy = True Then
                        MainWindow._IMSS_BACKGROUNDSYSTEMS_WORKER.RunWorkerAsync()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub IMSS_UNLOCK_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _IMSS_PASSWORD_TextBox.Clear()
    End Sub

    Private Sub _IMSS_Unlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Unlock.Click
        If _IMSS_PASSWORD_TextBox.Text = My.Settings._IMSS_Password Then
            MainWindow.Show()
            MainWindow.WindowState = FormWindowState.Normal
            MainWindow.ShowInTaskbar = True
            MainWindow.Focus()
            MainWindow.Activate()
            Me.Hide()
        Else
            MessageBox.Show("The password is incorrect. Try again", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            _IMSS_PASSWORD_TextBox.Clear()
        End If
    End Sub

End Class