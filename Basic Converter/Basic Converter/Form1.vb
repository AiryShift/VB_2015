Public Class CurrencyExchange
    Dim money As String = "USD"
    Dim USDRATE As Decimal = 0.78
    Dim GBRATE As Decimal = 0.51
    Dim BITRATE As Decimal = 0.0035
    Dim DOGERATE As Decimal = 5533

    Public Sub currencyChange(rate)
        lblOther.Text = rate * hsbSlider.Value
    End Sub

    Private Sub hsbSlider_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbSlider.Scroll
        lblScrollInst.Visible = False

        lblAus.Text = hsbSlider.Value
        If money = "USD" Then
            currencyChange(USDRATE)
        ElseIf money = "GB" Then
            currencyChange(GBRATE)
        ElseIf money = "BitCoin" Then
            currencyChange(BITRATE)
        Else  ' Money == DogeCoin
            currencyChange(DOGERATE)
        End If
    End Sub

    Private Sub rdbUSD_CheckedChanged(sender As Object, e As EventArgs) Handles rdbUSD.CheckedChanged
        money = "USD"
        currencyChange(USDRATE)
        plcOther.Image = My.Resources._06_13_2013_us_flag
    End Sub

    Private Sub rdbGB_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGB.CheckedChanged
        money = "GB"
        currencyChange(GBRATE)
        plcOther.Image = My.Resources._1280px_Flag_of_the_United_Kingdom_svg
        lblSwitchInst.Visible = False
    End Sub

    Private Sub rdbBitCoin_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBitCoin.CheckedChanged
        money = "BitCoin"
        currencyChange(BITRATE)
        plcOther.Image = My.Resources.BitcoinLogo
        lblSwitchInst.Visible = False
    End Sub

    Private Sub rdbDogeCoin_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDogeCoin.CheckedChanged
        money = "DogeCoin"
        currencyChange(DOGERATE)
        plcOther.Image = My.Resources.dogecoin_300
        lblSwitchInst.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
