Imports System.Data.DataTable
Imports System.Data.SqlClient
Imports System.IO
Public Class Outlet
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim objcmd As SqlCommand
    Dim getmob As String
    Dim ds As New DataSet
    Dim dr2 As SqlDataReader
    Dim index As Integer
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim skm As Object
    Dim str As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
        Dim command As New SqlCommand("insert into Outlet(name,Locality,city,pincode,state,pno) values(@name,@locality,@city,@pincode,@state,@pno)", con)
        Dim ms As New MemoryStream()
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = Name.Text
        command.Parameters.Add("@Locality", SqlDbType.VarChar).Value = Locality.Text
        command.Parameters.Add("@city", SqlDbType.VarChar).Value = City.Text
        command.Parameters.Add("@pincode", SqlDbType.VarChar).Value = Pincode.Text
        command.Parameters.Add("@state", SqlDbType.VarChar).Value = State.Text
        command.Parameters.Add("@pno", SqlDbType.VarChar).Value = Number.Text
        If (Name.Text = "" Or Locality.Text = "" Or City.Text = "" Or Pincode.Text = "" Or State.Text = "" Or Number.Text = "") Then
            MessageBox.Show("Please Enter The Details")
        Else
            con.Open()
            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Registered Successfully")

            Else

                MessageBox.Show("Not Added")

            End If
            str = "SELECT * FROM Outlet"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            GunaDataGridView1.DataSource = New BindingSource(dt, skm)
            con.Close()
        End If
    End Sub

    Private Sub Outlet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OutetDataSet.Outlet' table. You can move, or remove it, as needed.
        Dim com As SqlCommand
        Dim dr As SqlDataReader
        Me.OutletTableAdapter.Fill(Me.OutetDataSet.Outlet)
        Dim i8 As Object
        update.Visible = False
        reg.Visible = False
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True")
        con.Open()
        Try
            getmob = "select *from Outlet"
            objcmd = New SqlCommand(getmob, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(objcmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Update.Visible = True
                Button1.Visible = False
                reg.Visible = True
                GunaDataGridView1.Visible = True
            End If
        Catch ex As Exception
        End Try
        Dim cmd4 As String = "SELECT  Top 1 OId FROM Outlet ORDER BY OId DESC"
        com = New SqlCommand(cmd4, con)
        dr = com.ExecuteReader()
        If dr.Read() Then
            Chumma.Text = dr.GetValue(0).ToString()
        End If
        dr.Close()
        str = "SELECT * FROM Outlet"
        com = New SqlCommand(str, con)
        da = New SqlDataAdapter(com)
        dt = New DataTable()
        dv = New DataView()
        da.Fill(dt)
        GunaDataGridView1.DataSource = New BindingSource(dt, skm)
        con.Close()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles update.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim newDataRow As DataGridViewRow
        newDataRow = GunaDataGridView1.Rows(index)
        newDataRow.Cells(0).Value = Name.Text
        newDataRow.Cells(1).Value = Locality.Text
        newDataRow.Cells(2).Value = City.Text
        newDataRow.Cells(3).Value = Pincode.Text
        newDataRow.Cells(4).Value = State.Text
        newDataRow.Cells(5).Value = Number.Text
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Outlet set name='" + Name.Text + "',Locality= '" + Locality.Text + "',city= '" + City.Text + "',pincode= '" + Pincode.Text + "',pno= '" + Number.Text + "',state= '" + State.Text + "'where OId='" & Chumma.Text & "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Updated Sucessfully")
        Name.Text = ""
        Locality.Text = ""
        City.Text = ""
        Pincode.Text = ""
        State.Text = ""
        Number.Text = ""

    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = GunaDataGridView1.Rows(index)
        Name.Text = selectedrow.Cells(0).Value.ToString()
        Locality.Text = selectedrow.Cells(1).Value.ToString()
        City.Text = selectedrow.Cells(2).Value.ToString()
        Pincode.Text = selectedrow.Cells(3).Value.ToString()
        State.Text = selectedrow.Cells(4).Value.ToString()
        Number.Text = selectedrow.Cells(5).Value.ToString()
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub Number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Number.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
        If Number.Text.Length = 10 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Pincode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pincode.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
        If Pincode.Text.Length = 6 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Locality_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Locality.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub City_KeyPress(sender As Object, e As KeyPressEventArgs) Handles City.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub State_KeyPress(sender As Object, e As KeyPressEventArgs) Handles State.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar) = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
End Class