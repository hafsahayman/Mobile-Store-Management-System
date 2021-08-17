Public Class DashDis

    Private Sub DashDis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Dim image1 As Bitmap = My.Resources.callwhite
        PictureBox1.Image = image1

    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Dim image0 As Bitmap = My.Resources.callus 'change
        PictureBox1.Image = image0
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        Dim image2 As Bitmap = My.Resources.chatwhite
        PictureBox2.Image = image2
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Dim image3 As Bitmap = My.Resources.chatbackcolor
        PictureBox2.Image = image3
    End Sub



    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        Dim image4 As Bitmap = My.Resources.emailwhite
        PictureBox3.Image = image4
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        Dim image5 As Bitmap = My.Resources.emailbackcolor_png 'change
        PictureBox3.Image = image5
    End Sub


    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        Dim image6 As Bitmap = My.Resources.whatsappwhite
        PictureBox4.Image = image6
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        Dim image7 As Bitmap = My.Resources.whatsappBackcolor
        PictureBox4.Image = image7
    End Sub
End Class