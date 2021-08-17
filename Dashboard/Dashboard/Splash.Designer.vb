<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = True
        Me.BunifuCircleProgressbar1.animationIterval = 10
        Me.BunifuCircleProgressbar1.animationSpeed = 300
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineProgressThickness = 8
        Me.BunifuCircleProgressbar1.LineThickness = 5
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(59, 111)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Black
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(288, 288)
        Me.BunifuCircleProgressbar1.TabIndex = 0
        Me.BunifuCircleProgressbar1.Value = 0
        '
        'Timer1
        '
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(107, 180)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(194, 156)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox1.TabIndex = 1
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(410, 520)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
End Class
