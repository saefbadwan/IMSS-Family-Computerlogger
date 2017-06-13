<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_MainWindow = New DevComponents.DotNetBar.PanelEx()
        Me._IMS_MainTapControl = New DevComponents.DotNetBar.SuperTabControl()
        Me._IMSS_AllLoggerPanel = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_StartLogging_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Exit_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_RunOnStartUp = New System.Windows.Forms.CheckBox()
        Me._IMSS_EditPassword = New System.Windows.Forms.LinkLabel()
        Me._IMSS_RecordScreen_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me._IMSS_RecordVoice_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me._IMSS_KeyStrokes_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_AllLoggers = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_KeyLoggerPanel = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_KeyBoreadLogger = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_ScreenLogger_Panel = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_ScreenLogger_Tap = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_VOICERECORDER_Panel = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_VOUCRECORDER_TAP = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_BACKGROUNDSYSTEMS_WORKER = New System.ComponentModel.BackgroundWorker()
        Me._IMSS_MainWindow.SuspendLayout()
        CType(Me._IMS_MainTapControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMS_MainTapControl.SuspendLayout()
        Me._IMSS_AllLoggerPanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainWindow
        '
        Me._IMSS_MainWindow.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainWindow.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainWindow.Controls.Add(Me._IMS_MainTapControl)
        Me._IMSS_MainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainWindow.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainWindow.Name = "_IMSS_MainWindow"
        Me._IMSS_MainWindow.Size = New System.Drawing.Size(944, 475)
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
        '_IMS_MainTapControl
        '
        '
        '
        '
        '
        '
        '
        Me._IMS_MainTapControl.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me._IMS_MainTapControl.ControlBox.MenuBox.Name = ""
        Me._IMS_MainTapControl.ControlBox.Name = ""
        Me._IMS_MainTapControl.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMS_MainTapControl.ControlBox.MenuBox, Me._IMS_MainTapControl.ControlBox.CloseBox})
        Me._IMS_MainTapControl.Controls.Add(Me._IMSS_AllLoggerPanel)
        Me._IMS_MainTapControl.Controls.Add(Me._IMSS_KeyLoggerPanel)
        Me._IMS_MainTapControl.Controls.Add(Me._IMSS_ScreenLogger_Panel)
        Me._IMS_MainTapControl.Controls.Add(Me._IMSS_VOICERECORDER_Panel)
        Me._IMS_MainTapControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMS_MainTapControl.Location = New System.Drawing.Point(0, 0)
        Me._IMS_MainTapControl.Name = "_IMS_MainTapControl"
        Me._IMS_MainTapControl.ReorderTabsEnabled = True
        Me._IMS_MainTapControl.SelectedTabFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMS_MainTapControl.SelectedTabIndex = 0
        Me._IMS_MainTapControl.Size = New System.Drawing.Size(944, 475)
        Me._IMS_MainTapControl.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me._IMS_MainTapControl.TabFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMS_MainTapControl.TabIndex = 0
        Me._IMS_MainTapControl.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_AllLoggers, Me._IMSS_KeyBoreadLogger, Me._IMSS_ScreenLogger_Tap, Me._IMSS_VOUCRECORDER_TAP})
        '
        '_IMSS_AllLoggerPanel
        '
        Me._IMSS_AllLoggerPanel.Controls.Add(Me._IMSS_StartLogging_Button)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me._IMSS_Exit_Button)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me._IMSS_RunOnStartUp)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me._IMSS_EditPassword)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me._IMSS_RecordScreen_CheckBox)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me._IMSS_RecordVoice_CheckBox)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me._IMSS_KeyStrokes_CheckBox)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.Label6)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.Label7)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.Label4)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.Label5)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.Label3)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.Label2)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.Label1)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.ShapeContainer1)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.PictureBox4)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.PictureBox3)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.PictureBox2)
        Me._IMSS_AllLoggerPanel.Controls.Add(Me.PictureBox1)
        Me._IMSS_AllLoggerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_AllLoggerPanel.Location = New System.Drawing.Point(148, 0)
        Me._IMSS_AllLoggerPanel.Name = "_IMSS_AllLoggerPanel"
        Me._IMSS_AllLoggerPanel.Size = New System.Drawing.Size(796, 475)
        Me._IMSS_AllLoggerPanel.TabIndex = 1
        Me._IMSS_AllLoggerPanel.TabItem = Me._IMSS_AllLoggers
        '
        '_IMSS_StartLogging_Button
        '
        Me._IMSS_StartLogging_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_StartLogging_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_StartLogging_Button.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_StartLogging_Button.Image = Global.IMSS_Family_Computerlogger.My.Resources.Resources._IMSS_StartLogging_Icon_24x24
        Me._IMSS_StartLogging_Button.Location = New System.Drawing.Point(617, 420)
        Me._IMSS_StartLogging_Button.Name = "_IMSS_StartLogging_Button"
        Me._IMSS_StartLogging_Button.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 0, 10)
        Me._IMSS_StartLogging_Button.Size = New System.Drawing.Size(163, 42)
        Me._IMSS_StartLogging_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_StartLogging_Button.TabIndex = 11
        Me._IMSS_StartLogging_Button.Text = "Start Logging"
        '
        '_IMSS_Exit_Button
        '
        Me._IMSS_Exit_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Exit_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Exit_Button.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Exit_Button.Image = Global.IMSS_Family_Computerlogger.My.Resources.Resources._IMSS_Exit_Icon_24x24
        Me._IMSS_Exit_Button.Location = New System.Drawing.Point(515, 421)
        Me._IMSS_Exit_Button.Name = "_IMSS_Exit_Button"
        Me._IMSS_Exit_Button.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 0, 10)
        Me._IMSS_Exit_Button.Size = New System.Drawing.Size(96, 42)
        Me._IMSS_Exit_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Exit_Button.TabIndex = 19
        Me._IMSS_Exit_Button.Text = "Exit"
        '
        '_IMSS_RunOnStartUp
        '
        Me._IMSS_RunOnStartUp.AutoSize = True
        Me._IMSS_RunOnStartUp.Location = New System.Drawing.Point(613, 4)
        Me._IMSS_RunOnStartUp.Name = "_IMSS_RunOnStartUp"
        Me._IMSS_RunOnStartUp.Size = New System.Drawing.Size(98, 17)
        Me._IMSS_RunOnStartUp.TabIndex = 18
        Me._IMSS_RunOnStartUp.Text = "Run on startup"
        Me._IMSS_RunOnStartUp.UseVisualStyleBackColor = True
        '
        '_IMSS_EditPassword
        '
        Me._IMSS_EditPassword.AutoSize = True
        Me._IMSS_EditPassword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_EditPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me._IMSS_EditPassword.Location = New System.Drawing.Point(714, 5)
        Me._IMSS_EditPassword.Name = "_IMSS_EditPassword"
        Me._IMSS_EditPassword.Size = New System.Drawing.Size(77, 14)
        Me._IMSS_EditPassword.TabIndex = 17
        Me._IMSS_EditPassword.TabStop = True
        Me._IMSS_EditPassword.Text = "Edit Password"
        Me._IMSS_EditPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_IMSS_RecordScreen_CheckBox
        '
        '
        '
        '
        Me._IMSS_RecordScreen_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_RecordScreen_CheckBox.Checked = True
        Me._IMSS_RecordScreen_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me._IMSS_RecordScreen_CheckBox.CheckValue = "Y"
        Me._IMSS_RecordScreen_CheckBox.Location = New System.Drawing.Point(70, 279)
        Me._IMSS_RecordScreen_CheckBox.Name = "_IMSS_RecordScreen_CheckBox"
        Me._IMSS_RecordScreen_CheckBox.Size = New System.Drawing.Size(20, 23)
        Me._IMSS_RecordScreen_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_RecordScreen_CheckBox.TabIndex = 15
        '
        '_IMSS_RecordVoice_CheckBox
        '
        '
        '
        '
        Me._IMSS_RecordVoice_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_RecordVoice_CheckBox.Checked = True
        Me._IMSS_RecordVoice_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me._IMSS_RecordVoice_CheckBox.CheckValue = "Y"
        Me._IMSS_RecordVoice_CheckBox.Location = New System.Drawing.Point(378, 154)
        Me._IMSS_RecordVoice_CheckBox.Name = "_IMSS_RecordVoice_CheckBox"
        Me._IMSS_RecordVoice_CheckBox.Size = New System.Drawing.Size(20, 23)
        Me._IMSS_RecordVoice_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_RecordVoice_CheckBox.TabIndex = 14
        '
        '_IMSS_KeyStrokes_CheckBox
        '
        '
        '
        '
        Me._IMSS_KeyStrokes_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_KeyStrokes_CheckBox.Checked = True
        Me._IMSS_KeyStrokes_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me._IMSS_KeyStrokes_CheckBox.CheckValue = "Y"
        Me._IMSS_KeyStrokes_CheckBox.Location = New System.Drawing.Point(70, 154)
        Me._IMSS_KeyStrokes_CheckBox.Name = "_IMSS_KeyStrokes_CheckBox"
        Me._IMSS_KeyStrokes_CheckBox.Size = New System.Drawing.Size(20, 23)
        Me._IMSS_KeyStrokes_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_KeyStrokes_CheckBox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(93, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 42)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Record screen (take screenshots for pc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "screen every specific time) with date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "an" & _
            "d time on every screen shot"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(129, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Record Screen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(401, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 42)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Allows to record voices and loud sounds" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "near the PC, Starts so record after dete" & _
            "cting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a voice (for Windows)."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(431, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Record voices"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(93, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 42)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Records all keystrokes, texts and chats typed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on the keyboard like keylogger(Win" & _
            "dows). Also" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "records the text copied into the clipboard."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Record keystrokes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(68, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(796, 475)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 86
        Me.LineShape1.X2 = 705
        Me.LineShape1.Y1 = 131
        Me.LineShape1.Y2 = 131
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(213, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(354, 43)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(96, 275)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(404, 153)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(96, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_AllLoggers
        '
        Me._IMSS_AllLoggers.AttachedControl = Me._IMSS_AllLoggerPanel
        Me._IMSS_AllLoggers.GlobalItem = False
        Me._IMSS_AllLoggers.Image = CType(resources.GetObject("_IMSS_AllLoggers.Image"), System.Drawing.Image)
        Me._IMSS_AllLoggers.Name = "_IMSS_AllLoggers"
        Me._IMSS_AllLoggers.Text = "All loggers"
        '
        '_IMSS_KeyLoggerPanel
        '
        Me._IMSS_KeyLoggerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_KeyLoggerPanel.Location = New System.Drawing.Point(148, 0)
        Me._IMSS_KeyLoggerPanel.Name = "_IMSS_KeyLoggerPanel"
        Me._IMSS_KeyLoggerPanel.Size = New System.Drawing.Size(796, 475)
        Me._IMSS_KeyLoggerPanel.TabIndex = 0
        Me._IMSS_KeyLoggerPanel.TabItem = Me._IMSS_KeyBoreadLogger
        '
        '_IMSS_KeyBoreadLogger
        '
        Me._IMSS_KeyBoreadLogger.AttachedControl = Me._IMSS_KeyLoggerPanel
        Me._IMSS_KeyBoreadLogger.GlobalItem = False
        Me._IMSS_KeyBoreadLogger.Image = CType(resources.GetObject("_IMSS_KeyBoreadLogger.Image"), System.Drawing.Image)
        Me._IMSS_KeyBoreadLogger.Name = "_IMSS_KeyBoreadLogger"
        Me._IMSS_KeyBoreadLogger.Text = "Keystrokes Logger"
        '
        '_IMSS_ScreenLogger_Panel
        '
        Me._IMSS_ScreenLogger_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_ScreenLogger_Panel.Location = New System.Drawing.Point(156, 0)
        Me._IMSS_ScreenLogger_Panel.Name = "_IMSS_ScreenLogger_Panel"
        Me._IMSS_ScreenLogger_Panel.Size = New System.Drawing.Size(788, 475)
        Me._IMSS_ScreenLogger_Panel.TabIndex = 0
        Me._IMSS_ScreenLogger_Panel.TabItem = Me._IMSS_ScreenLogger_Tap
        '
        '_IMSS_ScreenLogger_Tap
        '
        Me._IMSS_ScreenLogger_Tap.AttachedControl = Me._IMSS_ScreenLogger_Panel
        Me._IMSS_ScreenLogger_Tap.GlobalItem = False
        Me._IMSS_ScreenLogger_Tap.Image = CType(resources.GetObject("_IMSS_ScreenLogger_Tap.Image"), System.Drawing.Image)
        Me._IMSS_ScreenLogger_Tap.Name = "_IMSS_ScreenLogger_Tap"
        Me._IMSS_ScreenLogger_Tap.Text = "Screenshots Logger"
        '
        '_IMSS_VOICERECORDER_Panel
        '
        Me._IMSS_VOICERECORDER_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_VOICERECORDER_Panel.Location = New System.Drawing.Point(148, 0)
        Me._IMSS_VOICERECORDER_Panel.Name = "_IMSS_VOICERECORDER_Panel"
        Me._IMSS_VOICERECORDER_Panel.Size = New System.Drawing.Size(796, 475)
        Me._IMSS_VOICERECORDER_Panel.TabIndex = 0
        Me._IMSS_VOICERECORDER_Panel.TabItem = Me._IMSS_VOUCRECORDER_TAP
        '
        '_IMSS_VOUCRECORDER_TAP
        '
        Me._IMSS_VOUCRECORDER_TAP.AttachedControl = Me._IMSS_VOICERECORDER_Panel
        Me._IMSS_VOUCRECORDER_TAP.GlobalItem = False
        Me._IMSS_VOUCRECORDER_TAP.Image = CType(resources.GetObject("_IMSS_VOUCRECORDER_TAP.Image"), System.Drawing.Image)
        Me._IMSS_VOUCRECORDER_TAP.Name = "_IMSS_VOUCRECORDER_TAP"
        Me._IMSS_VOUCRECORDER_TAP.Text = "Voices  Logger"
        '
        '_IMSS_BACKGROUNDSYSTEMS_WORKER
        '
        Me._IMSS_BACKGROUNDSYSTEMS_WORKER.WorkerSupportsCancellation = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 475)
        Me.Controls.Add(Me._IMSS_MainWindow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(960, 513)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(960, 513)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Family Computerlogger"
        Me._IMSS_MainWindow.ResumeLayout(False)
        CType(Me._IMS_MainTapControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMS_MainTapControl.ResumeLayout(False)
        Me._IMSS_AllLoggerPanel.ResumeLayout(False)
        Me._IMSS_AllLoggerPanel.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainWindow As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMS_MainTapControl As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents _IMSS_AllLoggerPanel As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_AllLoggers As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_ScreenLogger_Panel As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_ScreenLogger_Tap As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_KeyLoggerPanel As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_KeyBoreadLogger As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_VOICERECORDER_Panel As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_VOUCRECORDER_TAP As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_StartLogging_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_RecordScreen_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents _IMSS_RecordVoice_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents _IMSS_KeyStrokes_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents _IMSS_BACKGROUNDSYSTEMS_WORKER As System.ComponentModel.BackgroundWorker
    Friend WithEvents _IMSS_EditPassword As System.Windows.Forms.LinkLabel
    Friend WithEvents _IMSS_RunOnStartUp As System.Windows.Forms.CheckBox
    Friend WithEvents _IMSS_Exit_Button As DevComponents.DotNetBar.ButtonX

End Class
