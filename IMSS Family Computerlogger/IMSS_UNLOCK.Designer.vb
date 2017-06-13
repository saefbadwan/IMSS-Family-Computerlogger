<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_UNLOCK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_UNLOCK))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_CONTROL_HOLDER_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Unlock = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_PASSWORD_TextBox = New System.Windows.Forms.TextBox()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_CONTROL_HOLDER_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CONTROL_HOLDER_Panel)
        Me._IMSS_MainPanel.Controls.Add(Me.Label2)
        Me._IMSS_MainPanel.Controls.Add(Me.Label1)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_PASSWORD_TextBox)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(296, 92)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_CONTROL_HOLDER_Panel
        '
        Me._IMSS_CONTROL_HOLDER_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_CONTROL_HOLDER_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CONTROL_HOLDER_Panel.Controls.Add(Me._IMSS_Unlock)
        Me._IMSS_CONTROL_HOLDER_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_CONTROL_HOLDER_Panel.Location = New System.Drawing.Point(0, 60)
        Me._IMSS_CONTROL_HOLDER_Panel.Name = "_IMSS_CONTROL_HOLDER_Panel"
        Me._IMSS_CONTROL_HOLDER_Panel.Size = New System.Drawing.Size(296, 32)
        Me._IMSS_CONTROL_HOLDER_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_CONTROL_HOLDER_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_CONTROL_HOLDER_Panel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_CONTROL_HOLDER_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_CONTROL_HOLDER_Panel.Style.GradientAngle = 90
        Me._IMSS_CONTROL_HOLDER_Panel.TabIndex = 14
        '
        '_IMSS_Unlock
        '
        Me._IMSS_Unlock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Unlock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Unlock.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Unlock.Location = New System.Drawing.Point(217, 5)
        Me._IMSS_Unlock.Name = "_IMSS_Unlock"
        Me._IMSS_Unlock.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Unlock.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Unlock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Unlock.TabIndex = 13
        Me._IMSS_Unlock.Text = "Unlock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please insert your password to unlock Main Window !"
        '
        '_IMSS_PASSWORD_TextBox
        '
        Me._IMSS_PASSWORD_TextBox.Location = New System.Drawing.Point(75, 34)
        Me._IMSS_PASSWORD_TextBox.Name = "_IMSS_PASSWORD_TextBox"
        Me._IMSS_PASSWORD_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._IMSS_PASSWORD_TextBox.Size = New System.Drawing.Size(217, 20)
        Me._IMSS_PASSWORD_TextBox.TabIndex = 2
        '
        'IMSS_UNLOCK
        '
        Me.AcceptButton = Me._IMSS_Unlock
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 92)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(312, 130)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(312, 130)
        Me.Name = "IMSS_UNLOCK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Family Computerlogger"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me._IMSS_CONTROL_HOLDER_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_PASSWORD_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _IMSS_CONTROL_HOLDER_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Unlock As DevComponents.DotNetBar.ButtonX
End Class
