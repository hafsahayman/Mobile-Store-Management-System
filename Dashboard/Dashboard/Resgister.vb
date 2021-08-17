Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class Resgister
    Dim Usertype As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Signup where Username='" & BunifuMetroTextbox3.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Email Id Already Registered", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()
            If (BunifuMetroTextbox1.Text = "" Or BunifuMetroTextbox2.Text = "" Or ComboBox1.SelectedItem = "" Or BunifuMetroTextbox5.Text = "" Or BunifuMetroTextbox3.Text = "" Or BunifuMetroTextbox4.Text = "" Or BunifuMetroTextbox5.Text.Length < 10 Or (GunaRadioButton1.Checked = False And GunaRadioButton2.Checked = False)) Then
                MessageBox.Show("Please Enter the Details")
            Else
                If Not (BunifuMetroTextbox4.Text = BunifuMetroTextbox6.Text) Then
                    MessageBox.Show("Inavlid password")

                Else
                    cmd.CommandText = "Insert into Signup ( First_Name,Last_Name,Gender,Phone_Number,Username,Password,Confirm_Password,Usertype) VALUES (@First_Name,@Last_Name,@Gender,@Phone_Number,@Username,@Password,@Confirm_Password,@Usertype)"
                    cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = BunifuMetroTextbox1.Text
                    cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = BunifuMetroTextbox2.Text
                    cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = ComboBox1.SelectedItem
                    cmd.Parameters.Add("@Phone_Number", SqlDbType.VarChar).Value = BunifuMetroTextbox5.Text
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = BunifuMetroTextbox3.Text
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = BunifuMetroTextbox4.Text
                    cmd.Parameters.Add("@Confirm_Password", SqlDbType.VarChar).Value = BunifuMetroTextbox6.Text
                    cmd.Parameters.AddWithValue("@Usertype", Usertype)
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                End If
            End If
            con.Close()
        End If
    End Sub

    Private Sub ComboBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ComboBox1.DrawItem

        Dim itemBackColorDefault As Brush, itemForeColorDefault As Brush
        Dim itemBackColorSelected As Brush, itemForeColorSelected As Brush

        itemBackColorDefault = New Drawing.SolidBrush(Color.FromArgb(30, 31, 39))
        itemForeColorDefault = New Drawing.SolidBrush(Color.FromArgb(3, 198, 181))
        itemBackColorSelected = New Drawing.SolidBrush(Color.FromArgb(3, 198, 181))
        itemForeColorSelected = New Drawing.SolidBrush(Color.FromArgb(30, 31, 39))


        If e.Index < 0 Then Exit Sub

        Dim rct As Rectangle = e.Bounds
        Dim itemText As String = ComboBox1.Items(e.Index)

        If e.State And DrawItemState.Selected Then

            'Selected BackColor
            e.Graphics.FillRectangle(itemBackColorSelected, rct)

            'Selected ForeColor
            e.Graphics.DrawString(itemText, Me.ComboBox1.Font, itemForeColorSelected, rct.X, rct.Y)

        Else

            'Default BackColor
            e.Graphics.FillRectangle(itemBackColorDefault, rct)

            'Default ForeColor
            e.Graphics.DrawString(itemText, Me.ComboBox1.Font, itemForeColorDefault, rct.X, rct.Y)

        End If

    End Sub

    Private Sub ComboBox1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
        ControlPaint.DrawBorder(e.Graphics, Me.ComboBox1.ClientRectangle, Color.LightCyan, ButtonBorderStyle.Solid)
    End Sub






    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Login2.Show()
        Me.Close()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Resgister_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub BunifuMetroTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox5.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
        If BunifuMetroTextbox5.Text.Length = 10 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox5_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox5.OnValueChanged
        If BunifuMetroTextbox5.Text.Length <= 10 Then
            BunifuMetroTextbox3.BorderColorFocused = Color.Red
        End If
    End Sub

    Private Sub BunifuMetroTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox3.OnValueChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Signup where Username='" & BunifuMetroTextbox3.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            BunifuMetroTextbox3.BorderColorFocused = Color.Red
        Else
            BunifuMetroTextbox3.BorderColorFocused = Color.FromArgb(3, 198, 181)
        End If


    End Sub

    Private Sub GunaGoogleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaGoogleSwitch1.CheckedChanged
        If GunaGoogleSwitch1.Checked = True Then
            BunifuMetroTextbox4.isPassword = False
            BunifuMetroTextbox6.isPassword = False
        Else
            BunifuMetroTextbox4.isPassword = True
            BunifuMetroTextbox6.isPassword = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged
        BunifuMetroTextbox4.isPassword = True
    End Sub

    Private Sub BunifuMetroTextbox6_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox6.OnValueChanged
        BunifuMetroTextbox6.isPassword = True
    End Sub

    Private Sub GunaRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton1.CheckedChanged
        Usertype = "Admin"
    End Sub

    Private Sub GunaRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton2.CheckedChanged
        Usertype = "Staff"
    End Sub
End Class

