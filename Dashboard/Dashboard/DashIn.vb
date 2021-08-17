Imports System.Data.SqlClient
Public Class DashIn
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim dr2 As SqlDataReader
    Dim com As SqlCommand
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("hh:mm:ss")
        GunaCircleProgressBar5.Value = Date.Now.ToString("ss")
    End Sub

    Private Sub DashIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim i1, i2, i3, i4, i5, i6, i7, i8, i9
        Timer1.Start()
        GunaCircleProgressBar1.Value = 0
        GunaCircleProgressBar2.Value = 0
        GunaCircleProgressBar3.Value = 0
        GunaCircleProgressBar4.Value = 0
        GunaCircleProgressBar1.Maximum = 90
        GunaCircleProgressBar2.Maximum = 90
        GunaCircleProgressBar3.Maximum = 90
        GunaCircleProgressBar4.Maximum = 90
        GunaCircleProgressBar5.Maximum = 60
        GunaCircleProgressBar1.Minimum = 0
        GunaCircleProgressBar2.Minimum = 0
        GunaCircleProgressBar3.Minimum = 0
        GunaCircleProgressBar4.Minimum = 0
        GunaCircleProgressBar5.Minimum = 0
        GunaProgressBar1.Minimum = 0
        Dim v1 As String
        v1 = "iPhone"
        Dim v2 As String
        v2 = "Samsung"
        Dim v3 As String
        v3 = "Oneplus"
        Dim v4 As String
        v4 = "Mi"
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim cmd4 As New SqlCommand
        Dim cmd5 As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SKM\Music\Dashboard\Dashboard\Database2.mdf;Integrated Security=True"
        cmd2.CommandText = " "
        con.Open()
        cmd2.Connection = con
        cmd2.CommandText = "select count(Qty) from Sales where Brand='" & v1 & "'"
        i1 = Convert.ToString(cmd2.ExecuteScalar)
        GunaCircleProgressBar1.Value = i1
        cmd3.CommandText = " "
        cmd2.CommandText = "select count(Qty) from Sales where Brand='" & v2 & "'"
        i2 = Convert.ToString(cmd2.ExecuteScalar)
        GunaCircleProgressBar2.Value = i2
        cmd2.CommandText = "select count(Qty) from Sales where Brand='" & v3 & "'"
        i3 = Convert.ToString(cmd2.ExecuteScalar)
        GunaCircleProgressBar3.Value = i3
        cmd2.CommandText = "select count(Qty) from Sales where Brand='" & v4 & "'"
        i4 = Convert.ToString(cmd2.ExecuteScalar)
        GunaCircleProgressBar4.Value = i4
        cmd2.CommandText = "select sum(Quantity) from Mobile"
        i5 = Convert.ToString(cmd2.ExecuteScalar)
        GunaProgressBar1.Maximum = i5
        cmd2.CommandText = "select sum(Qty) from Sales"
        i6 = Convert.ToString(cmd2.ExecuteScalar)
        GunaProgressBar1.Value = i6
        cmd2.CommandText = "SELECT  Top 1 Brand FROM Mobile ORDER BY MobId DESC"
        i7 = Convert.ToString(cmd2.ExecuteScalar)
        Label1.Text = i7
        cmd2.CommandText = "SELECT  Top 1 Model FROM Mobile ORDER BY MobId DESC"
        i8 = Convert.ToString(cmd2.ExecuteScalar)
        Label3.Text = i8
        cmd2.CommandText = "SELECT  Top 1 Customer_Name FROM Customer ORDER BY Bill_No DESC"
        i8 = Convert.ToString(cmd2.ExecuteScalar)
        Label4.Text = i8
    End Sub

    Private Sub GunaCircleProgressBar4_Click(sender As Object, e As EventArgs) Handles GunaCircleProgressBar4.Click

    End Sub
End Class