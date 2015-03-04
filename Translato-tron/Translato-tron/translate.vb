Public Class country

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        mainScreen.Show()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Me.Hide()
        CurrencyChange.Show()
    End Sub

    Private Sub lblCountryTo_Click(sender As Object, e As EventArgs) Handles MyBase.Activated
        If GlobalVariables.CurrentCountry = "fran" Then
            lblCountryTo.Text = "French"
        ElseIf GlobalVariables.CurrentCountry = "den" Then
            lblCountryTo.Text = "Danish"
        Else  ' GlobalVariables.CurrentCountry = "bos"
            lblCountryTo.Text = "Bosnian"
        End If
    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged
        translate(2, txt2.Text)
    End Sub

    Private Sub txt10_TextChanged(sender As Object, e As EventArgs) Handles txt10.TextChanged
        translate(10, txt10.Text)
    End Sub

    Public Sub translate(rdbNum As Integer, Optional ByVal extra As String = "")
        Dim writeString As String = ""
        If GlobalVariables.CurrentCountry = "fran" Then
            GlobalVariables.French.TryGetValue(rdbNum, writeString)
        ElseIf GlobalVariables.CurrentCountry = "den" Then
            GlobalVariables.Danish.TryGetValue(rdbNum, writeString)
        Else  ' GlobalVariables.CurrentCountry = "bos"
            GlobalVariables.Bosnian.TryGetValue(rdbNum, writeString)
        End If

        txtTranslated.Text = writeString + " " + extra
    End Sub

    Private Sub rdb1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb1.CheckedChanged
        translate(1)
    End Sub

    Private Sub rdb2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb2.CheckedChanged
        translate(2)
        If txt2.ReadOnly = False Then
            txt2.ReadOnly = True
        Else
            txt2.ReadOnly = False
        End If
    End Sub

    Private Sub rdb3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb3.CheckedChanged
        translate(3)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        translate(4)
    End Sub

    Private Sub rdb5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb5.CheckedChanged
        translate(5)
    End Sub

    Private Sub rdb6_CheckedChanged(sender As Object, e As EventArgs) Handles rdb6.CheckedChanged
        translate(6)
    End Sub

    Private Sub rdb7_CheckedChanged(sender As Object, e As EventArgs) Handles rdb7.CheckedChanged
        translate(7)
    End Sub

    Private Sub rdb8_CheckedChanged(sender As Object, e As EventArgs) Handles rdb8.CheckedChanged
        translate(8)
    End Sub

    Private Sub rdb9_CheckedChanged(sender As Object, e As EventArgs) Handles rdb9.CheckedChanged
        translate(9)
    End Sub

    Private Sub rdb10_CheckedChanged(sender As Object, e As EventArgs) Handles rdb10.CheckedChanged
        translate(10)
        If txt10.ReadOnly = True Then
            txt10.ReadOnly = False
        Else
            txt10.ReadOnly = True
        End If
    End Sub
End Class