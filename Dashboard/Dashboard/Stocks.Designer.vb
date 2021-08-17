Imports Dashboard.Database2DataSetTableAdapters

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stocks
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
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stocks))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.stock_tab = New Bunifu.UI.WinForms.BunifuPages()
        Me.add = New System.Windows.Forms.TabPage()
        Me.ComboBox3 = New Guna.UI.WinForms.GunaComboBox()
        Me.ComboBox2 = New Guna.UI.WinForms.GunaComboBox()
        Me.ComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New Guna.UI.WinForms.GunaTextBox()
        Me.TextBox4 = New Guna.UI.WinForms.GunaTextBox()
        Me.TextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.TextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.TextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.edit = New System.Windows.Forms.TabPage()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox7 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaTextBox6 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox5 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox4 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.Model = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.del = New System.Windows.Forms.TabPage()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OneplusBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test = New Global.Dashboard.test()
        Me.GunaComboBox3 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaComboBox2 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.OneplusBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.del_stock = New FontAwesome.Sharp.IconButton()
        Me.add_stock = New FontAwesome.Sharp.IconButton()
        Me.edit_stock = New FontAwesome.Sharp.IconButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OneplusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OneplusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IPhoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OneplusTableAdapter = New Global.Dashboard.Database2DataSetTableAdapters.OneplusTableAdapter()
        Me.stock_tab.SuspendLayout()
        Me.add.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.edit.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.del.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OneplusBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OneplusBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.OneplusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OneplusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IPhoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stock_tab
        '
        Me.stock_tab.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.stock_tab.AllowTransitions = True
        Me.stock_tab.Controls.Add(Me.add)
        Me.stock_tab.Controls.Add(Me.edit)
        Me.stock_tab.Controls.Add(Me.del)
        Me.stock_tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stock_tab.Location = New System.Drawing.Point(0, 0)
        Me.stock_tab.Margin = New System.Windows.Forms.Padding(4)
        Me.stock_tab.Multiline = True
        Me.stock_tab.Name = "stock_tab"
        Me.stock_tab.Page = Me.add
        Me.stock_tab.PageIndex = 0
        Me.stock_tab.PageName = "add"
        Me.stock_tab.PageTitle = "ADD"
        Me.stock_tab.SelectedIndex = 0
        Me.stock_tab.Size = New System.Drawing.Size(1373, 860)
        Me.stock_tab.TabIndex = 22
        Animation1.AnimateOnlyDifferences = False
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.stock_tab.Transition = Animation1
        Me.stock_tab.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom
        '
        'add
        '
        Me.add.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.add.Controls.Add(Me.ComboBox3)
        Me.add.Controls.Add(Me.ComboBox2)
        Me.add.Controls.Add(Me.ComboBox1)
        Me.add.Controls.Add(Me.GunaLabel8)
        Me.add.Controls.Add(Me.GunaLabel7)
        Me.add.Controls.Add(Me.GunaLabel6)
        Me.add.Controls.Add(Me.GunaLabel5)
        Me.add.Controls.Add(Me.GunaLabel4)
        Me.add.Controls.Add(Me.GunaLabel3)
        Me.add.Controls.Add(Me.GunaLabel2)
        Me.add.Controls.Add(Me.GunaLabel1)
        Me.add.Controls.Add(Me.GunaButton2)
        Me.add.Controls.Add(Me.GunaButton1)
        Me.add.Controls.Add(Me.PictureBox1)
        Me.add.Controls.Add(Me.TextBox5)
        Me.add.Controls.Add(Me.TextBox4)
        Me.add.Controls.Add(Me.TextBox3)
        Me.add.Controls.Add(Me.TextBox2)
        Me.add.Controls.Add(Me.TextBox1)
        Me.add.Location = New System.Drawing.Point(4, 4)
        Me.add.Margin = New System.Windows.Forms.Padding(4)
        Me.add.Name = "add"
        Me.add.Padding = New System.Windows.Forms.Padding(4)
        Me.add.Size = New System.Drawing.Size(1365, 831)
        Me.add.TabIndex = 0
        Me.add.Text = "ADD"
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ComboBox3.BorderColor = System.Drawing.Color.Silver
        Me.ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FocusedColor = System.Drawing.Color.Empty
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.ItemHeight = 35
        Me.ComboBox3.Items.AddRange(New Object() {"12GB", "8GB", "6GB", "4GB"})
        Me.ComboBox3.Location = New System.Drawing.Point(197, 349)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ComboBox3.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ComboBox3.Size = New System.Drawing.Size(223, 41)
        Me.ComboBox3.TabIndex = 48
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ComboBox2.BorderColor = System.Drawing.Color.Silver
        Me.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FocusedColor = System.Drawing.Color.Empty
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ItemHeight = 35
        Me.ComboBox2.Items.AddRange(New Object() {"256GB", "128GB", "64GB", "32GB"})
        Me.ComboBox2.Location = New System.Drawing.Point(197, 270)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ComboBox2.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ComboBox2.Size = New System.Drawing.Size(223, 41)
        Me.ComboBox2.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ComboBox1.BorderColor = System.Drawing.Color.Silver
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 35
        Me.ComboBox1.Items.AddRange(New Object() {"iPhone", "Samsung", "Oneplus", "Mi"})
        Me.ComboBox1.Location = New System.Drawing.Point(197, 118)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ComboBox1.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.ComboBox1.Size = New System.Drawing.Size(223, 41)
        Me.ComboBox1.TabIndex = 46
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(69, 658)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(92, 23)
        Me.GunaLabel8.TabIndex = 45
        Me.GunaLabel8.Text = "Quantity"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(75, 585)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(61, 23)
        Me.GunaLabel7.TabIndex = 44
        Me.GunaLabel7.Text = "Price"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(42, 510)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(145, 23)
        Me.GunaLabel6.TabIndex = 43
        Me.GunaLabel6.Text = "Front Camera"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(42, 431)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(142, 23)
        Me.GunaLabel5.TabIndex = 42
        Me.GunaLabel5.Text = "Back Camera"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(75, 357)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(54, 23)
        Me.GunaLabel4.TabIndex = 41
        Me.GunaLabel4.Text = "Ram"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(75, 277)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(88, 23)
        Me.GunaLabel3.TabIndex = 40
        Me.GunaLabel3.Text = "Storage"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(75, 205)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel2.TabIndex = 39
        Me.GunaLabel2.Text = "Model"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(75, 125)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(70, 23)
        Me.GunaLabel1.TabIndex = 38
        Me.GunaLabel1.Text = "Brand"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton2.Image = Global.Dashboard.My.Resources.Resources.save_1659426_1408816
        Me.GunaButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton2.Location = New System.Drawing.Point(996, 531)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 15
        Me.GunaButton2.Size = New System.Drawing.Size(201, 57)
        Me.GunaButton2.TabIndex = 37
        Me.GunaButton2.Text = "SAVE"
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
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton1.Image = Global.Dashboard.My.Resources.Resources._3233333_200
        Me.GunaButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton1.Location = New System.Drawing.Point(996, 454)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.Size = New System.Drawing.Size(201, 57)
        Me.GunaButton1.TabIndex = 36
        Me.GunaButton1.Text = "BROWSE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(981, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 326)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox5.BorderColor = System.Drawing.Color.Silver
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox5.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(197, 649)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox5.SelectedText = ""
        Me.TextBox5.Size = New System.Drawing.Size(223, 43)
        Me.TextBox5.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox4.BorderColor = System.Drawing.Color.Silver
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox4.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(197, 575)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox4.SelectedText = ""
        Me.TextBox4.Size = New System.Drawing.Size(223, 43)
        Me.TextBox4.TabIndex = 32
        '
        'TextBox3
        '
        Me.TextBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox3.BorderColor = System.Drawing.Color.Silver
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(197, 501)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox3.SelectedText = ""
        Me.TextBox3.Size = New System.Drawing.Size(223, 43)
        Me.TextBox3.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox2.BorderColor = System.Drawing.Color.Silver
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(197, 421)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.Size = New System.Drawing.Size(223, 43)
        Me.TextBox2.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox1.BorderColor = System.Drawing.Color.Silver
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(197, 195)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(223, 43)
        Me.TextBox1.TabIndex = 27
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.edit.Controls.Add(Me.GunaButton4)
        Me.edit.Controls.Add(Me.GunaLabel17)
        Me.edit.Controls.Add(Me.GunaLabel9)
        Me.edit.Controls.Add(Me.GunaLabel10)
        Me.edit.Controls.Add(Me.GunaLabel11)
        Me.edit.Controls.Add(Me.GunaLabel12)
        Me.edit.Controls.Add(Me.GunaLabel13)
        Me.edit.Controls.Add(Me.GunaLabel14)
        Me.edit.Controls.Add(Me.GunaLabel15)
        Me.edit.Controls.Add(Me.GunaLabel16)
        Me.edit.Controls.Add(Me.GunaTextBox7)
        Me.edit.Controls.Add(Me.GunaButton3)
        Me.edit.Controls.Add(Me.PictureBox2)
        Me.edit.Controls.Add(Me.GunaTextBox6)
        Me.edit.Controls.Add(Me.GunaTextBox5)
        Me.edit.Controls.Add(Me.GunaTextBox4)
        Me.edit.Controls.Add(Me.GunaTextBox3)
        Me.edit.Controls.Add(Me.GunaTextBox2)
        Me.edit.Controls.Add(Me.GunaTextBox1)
        Me.edit.Controls.Add(Me.Model)
        Me.edit.Controls.Add(Me.GunaComboBox1)
        Me.edit.Location = New System.Drawing.Point(4, 4)
        Me.edit.Margin = New System.Windows.Forms.Padding(4)
        Me.edit.Name = "edit"
        Me.edit.Padding = New System.Windows.Forms.Padding(4)
        Me.edit.Size = New System.Drawing.Size(1365, 831)
        Me.edit.TabIndex = 1
        Me.edit.Text = "EDIT"
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton4.Image = Global.Dashboard.My.Resources.Resources.save_1659426_1408816
        Me.GunaButton4.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton4.Location = New System.Drawing.Point(980, 571)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 15
        Me.GunaButton4.Size = New System.Drawing.Size(192, 62)
        Me.GunaButton4.TabIndex = 55
        Me.GunaButton4.Text = "Save"
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel17.Location = New System.Drawing.Point(123, 207)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel17.TabIndex = 54
        Me.GunaLabel17.Text = "Model"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(102, 737)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(92, 23)
        Me.GunaLabel9.TabIndex = 53
        Me.GunaLabel9.Text = "Quantity"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel10.Location = New System.Drawing.Point(116, 667)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(61, 23)
        Me.GunaLabel10.TabIndex = 52
        Me.GunaLabel10.Text = "Price"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(70, 590)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(145, 23)
        Me.GunaLabel11.TabIndex = 51
        Me.GunaLabel11.Text = "Front Camera"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel12.Location = New System.Drawing.Point(70, 518)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(142, 23)
        Me.GunaLabel12.TabIndex = 50
        Me.GunaLabel12.Text = "Back Camera"
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel13.Location = New System.Drawing.Point(116, 443)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(54, 23)
        Me.GunaLabel13.TabIndex = 49
        Me.GunaLabel13.Text = "Ram"
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel14.Location = New System.Drawing.Point(105, 367)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(88, 23)
        Me.GunaLabel14.TabIndex = 48
        Me.GunaLabel14.Text = "Storage"
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel15.Location = New System.Drawing.Point(84, 287)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(131, 23)
        Me.GunaLabel15.TabIndex = 47
        Me.GunaLabel15.Text = "Model Name"
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel16.Location = New System.Drawing.Point(123, 126)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(70, 23)
        Me.GunaLabel16.TabIndex = 46
        Me.GunaLabel16.Text = "Brand"
        '
        'GunaTextBox7
        '
        Me.GunaTextBox7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaTextBox7.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox7.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox7.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox7.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox7.Location = New System.Drawing.Point(228, 725)
        Me.GunaTextBox7.Name = "GunaTextBox7"
        Me.GunaTextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox7.SelectedText = ""
        Me.GunaTextBox7.Size = New System.Drawing.Size(190, 42)
        Me.GunaTextBox7.TabIndex = 10
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton3.Image = Global.Dashboard.My.Resources.Resources._1200px_Picture_icon_BLACK_svg
        Me.GunaButton3.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton3.Location = New System.Drawing.Point(980, 488)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 15
        Me.GunaButton3.Size = New System.Drawing.Size(192, 62)
        Me.GunaButton3.TabIndex = 9
        Me.GunaButton3.Text = "Choose Image"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Dashboard.My.Resources.Resources.imageedit_5_3013696450
        Me.PictureBox2.Location = New System.Drawing.Point(958, 154)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(227, 312)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'GunaTextBox6
        '
        Me.GunaTextBox6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaTextBox6.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox6.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox6.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox6.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox6.Location = New System.Drawing.Point(228, 658)
        Me.GunaTextBox6.Name = "GunaTextBox6"
        Me.GunaTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox6.SelectedText = ""
        Me.GunaTextBox6.Size = New System.Drawing.Size(190, 39)
        Me.GunaTextBox6.TabIndex = 7
        '
        'GunaTextBox5
        '
        Me.GunaTextBox5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaTextBox5.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox5.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox5.Location = New System.Drawing.Point(231, 581)
        Me.GunaTextBox5.Name = "GunaTextBox5"
        Me.GunaTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox5.SelectedText = ""
        Me.GunaTextBox5.Size = New System.Drawing.Size(189, 41)
        Me.GunaTextBox5.TabIndex = 6
        '
        'GunaTextBox4
        '
        Me.GunaTextBox4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaTextBox4.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox4.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox4.Location = New System.Drawing.Point(230, 509)
        Me.GunaTextBox4.Name = "GunaTextBox4"
        Me.GunaTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox4.SelectedText = ""
        Me.GunaTextBox4.Size = New System.Drawing.Size(190, 41)
        Me.GunaTextBox4.TabIndex = 5
        '
        'GunaTextBox3
        '
        Me.GunaTextBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaTextBox3.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox3.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox3.Location = New System.Drawing.Point(231, 430)
        Me.GunaTextBox3.Name = "GunaTextBox3"
        Me.GunaTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox3.SelectedText = ""
        Me.GunaTextBox3.Size = New System.Drawing.Size(189, 41)
        Me.GunaTextBox3.TabIndex = 4
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox2.Location = New System.Drawing.Point(229, 359)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.SelectedText = ""
        Me.GunaTextBox2.Size = New System.Drawing.Size(191, 37)
        Me.GunaTextBox2.TabIndex = 3
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaTextBox1.Location = New System.Drawing.Point(229, 283)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(191, 41)
        Me.GunaTextBox1.TabIndex = 2
        '
        'Model
        '
        Me.Model.BackColor = System.Drawing.Color.Transparent
        Me.Model.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Model.BorderColor = System.Drawing.Color.Silver
        Me.Model.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Model.FocusedColor = System.Drawing.Color.Empty
        Me.Model.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Model.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Model.FormattingEnabled = True
        Me.Model.ItemHeight = 35
        Me.Model.Location = New System.Drawing.Point(229, 205)
        Me.Model.Name = "Model"
        Me.Model.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Model.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.Model.Size = New System.Drawing.Size(190, 41)
        Me.Model.TabIndex = 1
        '
        'GunaComboBox1
        '
        Me.GunaComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaComboBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaComboBox1.FormattingEnabled = True
        Me.GunaComboBox1.ItemHeight = 35
        Me.GunaComboBox1.Items.AddRange(New Object() {"iPhone", "Samsung", "Oneplus", "Mi"})
        Me.GunaComboBox1.Location = New System.Drawing.Point(229, 124)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.GunaComboBox1.Size = New System.Drawing.Size(190, 41)
        Me.GunaComboBox1.TabIndex = 0
        '
        'del
        '
        Me.del.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.del.Controls.Add(Me.GunaDataGridView1)
        Me.del.Controls.Add(Me.GunaComboBox3)
        Me.del.Controls.Add(Me.GunaComboBox2)
        Me.del.Controls.Add(Me.GunaButton5)
        Me.del.Location = New System.Drawing.Point(4, 4)
        Me.del.Margin = New System.Windows.Forms.Padding(4)
        Me.del.Name = "del"
        Me.del.Padding = New System.Windows.Forms.Padding(4)
        Me.del.Size = New System.Drawing.Size(1365, 831)
        Me.del.TabIndex = 2
        Me.del.Text = "DEL"
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoGenerateColumns = False
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 30
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewImageColumn4, Me.DataGridViewTextBoxColumn30})
        Me.GunaDataGridView1.DataSource = Me.OneplusBindingSource3
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(75, 202)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowTemplate.Height = 120
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(1219, 589)
        Me.GunaDataGridView1.TabIndex = 3
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 30
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 120
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Storage"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Storage"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Ram"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Ram"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Back"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Back"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Front"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Front"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.DataPropertyName = "img"
        Me.DataGridViewImageColumn4.HeaderText = "img"
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'OneplusBindingSource3
        '
        Me.OneplusBindingSource3.DataMember = "Oneplus"
        Me.OneplusBindingSource3.DataSource = Me.Test
        '
        'Test
        '
        Me.Test.DataSetName = "test"
        Me.Test.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GunaComboBox3
        '
        Me.GunaComboBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaComboBox3.BorderColor = System.Drawing.Color.Silver
        Me.GunaComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaComboBox3.FormattingEnabled = True
        Me.GunaComboBox3.ItemHeight = 35
        Me.GunaComboBox3.Location = New System.Drawing.Point(383, 126)
        Me.GunaComboBox3.Name = "GunaComboBox3"
        Me.GunaComboBox3.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaComboBox3.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.GunaComboBox3.Size = New System.Drawing.Size(211, 41)
        Me.GunaComboBox3.TabIndex = 1
        '
        'GunaComboBox2
        '
        Me.GunaComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaComboBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaComboBox2.FormattingEnabled = True
        Me.GunaComboBox2.ItemHeight = 35
        Me.GunaComboBox2.Items.AddRange(New Object() {"iPhone", "Samsung", "Oneplus", "Mi"})
        Me.GunaComboBox2.Location = New System.Drawing.Point(122, 126)
        Me.GunaComboBox2.Name = "GunaComboBox2"
        Me.GunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.GunaComboBox2.Size = New System.Drawing.Size(200, 41)
        Me.GunaComboBox2.TabIndex = 0
        '
        'GunaButton5
        '
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GunaButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton5.Image = Global.Dashboard.My.Resources.Resources.delete_remove_trash_trash_bin_trash_can_icon_1320073117929397588
        Me.GunaButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton5.Location = New System.Drawing.Point(688, 126)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton5.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton5.TabIndex = 2
        Me.GunaButton5.Text = "DELETE"
        '
        'OneplusBindingSource2
        '
        Me.OneplusBindingSource2.DataMember = "Oneplus"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(21, 21)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(99, 32)
        Me.BunifuCustomLabel1.TabIndex = 21
        Me.BunifuCustomLabel1.Text = "Stocks"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.del_stock)
        Me.Panel1.Controls.Add(Me.add_stock)
        Me.Panel1.Controls.Add(Me.edit_stock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1373, 74)
        Me.Panel1.TabIndex = 23
        '
        'del_stock
        '
        Me.del_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.del_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.del_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.del_stock.FlatAppearance.BorderSize = 0
        Me.del_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del_stock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.del_stock.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.del_stock.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.del_stock.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.del_stock.IconSize = 35
        Me.del_stock.Location = New System.Drawing.Point(1280, 10)
        Me.del_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.del_stock.Name = "del_stock"
        Me.del_stock.Size = New System.Drawing.Size(93, 63)
        Me.del_stock.TabIndex = 25
        Me.del_stock.UseVisualStyleBackColor = False
        '
        'add_stock
        '
        Me.add_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.add_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.add_stock.FlatAppearance.BorderSize = 0
        Me.add_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_stock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.add_stock.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.add_stock.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.add_stock.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.add_stock.IconSize = 45
        Me.add_stock.Location = New System.Drawing.Point(1095, 13)
        Me.add_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.add_stock.Name = "add_stock"
        Me.add_stock.Size = New System.Drawing.Size(81, 57)
        Me.add_stock.TabIndex = 23
        Me.add_stock.UseVisualStyleBackColor = False
        '
        'edit_stock
        '
        Me.edit_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edit_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.edit_stock.FlatAppearance.BorderSize = 0
        Me.edit_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_stock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.edit_stock.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.edit_stock.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.edit_stock.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_stock.IconSize = 60
        Me.edit_stock.Location = New System.Drawing.Point(1184, 4)
        Me.edit_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.edit_stock.Name = "edit_stock"
        Me.edit_stock.Size = New System.Drawing.Size(103, 66)
        Me.edit_stock.TabIndex = 24
        Me.edit_stock.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OneplusBindingSource1
        '
        Me.OneplusBindingSource1.DataMember = "Oneplus"
        '
        'OneplusBindingSource
        '
        Me.OneplusBindingSource.DataMember = "Oneplus"
        '
        'IPhoneBindingSource
        '
        Me.IPhoneBindingSource.DataMember = "iPhone"
        '
        'OneplusTableAdapter
        '
        Me.OneplusTableAdapter.ClearBeforeFill = True
        '
        'Stocks
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1373, 860)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stock_tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Stocks"
        Me.Text = "Stocks"
        Me.stock_tab.ResumeLayout(False)
        Me.add.ResumeLayout(False)
        Me.add.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.edit.ResumeLayout(False)
        Me.edit.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.del.ResumeLayout(False)
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OneplusBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OneplusBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OneplusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OneplusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IPhoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents stock_tab As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents add As System.Windows.Forms.TabPage
    Friend WithEvents edit As System.Windows.Forms.TabPage
    Friend WithEvents del As System.Windows.Forms.TabPage
    Friend WithEvents del_stock As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_stock As FontAwesome.Sharp.IconButton
    Friend WithEvents add_stock As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TextBox5 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TextBox4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TextBox3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GunaTextBox6 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox5 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Model As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaTextBox7 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaComboBox3 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaComboBox2 As Guna.UI.WinForms.GunaComboBox


    Friend WithEvents StorageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FrontDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImgDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPhoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents OneplusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OneplusBindingSource1 As System.Windows.Forms.BindingSource

    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox3 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents ComboBox2 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents ComboBox1 As Guna.UI.WinForms.GunaComboBox

    Friend WithEvents OneplusBindingSource2 As System.Windows.Forms.BindingSource

    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test As Global.Dashboard.test
    Friend WithEvents OneplusBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents OneplusTableAdapter As Database2DataSetTableAdapters.OneplusTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn


End Class
