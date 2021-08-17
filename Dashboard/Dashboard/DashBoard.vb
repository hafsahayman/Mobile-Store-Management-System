Imports FontAwesome.Sharp

Public Class DashBoard
    Inherits System.Windows.Forms.Form

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 87)
        PanelMenu.Controls.Add(leftBorderBtn)
        'form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea





    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(30, 31, 39)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()


        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(30, 31, 39)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        childForm.Size = New Size(1373, 860)

    End Sub



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New DashIn)
    End Sub



    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, RGBColors.color1)

        OpenChildForm(New Purchase)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Stocks)

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Outlet)

  
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Report)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()

    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
    End Sub



    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        End
    End Sub


    Private Sub maxbtn_Click(sender As Object, e As EventArgs) Handles maxbtn.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized


        Else
            WindowState = FormWindowState.Normal

        End If

    End Sub

    Private Sub minbtn_Click(sender As Object, e As EventArgs) Handles minbtn.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelDesktop_Paint(sender As Object, e As PaintEventArgs) Handles PanelDesktop.Paint

    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New DashDis)
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click

        Login2.Show()
        Me.Close()
        Login2.BunifuMaterialTextbox1.Text = ""
        Login2.BunifuMaterialTextbox2.Text = ""
    End Sub
End Class



