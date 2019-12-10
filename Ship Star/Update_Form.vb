Public Class Update_Form
    Private Sub Cancel_button_Click(sender As Object, e As EventArgs) Handles cancel_button.Click
        Me.Close()
    End Sub

    Private Sub Update_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mydata() As String = get_data_ticket(Id)

        ticket_number_text.Text = mydata(0)
        destination_textbox.Text = mydata(1)
        date_sail_datepicker.Value = mydata(2)
        ship_name_textbox.Text = mydata(3)
        accomodation_textbox.Text = mydata(4)
        seat_number_textbox.Text = mydata(5)
        passenger_name_textbox.Text = mydata(6)
        passenger_age_textbox.Text = mydata(7)
        fare_type_dropdown.Text = mydata(8)
    End Sub

    Private Sub Update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click
        If update_ticket(Id, passenger_name_textbox.Text, passenger_age_textbox.Text, fare_type_dropdown.Text, DateTime.Today) Then
            MessageBox.Show("Updated!")
            Me.Close()
        Else
            MessageBox.Show("Update Fail!")
        End If

    End Sub
End Class