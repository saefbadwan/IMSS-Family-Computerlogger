<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_KEY_LOGGER
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
        Me._IMSS_MainWindow = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me._IMSS_LOGS_FILE_LIST = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_LOG_DATE = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_LOGS_TEXT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_MainWindow.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me._IMSS_LOGS_FILE_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainWindow
        '
        Me._IMSS_MainWindow.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainWindow.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainWindow.Controls.Add(Me._IMSS_Refresh)
        Me._IMSS_MainWindow.Controls.Add(Me.SplitContainer1)
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
        '_IMSS_Refresh
        '
        Me._IMSS_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Refresh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Refresh.Location = New System.Drawing.Point(624, 12)
        Me._IMSS_Refresh.Name = "_IMSS_Refresh"
        Me._IMSS_Refresh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Refresh.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Refresh.TabIndex = 7
        Me._IMSS_Refresh.Text = "Refresh"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 42)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me._IMSS_LOGS_FILE_LIST)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me._IMSS_LOGS_TEXT)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 430)
        Me.SplitContainer1.SplitterDistance = 165
        Me.SplitContainer1.TabIndex = 6
        '
        '_IMSS_LOGS_FILE_LIST
        '
        Me._IMSS_LOGS_FILE_LIST.Columns.AddRange(New Object() {Me._IMSS_LOG_DATE})
        Me._IMSS_LOGS_FILE_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_LOGS_FILE_LIST.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_LOGS_FILE_LIST.MultiSelect = False
        Me._IMSS_LOGS_FILE_LIST.Name = "_IMSS_LOGS_FILE_LIST"
        Me._IMSS_LOGS_FILE_LIST.Size = New System.Drawing.Size(165, 430)
        Me._IMSS_LOGS_FILE_LIST.TabIndex = 4
        '
        '_IMSS_LOG_DATE
        '
        Me._IMSS_LOG_DATE.Name = "_IMSS_LOG_DATE"
        Me._IMSS_LOG_DATE.Text = "LOG DATE"
        Me._IMSS_LOG_DATE.Width = 154
        '
        '_IMSS_LOGS_TEXT
        '
        Me._IMSS_LOGS_TEXT.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me._IMSS_LOGS_TEXT.Border.Class = "TextBoxBorder"
        Me._IMSS_LOGS_TEXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LOGS_TEXT.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_LOGS_TEXT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LOGS_TEXT.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_LOGS_TEXT.MaxLength = 100000
        Me._IMSS_LOGS_TEXT.Multiline = True
        Me._IMSS_LOGS_TEXT.Name = "_IMSS_LOGS_TEXT"
        Me._IMSS_LOGS_TEXT.ReadOnly = True
        Me._IMSS_LOGS_TEXT.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._IMSS_LOGS_TEXT.Size = New System.Drawing.Size(619, 430)
        Me._IMSS_LOGS_TEXT.TabIndex = 0
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(705, 12)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "Clear log"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(525, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Key-Logger : you can enable the capturing of keyboards key(s) means anything that" & _
            " has been typed on the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "keyboard it will saved here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'IMSS_KEY_LOGGER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_MainWindow)
        Me.Name = "IMSS_KEY_LOGGER"
        Me.Size = New System.Drawing.Size(797, 482)
        Me._IMSS_MainWindow.ResumeLayout(False)
        Me._IMSS_MainWindow.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me._IMSS_LOGS_FILE_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainWindow As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_LOGS_TEXT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_LOGS_FILE_LIST As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_LOG_DATE As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents _IMSS_Refresh As DevComponents.DotNetBar.ButtonX

End Class
