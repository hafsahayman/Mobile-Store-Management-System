<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Outlet
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaLabel24 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel23 = New Guna.UI.WinForms.GunaLabel()
        Me.Number = New Guna.UI.WinForms.GunaTextBox()
        Me.Pincode = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel21 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.City = New Guna.UI.WinForms.GunaTextBox()
        Me.Locality = New Guna.UI.WinForms.GunaTextBox()
        Me.Name = New Guna.UI.WinForms.GunaTextBox()
        Me.State = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OutetDataSet = New Global.Dashboard.OutetDataSet()
        Me.OutletTableAdapter = New Global.Dashboard.OutetDataSetTableAdapters.OutletTableAdapter()
        Me.reg = New Guna.UI.WinForms.GunaLabel()
        Me.update = New Guna.UI.WinForms.GunaButton()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.Chumma = New Guna.UI.WinForms.GunaLabel()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel24
        '
        Me.GunaLabel24.AutoSize = True
        Me.GunaLabel24.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel24.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel24.Location = New System.Drawing.Point(153, 532)
        Me.GunaLabel24.Name = "GunaLabel24"
        Me.GunaLabel24.Size = New System.Drawing.Size(152, 28)
        Me.GunaLabel24.TabIndex = 21
        Me.GunaLabel24.Text = "Phone Number"
        '
        'GunaLabel23
        '
        Me.GunaLabel23.AutoSize = True
        Me.GunaLabel23.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel23.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel23.Location = New System.Drawing.Point(192, 454)
        Me.GunaLabel23.Name = "GunaLabel23"
        Me.GunaLabel23.Size = New System.Drawing.Size(85, 28)
        Me.GunaLabel23.TabIndex = 20
        Me.GunaLabel23.Text = "Pincode"
        '
        'Number
        '
        Me.Number.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Number.BorderColor = System.Drawing.Color.Silver
        Me.Number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Number.FocusedBaseColor = System.Drawing.Color.White
        Me.Number.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Number.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Number.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Number.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Number.Location = New System.Drawing.Point(330, 532)
        Me.Number.Name = "Number"
        Me.Number.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Number.SelectedText = ""
        Me.Number.Size = New System.Drawing.Size(220, 32)
        Me.Number.TabIndex = 19
        '
        'Pincode
        '
        Me.Pincode.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Pincode.BorderColor = System.Drawing.Color.Silver
        Me.Pincode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Pincode.FocusedBaseColor = System.Drawing.Color.White
        Me.Pincode.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Pincode.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Pincode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Pincode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Pincode.Location = New System.Drawing.Point(330, 454)
        Me.Pincode.Name = "Pincode"
        Me.Pincode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Pincode.SelectedText = ""
        Me.Pincode.Size = New System.Drawing.Size(220, 32)
        Me.Pincode.TabIndex = 18
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel20.Location = New System.Drawing.Point(200, 298)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(46, 28)
        Me.GunaLabel20.TabIndex = 17
        Me.GunaLabel20.Text = "City"
        '
        'GunaLabel21
        '
        Me.GunaLabel21.AutoSize = True
        Me.GunaLabel21.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel21.Location = New System.Drawing.Point(192, 218)
        Me.GunaLabel21.Name = "GunaLabel21"
        Me.GunaLabel21.Size = New System.Drawing.Size(80, 28)
        Me.GunaLabel21.TabIndex = 16
        Me.GunaLabel21.Text = "Locality"
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel22.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel22.Location = New System.Drawing.Point(153, 142)
        Me.GunaLabel22.Name = "GunaLabel22"
        Me.GunaLabel22.Size = New System.Drawing.Size(129, 28)
        Me.GunaLabel22.TabIndex = 15
        Me.GunaLabel22.Text = "Outlet Name"
        '
        'City
        '
        Me.City.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.City.BorderColor = System.Drawing.Color.Silver
        Me.City.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.City.FocusedBaseColor = System.Drawing.Color.White
        Me.City.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.City.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.City.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.City.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.City.Location = New System.Drawing.Point(328, 298)
        Me.City.Name = "City"
        Me.City.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.City.SelectedText = ""
        Me.City.Size = New System.Drawing.Size(220, 32)
        Me.City.TabIndex = 14
        '
        'Locality
        '
        Me.Locality.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Locality.BorderColor = System.Drawing.Color.Silver
        Me.Locality.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Locality.FocusedBaseColor = System.Drawing.Color.White
        Me.Locality.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Locality.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Locality.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Locality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Locality.Location = New System.Drawing.Point(328, 218)
        Me.Locality.Name = "Locality"
        Me.Locality.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Locality.SelectedText = ""
        Me.Locality.Size = New System.Drawing.Size(220, 32)
        Me.Locality.TabIndex = 13
        '
        'Name
        '
        Me.Name.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Name.BorderColor = System.Drawing.Color.Silver
        Me.Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Name.FocusedBaseColor = System.Drawing.Color.White
        Me.Name.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Name.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Name.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Name.Location = New System.Drawing.Point(330, 142)
        Me.Name.Name = "Name"
        Me.Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Name.SelectedText = ""
        Me.Name.Size = New System.Drawing.Size(220, 32)
        Me.Name.TabIndex = 12
        '
        'State
        '
        Me.State.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.State.BorderColor = System.Drawing.Color.Silver
        Me.State.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.State.FocusedBaseColor = System.Drawing.Color.White
        Me.State.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.State.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.State.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.State.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.State.Location = New System.Drawing.Point(328, 369)
        Me.State.Name = "State"
        Me.State.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.State.SelectedText = ""
        Me.State.Size = New System.Drawing.Size(220, 32)
        Me.State.TabIndex = 22
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(201, 369)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(57, 28)
        Me.GunaLabel1.TabIndex = 23
        Me.GunaLabel1.Text = "State"
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.GunaDataGridView1.AutoGenerateColumns = False
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.GunaDataGridView1.ColumnHeadersHeight = 30
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.GunaDataGridView1.DataSource = Me.OutletBindingSource
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle15
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(625, 142)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowTemplate.Height = 24
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(719, 422)
        Me.GunaDataGridView1.TabIndex = 26
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
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 30
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Locality"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Locality"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "city"
        Me.DataGridViewTextBoxColumn3.HeaderText = "City"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pincode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Pincode"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "state"
        Me.DataGridViewTextBoxColumn5.HeaderText = "State"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pno"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Number"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'OutletBindingSource
        '
        Me.OutletBindingSource.DataMember = "Outlet"
        Me.OutletBindingSource.DataSource = Me.OutetDataSet
        '
        'OutetDataSet
        '
        Me.OutetDataSet.DataSetName = "OutetDataSet"
        Me.OutetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OutletTableAdapter
        '
        Me.OutletTableAdapter.ClearBeforeFill = True
        '
        'reg
        '
        Me.reg.AutoSize = True
        Me.reg.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.reg.Location = New System.Drawing.Point(454, 48)
        Me.reg.Name = "reg"
        Me.reg.Size = New System.Drawing.Size(408, 41)
        Me.reg.TabIndex = 28
        Me.reg.Text = "You Have Already Registerd"
        '
        'update
        '
        Me.update.AnimationHoverSpeed = 0.07!
        Me.update.AnimationSpeed = 0.03!
        Me.update.BackColor = System.Drawing.Color.Transparent
        Me.update.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.update.BorderColor = System.Drawing.Color.Black
        Me.update.DialogResult = System.Windows.Forms.DialogResult.None
        Me.update.FocusedColor = System.Drawing.Color.Empty
        Me.update.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.update.Image = Global.Dashboard.My.Resources.Resources.Daco_438112
        Me.update.ImageSize = New System.Drawing.Size(20, 20)
        Me.update.Location = New System.Drawing.Point(575, 643)
        Me.update.Name = "update"
        Me.update.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.update.OnHoverBorderColor = System.Drawing.Color.Black
        Me.update.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.update.OnHoverImage = Nothing
        Me.update.OnPressedColor = System.Drawing.Color.Black
        Me.update.Radius = 15
        Me.update.Size = New System.Drawing.Size(164, 51)
        Me.update.TabIndex = 27
        Me.update.Text = "UPDATE"
        '
        'Button1
        '
        Me.Button1.AnimationHoverSpeed = 0.07!
        Me.Button1.AnimationSpeed = 0.03!
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Button1.BorderColor = System.Drawing.Color.Black
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button1.FocusedColor = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button1.Image = Global.Dashboard.My.Resources.Resources.Daco_438112
        Me.Button1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button1.Location = New System.Drawing.Point(361, 643)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 15
        Me.Button1.Size = New System.Drawing.Size(164, 51)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "REGISTER"
        '
        'Chumma
        '
        Me.Chumma.AutoSize = True
        Me.Chumma.BackColor = System.Drawing.Color.Transparent
        Me.Chumma.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chumma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Chumma.Location = New System.Drawing.Point(12, 812)
        Me.Chumma.Name = "Chumma"
        Me.Chumma.Size = New System.Drawing.Size(0, 28)
        Me.Chumma.TabIndex = 29
        '
        'Outlet
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1373, 859)
        Me.Controls.Add(Me.Chumma)
        Me.Controls.Add(Me.reg)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.GunaLabel24)
        Me.Controls.Add(Me.GunaLabel23)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.Pincode)
        Me.Controls.Add(Me.GunaLabel20)
        Me.Controls.Add(Me.GunaLabel21)
        Me.Controls.Add(Me.GunaLabel22)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.Locality)
        Me.Controls.Add(Me.Name)
        'Me.Name = "Outlet"
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel24 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel23 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Number As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Pincode As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel21 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents City As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Locality As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Name As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents State As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OutetDataSet As Global.Dashboard.OutetDataSet
    Friend WithEvents OutletBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OutletTableAdapter As Global.Dashboard.OutetDataSetTableAdapters.OutletTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents update As Guna.UI.WinForms.GunaButton
    Friend WithEvents reg As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Chumma As Guna.UI.WinForms.GunaLabel
End Class
