Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Module DatabaseHandler
    Private _ConString As String
    Private _Con As SqlConnection
    Private _Cmd As SqlCommand
    Private _Adapter As SqlDataAdapter
    Private _Table As DataTable

    Public Const ECONOMY As Double = 300
    Public Const TOURIST As Double = 450
    Public Const SITTING As Double = 250
    Public Id As Integer
    Public seat_number_D As String
    Public date_sail_D As DateTime
    Public ship_name_D As String
    Public accommodation_type_D As String


    'ByVal id As Integer, ByVal seat_book As String, ByVal remaining_seats() As String, ByVal ship_name As String, ByVal dates As DateTime, ByVal accommodation_type As String
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

    'Login
    Public Function login(ByVal username, ByVal password)
        Dim result As Boolean

        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("Select * from users where usernames = @username and passwords = @password", _Con)
        _Cmd.Parameters.AddWithValue("@username", username)
        _Cmd.Parameters.AddWithValue("@password", password)
        _Cmd.ExecuteNonQuery()

        Dim rdr As SqlDataReader = _Cmd.ExecuteReader

        result = rdr.HasRows

        'close connection
        _Con.Close()

        'return true or false
        'rdr.HasRows ( True = Has rows or sakto and username ug password, False = Empty or wrong password or username)
        Return result
    End Function

    'Sign-up
    Public Function signUp(ByVal username, ByVal password, ByVal fullname, ByVal branch)
        Dim result As Boolean = False

        If checkUsername(username) Then
            result = False
        Else
            'initialize database connection
            InitializeConnection()

            _Cmd = New SqlCommand("insert into users(usernames, passwords, fullnames, branch) values(@username, @password, @fullname, @branch)", _Con)
            _Cmd.Parameters.AddWithValue("@username", username)
            _Cmd.Parameters.AddWithValue("@password", password)
            _Cmd.Parameters.AddWithValue("@fullname", fullname)
            _Cmd.Parameters.AddWithValue("@branch", branch)

            Try
                _Cmd.ExecuteNonQuery()
                result = True
            Catch ex As Exception
                'do nothing
            End Try


            'Close connection
            _Con.Close()
        End If

        'result (True = insert successful, False = username exist or insert unsuccessful)
        Return result
    End Function

    'check username exist
    Private Function checkUsername(ByVal username)
        Dim result As Boolean

        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("Select * from users where usernames = '@username'", _Con)
        _Cmd.Parameters.AddWithValue("@username", username)
        _Cmd.ExecuteNonQuery()

        Dim rdr As SqlDataReader = _Cmd.ExecuteReader

        result = rdr.HasRows
        'Close connection
        _Con.Close()

        'rdr.HasRows ( True = Has rows or username exist, False = Empty or username doesn't exist)
        Return result
    End Function



    'TICKET
    'create ticket
    Public Function create_ticket(ByVal ticket_number, ByVal date_sail, ByVal ship_name, ByVal accommodation_type, ByVal seat_number, ByVal destination, ByVal passenger_name, ByVal passenger_age, ByVal fare_type, ByVal date_booked)
        Dim result As Boolean = False
        Dim new_remainingSeats As String

        'initialize database connection
        InitializeConnection()

        Dim query As String = "insert into ticket(ticket_number, ship_name, date_sail, accommodation_type, seat_number, destination, passenger_name, passenger_age, fare_type, date_booked) values(@ticket_number, @ship_name, @date_sail, @accommodation_type, @seat_number, @destination, @passenger_name, @passenger_age, @fare_type, @date_booked)"

        _Cmd = New SqlCommand(query, _Con)
        _Cmd.Parameters.AddWithValue("@ticket_number", ticket_number)
        _Cmd.Parameters.AddWithValue("@ship_name", ship_name)
        _Cmd.Parameters.AddWithValue("@date_sail", date_sail)
        _Cmd.Parameters.AddWithValue("@accommodation_type", accommodation_type)
        _Cmd.Parameters.AddWithValue("@seat_number", seat_number)
        _Cmd.Parameters.AddWithValue("@destination", destination)
        _Cmd.Parameters.AddWithValue("@passenger_name", passenger_name)
        _Cmd.Parameters.AddWithValue("@passenger_age", passenger_age)
        _Cmd.Parameters.AddWithValue("@fare_type", fare_type)
        _Cmd.Parameters.AddWithValue("@date_booked", date_booked)

        Try
            _Cmd.ExecuteNonQuery()
            result = True
            new_remainingSeats = remove_seat(seat_number, get_remainingSeats(ship_name, date_sail, accommodation_type))
            update_availableShip(ship_name, date_sail, accommodation_type, new_remainingSeats)
        Catch ex As Exception
            'do nothing
        End Try


        'Close connection
        _Con.Close()

        'result (True = insert successful, False =  insert unsuccessful)
        Return result
    End Function

    'update ticket
    Public Function update_ticket(ByVal id, ByVal passenger_name, ByVal passenger_age, ByVal fare_type, ByVal date_booked)
        Dim result As Boolean = False

        'initialize database connection
        InitializeConnection()

        Dim query As String = "update ticket set passenger_name = @passenger_name, passenger_age = @passenger_age, fare_type = @fare_type, date_booked = @date_booked where id = @id"

        _Cmd = New SqlCommand(query, _Con)
        _Cmd.Parameters.AddWithValue("@id", id)
        _Cmd.Parameters.AddWithValue("@passenger_name", passenger_name)
        _Cmd.Parameters.AddWithValue("@passenger_age", passenger_age)
        _Cmd.Parameters.AddWithValue("@fare_type", fare_type)
        _Cmd.Parameters.AddWithValue("@date_booked", date_booked)

        Try
            _Cmd.ExecuteNonQuery()
            result = True
        Catch ex As Exception
            'do nothing
        End Try


        'Close connection
        _Con.Close()

        'result (True = update successful, False =  update unsuccessful)
        Return result
    End Function

    'get ticket by specific id
    Public Sub get_ticket(ByVal id As Int32, ByRef data_grid As DataGridView)
        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("select * from ticket where id = @id", _Con)
        _Cmd.Parameters.AddWithValue("@id", id)
        _Cmd.ExecuteNonQuery()

        _Adapter = New SqlDataAdapter(_Cmd)
        _Table = New DataTable
        _Adapter.Fill(_Table)

        data_grid.DataSource = _Table


        'Close Connection
        _Con.Close()
    End Sub

    'get ticket by date
    Public Sub get_ticket(ByVal date_sail As DateTime, ByRef data_grid As DataGridView)
        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("select * from ticket where date_sail = @date_sail", _Con)
        _Cmd.Parameters.AddWithValue("@date_sail", date_sail)
        _Cmd.ExecuteNonQuery()

        _Adapter = New SqlDataAdapter(_Cmd)
        _Table = New DataTable
        _Adapter.Fill(_Table)

        data_grid.DataSource = _Table


        'Close Connection
        _Con.Close()
    End Sub

    Public Function get_data_ticket(ByVal Id As Integer)
        Dim result(9) As String

        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("select * from ticket where id = @id", _Con)
        _Cmd.Parameters.AddWithValue("@id", Id)


        Dim rdr As SqlDataReader = _Cmd.ExecuteReader

        Do While rdr.Read

            result(0) = rdr("ticket_number")
            result(1) = rdr("destination")
            result(2) = rdr("date_sail")
            result(3) = rdr("ship_name")
            result(4) = rdr("accommodation_type")
            result(5) = rdr("seat_number")
            result(6) = rdr("passenger_name")
            result(7) = rdr("passenger_age")
            result(8) = rdr("fare_type")
        Loop


        rdr.Close()
        _Con.Close()

        Return result
    End Function

    'get ticket by name
    Public Sub get_ticket(ByVal ship_name As String, ByRef data_grid As DataGridView)
        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("select * from ticket where ship_name = @ship_name", _Con)
        _Cmd.Parameters.AddWithValue("@ship_name", ship_name)
        _Cmd.ExecuteNonQuery()

        _Adapter = New SqlDataAdapter(_Cmd)
        _Table = New DataTable
        _Adapter.Fill(_Table)

        data_grid.DataSource = _Table


        'Close Connection
        _Con.Close()
    End Sub

    'get all ticket
    Public Sub get_ticket(ByRef data_grid As DataGridView)
        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("select * from ticket order by id DESC", _Con)
        _Cmd.ExecuteNonQuery()

        _Adapter = New SqlDataAdapter(_Cmd)
        _Table = New DataTable
        _Adapter.Fill(_Table)

        data_grid.DataSource = _Table

        'close connection
        _Con.Close()
    End Sub

    'delete ticket
    Public Function delete_ticket(ByVal id As Integer, ByVal seat_book As String, ByVal ship_name As String, ByVal dates As DateTime, ByVal accommodation_type As String)
        Dim result As Boolean = False
        Dim remaining_seats() As String


        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("delete from ticket where id = @id", _Con)
        _Cmd.Parameters.AddWithValue("@id", id)

        Try
            _Cmd.ExecuteNonQuery()
            result = True

        Catch ex As Exception
            'do nothing
        End Try

        'Close Connection
        _Con.Close()


        remaining_seats = get_remainingSeats(ship_name, dates, accommodation_type)

        'restore available seat
        restore_seat(seat_book, remaining_seats, ship_name, dates, accommodation_type)


        'result (True = delete successful, False =  delete unsuccessful)
        Return result
    End Function

    'generate ticket
    Public Function generate_ticket()
        Dim ticket_num As Integer = 10000
        Dim count As Integer

        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("Select id from ticket", _Con)
        _Cmd.ExecuteNonQuery()

        Dim rdr As SqlDataReader = _Cmd.ExecuteReader

        Do While rdr.Read
            count = rdr("id")
        Loop


        If count > 1 Then
            ticket_num += count
        Else
            ticket_num += 1
        End If

        'Close Connection
        _Con.Close()

        Return ticket_num
    End Function


    'AVAILABLE SHIP / SHIP BOOKING HISTORY / AVAILABLE SEATS
    'create available ship
    Public Function create_availableShip(ByVal ship_name, ByVal accomodation_type, ByVal dates, ByVal available_seats)
        Dim result As Boolean = False
        Dim query As String

        'initialize database connection
        InitializeConnection()


        query = "insert into available_ship(ship_name, dates, accomodation_type, available_seats) values(@ship_name, @accomodation_type, @dates, @available_seats)"

        _Cmd = New SqlCommand(query, _Con)
        _Cmd.Parameters.AddWithValue("@ship_name", ship_name)
        _Cmd.Parameters.AddWithValue("@dates", dates)
        _Cmd.Parameters.AddWithValue("@accomodation_type", accomodation_type)
        _Cmd.Parameters.AddWithValue("@available_seats", available_seats)


        Try
            _Cmd.ExecuteNonQuery()
        Catch ex As Exception
            'do nothing
        End Try


        'Close Connection
        _Con.Close()

        'result (True = insert successful, False =  insert unsuccessful)
        Return result
    End Function

    'update available ship/ available seats
    Public Function update_availableShip(ByVal id, ByVal available_seats)
        Dim result As Boolean = False
        Dim query As String

        'initialize database connection
        InitializeConnection()

        query = "update available_ship set available_seats = @available_seats where id = @id"

        _Cmd = New SqlCommand(query, _Con)
        _Cmd.Parameters.AddWithValue("@available_seats", available_seats)
        _Cmd.Parameters.AddWithValue("@id", id)


        Try
            _Cmd.ExecuteNonQuery()
        Catch ex As Exception
            'do nothing
        End Try


        'Close Connection
        _Con.Close()

        'result (True = update successful, False =  update unsuccessful)
        Return result
    End Function

    'update available ship/ available seats
    Public Function update_availableShip(ByVal ship_name, ByVal dates, ByVal accommodation_type, ByVal available_seats)
        Dim result As Boolean = False
        Dim query As String

        'initialize database connection
        InitializeConnection()

        query = "update available_ship set available_seats = @available_seats where ship_name = @ship_name and dates = @dates and accommodation_type = @accommodation_type"

        _Cmd = New SqlCommand(query, _Con)
        _Cmd.Parameters.AddWithValue("@available_seats", available_seats)
        _Cmd.Parameters.AddWithValue("@ship_name", ship_name)
        _Cmd.Parameters.AddWithValue("@dates", dates)
        _Cmd.Parameters.AddWithValue("@accommodation_type", accommodation_type)



        Try
            _Cmd.ExecuteNonQuery()
            result = True
        Catch ex As Exception
            'do nothing
        End Try


        'Close Connection
        _Con.Close()

        'result (True = update successful, False =  update unsuccessful)
        Return result
    End Function

    'get available by id
    Public Sub get_availableShip(ByVal id As Integer, ByRef data_grid As DataGridView)
        Dim query As String

        'initialize database connection
        InitializeConnection()

        query = "Select * from available_ship where id = @id"

        _Cmd = New SqlCommand(query, _Con)
        _Cmd.Parameters.AddWithValue("@id", id)
        _Cmd.ExecuteNonQuery()

        _Adapter = New SqlDataAdapter(_Cmd)
        _Table = New DataTable

        _Adapter.Fill(_Table)


        data_grid.DataSource = _Table


        'Close Connection
        _Con.Close()
    End Sub

    'get available ship
    Public Sub get_availableShip(ByRef data_grid As DataGridView)
        Dim query As String

        'initialize database connection
        InitializeConnection()

        query = "Select * from available_ship order by id DESC"

        _Cmd = New SqlCommand(query, _Con)
        _Cmd.ExecuteNonQuery()

        _Adapter = New SqlDataAdapter(_Cmd)
        _Table = New DataTable

        _Adapter.Fill(_Table)


        data_grid.DataSource = _Table


        'Close Connection
        _Con.Close()
    End Sub

    'get available seats
    Public Function get_availableSeats(ByVal ship_name, ByVal dates, ByVal accommodation_type)
        Dim result As String = ""

        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("Select * from available_ship where ship_name = @ship_name and dates = @dates and accommodation_type = @accommodation_type", _Con)
        _Cmd.Parameters.AddWithValue("@ship_name", ship_name)
        _Cmd.Parameters.AddWithValue("@dates", dates)
        _Cmd.Parameters.AddWithValue("@accommodation_type", accommodation_type)
        '_Cmd.ExecuteNonQuery()

        Dim rdr As SqlDataReader = _Cmd.ExecuteReader

        Do While rdr.Read
            result = rdr("available_seats")
        Loop

        'Close Connection
        _Con.Close()

        Return result
    End Function

    'get remaining seats (returned as string array)
    Public Function get_remainingSeats(ByVal ship_name, ByVal dates, ByVal accommodation_type)
        Dim result() As String

        Dim remaining As String = get_availableSeats(ship_name, dates, accommodation_type)

        result = remaining.Split("-")

        Return result
    End Function

    'remove booked seats and combine all remaining seats into string
    Public Function remove_seat(ByVal seat_book As String, ByVal remaining_seats() As String)
        Dim result As String
        Dim new_array(remaining_seats.Count - 1) As String
        Dim newIndex As Integer = 0

        For i As Integer = 0 To remaining_seats.Count - 1
            If seat_book <> remaining_seats(i) Then
                new_array(newIndex) = remaining_seats(i)
                newIndex += 1

            End If
        Next

        'combine new array to string
        result = String.Join("-", new_array)

        'remove trailing "-"
        result = result.Substring(0, result.Length - 1)


        Return result
    End Function

    'add available seat
    Public Function restore_seat(ByVal seat_book As String, ByVal remaining_seats() As String, ByVal ship_name As String, ByVal dates As DateTime, ByVal accommodation_type As String)
        Dim result As String
        Dim new_array(remaining_seats.Count) As Integer
        Dim newIndex As Integer = 0
        Dim typeCastArray() As Integer

        For i As Integer = 0 To remaining_seats.Count - 1
            new_array(i) = Integer.Parse(remaining_seats(i))
            newIndex += 1
        Next

        new_array(newIndex) = seat_book

        Array.Sort(new_array)





        'combine new array to string
        result = String.Join("-", new_array)

        'remove trailing "-"
        'result = result.Substring(0, result.Length - 1)

        update_availableShip(ship_name, dates, accommodation_type, result)

        Return result
    End Function

    'check if "available_ship data" is in database
    Public Function check_availableShip(ByVal ship_name, ByVal dates)
        Dim result As Boolean

        'initialize database connection
        InitializeConnection()

        _Cmd = New SqlCommand("Select * from available_ship where ship_name = @ship_name and dates = @dates", _Con)
        _Cmd.Parameters.AddWithValue("@ship_name", ship_name)
        _Cmd.Parameters.AddWithValue("@dates", dates)
        _Cmd.ExecuteNonQuery()

        Dim rdr As SqlDataReader = _Cmd.ExecuteReader

        result = rdr.HasRows

        _Con.Close()


        Return result
    End Function

    'check if in database if not insert
    'reference for all the available seats
    Public Sub checkOrCreate_available(ByVal ship_name, ByVal dates)
        Dim query As String

        If check_availableShip(ship_name, dates) = False Then

            query = "insert into available_ship(ship_name, dates, accommodation_type, available_seats) values(@ship_name, @dates, @accommodation_type, @available_seats)"


            'initialize database connection
            InitializeConnection()

            'query for economy
            _Cmd = New SqlCommand(query, _Con)
            _Cmd.Parameters.AddWithValue("@ship_name", ship_name)
            _Cmd.Parameters.AddWithValue("@dates", dates)
            _Cmd.Parameters.AddWithValue("@accommodation_type", "Economy")
            _Cmd.Parameters.AddWithValue("@available_seats", "1-2-3-4-5-6-7-8-9-10-11-12-13-14-15-16-17-18-19-20-21-22-23-24-25-26-27-28-29-30-31-32-33-34-35-36-37-38-39-40-41-42-43-44-45-46-47-48-49-50")
            _Cmd.ExecuteNonQuery()



            'query for tourist
            _Cmd = New SqlCommand(query, _Con)
            _Cmd.Parameters.AddWithValue("@ship_name", ship_name)
            _Cmd.Parameters.AddWithValue("@dates", dates)
            _Cmd.Parameters.AddWithValue("@accommodation_type", "Tourist")
            _Cmd.Parameters.AddWithValue("@available_seats", "1-2-3-4-5-6-7-8-9-10-11-12-13-14-15-16-17-18-19-20-21-22-23-24-25")
            _Cmd.ExecuteNonQuery()


            'query for sitting
            _Cmd = New SqlCommand(query, _Con)
            _Cmd.Parameters.AddWithValue("@ship_name", ship_name)
            _Cmd.Parameters.AddWithValue("@dates", dates)
            _Cmd.Parameters.AddWithValue("@accommodation_type", "Sitting")
            _Cmd.Parameters.AddWithValue("@available_seats", "1-2-3-4-5-6-7-8-9-10-11-12-13-14-15")
            _Cmd.ExecuteNonQuery()

            _Con.Close()

        End If
    End Sub
End Module
