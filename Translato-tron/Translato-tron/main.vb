Public Class mainScreen
    Dim highlight As Boolean = False

    Private Sub pbDenmark_Click(sender As Object, e As EventArgs) Handles pbDenmark.MouseEnter, pbDenmark.MouseLeave
        If highlight = False Then
            pbDenmark.Image = My.Resources.denmark_flag
            pcbWorldMap.Image = My.Resources.europe_denmark
            lblName_1.Show()
            highlight = True
        Else
            pbDenmark.Image = My.Resources.DENMARK
            pcbWorldMap.Image = My.Resources.blank_europe_map
            lblName_1.Hide()
            highlight = False
        End If

    End Sub

    Private Sub pbFrench_Click(sender As Object, e As EventArgs) Handles pbFrench.MouseEnter, pbFrench.MouseLeave
        If highlight = False Then
            pbFrench.Image = My.Resources.france_flag_thing
            pcbWorldMap.Image = My.Resources.europe_france
            lblName_2.Show()
            highlight = True
        Else
            pbFrench.Image = My.Resources.french
            pcbWorldMap.Image = My.Resources.blank_europe_map
            lblName_2.Hide()
            highlight = False
        End If

    End Sub

    Private Sub pbBosnia_Click(sender As Object, e As EventArgs) Handles pbBosnia.MouseEnter, pbBosnia.MouseLeave
        If highlight = False Then
            pbBosnia.Image = My.Resources.bosnia_flag
            pcbWorldMap.Image = My.Resources.europe_bosnia
            lblName_3.Show()
            highlight = True
        Else
            pbBosnia.Image = My.Resources.bosnia
            pcbWorldMap.Image = My.Resources.blank_europe_map
            lblName_3.Hide()
            highlight = False
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        formExit.ShowDialog()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Hide()
        help.Show()
    End Sub

    Public Sub openLanguage(lang As String)
        Me.Hide()
        GlobalVariables.CurrentCountry = lang
        country.Show()
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
