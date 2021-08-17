Imports System.Data.SqlClient
Public Class Report
    Dim con As New SqlConnection
    Dim dr As SqlDataReader
    Dim dr2 As SqlDataReader
    Dim dr3 As SqlDataReader
    Dim dr4 As SqlDataReader
    Dim com As SqlCommand
    Dim com2 As SqlCommand
    Dim ds As New DataSet
    Dim da As SqlDataAdapter
    Dim da1 As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim mobile As Object
    Dim customer As Object
    Dim staffnam As Object
    Dim getmob As String
    Dim getmob2 As String
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BunifuPages1.SetPage(Transaction)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BunifuPages1.SetPage(Analysis)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
        con.Open()
        Chart1.Series.Clear()
        If brand1.SelectedItem = brand2.SelectedItem Then
            MessageBox.Show("Please Choose a different brand to Compare")
        Else
            Me.Chart1.Series.Add(brand1.SelectedItem)
            Me.Chart1.Series.Add(brand2.SelectedItem)


            Dim jan1, jan2 As New SqlCommand
            Dim feb1, feb2 As New SqlCommand
            Dim mar1, mar2 As New SqlCommand
            Dim apr1, apr2 As New SqlCommand
            Dim may1, may2 As New SqlCommand
            Dim jun1, jun2 As New SqlCommand
            Dim jul1, jul2 As New SqlCommand
            Dim aug1, aug2 As New SqlCommand
            Dim sep1, sep2 As New SqlCommand
            Dim oct1, oct2 As New SqlCommand
            Dim nov1, nov2 As New SqlCommand
            Dim dec1, dec2 As New SqlCommand
            Dim i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12
            Dim m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12


            '1st combobox
            jan1.CommandText = "select count(P_date) from Sales where P_date between '01-Jan-2021' and '30-Jan-2021' and Brand='" & brand1.SelectedItem & "' "
            jan1.Connection = con
            i1 = Convert.ToString(jan1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("JAN", i1)


            feb1.CommandText = "select count(P_date) from Sales where P_date between '01-feb-2021' and '28-feb-2021' and Brand='" & brand1.SelectedItem & "' "
            feb1.Connection = con
            i2 = Convert.ToString(feb1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("FEB", i2)

            mar1.CommandText = "select count(P_date) from Sales where P_date between '01-mar-2021' and '31-mar-2021' and Brand='" & brand1.SelectedItem & "' "
            mar1.Connection = con
            i3 = Convert.ToString(mar1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("MAR", i3)

            apr1.CommandText = "select count(P_date) from Sales where P_date between '01-apr-2021' and '30-apr-2021' and Brand='" & brand1.SelectedItem & "' "
            apr1.Connection = con
            i4 = Convert.ToString(apr1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("APR", i4)

            may1.CommandText = "select count(P_date) from Sales where P_date between '01-may-2021' and '31-may-2021' and Brand='" & brand1.SelectedItem & "' "
            may1.Connection = con
            i5 = Convert.ToString(may1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("MAY", i5)

            jun1.CommandText = "select count(P_date) from Sales where P_date between '01-jun-2021' and '30-jun-2021' and Brand='" & brand1.SelectedItem & "' "
            jun1.Connection = con
            i6 = Convert.ToString(jun1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("JUN", i6)

            jul1.CommandText = "select count(P_date) from Sales where P_date between '01-jul-2021' and '31-jul-2021' and Brand='" & brand1.SelectedItem & "' "
            jul1.Connection = con
            i7 = Convert.ToString(jul1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("JUL", i7)

            aug1.CommandText = "select count(P_date) from Sales where P_date between '01-aug-2021' and '31-aug-2021' and Brand='" & brand1.SelectedItem & "' "
            aug1.Connection = con
            i8 = Convert.ToString(aug1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("AUG", i8)

            sep1.CommandText = "select count(P_date) from Sales where P_date between '01-sep-2021' and '30-sep-2021' and Brand='" & brand1.SelectedItem & "' "
            sep1.Connection = con
            i9 = Convert.ToString(sep1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("SEP", i9)

            oct1.CommandText = "select count(P_date) from Sales where P_date between '01-oct-2021' and '31-oct-2021' and Brand='" & brand1.SelectedItem & "' "
            oct1.Connection = con
            i10 = Convert.ToString(oct1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("OCT", i10)

            nov1.CommandText = "select count(P_date) from Sales where P_date between '01-nov-2021' and '30-nov-2021' and Brand='" & brand1.SelectedItem & "' "
            nov1.Connection = con
            i11 = Convert.ToString(nov1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("NOV", i11)

            dec1.CommandText = "select count(P_date) from Sales where P_date between '01-dec-2021' and '31-dec-2021' and Brand='" & brand1.SelectedItem & "' "
            dec1.Connection = con
            i12 = Convert.ToString(dec1.ExecuteScalar)
            Me.Chart1.Series(brand1.SelectedItem).Points.AddXY("DEC", i12)




            '2nd combo
            jan2.CommandText = "select count(P_date) from Sales where P_date between '01-Jan-2021' and '30-Jan-2021' and Brand='" & brand2.SelectedItem & "' "
            jan2.Connection = con
            m1 = Convert.ToString(jan2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("JAN", m1)

            feb2.CommandText = "select count(P_date) from Sales  where P_date between '01-feb-2021' and '28-feb-2021' and Brand='" & brand2.SelectedItem & "' "
            feb2.Connection = con
            m2 = Convert.ToString(feb2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("FEB", m2)

            mar2.CommandText = "select count(P_date) from Sales  where P_date between '01-mar-2021' and '31-mar-2021' and Brand='" & brand2.SelectedItem & "' "
            mar2.Connection = con
            m3 = Convert.ToString(mar2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("MAR", m3)

            apr2.CommandText = "select count(P_date) from Sales  where P_date between '01-apr-2021' and '30-apr-2021' and Brand='" & brand2.SelectedItem & "' "
            apr2.Connection = con
            m4 = Convert.ToString(apr2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("APR", m4)

            may2.CommandText = "select count(P_date) from Sales  where P_date between '01-may-2021' and '31-may-2021' and Brand='" & brand2.SelectedItem & "' "
            may2.Connection = con
            m5 = Convert.ToString(may2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("MAY", m5)

            jun2.CommandText = "select count(P_date) from Sales  where P_date between '01-jun-2021' and '30-jun-2021' and Brand='" & brand2.SelectedItem & "' "
            jun2.Connection = con
            m6 = Convert.ToString(jun2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("JUN", m6)

            jul2.CommandText = "select count(P_date) from Sales  where P_date between '01-jul-2021' and '31-jul-2021' and Brand='" & brand2.SelectedItem & "' "
            jul2.Connection = con
            m7 = Convert.ToString(jul2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("JUL", m7)

            aug2.CommandText = "select count(P_date) from Sales  where P_date between '01-aug-2021' and '31-aug-2021' and Brand='" & brand2.SelectedItem & "' "
            aug2.Connection = con
            m8 = Convert.ToString(aug2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("AUG", m8)

            sep2.CommandText = "select count(P_date) from Sales  where P_date between '01-sep-2021' and '30-sep-2021' and Brand='" & brand2.SelectedItem & "' "
            sep2.Connection = con
            m9 = Convert.ToString(sep2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("SEP", m9)

            oct2.CommandText = "select count(P_date) from Sales  where P_date between '01-oct-2021' and '31-oct-2021' and Brand='" & brand2.SelectedItem & "' "
            oct2.Connection = con
            m10 = Convert.ToString(oct2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("OCT", m10)

            nov2.CommandText = "select count(P_date) from Sales  where P_date between '01-nov-2021' and '30-nov-2021' and Brand='" & brand2.SelectedItem & "' "
            nov2.Connection = con
            m11 = Convert.ToString(nov2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("NOV", m11)

            dec2.CommandText = "select count(P_date) from Sales  where P_date between '01-dec-2021' and '31-dec-2021' and Brand= '" & brand2.SelectedItem & "' "
            dec2.Connection = con
            m12 = Convert.ToString(dec2.ExecuteScalar)
            Me.Chart1.Series(brand2.SelectedItem).Points.AddXY("DEC", m12)
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True; MultipleActiveResultSets=True")
        con.Open()
        str = "SELECT *From Sales WHERE Bill_No = '" + TextBox1.Text + "'"
        com = New SqlCommand(str, con)
        da = New SqlDataAdapter(com)
        dt = New DataTable()
        dv = New DataView()
        da.Fill(dt)
        GunaDataGridView1.DataSource = New BindingSource(dt, mobile)
        getmob = "select RegId from Sales where Bill_No='" & TextBox1.Text & "'"
        com = New SqlCommand(getmob, con)
        dr3 = com.ExecuteReader()
        If dr3.Read() Then
            Sid.Text = dr3.GetValue(0).ToString()
            staffnam = dr3.GetValue(0).ToString()
        End If
        dr3.Close()
        getmob2 = "select First_Name from Signup where RegId='" & staffnam & "'"
        com2 = New SqlCommand(getmob2, con)
        dr2 = com2.ExecuteReader()
        If dr2.Read() Then
            Label1.Text = dr2.GetValue(0).ToString()
        End If
        dr2.Close()
        GunaDataGridView1.DataSource = New BindingSource(dt, mobile)
        Try
            getmob = "select Customer_Name,Customer_Phone,Customer_Email,Payment from Customer where Bill_No='" & TextBox1.Text & "'"
            com = New SqlCommand(getmob, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                TextBox2.Text = dr.GetValue(0).ToString()
                TextBox3.Text = dr.GetValue(1).ToString()
                TextBox4.Text = dr.GetValue(2).ToString()
                TextBox5.Text = dr.GetValue(3).ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sales2DataSet1.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.Sales2DataSet1.Sales)


    End Sub

    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
