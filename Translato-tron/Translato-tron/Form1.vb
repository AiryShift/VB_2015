Public Class mainScreen
    Dim highlight As Boolean = False

    Private Sub mainScreen_Load(sender As Object, e As EventArgs) Handles _
        pbDenmark.MouseLeave, pbDenmark.MouseEnter, _
        pbAzerbaijan.MouseEnter, pbAzerbaijan.MouseLeave, _
        pbFrench.MouseEnter, pbFrench.MouseLeave
        If highlight = True Then
            Me.BackgroundImage = My.Resources.redTriangle
        Else
            Me.BackgroundImage = My.Resources.triangle
        End If

    End Sub

    Private Sub pbDenmark_Click(sender As Object, e As EventArgs) Handles _
        pbDenmark.MouseEnter, pbDenmark.MouseLeave
        If highlight = False Then
            pbDenmark.Image = My.Resources.denmark_flag
            highlight = True
        Else
            pbDenmark.Image = My.Resources.DENMARK
            highlight = False
        End If

    End Sub

    Private Sub pbFrench_Click(sender As Object, e As EventArgs) Handles _
        pbFrench.MouseEnter, pbFrench.MouseLeave
        If highlight = False Then
            pbFrench.Image = My.Resources.french_flag
            highlight = True
        Else
            pbFrench.Image = My.Resources.french
            highlight = False
        End If

    End Sub
End Class
