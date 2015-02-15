Public Class Fonts

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub chkBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold.CheckedChanged, chkItalic.CheckedChanged
        If chkBold.Checked Then
            If chkItalic.Checked Then  ' i and b
                txtInput.Font = New Font("")
            Else  ' b
                txtInput.Font = New Font("")
            End If
        ElseIf chkItalic.Checked Then  ' i
            txtEntry.Font = New Font("")
        Else
            txtEntry.Font = New Font("")
        End If
    End Sub
End Class
