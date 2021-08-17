<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashDis
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
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashDis))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(520, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 72)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Contact Us"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(263, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(839, 36)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Need some help? Ask a question to quickly get your answers."
        '
        'GunaTransition1
        '
        Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.GunaTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
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
        Me.GunaTransition1.DefaultAnimation = Animation1
        '
        'PictureBox5
        '
        Me.GunaTransition1.SetDecoration(Me.PictureBox5, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox5.Image = Global.Dashboard.My.Resources.Resources.imageedit_14_2325873602
        Me.PictureBox5.Location = New System.Drawing.Point(1066, 615)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(456, 324)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.GunaTransition1.SetDecoration(Me.PictureBox4, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox4.Image = Global.Dashboard.My.Resources.Resources.whatsappBackcolor
        Me.PictureBox4.Location = New System.Drawing.Point(1066, 264)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(274, 306)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.GunaTransition1.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox3.Image = Global.Dashboard.My.Resources.Resources.emailbackcolor_png
        Me.PictureBox3.Location = New System.Drawing.Point(718, 263)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(259, 306)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.GunaTransition1.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox2.Image = Global.Dashboard.My.Resources.Resources.chatbackcolor
        Me.PictureBox2.Location = New System.Drawing.Point(369, 263)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(255, 306)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.GunaTransition1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = Global.Dashboard.My.Resources.Resources.callus
        Me.PictureBox1.Location = New System.Drawing.Point(23, 263)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 306)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DashDis
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 814)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.Name = "DashDis"
        Me.Text = "DashDis"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
End Class
