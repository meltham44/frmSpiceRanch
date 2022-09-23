Public Class LoginForm
    Private Sub LoginForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MainForm.Hide()
        HelpForm.Hide()
        'This makes sure the user can't access the main Spice Ranch form before logging in.
    End Sub

    Private Sub cmbLogin_Click(sender As Object, e As EventArgs) Handles cmbLogin.Click
        If txtUsername.Text = "admin" Then
            If txtPassword.Text = "password" Then
                MainForm.Show()
            Else
                MsgBox("Username or password is wrong.")
            End If
        Else
            MsgBox("Username or password is wrong.")
        End If
        'The username and password are checked and if wrong, a message box tells the user that the information is incorrect and denies access to the Spice Ranch form.
    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        End
        'The program closes when the end button is clicked.
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class