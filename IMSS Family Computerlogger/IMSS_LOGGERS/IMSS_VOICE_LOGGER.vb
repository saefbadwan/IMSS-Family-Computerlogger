Imports Argus.Audio
Public Class IMSS_VOICE_LOGGER
    Private Shared _IMSS_CONTROL As IMSS_VOICE_LOGGER
    Private _IMSS_AUDIO_RECORDER As New Recording
    Public Shared Function _IMSS_CREATE_CONTROL() As IMSS_VOICE_LOGGER
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_VOICE_LOGGER
            _IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_LOAD_VOICE_RECOREDS()
    End Sub

    Private Sub _IMSS_LOAD_VOICE_RECOREDS()
        _IMSS_AudioListView.Items.Clear()
        For Each _IMSS_AUFIO_FILE As String In My.Computer.FileSystem.GetFiles(IMSS_PATHS._IMSS_VOICE_LOGS_DIR, FileIO.SearchOption.SearchTopLevelOnly)
            With _IMSS_AudioListView.Items.Add(New IO.FileInfo(_IMSS_AUFIO_FILE).CreationTime.ToString())
                .Tag = _IMSS_AUFIO_FILE
                .Image = My.Resources._IMSS_ADUIO_Icon_16x16
            End With
        Next _IMSS_AUFIO_FILE
    End Sub

    Private Sub _IMSS_AudioListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AudioListView.SelectedIndexChanged
        If Not _IMSS_AudioListView.Items.Count() = 0 Then
            If Not _IMSS_AudioListView.SelectedItems.Count() = 0 Then
                If IO.File.Exists(_IMSS_AudioListView.SelectedItems(0).Tag.ToString()) = True Then
                    Me._IMSS_PLAYER.URL = _IMSS_AudioListView.SelectedItems(0).Tag.ToString()
                Else
                    _IMSS_LOAD_VOICE_RECOREDS()
                End If
            End If
        End If
    End Sub

    Public Sub _IMSS_START_RECORD(ByVal _IMSS_STATUS As Boolean)
        If _IMSS_STATUS = True Then
            _IMSS_AUDIO_RECORDER = New Recording(IMSS_PATHS._IMSS_VOICE_LOGS_DIR & "\" & IMSS_PATHS._IMSS_GenerateRandomFileName() & "-" & Now.Month & "-" & Now.Day & "-" & Now.Year & ".wav")
            _IMSS_AUDIO_RECORDER.StartRecording()
        Else
            _IMSS_AUDIO_RECORDER.StopRecording()
        End If
    End Sub

    Private Sub _IMSS_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Refresh.Click
        _IMSS_LOAD_VOICE_RECOREDS()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Not _IMSS_AudioListView.Items.Count() = 0 Then
            If Not _IMSS_AudioListView.SelectedItems.Count() = 0 Then
                If MessageBox.Show("Are you shur you want to delete the selected (" & _IMSS_AudioListView.SelectedItems(0).Text & ") log file ? ", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Try : IO.File.Delete(_IMSS_AudioListView.SelectedItems(0).Tag.ToString()) : Catch ex As Exception : MessageBox.Show(ex.Message, Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) : End Try
                    System.Threading.Thread.Sleep(400)
                    _IMSS_LOAD_VOICE_RECOREDS()
                End If
            End If
        End If
    End Sub
End Class
