Public Class Authentication_Form
    Private Sub Login_button_menu_panel_Click(sender As Object, e As EventArgs) Handles login_button_menu_panel.Click
        Dim loginviewform As New Login_Form_View()

        content_panel.Controls.Clear()
        content_panel.Controls.Add(loginviewform)
    End Sub

    Private Sub Signup_button_menu_panel_Click(sender As Object, e As EventArgs) Handles signup_button_menu_panel.Click
        Dim signviewform As New SignUp_Form_View()

        content_panel.Controls.Clear()
        content_panel.Controls.Add(signviewform)
    End Sub

    Private Sub Authentication_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login_button_menu_panel_Click(sender, e)
    End Sub

    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_button.Click
        Environment.Exit(0)
    End Sub
End Class