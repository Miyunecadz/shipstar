Public Class Available_Ship_View
    Private Sub Available_Ship_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_availableShip(available_ship_datagridview)

        Me.available_ship_datagridview.Columns("Id").Visible = False

        Me.available_ship_datagridview.Columns(1).HeaderText = "Ship Name"
        Me.available_ship_datagridview.Columns(2).HeaderText = "Dates"
        Me.available_ship_datagridview.Columns(3).HeaderText = "Available Seats"
        Me.available_ship_datagridview.Columns(4).HeaderText = "Accommodation Type"
    End Sub
End Class
