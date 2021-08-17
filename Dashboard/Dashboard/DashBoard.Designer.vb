<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoard))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.exitbtn = New FontAwesome.Sharp.IconButton()
        Me.minbtn = New FontAwesome.Sharp.IconButton()
        Me.maxbtn = New FontAwesome.Sharp.IconButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelMenu.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.AccessibleName = "Panel Menu"
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconPictureBox1)
        Me.PanelMenu.Controls.Add(Me.IconButton6)
        Me.PanelMenu.Controls.Add(Me.IconButton5)
        Me.PanelMenu.Controls.Add(Me.IconButton3)
        Me.PanelMenu.Controls.Add(Me.Label1)
        Me.PanelMenu.Controls.Add(Me.IconButton2)
        Me.PanelMenu.Controls.Add(Me.IconButton4)
        Me.PanelMenu.Controls.Add(Me.GunaLabel1)
        Me.PanelMenu.Controls.Add(Me.GunaPictureBox1)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 18)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(263, 884)
        Me.PanelMenu.TabIndex = 0
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 59
        Me.IconPictureBox1.Location = New System.Drawing.Point(65, 143)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(61, 59)
        Me.IconPictureBox1.TabIndex = 10
        Me.IconPictureBox1.TabStop = False
        '
        'IconButton6
        '
        Me.IconButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.IconButton6.ForeColor = System.Drawing.Color.White
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconButton6.IconColor = System.Drawing.Color.White
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 32
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(0, 623)
        Me.IconButton6.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton6.Size = New System.Drawing.Size(263, 87)
        Me.IconButton6.TabIndex = 6
        Me.IconButton6.Text = "About Us"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = False
        '
        'IconButton5
        '
        Me.IconButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.IconButton5.ForeColor = System.Drawing.Color.White
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.ChartPie
        Me.IconButton5.IconColor = System.Drawing.Color.White
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 32
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(-3, 540)
        Me.IconButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton5.Size = New System.Drawing.Size(263, 87)
        Me.IconButton5.TabIndex = 5
        Me.IconButton5.Text = "Report"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.MobileAlt
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 32
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 377)
        Me.IconButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton3.Size = New System.Drawing.Size(263, 87)
        Me.IconButton3.TabIndex = 3
        Me.IconButton3.Text = "Stock"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(125, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 32
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(-4, 460)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton2.Size = New System.Drawing.Size(263, 87)
        Me.IconButton2.TabIndex = 2
        Me.IconButton2.Text = "Sales"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.IconButton4.ForeColor = System.Drawing.Color.White
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        Me.IconButton4.IconColor = System.Drawing.Color.White
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 32
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(-4, 292)
        Me.IconButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton4.Size = New System.Drawing.Size(263, 87)
        Me.IconButton4.TabIndex = 4
        Me.IconButton4.Text = "Outlet"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(79, 851)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(79, 23)
        Me.GunaLabel1.TabIndex = 8
        Me.GunaLabel1.Text = "Sign-Out"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Dashboard.My.Resources.Resources.Logout
        Me.GunaPictureBox1.Location = New System.Drawing.Point(83, 771)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(65, 77)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 7
        Me.GunaPictureBox1.TabStop = False
        '
        'PanelLogo
        '
        Me.PanelLogo.AccessibleName = "Panel Logo"
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Location = New System.Drawing.Point(-3, 22)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(265, 110)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, -59)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ChevronDown
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 209)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton1.Size = New System.Drawing.Size(263, 87)
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.Text = "DashBoard"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.PictureBox3)
        Me.PanelDesktop.Location = New System.Drawing.Point(255, 43)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1373, 859)
        Me.PanelDesktop.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(393, 176)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(616, 469)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PanelTitle
        '
        Me.PanelTitle.AccessibleName = "Panel title"
        Me.PanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PanelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTitle.Controls.Add(Me.exitbtn)
        Me.PanelTitle.Controls.Add(Me.minbtn)
        Me.PanelTitle.Controls.Add(Me.maxbtn)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1628, 44)
        Me.PanelTitle.TabIndex = 1
        '
        'exitbtn
        '
        Me.exitbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitbtn.FlatAppearance.BorderSize = 0
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.ForeColor = System.Drawing.Color.Transparent
        Me.exitbtn.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.exitbtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.exitbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.exitbtn.IconSize = 25
        Me.exitbtn.Location = New System.Drawing.Point(1573, 0)
        Me.exitbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(53, 34)
        Me.exitbtn.TabIndex = 13
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'minbtn
        '
        Me.minbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minbtn.FlatAppearance.BorderSize = 0
        Me.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minbtn.ForeColor = System.Drawing.Color.Transparent
        Me.minbtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.minbtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.minbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.minbtn.IconSize = 29
        Me.minbtn.Location = New System.Drawing.Point(1490, -1)
        Me.minbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.minbtn.Name = "minbtn"
        Me.minbtn.Size = New System.Drawing.Size(52, 34)
        Me.minbtn.TabIndex = 12
        Me.minbtn.UseVisualStyleBackColor = True
        '
        'maxbtn
        '
        Me.maxbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxbtn.FlatAppearance.BorderSize = 0
        Me.maxbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maxbtn.ForeColor = System.Drawing.Color.Transparent
        Me.maxbtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.maxbtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.maxbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.maxbtn.IconSize = 25
        Me.maxbtn.Location = New System.Drawing.Point(1536, 0)
        Me.maxbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.maxbtn.Name = "maxbtn"
        Me.maxbtn.Size = New System.Drawing.Size(52, 34)
        Me.maxbtn.TabIndex = 11
        Me.maxbtn.UseVisualStyleBackColor = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelTitle
        Me.BunifuDragControl1.Vertical = True
        '
        'DashBoard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1628, 902)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As System.Windows.Forms.Panel
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents exitbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents minbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents maxbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox

End Class
