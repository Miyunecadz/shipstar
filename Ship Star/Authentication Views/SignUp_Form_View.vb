Public Class SignUp_Form_View
    Private Sub SignUp_Form_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        branch_dropdown.SelectedIndex = 0
    End Sub

    Private Sub Signup_button_Click(sender As Object, e As EventArgs) Handles signup_button.Click
        Dim fullname As String = fullname_textbox.Text
        Dim username As String = username_textbox.Text
        Dim password As String = password_textbox.Text
        Dim branch As String = branch_dropdown.Text

        If fullname = "" Or username = "" Or password = "" Then
            MessageBox.Show("Please fill-up all requirements")
        Else

            If DatabaseHandler.signUp(username, password, fullname, branch) Then
                MessageBox.Show("New User Created!")
                fullname_textbox.Text = ""
                username_textbox.Text = ""
                password_textbox.Text = ""
            Else
                MessageBox.Show("Error! Failed to create user.")
            End If

        End If

    End Sub
End Class
