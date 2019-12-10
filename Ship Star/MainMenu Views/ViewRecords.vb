Public Class ViewRecords
    Private Sub ViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_ticket(view_record_datagrid)

        Me.view_record_datagrid.Columns("Id").Visible = False

        Me.view_record_datagrid.Columns(1).HeaderText = "Ticket Number"
        Me.view_record_datagrid.Columns(2).HeaderText = "Destination"
        Me.view_record_datagrid.Columns(3).HeaderText = "Date Sail"
        Me.view_record_datagrid.Columns(4).HeaderText = "Ship Name"
        Me.view_record_datagrid.Columns(5).HeaderText = "Accommodation Type"
        Me.view_record_datagrid.Columns(6).HeaderText = "Seat Number"
        Me.view_record_datagrid.Columns(7).HeaderText = "Passenger Name"
        Me.view_record_datagrid.Columns(8).HeaderText = "Passenger Age"
        Me.view_record_datagrid.Columns(9).HeaderText = "Fare Type"
        Me.view_record_datagrid.Columns(10).HeaderText = "Date Booked"
    End Sub

    Private Sub View_record_datagrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles view_record_datagrid.CellDoubleClick
        Id = view_record_datagrid.SelectedCells(0).Value.ToString()
        seat_number_D = view_record_datagrid.SelectedCells(6).Value.ToString()
        ship_name_D = view_record_datagrid.SelectedCells(4).Value.ToString()
        date_sail_D = view_record_datagrid.SelectedCells(3).Value.ToString()
        accommodation_type_D = view_record_datagrid.SelectedCells(5).Value.ToString()


        Dim custom As New Custom_Controller_Form()
        custom.ShowDialog()
        ViewRecords_Load(sender, e)
    End Sub
End Class
