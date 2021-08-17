<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login2))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaGoogleSwitch1 = New Guna.UI.WinForms.GunaGoogleSwitch()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintText = "Username"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineThickness = 5
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(134, 353)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(433, 62)
        Me.BunifuMaterialTextbox1.TabIndex = 10
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintText = "Password"
        Me.BunifuMaterialTextbox2.isPassword = True
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineThickness = 4
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(134, 458)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(433, 60)
        Me.BunifuMaterialTextbox2.TabIndex = 9
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(233, 598)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GunaButton1.OnPressedDepth = 60
        Me.GunaButton1.Radius = 13
        Me.GunaButton1.Size = New System.Drawing.Size(218, 59)
        Me.GunaButton1.TabIndex = 8
        Me.GunaButton1.Text = "LOGIN"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 44
        Me.IconPictureBox1.Location = New System.Drawing.Point(627, 12)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(44, 56)
        Me.IconPictureBox1.TabIndex = 12
        Me.IconPictureBox1.TabStop = False
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(282, 671)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(85, 28)
        Me.GunaLinkLabel1.TabIndex = 13
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "SIGN IN"
        '
        'GunaGoogleSwitch1
        '
        Me.GunaGoogleSwitch1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaGoogleSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGoogleSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaGoogleSwitch1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaGoogleSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.GunaGoogleSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaGoogleSwitch1.FillColor = System.Drawing.Color.White
        Me.GunaGoogleSwitch1.Location = New System.Drawing.Point(134, 538)
        Me.GunaGoogleSwitch1.Name = "GunaGoogleSwitch1"
        Me.GunaGoogleSwitch1.Size = New System.Drawing.Size(58, 32)
        Me.GunaGoogleSwitch1.TabIndex = 14
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(182, 531)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(158, 28)
        Me.GunaLabel1.TabIndex = 15
        Me.GunaLabel1.Text = "Show Password"
        '
        'Login2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Dashboard.My.Resources.Resources.innerlog
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(683, 758)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaGoogleSwitch1)
        Me.Controls.Add(Me.GunaLinkLabel1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.Controls.Add(Me.GunaButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login2"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaGoogleSwitch1 As Guna.UI.WinForms.GunaGoogleSwitch
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
