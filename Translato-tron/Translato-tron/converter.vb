Public Class converter
    Dim CURRENTRATE_OFUSA As Decimal

    Private Sub pbFrom(sender As Object, e As EventArgs) Handles Me.GotFocus
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
        Me.Visible = False
        country.Visible = True
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles vSclCurValue.Scroll
    End Sub
End Class