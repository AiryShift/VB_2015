Public Class main
    Private Sub reset()
        picRedCar.Left = Me.Width - picRedCar.Width - 10
        picYellowCar.Left = Me.Width - picYellowCar.Width - 10
        lblRedLaps.Text = "0"
        lblYellowLaps.Text = "0"
    End Sub

    Private Sub tmrRace_Tick(sender As Object, e As EventArgs) Handles tmrRace.Tick
        Dim whichCar As Integer
        Randomize()
        whichCar = Int(Rnd() * 2)
        If whichCar = 0 Then
            picRedCar.Left -= 5
            If picRedCar.Left + picRedCar.Width < 0 Then
                picRedCar.Left = Me.Width
                lblRedLaps.Text += 1
                If lblRedLaps.Text = "1" Then
                    tmrRace.Enabled = False
                    MessageBox.Show("Red wins!", "Grand Prix", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    reset()
                End If
            End If
        Else
            picYellowCar.Left -= 5
            If picYellowCar.Left + picYellowCar.Width < 0 Then
                picYellowCar.Left = Me.Width
                lblYellowLaps.Text += 1
                If lblYellowLaps.Text = "1" Then
                    tmrRace.Enabled = False
                    MessageBox.Show("Yellow wins!", "Grand Prix", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    reset()
                End If
            End If
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        tmrRace.Enabled = True
    End Sub
End Class
