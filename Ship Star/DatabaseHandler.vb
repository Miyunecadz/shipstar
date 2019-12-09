Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Module DatabaseHandler
    Private _ConString As String
    Private _Con As SqlConnection
    Private _Cmd As SqlCommand


    Private Sub InitializeConnection()
        Dim path As String = Application.StartupPath.Replace("bin\Debug", "")
        Dim pathwDatabase As String = path + "StarShip_Database.mdf"
        _ConString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename='" + pathwDatabase + "'; Integrated Security=True"

        Try
            _Con = New SqlConnection(_ConString)
            _Con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Function login(ByVal username, ByVal password)
        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("Select * from users where usernames = '@username' and passwords = '@password'", _Con)
        _Cmd.Parameters.Add("@username", username)
        _Cmd.Parameters.Add("@password", password)
        _Cmd.ExecuteNonQuery()

        Dim rdr As SqlDataReader = _Cmd.ExecuteReader

        'close connection
        _Con.Close()

        'return true or false
        'rdr.HasRows ( True = Has rows or sakto and username ug password, False = Empty or wrong password or username
        Return rdr.HasRows
    End Function

End Module
