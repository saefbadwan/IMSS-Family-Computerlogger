Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private _IMSS_EXIT_NACKGROUNDSYSTEMS As Boolean = False
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            If Not IO.Directory.Exists(IMSS_PATHS._IMSS_LOGS_DIR) = True Then IO.Directory.CreateDirectory(IMSS_PATHS._IMSS_LOGS_DIR)
            If Not IO.Directory.Exists(IMSS_PATHS._IMSS_KEY_LOGS_DIR) = True Then IO.Directory.CreateDirectory(IMSS_PATHS._IMSS_KEY_LOGS_DIR)
            If Not IO.Directory.Exists(IMSS_PATHS._IMSS_VOICE_LOGS_DIR) = True Then IO.Directory.CreateDirectory(IMSS_PATHS._IMSS_VOICE_LOGS_DIR)
            If Not IO.Directory.Exists(IMSS_PATHS._IMSS_SCREEN_LOGS_DIR) = True Then IO.Directory.CreateDirectory(IMSS_PATHS._IMSS_SCREEN_LOGS_DIR)
            If My.Settings._IMSS_Password.Length > 0 Then
                If My.Settings._IMSS_RunOnStartup = True Then
                    MainWindow._IMSS_StartLogging_Button.PerformClick()
                    Do
                        If IMSS_PATHS.getkey(17) And IMSS_PATHS.getkey(160) And IMSS_PATHS.getkey(83) Then
                            Exit Do
                        End If
                        System.Threading.Thread.Sleep(400)
                    Loop
                End If
                My.Application.MainForm = IMSS_UNLOCK
            Else
                My.Application.MainForm = IMSS_REGISTER
            End If
        End Sub
    End Class


End Namespace

