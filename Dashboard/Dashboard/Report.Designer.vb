<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BunifuPages1 = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Button2 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Transaction = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sid = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sales2DataSet1 = New Global.Dashboard.Sales2DataSet1()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.TextBox5 = New Guna.UI.WinForms.GunaTextBox()
        Me.TextBox4 = New Guna.UI.WinForms.GunaTextBox()
        Me.TextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.TextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.TextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.Analysis = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.brand2 = New Guna.UI.WinForms.GunaComboBox()
        Me.brand1 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.PurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurDataSet1 = New Global.Dashboard.PurDataSet1()
        Me.Purchase3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseDataSet1 = New Global.Dashboard.PurchaseDataSet1()
        Me.Purchase3TableAdapter = New Global.Dashboard.PurchaseDataSet1TableAdapters.purchase3TableAdapter()
        Me.PurchaseTableAdapter = New Global.Dashboard.PurDataSet1TableAdapters.PurchaseTableAdapter()
        Me.SalesTableAdapter = New Global.Dashboard.Sales2DataSet1TableAdapters.SalesTableAdapter()
        Me.BunifuPages1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Transaction.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sales2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Analysis.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purchase3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuPages1
        '
        Me.BunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPages1.AllowTransitions = True
        Me.BunifuPages1.Controls.Add(Me.TabPage1)
        Me.BunifuPages1.Controls.Add(Me.Transaction)
        Me.BunifuPages1.Controls.Add(Me.Analysis)
        Me.BunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuPages1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuPages1.Multiline = True
        Me.BunifuPages1.Name = "BunifuPages1"
        Me.BunifuPages1.Page = Me.Transaction
        Me.BunifuPages1.PageIndex = 1
        Me.BunifuPages1.PageName = "Transaction"
        Me.BunifuPages1.PageTitle = "TabPage2"
        Me.BunifuPages1.SelectedIndex = 0
        Me.BunifuPages1.Size = New System.Drawing.Size(1352, 814)
        Me.BunifuPages1.TabIndex = 0
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
        Me.BunifuPages1.Transition = Animation1
        Me.BunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1344, 785)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Button1
        '
        Me.Button1.AnimationHoverSpeed = 0.07!
        Me.Button1.AnimationSpeed = 0.03!
        Me.Button1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Button1.BorderColor = System.Drawing.Color.Black
        Me.Button1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Button1.CheckedBorderColor = System.Drawing.Color.Black
        Me.Button1.CheckedForeColor = System.Drawing.Color.White
        Me.Button1.CheckedImage = CType(resources.GetObject("Button1.CheckedImage"), System.Drawing.Image)
        Me.Button1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button1.FocusedColor = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageSize = New System.Drawing.Size(52, 52)
        Me.Button1.LineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(444, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnHoverLineColor = System.Drawing.Color.White
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Size = New System.Drawing.Size(202, 216)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "TRANSACTIONS"
        '
        'Button2
        '
        Me.Button2.AnimationHoverSpeed = 0.07!
        Me.Button2.AnimationSpeed = 0.03!
        Me.Button2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Button2.BorderColor = System.Drawing.Color.Black
        Me.Button2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Button2.CheckedBorderColor = System.Drawing.Color.Black
        Me.Button2.CheckedForeColor = System.Drawing.Color.White
        Me.Button2.CheckedImage = CType(resources.GetObject("Button2.CheckedImage"), System.Drawing.Image)
        Me.Button2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button2.FocusedColor = System.Drawing.Color.Empty
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageSize = New System.Drawing.Size(52, 52)
        Me.Button2.LineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(712, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Button2.OnHoverImage = Nothing
        Me.Button2.OnHoverLineColor = System.Drawing.Color.White
        Me.Button2.OnPressedColor = System.Drawing.Color.Black
        Me.Button2.Size = New System.Drawing.Size(196, 216)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "ANALYSIS"
        '
        'Transaction
        '
        Me.Transaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Transaction.Controls.Add(Me.Label1)
        Me.Transaction.Controls.Add(Me.Sid)
        Me.Transaction.Controls.Add(Me.GunaLabel8)
        Me.Transaction.Controls.Add(Me.GunaLabel7)
        Me.Transaction.Controls.Add(Me.GunaLabel6)
        Me.Transaction.Controls.Add(Me.GunaLabel5)
        Me.Transaction.Controls.Add(Me.GunaLabel4)
        Me.Transaction.Controls.Add(Me.GunaLabel3)
        Me.Transaction.Controls.Add(Me.GunaLabel2)
        Me.Transaction.Controls.Add(Me.GunaLabel1)
        Me.Transaction.Controls.Add(Me.GunaDataGridView1)
        Me.Transaction.Controls.Add(Me.GunaButton2)
        Me.Transaction.Controls.Add(Me.TextBox5)
        Me.Transaction.Controls.Add(Me.TextBox4)
        Me.Transaction.Controls.Add(Me.TextBox3)
        Me.Transaction.Controls.Add(Me.TextBox2)
        Me.Transaction.Controls.Add(Me.TextBox1)
        Me.Transaction.Location = New System.Drawing.Point(4, 4)
        Me.Transaction.Name = "Transaction"
        Me.Transaction.Padding = New System.Windows.Forms.Padding(3)
        Me.Transaction.Size = New System.Drawing.Size(1344, 785)
        Me.Transaction.TabIndex = 1
        Me.Transaction.Text = "TabPage2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(203, 719)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 16
        '
        'Sid
        '
        Me.Sid.AutoSize = True
        Me.Sid.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Sid.Location = New System.Drawing.Point(203, 660)
        Me.Sid.Name = "Sid"
        Me.Sid.Size = New System.Drawing.Size(0, 25)
        Me.Sid.TabIndex = 15
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(40, 719)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(127, 25)
        Me.GunaLabel8.TabIndex = 14
        Me.GunaLabel8.Text = "Staff Name :-"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(40, 660)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(95, 25)
        Me.GunaLabel7.TabIndex = 13
        Me.GunaLabel7.Text = "Staff ID :-"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(33, 79)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(150, 25)
        Me.GunaLabel6.TabIndex = 12
        Me.GunaLabel6.Text = "Invoice Number"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("LEMON MILK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(73, 162)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(321, 29)
        Me.GunaLabel5.TabIndex = 11
        Me.GunaLabel5.Text = "------Customer Details------"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(33, 575)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(142, 25)
        Me.GunaLabel4.TabIndex = 10
        Me.GunaLabel4.Text = "Payment Mode"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(36, 475)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(147, 25)
        Me.GunaLabel3.TabIndex = 9
        Me.GunaLabel3.Text = "Customer Email"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(33, 372)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(171, 25)
        Me.GunaLabel2.TabIndex = 8
        Me.GunaLabel2.Text = "Customer Number"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(40, 267)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(152, 25)
        Me.GunaLabel1.TabIndex = 7
        Me.GunaLabel1.Text = "Customer Name"
        '
        'GunaDataGridView1
        '
        Me.GunaDataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoGenerateColumns = False
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
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
        Me.GunaDataGridView1.ColumnHeadersHeight = 27
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.PdateDataGridViewTextBoxColumn})
        Me.GunaDataGridView1.DataSource = Me.SalesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(458, 147)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidth = 50
        Me.GunaDataGridView1.RowTemplate.Height = 24
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(859, 606)
        Me.GunaDataGridView1.TabIndex = 6
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 27
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price "
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price "
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'PdateDataGridViewTextBoxColumn
        '
        Me.PdateDataGridViewTextBoxColumn.DataPropertyName = "P_date"
        Me.PdateDataGridViewTextBoxColumn.HeaderText = "P_date"
        Me.PdateDataGridViewTextBoxColumn.Name = "PdateDataGridViewTextBoxColumn"
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.Sales2DataSet1
        '
        'Sales2DataSet1
        '
        Me.Sales2DataSet1.DataSetName = "Sales2DataSet1"
        Me.Sales2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.Black
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(35, 35)
        Me.GunaButton2.Location = New System.Drawing.Point(458, 73)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton2.TabIndex = 5
        Me.GunaButton2.Text = "CHECK"
        '
        'TextBox5
        '
        Me.TextBox5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox5.BorderColor = System.Drawing.Color.Silver
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox5.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(208, 575)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox5.SelectedText = ""
        Me.TextBox5.Size = New System.Drawing.Size(160, 32)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox4.BorderColor = System.Drawing.Color.Silver
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox4.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(208, 475)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox4.SelectedText = ""
        Me.TextBox4.Size = New System.Drawing.Size(160, 32)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox3.BorderColor = System.Drawing.Color.Silver
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(208, 368)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox3.SelectedText = ""
        Me.TextBox3.Size = New System.Drawing.Size(160, 32)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox2.BorderColor = System.Drawing.Color.Silver
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(208, 267)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.Size = New System.Drawing.Size(160, 32)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox1.BorderColor = System.Drawing.Color.Silver
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(208, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(160, 32)
        Me.TextBox1.TabIndex = 0
        '
        'Analysis
        '
        Me.Analysis.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Analysis.Controls.Add(Me.Chart1)
        Me.Analysis.Controls.Add(Me.brand2)
        Me.Analysis.Controls.Add(Me.brand1)
        Me.Analysis.Controls.Add(Me.GunaButton1)
        Me.Analysis.Location = New System.Drawing.Point(4, 4)
        Me.Analysis.Name = "Analysis"
        Me.Analysis.Padding = New System.Windows.Forms.Padding(3)
        Me.Analysis.Size = New System.Drawing.Size(1344, 785)
        Me.Analysis.TabIndex = 2
        Me.Analysis.Text = "TabPage3"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        ChartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        ChartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        ChartArea1.AxisX2.Interval = 1.0R
        ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        ChartArea1.AxisY.Interval = 1.0R
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        ChartArea1.AxisY2.Interval = 1.0R
        ChartArea1.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Legend1.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(158, 145)
        Me.Chart1.Name = "Chart1"
        Series1.BorderColor = System.Drawing.Color.Transparent
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Series1.CustomProperties = "DrawingStyle=Emboss"
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Series1.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1083, 605)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
        '
        'brand2
        '
        Me.brand2.BackColor = System.Drawing.Color.Transparent
        Me.brand2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.brand2.BorderColor = System.Drawing.Color.Silver
        Me.brand2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.brand2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.brand2.FocusedColor = System.Drawing.Color.Empty
        Me.brand2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.brand2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.brand2.FormattingEnabled = True
        Me.brand2.ItemHeight = 30
        Me.brand2.Items.AddRange(New Object() {"iPhone", "Samsung", "Oneplus", "Mi"})
        Me.brand2.Location = New System.Drawing.Point(931, 88)
        Me.brand2.Name = "brand2"
        Me.brand2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.brand2.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.brand2.Size = New System.Drawing.Size(179, 36)
        Me.brand2.TabIndex = 1
        '
        'brand1
        '
        Me.brand1.BackColor = System.Drawing.Color.Transparent
        Me.brand1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.brand1.BorderColor = System.Drawing.Color.Silver
        Me.brand1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.brand1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.brand1.FocusedColor = System.Drawing.Color.Empty
        Me.brand1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.brand1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.brand1.FormattingEnabled = True
        Me.brand1.ItemHeight = 30
        Me.brand1.Items.AddRange(New Object() {"iPhone", "Samsung", "Oneplus", "Mi"})
        Me.brand1.Location = New System.Drawing.Point(267, 84)
        Me.brand1.Name = "brand1"
        Me.brand1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.brand1.OnHoverItemForeColor = System.Drawing.Color.Black
        Me.brand1.Size = New System.Drawing.Size(179, 36)
        Me.brand1.TabIndex = 0
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaButton1.Image = Global.Dashboard.My.Resources.Resources.clipart1900963
        Me.GunaButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton1.Location = New System.Drawing.Point(578, 82)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(208, 42)
        Me.GunaButton1.TabIndex = 2
        Me.GunaButton1.Text = "COMPARE"
        '
        'PurchaseBindingSource
        '
        Me.PurchaseBindingSource.DataMember = "Purchase"
        Me.PurchaseBindingSource.DataSource = Me.PurDataSet1
        '
        'PurDataSet1
        '
        Me.PurDataSet1.DataSetName = "PurDataSet1"
        Me.PurDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Purchase3BindingSource
        '
        Me.Purchase3BindingSource.DataMember = "purchase3"
        Me.Purchase3BindingSource.DataSource = Me.PurchaseDataSet1
        '
        'PurchaseDataSet1
        '
        Me.PurchaseDataSet1.DataSetName = "PurchaseDataSet1"
        Me.PurchaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Purchase3TableAdapter
        '
        Me.Purchase3TableAdapter.ClearBeforeFill = True
        '
        'PurchaseTableAdapter
        '
        Me.PurchaseTableAdapter.ClearBeforeFill = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1352, 814)
        Me.Controls.Add(Me.BunifuPages1)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.BunifuPages1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Transaction.ResumeLayout(False)
        Me.Transaction.PerformLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sales2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Analysis.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purchase3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuPages1 As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Transaction As System.Windows.Forms.TabPage
    Friend WithEvents Analysis As System.Windows.Forms.TabPage
    Friend WithEvents brand1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents brand2 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents TextBox5 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TextBox4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TextBox3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PurchaseDataSet1 As Global.Dashboard.PurchaseDataSet1
    Friend WithEvents Purchase3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Purchase3TableAdapter As Global.Dashboard.PurchaseDataSet1TableAdapters.purchase3TableAdapter
    Friend WithEvents BrandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents Button2 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents PurDataSet1 As Global.Dashboard.PurDataSet1
    Friend WithEvents PurchaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseTableAdapter As Global.Dashboard.PurDataSet1TableAdapters.PurchaseTableAdapter
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Sales2DataSet1 As Global.Dashboard.Sales2DataSet1
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As Global.Dashboard.Sales2DataSet1TableAdapters.SalesTableAdapter
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Sid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
