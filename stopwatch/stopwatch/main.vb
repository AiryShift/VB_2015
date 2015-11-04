Public Class main
    Private Sub init()
        tmr.Enabled = False
        lblSeconds.Text = "0"
        lblMinutes.Text = "0"
        lblLittleSeconds.Text = "0"
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        init()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmr.Enabled = False
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        tmr.Enabled = True
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        lblLittleSeconds.Text += 1
        If lblLittleSeconds.Text = "10" Then
            lblLittleSeconds.Text = "0"
            lblSeconds.Text += 1
            If lblSeconds.Text = "5" Then
                lblSeconds.Text = "0"
                lblMinutes.Text += 1
            End If
        End If
    End Sub
End Class
