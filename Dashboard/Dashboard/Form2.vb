Imports System.Data.SqlClient
Public Class Form2

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged
        If GunaGoogleSwitch1.Checked = True Then
            BunifuMaterialTextbox2.isPassword = False
        Else
            BunifuMaterialTextbox2.isPassword = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Resgister.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing
        

        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from Signup where Username ='" & BunifuMaterialTextbox1.Text & "' AND Password ='" & BunifuMaterialTextbox2.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                Me.Hide()
            Else
                MessageBox.Show("Invalid Login Please Check!")
            End If
        Catch ex As Exception
            MessageBox.Show("Exception")
        End Try
    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs)

    End Sub
End Class