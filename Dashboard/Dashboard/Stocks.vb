Imports System.Data.SqlClient
Imports System.IO
Imports FontAwesome.Sharp
Public Class Stocks
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim cmd As SqlCommand
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim Mi As Object
    Dim Oneplus As Object
    Dim Samsung As Object
    Dim iPhone As Object
    Dim reg As String
    'Button
    Private currentBtn As New IconButton
    Private labelbtn As New Label



    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test.Oneplus' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Test.Oneplus' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'OP.Oneplus' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'OP.Oneplus' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Database2DataSet.iPhone' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Database2DataSet.iPhone' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'StkDataSet.Mi' table. You can move, or remove it, as needed.
        GunaDataGridView1.RowTemplate.Height = 120


    End Sub


    Private Sub ActivateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.IconColor = Color.FromArgb(249, 118, 176)
            currentBtn.ImageAlign = ContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.IconColor = Color.FromArgb(3, 198, 181)
            currentBtn.ImageAlign = ContentAlignment.MiddleCenter


        End If
    End Sub


    Private Sub add_stock_Click_1(sender As Object, e As EventArgs) Handles add_stock.Click
        stock_tab.SetPage(add)
        BunifuCustomLabel1.Text = "ADD STOCKS"
        ActivateButton(sender, RGBColors.color2)
    End Sub

    Private Sub edit_stock_Click_1(sender As Object, e As EventArgs) Handles edit_stock.Click
        stock_tab.SetPage(edit)
        BunifuCustomLabel1.Text = "EDIT STOCKS"
        ActivateButton(sender, RGBColors.color2)
    End Sub

    Private Sub del_stock_Click_1(sender As Object, e As EventArgs) Handles del_stock.Click
        stock_tab.SetPage(del)
        BunifuCustomLabel1.Text = "DELETE STOCKS"
        ActivateButton(sender, RGBColors.color2)
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
      
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        OpenFileDialog1.Filter = "images| *.jpg;*.png;*.bmp;*.jpeg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
        Dim command As New SqlCommand("insert into Mobile(Brand,Model,Storage,Ram,Back,Front,Quantity,img,Price,RegId) values(@Brand,@Model,@Storage,@Ram,@Back,@Front,@Quantity,@img,@Price,@RegId)", con)
        con.Open()
        Dim cmd As String = "select RegId from Signup where Username ='" & Login2.BunifuMaterialTextbox1.Text & "' AND Password ='" & Login2.BunifuMaterialTextbox2.Text & "' "
        com = New SqlCommand(cmd, con)
        dr = com.ExecuteReader()
        If dr.Read() Then
            reg = dr.GetValue(0).ToString()
        End If
        con.Close()
        Dim ms As New MemoryStream()
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        command.Parameters.Add("@Brand", SqlDbType.VarChar).Value = ComboBox1.Text
        command.Parameters.Add("@Model", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@Storage", SqlDbType.VarChar).Value = ComboBox2.Text
        command.Parameters.Add("@Ram", SqlDbType.VarChar).Value = ComboBox3.Text
        command.Parameters.Add("@Back", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@Front", SqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@Quantity", SqlDbType.Int).Value = TextBox5.Text
        command.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
        command.Parameters.Add("@Price", SqlDbType.Money).Value = TextBox4.Text
        command.Parameters.AddWithValue("@RegId", reg)
        If (ComboBox1.SelectedItem = "" Or TextBox1.Text = "" Or ComboBox2.SelectedItem = "" Or ComboBox3.SelectedItem = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox4.Text = "") Then
            MessageBox.Show("Please Enter The Details")
        Else
            con.Open()
            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Added")

            Else

                MessageBox.Show("Added")

            End If
            con.Close()
        End If
    End Sub


    Private Sub ComboBox1_DrawItem(sender As Object, e As DrawItemEventArgs)

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

    Private Sub ComboBox2_DrawItem(sender As Object, e As DrawItemEventArgs)

    End Sub

    Private Sub ComboBox3_DrawItem(sender As Object, e As DrawItemEventArgs)


    End Sub


    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click

    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        Model.Items.Clear()
        Dim cmd2 As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        cmd2.CommandText = " "
        con.Open()
        cmd2.Connection = con
        If GunaComboBox1.SelectedIndex = "0" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & GunaComboBox1.SelectedItem & "' "


        ElseIf GunaComboBox1.SelectedIndex = "1" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & GunaComboBox1.SelectedItem & "' "


        ElseIf GunaComboBox1.SelectedIndex = "2" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & GunaComboBox1.SelectedItem & "' "

        ElseIf GunaComboBox1.SelectedIndex = "3" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & GunaComboBox1.SelectedItem & "' "

        End If
        dr = cmd2.ExecuteReader
        Do While dr.Read
            Model.Items.Add(dr("Model"))

        Loop
        con.Close()
    End Sub

    Private Sub Model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Model.SelectedIndexChanged
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        con.Open()
        cmd2.Connection = con
        If GunaComboBox1.SelectedItem = "iPhone" Then
            cmd2.CommandText = "select Model,Storage,Ram,Back,Front,Quantity,Price from Mobile where Model=" & "(@Model)"

        ElseIf GunaComboBox1.SelectedItem = "Samsung" Then
            cmd2.CommandText = "select Model,Storage,Ram,Back,Front,Quantity,Price from Mobile where Model=" & "(@Model)"

        ElseIf GunaComboBox1.SelectedItem = "Oneplus" Then
            cmd2.CommandText = "select Model,Storage,Ram,Back,Front,Quantity,Price from Mobile where Model=" & "(@Model)"

        ElseIf GunaComboBox1.SelectedItem = "Mi" Then
            cmd2.CommandText = "select Model,Storage,Ram,Back,Front,Quantity,Price from Mobile where Model=" & "(@Model)"

        End If
        Dim parameterstate As New SqlParameter("@Model", SqlDbType.VarChar)
        parameterstate.Direction = ParameterDirection.Input
        parameterstate.Value = Model.SelectedItem
        cmd2.Parameters.Add(parameterstate)
        dr = cmd2.ExecuteReader
        Do While dr.Read
            GunaTextBox1.Text = dr("Model")
            GunaTextBox2.Text = dr("Storage")
            GunaTextBox3.Text = dr("Ram")
            GunaTextBox4.Text = dr("Back")
            GunaTextBox5.Text = dr("Front")
            GunaTextBox7.Text = dr("Quantity")
            GunaTextBox6.Text = dr("Price")
        Loop
        dr.Close()

        If GunaComboBox1.SelectedItem = "iPhone" Then
            cmd2.CommandText = "select  *from Mobile where Model='" & Model.SelectedItem & "' "

        ElseIf GunaComboBox1.SelectedItem = "Samsung" Then
            cmd2.CommandText = "select  *from Mobile where Model='" & Model.SelectedItem & "' "

        ElseIf GunaComboBox1.SelectedItem = "Oneplus" Then
            cmd2.CommandText = "select  *from Mobile where Model='" & Model.SelectedItem & "' "

        ElseIf GunaComboBox1.SelectedItem = "Mi" Then
            cmd2.CommandText = "select  *from Mobile where Model='" & Model.SelectedItem & "' "
        End If
        Dim arrImg() As Byte
        Dim pictable As New DataTable
        da.SelectCommand = cmd2
        da.Fill(pictable)
        If pictable.Rows.Count = 0 Then
            MessageBox.Show("No Image Exist")
        Else
            arrImg = pictable.Rows(0)(8)
            Dim ms As New MemoryStream(arrImg)
            PictureBox2.Image = Image.FromStream(ms)
        End If
        con.Close()
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        OpenFileDialog1.Filter = "images| *.jpg;*.png;*.bmp;*.jpeg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub GunaLabel15_Click(sender As Object, e As EventArgs) Handles GunaLabel15.Click

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        Dim memstr As New MemoryStream
        PictureBox2.Image.Save(memstr, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = memstr.ToArray()
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
        con.Open()
        If GunaComboBox1.SelectedIndex = "0" Then
            cmd = New SqlCommand(" update Mobile set Model='" + GunaTextBox1.Text + "',Storage='" + GunaTextBox2.Text + "',Ram='" + GunaTextBox3.Text + "',Back='" + GunaTextBox4.Text + "',Front='" + GunaTextBox5.Text + "',Quantity='" + GunaTextBox7.Text + "',Price='" + GunaTextBox6.Text + "',img=@img where Model=" & "(@Model)", con)
        ElseIf GunaComboBox1.SelectedIndex = "1" Then
            cmd = New SqlCommand(" update Mobile set Model='" + GunaTextBox1.Text + "',Storage='" + GunaTextBox2.Text + "',Ram='" + GunaTextBox3.Text + "',Back='" + GunaTextBox4.Text + "',Front='" + GunaTextBox5.Text + "',Quantity='" + GunaTextBox7.Text + "',Price='" + GunaTextBox6.Text + "',img=@img where Model=" & "(@Model)", con)
        ElseIf GunaComboBox1.SelectedIndex = "2" Then
            cmd = New SqlCommand(" update Mobile set Model='" + GunaTextBox1.Text + "',Storage='" + GunaTextBox2.Text + "',Ram='" + GunaTextBox3.Text + "',Back='" + GunaTextBox4.Text + "',Front='" + GunaTextBox5.Text + "',Quantity='" + GunaTextBox7.Text + "',Price='" + GunaTextBox6.Text + "',img=@img where Model=" & "(@Model)", con)
        ElseIf GunaComboBox1.SelectedIndex = "3" Then
            cmd = New SqlCommand(" update Mobile set Model='" + GunaTextBox1.Text + "',Storage='" + GunaTextBox2.Text + "',Ram='" + GunaTextBox3.Text + "',Back='" + GunaTextBox4.Text + "',Front='" + GunaTextBox5.Text + "',Quantity='" + GunaTextBox7.Text + "',Price='" + GunaTextBox6.Text + "',img=@img where Model=" & "(@Model)", con)
        End If
        Dim parameterstate As New SqlParameter("@Model", SqlDbType.VarChar)
        parameterstate.Direction = ParameterDirection.Input
        parameterstate.Value = Model.SelectedItem
        cmd.Parameters.Add(parameterstate)
        cmd.Parameters.Add("@img", SqlDbType.Image).Value = img
        cmd.ExecuteNonQuery()
        MsgBox("Updated")
        con.Close()

    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        If GunaComboBox2.SelectedItem = "iPhone" Then
            cmd = New SqlCommand("Delete from Mobile where Model=" & "(@Model)", con)
        ElseIf GunaComboBox2.SelectedItem = "Samsung" Then
            cmd = New SqlCommand("Delete from Mobile where Model=" & "(@Model)", con)
        ElseIf GunaComboBox2.SelectedItem = "Oneplus" Then
            cmd = New SqlCommand("Delete from Mobile where Model=" & "(@Model)", con)
        ElseIf GunaComboBox2.SelectedItem = "Mi" Then
            cmd = New SqlCommand("Delete from Mobile where Model=" & "(@Model)", con)
        End If
        Dim parameterstate As New SqlParameter("@Model", SqlDbType.VarChar)
        parameterstate.Direction = ParameterDirection.Input
        parameterstate.Value = GunaComboBox3.SelectedItem
        cmd.Parameters.Add(parameterstate)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Product Deleted")
        Else
            MsgBox("failed")
        End If
        If GunaComboBox2.SelectedItem = "iPhone" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
                str = "SELECT * FROM Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                GunaDataGridView1.DataSource = New BindingSource(dt, iPhone)
            End Using
        ElseIf GunaComboBox2.SelectedItem = "Samsung" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
                str = "SELECT * FROM Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                GunaDataGridView1.DataSource = New BindingSource(dt, Samsung)
            End Using
        ElseIf GunaComboBox2.SelectedItem = "Oneplus" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
                str = "SELECT * FROM Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                GunaDataGridView1.DataSource = New BindingSource(dt, Oneplus)
            End Using
        ElseIf GunaComboBox2.SelectedItem = "Mi" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
                str = "SELECT * FROM Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                GunaDataGridView1.DataSource = New BindingSource(dt, Mi)
            End Using
        End If
        con.Close()
    End Sub
    Public Sub ExecuteQuery(query As String)
    End Sub

    Private Sub GunaComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox2.SelectedIndexChanged
        GunaComboBox3.Items.Clear()
        Dim cmd2 As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        cmd2.CommandText = " "
        con.Open()
        cmd2.Connection = con
        If GunaComboBox2.SelectedItem = "iPhone" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "


        ElseIf GunaComboBox2.SelectedItem = "Samsung" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "


        ElseIf GunaComboBox2.SelectedItem = "Oneplus" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "

        ElseIf GunaComboBox2.SelectedItem = "Mi" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "

        End If
        dr = cmd2.ExecuteReader
        Do While dr.Read
            GunaComboBox3.Items.Add(dr("Model"))

        Loop

        con.Close()
        'REFRESH DATAGRID
        If GunaComboBox2.SelectedItem = "iPhone" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
                str = "SELECT * FROM Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                GunaDataGridView1.DataSource = New BindingSource(dt, iPhone)
            End Using
        ElseIf GunaComboBox2.SelectedItem = "Samsung" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
                str = "SELECT * FROM Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                GunaDataGridView1.DataSource = New BindingSource(dt, Samsung)
            End Using
        ElseIf GunaComboBox2.SelectedItem = "Oneplus" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
                str = "SELECT * FROM Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                GunaDataGridView1.DataSource = New BindingSource(dt, Oneplus)
            End Using
        ElseIf GunaComboBox2.SelectedItem = "Mi" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
                str = "SELECT * FROM Mobile where Brand='" & GunaComboBox2.SelectedItem & "' "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                GunaDataGridView1.DataSource = New BindingSource(dt, Mi)
            End Using
        End If
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox3.SelectedIndexChanged
       
    End Sub
End Class