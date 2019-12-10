Public Class Custom_Controller_Form
    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles cancel_button.Click
        Me.Close()
    End Sub

    Private Sub Delete_button_Click(sender As Object, e As EventArgs) Handles delete_button.Click
        delete_ticket(Id, seat_number_D, ship_name_D, date_sail_D, accommodation_type_D)
        MessageBox.Show("Deleted!")
        Me.Close()
    End Sub

    Private Sub Edit_button_Click(sender As Object, e As EventArgs) Handles edit_button.Click
        Dim update As New Update_Form()

        Me.Close()
        update.ShowDialog()
    End Sub
End Class