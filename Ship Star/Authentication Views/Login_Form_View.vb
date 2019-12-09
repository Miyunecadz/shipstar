Public Class Login_Form_View
    Private Sub Login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        'username_textbox = username
        'password_textbox = password

        Dim db_response As Boolean =  DatabaseHandler.login(username_textbox.Text, password_textbox.Text)
        
        If db_response Then
            
        else 

            MessageBox.Show("Wrong Username/Password!")
        End If
    End Sub
End Class
