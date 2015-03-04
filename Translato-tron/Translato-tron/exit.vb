Public Class formExit

    Private Sub btnExitFalse_Click(sender As Object, e As EventArgs) Handles btnExitFalse.Click
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnExitTrue_Click(sender As Object, e As EventArgs) Handles btnExitTrue.Click
        End
    End Sub

    Private Sub formExit_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        My.Computer.Audio.Play(My.Resources.x_files, AudioPlayMode.BackgroundLoop)
    End Sub
End Class