Public Class help

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        My.Computer.Audio.Play(My.Resources.x_files, AudioPlayMode.BackgroundLoop)
    End Sub
End Class