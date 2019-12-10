Public Class ViewRecords
    Private Sub ViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_ticket(view_record_datagrid)

        Me.view_record_datagrid.Columns("Id").Visible = False
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
