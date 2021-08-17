Public Class Splash

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuCircleProgressbar1.Value = 0
        BunifuCircleProgressbar1.MaxValue = 100
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuCircleProgressbar1.Value += 5
        BunifuCircleProgressbar1.Text = BunifuCircleProgressbar1.Value.ToString() & "%"

        If BunifuCircleProgressbar1.Value = 100 Then
            Timer1.Enabled = False
            DashBoard.Show()
            Me.Hide()
        End If
    End Sub
End Class