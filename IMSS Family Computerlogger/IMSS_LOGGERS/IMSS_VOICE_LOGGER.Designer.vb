<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_VOICE_LOGGER
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_VOICE_LOGGER))
        Me._IMSS_MainWindow = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_PLAYER = New AxWMPLib.AxWindowsMediaPlayer()
        Me._IMSS_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_AudioListView = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_LOGDATE = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_MainWindow.SuspendLayout()
        CType(Me._IMSS_PLAYER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_AudioListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainWindow
        '
        Me._IMSS_MainWindow.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainWindow.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainWindow.Controls.Add(Me._IMSS_PLAYER)
        Me._IMSS_MainWindow.Controls.Add(Me._IMSS_Refresh)
        Me._IMSS_MainWindow.Controls.Add(Me.ButtonX1)
        Me._IMSS_MainWindow.Controls.Add(Me._IMSS_AudioListView)
        Me._IMSS_MainWindow.Controls.Add(Me.Label1)
        Me._IMSS_MainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainWindow.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainWindow.Name = "_IMSS_MainWindow"
        Me._IMSS_MainWindow.Size = New System.Drawing.Size(797, 482)
        Me._IMSS_MainWindow.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainWindow.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainWindow.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainWindow.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainWindow.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainWindow.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainWindow.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainWindow.Style.GradientAngle = 90
        Me._IMSS_MainWindow.TabIndex = 0
        '
        '_IMSS_PLAYER
        '
        Me._IMSS_PLAYER.Enabled = True
        Me._IMSS_PLAYER.Location = New System.Drawing.Point(201, 38)
        Me._IMSS_PLAYER.Name = "_IMSS_PLAYER"
        Me._IMSS_PLAYER.OcxState = CType(resources.GetObject("_IMSS_PLAYER.OcxState"), System.Windows.Forms.AxHost.State)
        Me._IMSS_PLAYER.Size = New System.Drawing.Size(584, 429)
        Me._IMSS_PLAYER.TabIndex = 13
        '
        '_IMSS_Refresh
        '
        Me._IMSS_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Refresh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Refresh.Location = New System.Drawing.Point(629, 9)
        Me._IMSS_Refresh.Name = "_IMSS_Refresh"
        Me._IMSS_Refresh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Refresh.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Refresh.TabIndex = 12
        Me._IMSS_Refresh.Text = "Refresh"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(710, 9)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 11
        Me.ButtonX1.Text = "Clear log"
        '
        '_IMSS_AudioListView
        '
        Me._IMSS_AudioListView.Columns.AddRange(New Object() {Me._IMSS_LOGDATE})
        Me._IMSS_AudioListView.Location = New System.Drawing.Point(15, 38)
        Me._IMSS_AudioListView.MultiSelect = False
        Me._IMSS_AudioListView.Name = "_IMSS_AudioListView"
        Me._IMSS_AudioListView.Size = New System.Drawing.Size(180, 429)
        Me._IMSS_AudioListView.TabIndex = 10
        '
        '_IMSS_LOGDATE
        '
        Me._IMSS_LOGDATE.Name = "_IMSS_LOGDATE"
        Me._IMSS_LOGDATE.Text = "Recording Start At"
        Me._IMSS_LOGDATE.Width = 178
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Voice-Logger : Allows to record voices and loud sounds near the PC, Starts so rec" & _
            "ord after detecting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a voice (for Windows)."
        '
        'IMSS_VOICE_LOGGER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_MainWindow)
        Me.Name = "IMSS_VOICE_LOGGER"
        Me.Size = New System.Drawing.Size(797, 482)
        Me._IMSS_MainWindow.ResumeLayout(False)
        Me._IMSS_MainWindow.PerformLayout()
        CType(Me._IMSS_PLAYER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_AudioListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainWindow As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_PLAYER As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents _IMSS_AudioListView As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_LOGDATE As ComponentOwl.BetterListView.BetterListViewColumnHeader

End Class
