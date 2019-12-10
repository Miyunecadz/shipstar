Public Class MainMenu_Form
    Private Sub Menubar_panel_Paint(sender As Object, e As PaintEventArgs) Handles menubar_panel.Paint

    End Sub

    Private Sub Book_new_customer_button_Click(sender As Object, e As EventArgs) Handles book_new_customer_button.Click
        Dim newbookcustomerview As New New_Book_Customer_View()

        content_panel.Controls.Clear()
        content_panel.Controls.Add(newbookcustomerview)
    End Sub

    Private Sub Available_ship_button_Click(sender As Object, e As EventArgs) Handles available_ship_button.Click
        Dim availableshipview As New Available_Ship_View()

        content_panel.Controls.Clear()
        content_panel.Controls.Add(availableshipview)
    End Sub

    Private Sub Logout_button_Click(sender As Object, e As EventArgs) Handles logout_button.Click
        Me.Close()

        Dim auth As New Authentication_Form()
        auth.Show()
    End Sub

    Private Sub View_records_button_Click(sender As Object, e As EventArgs) Handles view_records_button.Click
        Dim viewrecord As New ViewRecords()

        content_panel.Controls.Clear()
        content_panel.Controls.Add(viewrecord)
    End Sub
End Class
