<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGoogleSwitch1 = New Guna.UI.WinForms.GunaGoogleSwitch()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 25
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = False
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(105, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintText = "Username"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineThickness = 4
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(95, 228)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(322, 48)
        Me.BunifuMaterialTextbox1.TabIndex = 1
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintText = "Password"
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineThickness = 4
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(95, 305)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(322, 48)
        Me.BunifuMaterialTextbox2.TabIndex = 2
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Honeydew
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("LEMON MILK", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(203, 494)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(95, 27)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "SIGN-UP"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.DarkSlateGray
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(433, 12)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(27, 28)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 5
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "LOGIN"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(142, 426)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(216, 53)
        Me.BunifuFlatButton1.TabIndex = 6
        Me.BunifuFlatButton1.Text = "LOGIN"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("LEMON MILK Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(188, 384)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(134, 23)
        Me.GunaLabel1.TabIndex = 9
        Me.GunaLabel1.Text = "Show Password"
        '
        'GunaGoogleSwitch1
        '
        Me.GunaGoogleSwitch1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaGoogleSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGoogleSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaGoogleSwitch1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaGoogleSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.GunaGoogleSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.GunaGoogleSwitch1.FillColor = System.Drawing.Color.White
        Me.GunaGoogleSwitch1.Location = New System.Drawing.Point(129, 384)
        Me.GunaGoogleSwitch1.Name = "GunaGoogleSwitch1"
        Me.GunaGoogleSwitch1.Size = New System.Drawing.Size(53, 26)
        Me.GunaGoogleSwitch1.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(486, 572)
        Me.Controls.Add(Me.GunaGoogleSwitch1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGoogleSwitch1 As Guna.UI.WinForms.GunaGoogleSwitch
End Class
