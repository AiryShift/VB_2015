Public Class country

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        mainScreen.Visible = True
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Me.Visible = False
        converter.Visible = True
    End Sub

    Private Sub lblCountryTo_Click(sender As Object, e As EventArgs) Handles Me.GotFocus
        If GlobalVariables.CurrentCountry = "fran" Then
            lblCountryTo.Text = "French"
        ElseIf GlobalVariables.CurrentCountry = "den" Then
            lblCountryTo.Text = "Danish"
        Else  ' GlobalVariables.CurrentCountry = "bos"
            lblCountryTo.Text = "Bosnian"
        End If

    End Sub
End Class