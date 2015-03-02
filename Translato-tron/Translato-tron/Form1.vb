Public Class mainScreen
    Dim highlight As Boolean = False

    Private Sub mainScreen_Load(sender As Object, e As EventArgs) Handles pbDenmark.MouseEnter, pbDenmark.MouseLeave,
        pbBosnia.MouseEnter, pbBosnia.MouseLeave,
        pbFrench.MouseEnter, pbFrench.MouseLeave

        If highlight = False Then
            Me.BackgroundImage = My.Resources.redTriangle
        Else
            Me.BackgroundImage = My.Resources.triangle
        End If

    End Sub

    Private Sub pbDenmark_Click(sender As Object, e As EventArgs) Handles pbDenmark.MouseEnter, pbDenmark.MouseLeave
        If highlight = False Then
            pbDenmark.Image = My.Resources.denmark_flag
            highlight = True
        Else
            pbDenmark.Image = My.Resources.DENMARK
            highlight = False
        End If

    End Sub

    Private Sub pbFrench_Click(sender As Object, e As EventArgs) Handles pbFrench.MouseEnter, pbFrench.MouseLeave
        If highlight = False Then
            pbFrench.Image = My.Resources.french_flag
            highlight = True
        Else
            pbFrench.Image = My.Resources.french
            highlight = False
        End If

    End Sub

    Private Sub pbBosnia_Click(sender As Object, e As EventArgs) Handles pbBosnia.MouseEnter, pbBosnia.MouseLeave
        If highlight = False Then
            pbBosnia.Image = My.Resources.bosnia_flag
            highlight = True
        Else
            pbBosnia.Image = My.Resources.bosnia
            highlight = False
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Visible = False
        formExit.Visible = True
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Visible = False
        help.Visible = True
    End Sub

    Public Sub openLanguage(lang As String)
        Me.Visible = False
        GlobalVariables.CurrentCountry = lang
        country.Visible = True
    End Sub

    Private Sub pbDenmark_Click_1(sender As Object, e As EventArgs) Handles pbDenmark.Click
        openLanguage("den")
    End Sub

    Private Sub pbFrench_Click_1(sender As Object, e As EventArgs) Handles pbFrench.Click
        openLanguage("fran")
    End Sub

    Private Sub pbBosnia_Click_1(sender As Object, e As EventArgs) Handles pbBosnia.Click
        openLanguage("bos")
    End Sub
End Class
