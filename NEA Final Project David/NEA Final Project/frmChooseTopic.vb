Public Class frmChooseTopic
    Private Sub btnTreeTraversing_Click(sender As Object, e As EventArgs) Handles btnTreeTraversing.Click
        Me.Close() 'Doesn't close down the form, just hides it so use End later to close forms
        frmTreeTraversing.Show()
    End Sub

    Private Sub btnRPN_Click(sender As Object, e As EventArgs) Handles btnRPN.Click
        Me.Close() 'Doesn't close down the form, just hides it so use End later to close forms
        frmRPN.Show()
    End Sub

    Private Sub btnCloseProgram_Click(sender As Object, e As EventArgs) Handles btnCloseProgram.Click
        End
    End Sub

End Class
