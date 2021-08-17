Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class Purchase
    Dim con As New SqlConnection
    Dim dr2 As SqlDataReader
    Dim con_str As String
    Dim adapter As New SqlDataAdapter
    Dim cmd As SqlCommand
    Dim Payment As String
    Dim reg As String
    Dim dr As SqlDataReader
    Dim bill As String
    Dim mob As Object
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Model.Items.Clear()
        Dim cmd2 As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        cmd2.CommandText = " "
        con.Open()
        cmd2.Connection = con
        If ComboBox1.SelectedItem = "iPhone" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & ComboBox1.SelectedItem & "' "


        ElseIf ComboBox1.SelectedItem = "Samsung" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & ComboBox1.SelectedItem & "' "


        ElseIf ComboBox1.SelectedItem = "Oneplus" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & ComboBox1.SelectedItem & "' "

        ElseIf ComboBox1.SelectedItem = "3" Then

            cmd2.CommandText = "select Model from Mobile where Brand='" & ComboBox1.SelectedItem & "' "

        End If
        dr2 = cmd2.ExecuteReader
        Do While dr2.Read
            Model.Items.Add(dr2("Model"))

        Loop
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Str As String
        Dim da As New SqlDataAdapter
        Dim dt As DataTable
        Dim dv As DataView
        Dim obs As Object
        Dim com As SqlCommand
        Dim objcmd As SqlCommand
        'TODO: This line of code loads data into the 'OutletPurchaseDataSet1.Outlet' table. You can move, or remove it, as needed.
        Me.OutletTableAdapter.Fill(Me.OutletPurchaseDataSet1.Outlet)
        'TODO: This line of code loads data into the 'NewOutletDataSet2.Outlet' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'OutletDataSet2.Outlet' table. You can move, or remove it, as needed.
        'Me.OutletTableAdapter1.Fill(Me.OutletDataSet2.Outlet)
        ''TODO: This line of code loads data into the 'OutletDataSetnew.Outlet' table. You can move, or remove it, as needed.
        'Dim cmd As New SqlCommand
        'Dim com As SqlCommand
        'Dim dr As SqlDataReader
        'Dim cusid As Object
        'Dim i1
        ''cusid = Label2.Text
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        con.Open()
        ''Dim cmd2 As String = "SELECT  Top 1 Customer_Name FROM Customer ORDER BY Cid DESC"
        ''com = New SqlCommand(cmd2, con)
        ''dr = com.ExecuteReader()
        ''If dr.Read() Then
        ''    cusid = dr.GetValue(0).ToString()
        ''    'cusid.show()
        ''End If
        'cmd.Connection = con
        'cmd.CommandText = "SELECT  Top 1 Cid FROM Customer ORDER BY Cid DESC"
        'i1 = Convert.ToString(cmd.ExecuteScalar)
        'Label2.Text = i1
        'con.Close()
        getData()
        AutoID()

        GunaDataGridView1.RowTemplate.Height = 120
        GunaTextBox1.Visible = False
        GunaTextBox2.Visible = False
        GunaComboBox2.Visible = False
        GunaComboBox1.Visible = False
        GunaLabel25.Visible = False
        GunaLabel26.Visible = False
        GunaLabel27.Visible = False
        Str = "SELECT * FROM Outlet"
        com = New SqlCommand(Str, con)
        da = New SqlDataAdapter(com)
        dt = New DataTable()
        dv = New DataView()
        da.Fill(dt)
        GunaDataGridView2.DataSource = New BindingSource(dt, mob)
        con.Close()
    End Sub

    Private Sub Model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Model.SelectedIndexChanged
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        con.Open()
        cmd2.Connection = con
        If ComboBox1.SelectedItem = "iPhone" Then
            cmd2.CommandText = "select MobId,Model,Storage,Ram,Back,Front,Quantity,Price from Mobile where Model=" & "(@Model)"

        ElseIf ComboBox1.SelectedItem = "Samsung" Then
            cmd2.CommandText = "select MobId,Model,Storage,Ram,Back,Front,Quantity,Price from Mobile where Model=" & "(@Model)"

        ElseIf ComboBox1.SelectedItem = "Oneplus" Then
            cmd2.CommandText = "select MobId,Model,Storage,Ram,Back,Front,Quantity,Price from Mobile where Model=" & "(@Model)"

        ElseIf ComboBox1.SelectedItem = "Mi" Then
            cmd2.CommandText = "select MobId,Model,Storage,Ram,Back,Front,Quantity,Price from Mobile where Model=" & "(@Model)"

        End If
        Dim parameterstate As New SqlParameter("@Model", SqlDbType.VarChar)
        parameterstate.Direction = ParameterDirection.Input
        parameterstate.Value = Model.SelectedItem
        cmd2.Parameters.Add(parameterstate)
        dr2 = cmd2.ExecuteReader
        Do While dr2.Read
            TextBox1.Text = dr2("Model")
            TextBox2.Text = dr2("Storage")
            TextBox3.Text = dr2("Ram")
            TextBox4.Text = dr2("Back")
            TextBox5.Text = dr2("Front")
            TextBox6.Text = dr2("Quantity")
            TextBox7.Text = dr2("Price")
            Label1.Text = dr2("MobId")
        Loop
        dr2.Close()
        If ComboBox1.SelectedItem = "iPhone" Then
            cmd2.CommandText = "select  *from Mobile where Model='" & Model.SelectedItem & "' "

        ElseIf ComboBox1.SelectedItem = "Samsung" Then
            cmd2.CommandText = "select  *from Mobile where Model='" & Model.SelectedItem & "' "

        ElseIf ComboBox1.SelectedItem = "Oneplus" Then
            cmd2.CommandText = "select  *from Mobile where Model='" & Model.SelectedItem & "' "

        ElseIf ComboBox1.SelectedItem = "Mi" Then
            cmd2.CommandText = "select  *from Mobile where Model='" & Model.SelectedItem & "' "
        End If
        Dim arrImg() As Byte
        Dim pictable As New DataTable
        da.SelectCommand = cmd2
        da.Fill(pictable)
        If pictable.Rows.Count = 0 Then
            MessageBox.Show("no image with such id exist")
        Else
            arrImg = pictable.Rows(0)(8)
            Dim ms As New MemoryStream(arrImg)
            PictureBox1.Image = Image.FromStream(ms)
        End If
        con.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub edit_stock_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub add_stock_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub del_stock_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
    Sub getData()
        con_str = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        Using con = New SqlConnection(con_str)
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM Customer"
                cmd = New SqlCommand(sql, con)
                adapter = New SqlDataAdapter(cmd)


            Catch ex As Exception
                MessageBox.Show("1st")
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Sub AutoID()
        con_str = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        Using con = New SqlConnection(con_str)
            Try
                con.Open()
                Dim sql As String = "SELECT  Top 1 Bill_No FROM Customer ORDER BY Bill_No DESC"
                cmd = New SqlCommand(sql, con)
                adapter = New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds)

                If (ds.Tables(0).Rows.Count > 0) Then

                    Dim tmp_id = ds.Tables(0).Rows(0)("Bill_No").ToString().Substring(3, 7)
                    Dim new_id As Integer = CInt(tmp_id) + 1
                    TextBox8.Text = "INV" & new_id.ToString("0000000")

                Else
                    TextBox8.Text = "INV0000001"
                End If



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub GunaLabel7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Numeric1_ValueChanged(sender As Object, e As EventArgs) Handles Numeric1.ValueChanged
        If Numeric1.Value <= Val(TextBox6.Text) Then
            GunaLabel7.Text = "Available"
            GunaLabel7.ForeColor = Color.FromArgb(3, 198, 181)
        Else
            GunaLabel7.Text = "Out Of Stock"
            GunaLabel7.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaDataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView2.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = GunaDataGridView2.Rows(index)
        Name.Text = selectedrow.Cells(0).Value.ToString()
        Locality.Text = selectedrow.Cells(1).Value.ToString()
        City.Text = selectedrow.Cells(2).Value.ToString()
        Pincode.Text = selectedrow.Cells(3).Value.ToString()
        Number.Text = selectedrow.Cells(5).Value.ToString()
        State.Text = selectedrow.Cells(4).Value.ToString()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim pent2 As New Pen(Color.Black, 3)
        e.Graphics.DrawString(Name.Text, New Font("Arial", 20, FontStyle.Bold), Brushes.Blue, New Point(295, 20))
        e.Graphics.DrawString(Locality.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(310, 53))
        e.Graphics.DrawString(City.Text + "-" + Pincode.Text + " Ph:" + Number.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(305, 73))
        e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, New Point(0, 100))
        e.Graphics.DrawString("TAX INVOICE", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(355, 120))
        e.Graphics.DrawString("---------------------", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, New Point(350, 127))
        e.Graphics.DrawString("Original for Receipient", New Font("Arial", 9, FontStyle.Regular), Brushes.Black, New Point(700, 115))
        e.Graphics.DrawString("Invoice No:" + TextBox8.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(20, 140))
        e.Graphics.DrawString("SalesPerson:" + DashBoard.Label1.Text, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(20, 160))
        e.Graphics.DrawString("Date of Invoice:" + Date.Today, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(650, 140))
        e.Graphics.DrawString("Invoice Time:" + TimeOfDay, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(650, 160))
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, New Point(0, 180))
        e.Graphics.DrawString("To:", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(20, 200))
        e.Graphics.DrawString("Mr/Ms:" + Custname.Text, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(60, 220))
        e.Graphics.DrawString("Mobile: " + Custnum.Text, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(60, 240))
        e.Graphics.DrawString("Email: " + CustEmail.Text, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(60, 260))
        e.Graphics.DrawString("Payment Method  : " + Payment, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(650, 200))
        e.Graphics.DrawString("Cash/Card", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(650, 220))
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, New Point(0, 300))
        e.Graphics.DrawString("Brand", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(20, 325))
        e.Graphics.DrawString("Model", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(175, 325))
        e.Graphics.DrawString("Rate", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(360, 325))
        e.Graphics.DrawString("Quantity", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(479, 325))
        e.Graphics.DrawString("Amount", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(650, 325))

        Dim bm As New Bitmap(GunaDataGridView1.Width, GunaDataGridView1.Height)
        GunaDataGridView1.ColumnHeadersVisible = False
        GunaDataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, GunaDataGridView1.Width, GunaDataGridView1.Height))
        e.Graphics.DrawImage(bm, 60, 385)

        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, New Point(0, 345))
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, New Point(0, 720))
        e.Graphics.DrawString("Total Amount :" + GunaLabel5.Text, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(200, 735))
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, New Point(0, 750))
        e.Graphics.DrawString("Terms and Conditions", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(20, 765))
        e.Graphics.DrawString("1.Goods once sold will not be taken back/replaced/refunded.For after sales service contact Authoritized Service Centre", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(20, 782))
        e.Graphics.DrawString("2.Customer should verify an initial with date on the Invoice below", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(20, 800))
        e.Graphics.DrawString("3.VAS is not applicable on this invoice unless specifically Purchased", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(20, 820))
        e.Graphics.DrawString("To claim VAS valid id proof is mandatory and FIR is compulsory to claim theft protection", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(30, 840))
        e.Graphics.DrawString("4. Claim for screen replacement within 7 days from date of purchase will not be accepted", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(20, 860))
        e.Graphics.DrawString("5.Warranty whatsoever provided is by the manufacturer and not by " + Name.Text, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New Point(20, 880))
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, New Point(0, 900))
        e.Graphics.DrawString("Customer Signature", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(40, 970))
        e.Graphics.DrawString("Authorised Signature", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(625, 970))
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 11, FontStyle.Bold), Brushes.Black, New Point(0, 1000))
        e.Graphics.DrawString(Name.Text, New Font("Arial", 15, FontStyle.Bold), Brushes.Black, New Point(320, 1040))
        e.Graphics.DrawString("'Customer is King And King never bargains'", New Font("Arial", 13, FontStyle.Bold), Brushes.Black, New Point(220, 1070))
        Dim drawString As String = "------------------------------------------------------------------------------------"
        Dim drawFont As System.Drawing.Font = New System.Drawing.Font("Arial", 11, FontStyle.Bold)
        Dim drawBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(System.Drawing.Color.Black)
        Dim x As Single = 60.0F
        Dim y As Single = 305.0F
        Dim drawFormat As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical
        'e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat)
        'Dim a As Single = 370.0F
        'Dim b As Single = 305.0F
        'e.Graphics.DrawString(drawString, drawFont, drawBrush, a, b, drawFormat)
        'Dim c As Single = 490.0F
        'Dim d As Single = 305.0F
        'e.Graphics.DrawString(drawString, drawFont, drawBrush, c, d, drawFormat)
        'Dim f As Single = 590.0F
        'Dim g As Single = 305.0F
        'e.Graphics.DrawString(drawString, drawFont, drawBrush, f, g, drawFormat)
    End Sub

    Private Sub GunaGroupBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaImageRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaImageRadioButton1.CheckedChanged
        Payment = "Cash"
    End Sub

    Private Sub GunaImageRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaImageRadioButton2.CheckedChanged
        Payment = "Card"
    End Sub

    Private Sub GunaImageRadioButton2_Click(sender As Object, e As EventArgs) Handles GunaImageRadioButton2.Click
        GunaTextBox1.Visible = True
        GunaTextBox2.Visible = True
        GunaComboBox2.Visible = True
        GunaComboBox1.Visible = True
        GunaLabel25.Visible = True
        GunaLabel26.Visible = True
        GunaLabel27.Visible = True
    End Sub

    Private Sub GunaImageRadioButton1_Click(sender As Object, e As EventArgs) Handles GunaImageRadioButton1.Click
        GunaTextBox1.Visible = False
        GunaTextBox2.Visible = False
        GunaComboBox2.Visible = False
        GunaComboBox1.Visible = False
        GunaLabel25.Visible = False
        GunaLabel26.Visible = False
        GunaLabel27.Visible = False
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        BunifuPages1.SetPage(TabPage2)
    End Sub

    Private Sub Custname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
        If TextBox10.Text.Length = 10 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        Dim p As String
        p = "^([0-9a-z]([-\.\w]*[0-9a-z]*@[0-9a-z][-\w]*[0-9a-z]\.)+[c,o,m]{3,9})$"
        If Regex.IsMatch(TextBox11.Text, p) Then
            TextBox11.FocusedBorderColor = Color.FromArgb(3, 198, 181)
        Else
            TextBox11.FocusedBorderColor = Color.FromArgb(219, 5, 47)
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
        If GunaTextBox2.Text.Length = 16 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = True
    End Sub
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs)
        'Dim cmd As New SqlCommand
        'Dim com As SqlCommand
        'Dim dr As SqlDataReader
        'Dim cusid As Object
        'cusid = Label2
        'con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        'con.Open()
        'cmd.Connection = con
        'cmd.CommandText = "Insert into Customer( Customer_Name,Customer_Phone,Customer_Email,Bill_No) VALUES (@Customer_Name, @Customer_Phone, @Customer_Email,@CBill_No)"
        'cmd.Parameters.Add("@Customer_Name", SqlDbType.VarChar).Value = TextBox9.Text
        'cmd.Parameters.Add("@Customer_Phone", SqlDbType.VarChar).Value = TextBox10.Text
        'cmd.Parameters.Add("@Customer_Email", SqlDbType.VarChar).Value = TextBox11.Text
        ''cmd.Parameters.AddWithValue("@Payment", Payment)
        'cmd.Parameters.AddWithValue("CBill_No", TextBox8.Text)
        'cmd.ExecuteNonQuery()
        'con.Close()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim com As SqlCommand
        'Dim cmd2 As New SqlCommand
        'con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
        'con.Open()
        'Dim cmd As String = "select RegId from Signup where Username ='" & Login2.BunifuMaterialTextbox1.Text & "' AND Password ='" & Login2.BunifuMaterialTextbox2.Text & "' "
        'com = New SqlCommand(cmd, con)
        'dr = com.ExecuteReader()
        'If dr.Read() Then
        '    reg = dr.GetValue(0).ToString()
        'End If
        'con.Close()
        'con.Open()
        'cmd2.Connection = con
        'cmd2.CommandText = "INSERT INTO Sales( Brand,Model, price, Qty, Total, P_date,Bill_No,RegId,MobId) VALUES (@Brand,@Model, @Price, @Qty, @Total ,@Date,@Bill_No,@RegId,@MobId)"
        'cmd2.Parameters.Add("@Brand", SqlDbType.VarChar)
        'cmd2.Parameters.Add("@Model", SqlDbType.VarChar)
        'cmd2.Parameters.Add("@Price", SqlDbType.Money)
        'cmd2.Parameters.Add("@Qty", SqlDbType.Int)
        'cmd2.Parameters.Add("@Total", SqlDbType.Money)
        'cmd2.Parameters.Add("@Date", SqlDbType.Date)
        'cmd2.Parameters.AddWithValue("Bill_No", TextBox8.Text)
        'cmd2.Parameters.AddWithValue("RegId", reg)
        'cmd2.Parameters.AddWithValue("MobId", Label1.Text)
        'For i As Integer = 0 To GunaDataGridView1.Rows.Count - 1
        '    cmd2.Parameters(0).Value = GunaDataGridView1.Rows(i).Cells(0).Value
        '    cmd2.Parameters(1).Value = GunaDataGridView1.Rows(i).Cells(1).Value
        '    cmd2.Parameters(2).Value = GunaDataGridView1.Rows(i).Cells(2).Value
        '    cmd2.Parameters(3).Value = GunaDataGridView1.Rows(i).Cells(3).Value
        '    cmd2.Parameters(4).Value = GunaDataGridView1.Rows(i).Cells(4).Value
        '    cmd2.Parameters(5).Value = Now.Date
        '    cmd2.Parameters(6).Value = TextBox8.Text
        'cmd2.Parameters(7).Value = reg
        'cmd2.Parameters(8).Value = Label1.Text
        '    cmd2.ExecuteNonQuery()
        '    getData()
        '    AutoID()
        'Next
        'Dim check As String
        'check = Val(TextBox6.Text) - Val(Numeric1.Value)
        'Dim memstr As New MemoryStream
        'PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
        'Dim img() As Byte
        'img = memstr.ToArray()
        'con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
        'con.Open()
        'If ComboBox1.SelectedIndex = "0" Then
        '    cmd2 = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
        'ElseIf ComboBox1.SelectedIndex = "1" Then
        '    cmd2 = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
        'ElseIf ComboBox1.SelectedIndex = "2" Then
        '    cmd2 = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
        'ElseIf ComboBox1.SelectedIndex = "3" Then
        '    cmd2 = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
        'End If
        'Dim parameterstate As New SqlParameter("@Model", SqlDbType.VarChar)
        'parameterstate.Direction = ParameterDirection.Input
        'parameterstate.Value = Model.SelectedItem
        'cmd2.Parameters.Add(parameterstate)
        'cmd2.Parameters.Add("@img", SqlDbType.Image).Value = img
        'cmd2.ExecuteNonQuery()
        'MsgBox("Purchase Complete")
        'con.Close()

        'getData()
        'AutoID()
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        con.Open()
        Dim cmd3 As String = "select RegId from Signup where Username ='" & Login2.BunifuMaterialTextbox1.Text & "' AND Password ='" & Login2.BunifuMaterialTextbox2.Text & "' "
        com = New SqlCommand(cmd3, con)
        dr = com.ExecuteReader()
        If dr.Read() Then
            reg = dr.GetValue(0).ToString()
        End If
        con.Close()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Insert into Customer( Bill_No,Customer_Name,Customer_Phone,Customer_Email,Payment) VALUES (@CBill_No, @Customer_Name, @Customer_Phone, @Customer_Email,@Payment)"
        cmd.Parameters.Add("@Customer_Name", SqlDbType.VarChar).Value = TextBox9.Text
        cmd.Parameters.Add("@Customer_Phone", SqlDbType.VarChar).Value = TextBox10.Text
        cmd.Parameters.Add("@Customer_Email", SqlDbType.VarChar).Value = TextBox11.Text
        cmd.Parameters.AddWithValue("@Payment", Payment)
        cmd.Parameters.AddWithValue("CBill_No", TextBox8.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        con.Open()
        Dim cmd4 As String = "SELECT  Top 1 Bill_No FROM Customer ORDER BY Bill_No DESC"
        com = New SqlCommand(cmd4, con)
        dr = com.ExecuteReader()
        If dr.Read() Then
            bill = dr.GetValue(0).ToString()
        End If
        con.Close()
        con.Open()
        cmd2.Connection = con
        cmd2.CommandText = "INSERT INTO Sales( Brand,Model, price, Qty, Total, P_date,Bill_No,RegId,MobId) VALUES (@Brand,@Model, @Price, @Qty, @Total ,@Date,@Bill_No,@RegId,@MobId)"
            cmd2.Parameters.Add("@Brand", SqlDbType.VarChar)
            cmd2.Parameters.Add("@Model", SqlDbType.VarChar)
            cmd2.Parameters.Add("@Price", SqlDbType.Money)
            cmd2.Parameters.Add("@Qty", SqlDbType.Int)
            cmd2.Parameters.Add("@Total", SqlDbType.Money)
            cmd2.Parameters.Add("@Date", SqlDbType.Date)
            cmd2.Parameters.AddWithValue("Bill_No", bill)
            cmd2.Parameters.AddWithValue("RegId", reg)
            cmd2.Parameters.AddWithValue("MobId", Label1.Text)
            For i As Integer = 0 To GunaDataGridView1.Rows.Count - 1
                cmd2.Parameters(0).Value = GunaDataGridView1.Rows(i).Cells(0).Value
                cmd2.Parameters(1).Value = GunaDataGridView1.Rows(i).Cells(1).Value
                cmd2.Parameters(2).Value = GunaDataGridView1.Rows(i).Cells(2).Value
                cmd2.Parameters(3).Value = GunaDataGridView1.Rows(i).Cells(3).Value
                cmd2.Parameters(4).Value = GunaDataGridView1.Rows(i).Cells(4).Value
                cmd2.Parameters(5).Value = Now.Date
                cmd2.Parameters(6).Value = bill
                cmd2.Parameters(7).Value = reg
                cmd2.Parameters(8).Value = Label1.Text
                cmd2.ExecuteNonQuery()
                getData()
                AutoID()
            Next
            con.Close()
            Dim check As String
            check = Val(TextBox6.Text) - Val(Numeric1.Value)
            Dim memstr As New MemoryStream
            PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
            Dim img() As Byte
            img = memstr.ToArray()
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
            con.Open()
            If ComboBox1.SelectedIndex = "0" Then
                cmd2 = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
            ElseIf ComboBox1.SelectedIndex = "1" Then
                cmd2 = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
            ElseIf ComboBox1.SelectedIndex = "2" Then
                cmd2 = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
            ElseIf ComboBox1.SelectedIndex = "3" Then
                cmd2 = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
            End If
            Dim parameterstate As New SqlParameter("@Model", SqlDbType.VarChar)
            parameterstate.Direction = ParameterDirection.Input
            parameterstate.Value = Model.SelectedItem
            cmd2.Parameters.Add(parameterstate)
            cmd2.Parameters.Add("@img", SqlDbType.Image).Value = img
            cmd2.ExecuteNonQuery()
            MsgBox("Purchase Complete")
            con.Close()

            getData()
            AutoID()
            Custname.Text = TextBox9.Text
            Custnum.Text = TextBox10.Text
            CustEmail.Text = TextBox11.Text
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        PrintPreviewDialog1.Document = PrintDocument1
        If Name.Text = Nothing Then
            MessageBox.Show("Please Select Your Branch")
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        BunifuPages1.SetPage(TabPage4)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Double
        total = Val(TextBox7.Text) * Val(Numeric1.Value)
        GunaDataGridView1.Rows.Add(ComboBox1.SelectedItem, Model.SelectedItem, TextBox7.Text, Numeric1.Value, total)

        Dim ttl As Decimal = 0
        For i = 0 To GunaDataGridView1.RowCount - 1
            ttl += GunaDataGridView1.Rows(i).Cells(4).Value
        Next
        Dim ttl_q As Decimal = 0
        For i = 0 To GunaDataGridView1.RowCount - 1
            ttl_q += GunaDataGridView1.Rows(i).Cells(3).Value
        Next
        GunaLabel5.Text = ttl
        GunaLabel32.Text = ttl_q
        'Dim cmd As New SqlCommand
        'con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        'con.Open()
        'cmd.Connection = con
        'cmd.CommandText = "Insert into Customer( Bill_No,Customer_Name,Customer_Phone,Customer_Email,Payment) VALUES (@CBill_No, @Customer_Name, @Customer_Phone, @Customer_Email,@Payment)"
        'cmd.Parameters.Add("@Customer_Name", SqlDbType.VarChar).Value = TextBox9.Text
        'cmd.Parameters.Add("@Customer_Phone", SqlDbType.VarChar).Value = TextBox10.Text
        'cmd.Parameters.Add("@Customer_Email", SqlDbType.VarChar).Value = TextBox11.Text
        'cmd.Parameters.AddWithValue("@Payment", Payment)
        'cmd.Parameters.AddWithValue("CBill_No", TextBox8.Text)
        'cmd.ExecuteNonQuery()
        'con.Close()
        'Dim check As String
        'check = Val(TextBox6.Text) - Val(Numeric1.Value)
        'Dim cmd As New SqlCommand
        'Dim memstr As New MemoryStream
        'PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)
        'Dim img() As Byte
        'img = memstr.ToArray()
        'con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
        'con.Open()
        'If ComboBox1.SelectedIndex = "0" Then
        '    cmd = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
        'ElseIf ComboBox1.SelectedIndex = "1" Then
        '    cmd = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
        'ElseIf ComboBox1.SelectedIndex = "2" Then
        '    cmd = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
        'ElseIf ComboBox1.SelectedIndex = "3" Then
        '    cmd = New SqlCommand(" update Mobile set Quantity='" & check & "'   where Model=" & "(@Model)", con)
        'End If
        'Dim parameterstate As New SqlParameter("@Model", SqlDbType.VarChar)
        'parameterstate.Direction = ParameterDirection.Input
        'parameterstate.Value = Model.SelectedItem
        'cmd.Parameters.Add(parameterstate)
        'cmd.Parameters.Add("@img", SqlDbType.Image).Value = img
        'cmd.ExecuteNonQuery()
        If Numeric1.Value <= 0 Then
            MessageBox.Show("Please choose quantity ")
        Else
            MsgBox("Added To Cart")
        End If
        'con.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Custname.Text = TextBox9.Text
        CustEmail.Text = TextBox11.Text
        Custnum.Text = TextBox10.Text
            If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "") Then
                MessageBox.Show("Select product to be added")
            ElseIf Numeric1.Value <= 0 Then
                MessageBox.Show("Please choose quantity ")
            Else
            BunifuPages1.SetPage(TabPage3)
            End If
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If (TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "") Then
            MessageBox.Show("Please Enter The Details")
        Else
            BunifuPages1.SetPage(TabPage2)
        End If
    End Sub

    

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        PrintDocument1.Print()
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub
End Class