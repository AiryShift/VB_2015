Public Class CurrencyChange
    Dim CURRENTRATE_OFUSA As Decimal
    Dim selectedCountry As String = "USD"

    Private Sub pbFrom(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If GlobalVariables.CurrentCountry = "fran" Then
            pbFlagTo.Image = My.Resources.french
            CURRENTRATE_OFUSA = 0.89
        ElseIf GlobalVariables.CurrentCountry = "den" Then
            pbFlagTo.Image = My.Resources.DENMARK
            CURRENTRATE_OFUSA = 6.68
        Else  ' GlobalVariables.CurrentCountry = "bos"
            pbFlagTo.Image = My.Resources.bosnia
            CURRENTRATE_OFUSA = 1.75053  ' Bosnian Convertible Marka
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        country.Show()
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles vSclCurValue.Scroll
        lblFrom.Text = vSclCurValue.Value
        If selectedCountry = "USD" Then
            lblTo.Text = vSclCurValue.Value * CURRENTRATE_OFUSA
        ElseIf selectedCountry = "EUR" Then
            lblTo.Text = vSclCurValue.Value * CURRENTRATE_OFUSA / 0.89
        Else  ' selectedCountry = "AUD"
            lblTo.Text = vSclCurValue.Value * CURRENTRATE_OFUSA / 1.28
        End If
    End Sub

    Private Sub rdbUSA_CheckedChanged(sender As Object, e As EventArgs) Handles rdbUSA.CheckedChanged
        selectedCountry = "USD"
        lblTo.Text = vSclCurValue.Value * CURRENTRATE_OFUSA
        pbFlagFrom.Image = My.Resources.usa
    End Sub

    Private Sub rdbEurope_CheckedChanged(sender As Object, e As EventArgs) Handles rdbEurope.CheckedChanged
        selectedCountry = "EUR"
        lblTo.Text = vSclCurValue.Value * CURRENTRATE_OFUSA / 0.89
        pbFlagFrom.Image = My.Resources.eu_flag
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAUS.CheckedChanged
        selectedCountry = "AUD"
        lblTo.Text = vSclCurValue.Value * CURRENTRATE_OFUSA / 1.28
        pbFlagFrom.Image = My.Resources.australia
    End Sub
End Class