' بسم الله الرحمن الرحيم
Public Class IMSS_SCREEN_LOGGER
    Private Shared _IMSS_CONTROL As IMSS_SCREEN_LOGGER
    Private _IMSS_EXIT_SCREENLOGGING As Boolean = False
    Private _IMSS_LOGS_NUMBER As Integer = 0
    Public Shared Function _IMSS_CREATE_CONTROL() As IMSS_SCREEN_LOGGER
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_SCREEN_LOGGER
            _IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _IMSS_LoadLogs()

    End Sub


    Public Sub _IMSS_LANUCH_SCREEN_LOGGING(ByVal _IMSS_STATUS As Boolean)
        If _IMSS_STATUS = False Then
            Dim _IMSS_THREAD As New Threading.Thread(AddressOf _IMSS_ScreenLoggerCoreEngine) : _IMSS_THREAD.Start()
        Else
            _IMSS_EXIT_SCREENLOGGING = _IMSS_STATUS
        End If
    End Sub

    Private Sub _IMSS_ScreenLoggerCoreEngine()
        Dim _IMSS_DirPath As String = IMSS_PATHS._IMSS_SCREEN_LOGS_DIR & "\" & Now.Month & "-" & Now.Day & "-" & Now.Year
        Do Until _IMSS_EXIT_SCREENLOGGING = True
            If Not IO.Directory.Exists(_IMSS_DirPath) Then IO.Directory.CreateDirectory(_IMSS_DirPath)
            _IMSS_GetScreen().Save(_IMSS_DirPath & "\" & IMSS_PATHS._IMSS_GenerateRandomFileName() & "-" & Now.Day & "-" & Now.Month & "-" & Now.Hour & ".jpeg", Imaging.ImageFormat.Jpeg)
            System.Threading.Thread.Sleep(60000)

        Loop : _IMSS_EXIT_SCREENLOGGING = False
    End Sub
    Private Function _IMSS_GetScreen() As Bitmap
        Return _IMSS_GetScreen(0, 0, Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
    End Function
    Private Function _IMSS_GetScreen(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer) As Bitmap
        Dim Img As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(Img)
        g.CopyFromScreen(X, Y, 0, 0, Img.Size)
        g.Dispose()
        Return Img
    End Function

    Private Sub _IMSS_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Refresh.Click
        _IMSS_MainPicuterBox.Image = _IMSS_MainPicuterBox.BackgroundImage
        _IMSS_MainPicuterBox.SizeMode = PictureBoxSizeMode.CenterImage
        _IMSS_ImagesListView.Items.Clear()
        _IMSS_ImageList.Images.Clear()
        _IMSS_LoadLogs()
    End Sub


    Private Sub _IMSS_LoadLogs()
        _IMSS_LOGS_FILE_LIST.Items.Clear()
        _IMSS_LOGS_NUMBER = 0
        For Each _IMSS_List As String In My.Computer.FileSystem.GetDirectories(IMSS_PATHS._IMSS_SCREEN_LOGS_DIR, FileIO.SearchOption.SearchTopLevelOnly)
            Application.DoEvents()
            _IMSS_LOGS_NUMBER += 1
            With _IMSS_LOGS_FILE_LIST.Items.Add(IO.Path.GetFileName(_IMSS_List))
                .Image = My.Resources._IMSS_ScreenLog_Icon_16x16
                .Tag = _IMSS_List
            End With
        Next _IMSS_List
        If Not _IMSS_LOGS_FILE_LIST.Items.Count() = 0 Then
            _IMSS_LOGS_FILE_LIST.Items(0).Selected = True
        End If
    End Sub

    Private Sub _IMSS_LOGS_FILE_LIST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_LOGS_FILE_LIST.SelectedIndexChanged
        If Not _IMSS_LOGS_FILE_LIST.SelectedItems.Count() = 0 Then
            _IMSS_ImagesListView.Items.Clear()
            _IMSS_ImageList.Images.Clear()
            For Each _IMSS_FILE In My.Computer.FileSystem.GetFiles(_IMSS_LOGS_FILE_LIST.SelectedItems(0).Tag.ToString())
                Application.DoEvents()
                _IMSS_ImageList.Images.Add(_IMSS_FILE, Image.FromFile(_IMSS_FILE))
                With _IMSS_ImagesListView.Items.Add(New IO.FileInfo(_IMSS_FILE).CreationTime.ToString())
                    .ImageKey = _IMSS_FILE
                    .Tag = _IMSS_FILE
                End With
            Next _IMSS_FILE
            If Not _IMSS_ImagesListView.Items.Count() = 0 Then
                _IMSS_ImagesListView.Items(0).Selected = True
            End If
        End If
    End Sub
    Private Sub _IMSS_LoadImage(ByVal _IMSS_INDEX As Short)
        _IMSS_LOGS_NUMBER = _IMSS_INDEX
        Dim _IMSS_FilePath = _IMSS_ImagesListView.Items(_IMSS_INDEX).Tag.ToString()
        _IMSS_MainPicuterBox.Image = Image.FromFile(_IMSS_FilePath)
        _IMSS_MainPicuterBox.SizeMode = PictureBoxSizeMode.StretchImage
        _IMSS_MainPicuterBox.Tag = _IMSS_FilePath
        _IMSS_Date_Label.Text = "Date : " & _IMSS_ImagesListView.Items(_IMSS_INDEX).Text
        _IMSS_ImageName_Label.Text = "Name : " & IO.Path.GetFileNameWithoutExtension(_IMSS_ImagesListView.Items(_IMSS_INDEX).Tag.ToString())
    End Sub
    Private Sub _IMSS_ImagesListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ImagesListView.SelectedIndexChanged
        If Not _IMSS_ImagesListView.SelectedItems.Count() = 0 Then
            _IMSS_LoadImage(_IMSS_ImagesListView.SelectedItems(0).Index)
        End If
    End Sub

    Private Sub _IMSS_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Back.Click
        If Not _IMSS_ImagesListView.Items.Count() = 0 Then
            If Not _IMSS_ImagesListView.SelectedItems.Count() = 0 Then
                _IMSS_LOGS_NUMBER -= 1
                Try : _IMSS_LoadImage(_IMSS_ImagesListView.Items(_IMSS_LOGS_NUMBER).Index) : Catch : _IMSS_LOGS_NUMBER = _IMSS_ImagesListView.Items.Count() - 1 : End Try
                My.Computer.Audio.Play(My.Resources.IMSS_Click, AudioPlayMode.Background)
            End If
        End If
    End Sub

    Private Sub _IMSS_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Next.Click
        If Not _IMSS_ImagesListView.Items.Count() = 0 Then
            If Not _IMSS_ImagesListView.SelectedItems.Count() = 0 Then
                _IMSS_LOGS_NUMBER += 1
                Try : _IMSS_LoadImage(_IMSS_ImagesListView.Items(_IMSS_LOGS_NUMBER).Index) : Catch : _IMSS_LOGS_NUMBER = 0 : End Try
                My.Computer.Audio.Play(My.Resources.IMSS_Click, AudioPlayMode.Background)
            End If
        End If
    End Sub

    Private Sub _IMSS_MainPicuterBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MainPicuterBox.Click
        Try : Process.Start(_IMSS_MainPicuterBox.Tag.ToString()) : Catch : End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If MessageBox.Show("Are you shur you want to clear selected log file (" & _IMSS_LOGS_FILE_LIST.SelectedItems(0).Text & ") ? ", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Try
                IO.Directory.Delete(_IMSS_LOGS_FILE_LIST.SelectedItems(0).Tag.ToString(), True)
                _IMSS_Refresh.PerformClick()
            Catch : End Try
        End If
    End Sub
End Class
