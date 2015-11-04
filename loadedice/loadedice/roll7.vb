Public Class main
    Dim stats = New Integer(11) {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim random As New Random()

    Private Function throwDie() As Integer
        Dim num1 As Integer = random.Next() Mod 6 + 1
        If random.Next() Mod 16 + 1 = 1 Then
            Return 6
        End If
        Return num1
    End Function

    Private Sub throwAll()
        dice1.Text = throwDie()
        dice2.Text = throwDie()
        stats(CInt(dice1.Text) + CInt(dice2.Text) - 2) += 1
        results.Text = ""
        For i = 0 To 10
            results.AppendText(CStr(i + 2) + ": " + CStr(stats(i)) + Environment.NewLine)
        Next
    End Sub

    Private Sub roll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dice1.Text = "0"
        dice2.Text = "0"
        Timer1.Enabled = True
        Timer1.Interval = 20
    End Sub

    Private Sub press_Click(sender As Object, e As EventArgs) Handles press.Click
        throwAll()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        throwAll()
    End Sub
End Class
