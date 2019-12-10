Public Class Available_Ship_View
    Private Sub Available_Ship_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_availableShip(available_ship_datagridview)

        Me.available_ship_datagridview.Columns("Id").Visible = False
    End Sub
End Class
