Public Class HelpForm
    Private Sub HelpForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoginForm.Hide()
        'The login form is hidden, just in case it is still open.
    End Sub

    Private Sub cmbReturn_Click(sender As Object, e As EventArgs) Handles cmbReturn.Click
        Me.Hide()
        'The help form is hidden if the return button is clicked.
    End Sub

    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class