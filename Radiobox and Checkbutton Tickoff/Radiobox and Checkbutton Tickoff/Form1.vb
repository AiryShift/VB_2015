Public Class Fonts

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        formExit.Show()
    End Sub

    Private Sub chkBold_CheckedChanged(sender As Object, e As EventArgs) Handles _
        chkBold.CheckedChanged, chkItalic.CheckedChanged
        If chkBold.Checked Then
            If chkItalic.Checked Then  ' i and b
                txtInput.Font = New Font(txtInput.Font.FontFamily, txtInput.Font.Size,
                                         FontStyle.Bold Or FontStyle.Italic)
            Else  ' b
                txtInput.Font = New Font(txtInput.Font.FontFamily, txtInput.Font.Size,
                                         FontStyle.Bold)
            End If
        ElseIf chkItalic.Checked Then  ' i
            txtInput.Font = New Font(txtInput.Font.FontFamily, txtInput.Font.Size,
                                     FontStyle.Italic)
        Else
            txtInput.Font = New Font(txtInput.Font.FontFamily, txtInput.Font.Size,
                                     FontStyle.Regular)
        End If
    End Sub

    Private Sub rdbFontJoke_CheckedChanged(sender As Object, e As EventArgs) Handles _
        rdbFontJoke.CheckedChanged, rdbFontComic.CheckedChanged
        If rdbFontJoke.Checked Then
            txtInput.Font = New Font("Jokerman", txtInput.Font.Size,
                                     txtInput.Font.Style)
        ElseIf rdbFontComic.Checked Then
            txtInput.Font = New Font("Comic Sans", txtInput.Font.Size,
                                     txtInput.Font.Style)
        End If
    End Sub
End Class
