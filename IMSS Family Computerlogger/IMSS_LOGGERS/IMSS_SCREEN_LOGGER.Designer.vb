<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SCREEN_LOGGER
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_SCREEN_LOGGER))
        Me._IMSS_MainWindow = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_MainSpliter = New System.Windows.Forms.SplitContainer()
        Me._IMSS_LOGS_FILE_LIST = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_LOG_DATE = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_MainBackGroundImages = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Date_Label = New System.Windows.Forms.Label()
        Me._IMSS_ImageName_Label = New System.Windows.Forms.Label()
        Me._IMSS_Back = New System.Windows.Forms.PictureBox()
        Me._IMSS_Next = New System.Windows.Forms.PictureBox()
        Me._IMSS_MainPicuterBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_ImagesListView = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_MainWindow.SuspendLayout()
        Me._IMSS_MainSpliter.Panel1.SuspendLayout()
        Me._IMSS_MainSpliter.Panel2.SuspendLayout()
        Me._IMSS_MainSpliter.SuspendLayout()
        CType(Me._IMSS_LOGS_FILE_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MainBackGroundImages.SuspendLayout()
        CType(Me._IMSS_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_MainPicuterBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_ImagesListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainWindow
        '
        Me._IMSS_MainWindow.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainWindow.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainWindow.Controls.Add(Me._IMSS_MainSpliter)
        Me._IMSS_MainWindow.Controls.Add(Me._IMSS_Refresh)
        Me._IMSS_MainWindow.Controls.Add(Me.ButtonX1)
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
        '_IMSS_MainSpliter
        '
        Me._IMSS_MainSpliter.Location = New System.Drawing.Point(6, 36)
        Me._IMSS_MainSpliter.Name = "_IMSS_MainSpliter"
        '
        '_IMSS_MainSpliter.Panel1
        '
        Me._IMSS_MainSpliter.Panel1.Controls.Add(Me._IMSS_LOGS_FILE_LIST)
        '
        '_IMSS_MainSpliter.Panel2
        '
        Me._IMSS_MainSpliter.Panel2.Controls.Add(Me._IMSS_MainBackGroundImages)
        Me._IMSS_MainSpliter.Size = New System.Drawing.Size(777, 434)
        Me._IMSS_MainSpliter.SplitterDistance = 155
        Me._IMSS_MainSpliter.TabIndex = 12
        '
        '_IMSS_LOGS_FILE_LIST
        '
        Me._IMSS_LOGS_FILE_LIST.Columns.AddRange(New Object() {Me._IMSS_LOG_DATE})
        Me._IMSS_LOGS_FILE_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_LOGS_FILE_LIST.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_LOGS_FILE_LIST.MultiSelect = False
        Me._IMSS_LOGS_FILE_LIST.Name = "_IMSS_LOGS_FILE_LIST"
        Me._IMSS_LOGS_FILE_LIST.Size = New System.Drawing.Size(155, 434)
        Me._IMSS_LOGS_FILE_LIST.TabIndex = 11
        '
        '_IMSS_LOG_DATE
        '
        Me._IMSS_LOG_DATE.Name = "_IMSS_LOG_DATE"
        Me._IMSS_LOG_DATE.Text = "LOG DATE"
        Me._IMSS_LOG_DATE.Width = 150
        '
        '_IMSS_MainBackGroundImages
        '
        Me._IMSS_MainBackGroundImages.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainBackGroundImages.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainBackGroundImages.Controls.Add(Me._IMSS_Date_Label)
        Me._IMSS_MainBackGroundImages.Controls.Add(Me._IMSS_ImageName_Label)
        Me._IMSS_MainBackGroundImages.Controls.Add(Me._IMSS_Back)
        Me._IMSS_MainBackGroundImages.Controls.Add(Me._IMSS_Next)
        Me._IMSS_MainBackGroundImages.Controls.Add(Me._IMSS_MainPicuterBox)
        Me._IMSS_MainBackGroundImages.Controls.Add(Me._IMSS_ImagesListView)
        Me._IMSS_MainBackGroundImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainBackGroundImages.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainBackGroundImages.Name = "_IMSS_MainBackGroundImages"
        Me._IMSS_MainBackGroundImages.Size = New System.Drawing.Size(618, 434)
        Me._IMSS_MainBackGroundImages.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainBackGroundImages.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_MainBackGroundImages.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainBackGroundImages.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainBackGroundImages.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainBackGroundImages.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainBackGroundImages.Style.GradientAngle = 90
        Me._IMSS_MainBackGroundImages.TabIndex = 2
        '
        '_IMSS_Date_Label
        '
        Me._IMSS_Date_Label.AutoSize = True
        Me._IMSS_Date_Label.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Date_Label.Location = New System.Drawing.Point(421, 22)
        Me._IMSS_Date_Label.Name = "_IMSS_Date_Label"
        Me._IMSS_Date_Label.Size = New System.Drawing.Size(35, 14)
        Me._IMSS_Date_Label.TabIndex = 5
        Me._IMSS_Date_Label.Text = "Date :"
        '
        '_IMSS_ImageName_Label
        '
        Me._IMSS_ImageName_Label.AutoSize = True
        Me._IMSS_ImageName_Label.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ImageName_Label.Location = New System.Drawing.Point(57, 22)
        Me._IMSS_ImageName_Label.Name = "_IMSS_ImageName_Label"
        Me._IMSS_ImageName_Label.Size = New System.Drawing.Size(40, 14)
        Me._IMSS_ImageName_Label.TabIndex = 4
        Me._IMSS_ImageName_Label.Text = "Name :"
        '
        '_IMSS_Back
        '
        Me._IMSS_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_Back.Image = CType(resources.GetObject("_IMSS_Back.Image"), System.Drawing.Image)
        Me._IMSS_Back.Location = New System.Drawing.Point(6, 167)
        Me._IMSS_Back.Name = "_IMSS_Back"
        Me._IMSS_Back.Size = New System.Drawing.Size(48, 48)
        Me._IMSS_Back.TabIndex = 3
        Me._IMSS_Back.TabStop = False
        '
        '_IMSS_Next
        '
        Me._IMSS_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_Next.Image = CType(resources.GetObject("_IMSS_Next.Image"), System.Drawing.Image)
        Me._IMSS_Next.Location = New System.Drawing.Point(565, 167)
        Me._IMSS_Next.Name = "_IMSS_Next"
        Me._IMSS_Next.Size = New System.Drawing.Size(48, 48)
        Me._IMSS_Next.TabIndex = 2
        Me._IMSS_Next.TabStop = False
        '
        '_IMSS_MainPicuterBox
        '
        Me._IMSS_MainPicuterBox.BackColor = System.Drawing.Color.White
        Me._IMSS_MainPicuterBox.BackgroundImage = CType(resources.GetObject("_IMSS_MainPicuterBox.BackgroundImage"), System.Drawing.Image)
        Me._IMSS_MainPicuterBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me._IMSS_MainPicuterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._IMSS_MainPicuterBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me._IMSS_MainPicuterBox.Location = New System.Drawing.Point(60, 40)
        Me._IMSS_MainPicuterBox.Name = "_IMSS_MainPicuterBox"
        Me._IMSS_MainPicuterBox.Size = New System.Drawing.Size(499, 284)
        Me._IMSS_MainPicuterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_MainPicuterBox.TabIndex = 1
        Me._IMSS_MainPicuterBox.TabStop = False
        '
        '_IMSS_ImagesListView
        '
        Me._IMSS_ImagesListView.ImageList = Me._IMSS_ImageList
        Me._IMSS_ImagesListView.Location = New System.Drawing.Point(8, 330)
        Me._IMSS_ImagesListView.MultiSelect = False
        Me._IMSS_ImagesListView.Name = "_IMSS_ImagesListView"
        Me._IMSS_ImagesListView.Size = New System.Drawing.Size(602, 99)
        Me._IMSS_ImagesListView.TabIndex = 0
        Me._IMSS_ImagesListView.View = ComponentOwl.BetterListView.BetterListViewView.LargeIcon
        '
        '_IMSS_ImageList
        '
        Me._IMSS_ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me._IMSS_ImageList.ImageSize = New System.Drawing.Size(74, 49)
        Me._IMSS_ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        '_IMSS_Refresh
        '
        Me._IMSS_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Refresh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Refresh.Location = New System.Drawing.Point(621, 5)
        Me._IMSS_Refresh.Name = "_IMSS_Refresh"
        Me._IMSS_Refresh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Refresh.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Refresh.TabIndex = 10
        Me._IMSS_Refresh.Text = "Refresh"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(702, 5)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 9
        Me.ButtonX1.Text = "Clear log"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Screen-Logging : screen recorder taking a screenshot every current time for the p" & _
            "c screen to find out what's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "happening on your computer."
        '
        'IMSS_SCREEN_LOGGER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_MainWindow)
        Me.Name = "IMSS_SCREEN_LOGGER"
        Me.Size = New System.Drawing.Size(797, 482)
        Me._IMSS_MainWindow.ResumeLayout(False)
        Me._IMSS_MainWindow.PerformLayout()
        Me._IMSS_MainSpliter.Panel1.ResumeLayout(False)
        Me._IMSS_MainSpliter.Panel2.ResumeLayout(False)
        Me._IMSS_MainSpliter.ResumeLayout(False)
        CType(Me._IMSS_LOGS_FILE_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MainBackGroundImages.ResumeLayout(False)
        Me._IMSS_MainBackGroundImages.PerformLayout()
        CType(Me._IMSS_Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_MainPicuterBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_ImagesListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainWindow As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_MainSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents _IMSS_LOGS_FILE_LIST As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_LOG_DATE As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_MainPicuterBox As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_ImagesListView As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_MainBackGroundImages As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Back As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Next As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Date_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_ImageName_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_ImageList As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
