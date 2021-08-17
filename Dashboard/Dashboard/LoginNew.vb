Imports System.Data.SqlClient
    Public Class Login2
    Dim InsideName As Object
    Dim InsideName1 As Object
    Dim getmob As String
    Dim com As SqlCommand
        Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
            Me.Close()
        End Sub

        Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing
        InsideName = DashBoard.Label1

        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from Signup where Username ='" & BunifuMaterialTextbox1.Text & "' AND Password ='" & BunifuMaterialTextbox2.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            'Dim reader As SqlDataReader = objcmd.ExecuteReader
            'sda.Fill(dt)
            'If reader.Read Then
            '    If (dt.Rows.Count > 0) Then

            '        MessageBox.Show(("you are logged in as " + dt.Rows(0)(8)))
            '    Else

            '        MessageBox.Show("Error")

            '    End If
            '    MessageBox.Show("Login Succesful")
            'Else
            '    MessageBox.Show("Invalid Login Please Check!")
            'End If
            Dim sda As SqlDataAdapter = New SqlDataAdapter(objcmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then

                'MessageBox.Show(("you are login as " + dt.Rows(0)(8)))
                If dt.Rows(0)(8).ToString = "Admin" Then
                    DashBoard.Show()
                End If
                If dt.Rows(0)(8).ToString = "Staff" Then
                    DashBoard.Show()
                    DashBoard.IconButton3.Hide()
                    DashBoard.IconButton4.Hide()
                    DashBoard.IconButton2.Location = New Point(-4, 292)
                    DashBoard.IconButton5.Location = New Point(0, 377)
                    DashBoard.IconButton6.Location = New Point(-4, 460)

                End If
            Else
                MessageBox.Show("Invalid Credentials")
            End If
            getmob = "select *from Signup where Username='" & BunifuMaterialTextbox1.Text & "'"
            com = New SqlCommand(getmob, objcon)
            dr = com.ExecuteReader()
            If dr.Read() Then
                InsideName.Text = dr.GetValue(1).ToString()
                InsideName.show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged
        BunifuMaterialTextbox2.isPassword = True
    End Sub

    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress
       
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        Resgister.Show()
        Me.Hide()
    End Sub

    Private Sub Login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaGoogleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaGoogleSwitch1.CheckedChanged
        If GunaGoogleSwitch1.Checked = True Then
            BunifuMaterialTextbox2.isPassword = False
        Else
            BunifuMaterialTextbox2.isPassword = True
        End If
    End Sub
End Class