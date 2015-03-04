Public Class country

    Private Sub initialize(sender As Object, e As EventArgs) Handles MyBase.Activated
        If GlobalVariables.CurrentCountry = "fran" Then
            lblCountryTo.Text = "French"
        ElseIf GlobalVariables.CurrentCountry = "den" Then
            lblCountryTo.Text = "Danish"
        Else  ' GlobalVariables.CurrentCountry = "bos"
            lblCountryTo.Text = "Bosnian"
        End If
        rdb1.Checked = True
        translate(1)
        txt2.Text = ""
        txt10.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        mainScreen.Show()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Me.Hide()
        CurrencyChange.Show()
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

        If extra <> "" Then
            txtTranslated.Text = writeString + " " + extra
        Else
            txtTranslated.Text = writeString
        End If
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

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged
        translate(2, txt2.Text)
    End Sub

    Private Sub rdb3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb3.CheckedChanged
        translate(3)
    End Sub

    Private Sub rdb4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb4.CheckedChanged
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

    Private Sub txt10_TextChanged(sender As Object, e As EventArgs) Handles txt10.TextChanged
        translate(10, txt10.Text)
    End Sub

    Private Sub chkHide_CheckedChanged(sender As Object, e As EventArgs) Handles chkHide.CheckedChanged
        If chkHide.Checked = True Then
            rdb1.Text = ""
            rdb2.Text = ""
            rdb3.Text = ""
            rdb4.Text = ""
            rdb5.Text = ""
            rdb6.Text = ""
            rdb7.Text = ""
            rdb8.Text = ""
            rdb9.Text = ""
            rdb10.Text = ""
        Else
            GlobalVariables.English.TryGetValue(1, rdb1.Text)
            GlobalVariables.English.TryGetValue(2, rdb2.Text)
            GlobalVariables.English.TryGetValue(3, rdb3.Text)
            GlobalVariables.English.TryGetValue(4, rdb4.Text)
            GlobalVariables.English.TryGetValue(5, rdb5.Text)
            GlobalVariables.English.TryGetValue(6, rdb6.Text)
            GlobalVariables.English.TryGetValue(7, rdb7.Text)
            GlobalVariables.English.TryGetValue(8, rdb8.Text)
            GlobalVariables.English.TryGetValue(9, rdb9.Text)
            GlobalVariables.English.TryGetValue(10, rdb10.Text)
        End If
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        Dim rand As New Random
        Dim num As Integer = rand.Next(1, 11)
        If num = 1 Then
            rdb1.Checked = True
        ElseIf num = 2 Then
            rdb2.Checked = True
        ElseIf num = 3 Then
            rdb3.Checked = True
        ElseIf num = 4 Then
            rdb4.Checked = True
        ElseIf num = 5 Then
            rdb5.Checked = True
        ElseIf num = 6 Then
            rdb6.Checked = True
        ElseIf num = 7 Then
            rdb7.Checked = True
        ElseIf num = 8 Then
            rdb8.Checked = True
        ElseIf num = 9 Then
            rdb9.Checked = True
        Else  ' num = 10
            rdb10.Checked = True
        End If
    End Sub
End Class