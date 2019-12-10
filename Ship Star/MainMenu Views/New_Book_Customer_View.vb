Public Class New_Book_Customer_View
    Private Sub New_Book_Customer_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For x As Integer = 1 To 20
            seat_number_dropdown.Items.Add(x)
        Next

        date_sail_datepicker.MinDate = Date.Today
        date_sail_datepicker.MaxDate = Date.Today.AddDays(2)

        ship_name_dropdown.SelectedIndex = 0
        accommodation_type_dropdown.SelectedIndex = 0
        seat_number_dropdown.SelectedIndex = 0
        destination_dropdown.SelectedIndex = 0
        fare_type_dropdown.SelectedIndex = 0

        ticket_number_text.Text = generate_ticket()

    End Sub

    Private Sub Destination_dropdown_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles destination_dropdown.SelectedIndexChanged
        If destination_dropdown.SelectedIndex = 0 Then
            ship_name_dropdown.Items.Clear()
            ship_name_dropdown.Items.Add("Ship1 : Morning")
            ship_name_dropdown.Items.Add("Ship2 : Evening")
        ElseIf destination_dropdown.SelectedIndex = 1 Then
            ship_name_dropdown.Items.Clear()
            ship_name_dropdown.Items.Add("Ship1 : Evening")
            ship_name_dropdown.Items.Add("Ship2 : Morning")
        End If

        ship_name_dropdown.SelectedIndex = 0
    End Sub

    Private Sub Book_customer_button_Click(sender As Object, e As EventArgs) Handles book_customer_button.Click
        Dim ticket_number As Integer = Integer.Parse(ticket_number_text.Text)
        Dim destination As String = destination_dropdown.Text
        Dim date_sail As DateTime = date_sail_datepicker.Value
        Dim ship_name As String = ship_name_dropdown.Text
        Dim accommodation As String = accommodation_type_dropdown.Text
        Dim seat_number As Integer = Integer.Parse(seat_number_dropdown.Text)
        Dim passenger_name As String = passenger_name_textbox.Text
        Dim passenger_age As String = passenger_age_textbox.Text
        Dim fare_type As String = fare_type_dropdown.Text
        Dim date_booked As DateTime = date_booked_datepicker.Value

        If destination = "" Or
                ship_name = "" Or
                accommodation = "" Or
                passenger_name = "" Or
                fare_type = "" Then
            MessageBox.Show("Please Fill-up all the requirements")
        Else
            If create_ticket(ticket_number, date_sail, ship_name, accommodation, seat_number, destination, passenger_name, passenger_age, fare_type, date_booked) Then
                MessageBox.Show("New Record Added!")
                Clear_all_button_Click(sender, e)
                New_Book_Customer_View_Load(sender, e)
            Else
                MessageBox.Show("Unable to save!")
            End If

        End If


    End Sub

    Private Sub Clear_all_button_Click(sender As Object, e As EventArgs) Handles clear_all_button.Click
        destination_dropdown.SelectedIndex = 0
        date_sail_datepicker.Value = Date.Today
        ship_name_dropdown.SelectedIndex = 0
        accommodation_type_dropdown.SelectedIndex = 0
        seat_number_dropdown.SelectedIndex = 0
        passenger_name_textbox.Text = ""
        passenger_age_textbox.Text = ""
        fare_type_dropdown.SelectedIndex = 0
    End Sub

    Private Sub Pasenger_age_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passenger_age_textbox.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Accommodation_type_dropdown_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles accommodation_type_dropdown.SelectedIndexChanged

        If accommodation_type_dropdown.SelectedIndex = 0 Then
            overall_price_label.Text = ECONOMY

        ElseIf accommodation_type_dropdown.SelectedIndex = 1 Then
            overall_price_label.Text = TOURIST


        ElseIf accommodation_type_dropdown.SelectedIndex = 2 Then
            overall_price_label.Text = SITTING
        End If

        If ship_name_dropdown.Text <> "" Then
            If accommodation_type_dropdown.SelectedIndex = 0 Then

                Dim seats() As String = get_remainingSeats(ship_name_dropdown.Text, date_sail_datepicker.Value, "Economy")

                seat_number_dropdown.Items.Clear()

                For i As Integer = 0 To seats.Length - 1
                    seat_number_dropdown.Items.Add(seats(i))
                Next

            ElseIf accommodation_type_dropdown.SelectedIndex = 1 Then

                Dim seats() As String = get_remainingSeats(ship_name_dropdown.Text, date_sail_datepicker.Value, "Tourist")

                seat_number_dropdown.Items.Clear()

                For i As Integer = 0 To seats.Length - 1
                    seat_number_dropdown.Items.Add(seats(i))
                Next

            ElseIf accommodation_type_dropdown.SelectedIndex = 2 Then

                Dim seats() As String = get_remainingSeats(ship_name_dropdown.Text, date_sail_datepicker.Value, "Sitting")

                seat_number_dropdown.Items.Clear()

                For i As Integer = 0 To seats.Length - 1
                    seat_number_dropdown.Items.Add(seats(i))
                Next
            End If
        End If
    End Sub

    Private Sub Fare_type_dropdown_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles fare_type_dropdown.SelectedIndexChanged
        Dim price As Double
        Dim overall_price As Double

        If accommodation_type_dropdown.SelectedIndex = 0 Then
            price = ECONOMY
        ElseIf accommodation_type_dropdown.SelectedIndex = 1 Then
            price = TOURIST
        ElseIf accommodation_type_dropdown.SelectedIndex = 2 Then
            price = SITTING
        End If

        If fare_type_dropdown.SelectedIndex = 0 Then
            overall_price = price * 1
        ElseIf fare_type_dropdown.SelectedIndex = 1 Then
            overall_price = price - (price * 0.2)
        ElseIf fare_type_dropdown.SelectedIndex = 2 Then
            overall_price = price - (price * 0.25)
        ElseIf fare_type_dropdown.SelectedIndex = 3 Then
            overall_price = price - (price * 0.4)
        End If
        overall_price_label.Text = overall_price.ToString()
    End Sub

    Private Sub Ship_name_dropdown_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ship_name_dropdown.SelectedIndexChanged
        checkOrCreate_available(ship_name_dropdown.Text, date_sail_datepicker.Value)


        If accommodation_type_dropdown.SelectedIndex = 0 Then

            Dim seats() As String = get_remainingSeats(ship_name_dropdown.Text, date_sail_datepicker.Value, "Economy")

            seat_number_dropdown.Items.Clear()

            For i As Integer = 0 To seats.Length - 1
                seat_number_dropdown.Items.Add(seats(i))
            Next

        ElseIf accommodation_type_dropdown.SelectedIndex = 1 Then

            Dim seats() As String = get_remainingSeats(ship_name_dropdown.Text, date_sail_datepicker.Value, "Tourist")

            seat_number_dropdown.Items.Clear()

            For i As Integer = 0 To seats.Length - 1
                seat_number_dropdown.Items.Add(seats(i))
            Next

        ElseIf accommodation_type_dropdown.SelectedIndex = 2 Then

            Dim seats() As String = get_remainingSeats(ship_name_dropdown.Text, date_sail_datepicker.Value, "Sitting")

            seat_number_dropdown.Items.Clear()

            For i As Integer = 0 To seats.Length - 1
                seat_number_dropdown.Items.Add(seats(i))
            Next
        End If
    End Sub

    Private Sub Date_sail_datepicker_ValueChanged(sender As Object, e As EventArgs) Handles date_sail_datepicker.ValueChanged
        If ship_name_dropdown.Text <> "" And accommodation_type_dropdown.Text <> "" Then
            checkOrCreate_available(ship_name_dropdown.Text, date_sail_datepicker.Value)

            If accommodation_type_dropdown.SelectedIndex = 0 Then

                Dim seats() As String = get_remainingSeats(ship_name_dropdown.Text, date_sail_datepicker.Value, "Economy")

                seat_number_dropdown.Items.Clear()

                For i As Integer = 0 To seats.Length - 1
                    seat_number_dropdown.Items.Add(seats(i))
                Next

            ElseIf accommodation_type_dropdown.SelectedIndex = 1 Then

                Dim seats() As String = get_remainingSeats(ship_name_dropdown.Text, date_sail_datepicker.Value, "Tourist")

                seat_number_dropdown.Items.Clear()

                For i As Integer = 0 To seats.Length - 1
                    seat_number_dropdown.Items.Add(seats(i))
                Next

            ElseIf accommodation_type_dropdown.SelectedIndex = 2 Then

                Dim seats() As String = get_remainingSeats(ship_name_dropdown.Text, date_sail_datepicker.Value, "Sitting")

                seat_number_dropdown.Items.Clear()

                For i As Integer = 0 To seats.Length - 1
                    seat_number_dropdown.Items.Add(seats(i))
                Next
            End If
        End If
    End Sub
End Class
