<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_Book_Customer_View
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.book_new_customer_label = New System.Windows.Forms.Label()
        Me.ticket_number_label = New System.Windows.Forms.Label()
        Me.destination_label = New System.Windows.Forms.Label()
        Me.date_sail_label = New System.Windows.Forms.Label()
        Me.ship_name_label = New System.Windows.Forms.Label()
        Me.accommodation_type_label = New System.Windows.Forms.Label()
        Me.seat_number_label = New System.Windows.Forms.Label()
        Me.passenger_label = New System.Windows.Forms.Label()
        Me.passenger_age_label = New System.Windows.Forms.Label()
        Me.fare_type_label = New System.Windows.Forms.Label()
        Me.date_booked_label = New System.Windows.Forms.Label()
        Me.ticket_number_text = New Telerik.WinControls.UI.RadTextBox()
        Me.passenger_name_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.passenger_age_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.book_customer_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.clear_all_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.CrystalTheme = New Telerik.WinControls.Themes.CrystalTheme()
        Me.date_sail_datepicker = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.destination_dropdown = New Telerik.WinControls.UI.RadDropDownList()
        Me.ship_name_dropdown = New Telerik.WinControls.UI.RadDropDownList()
        Me.accommodation_type_dropdown = New Telerik.WinControls.UI.RadDropDownList()
        Me.seat_number_dropdown = New Telerik.WinControls.UI.RadDropDownList()
        Me.fare_type_dropdown = New Telerik.WinControls.UI.RadDropDownList()
        Me.date_booked_datepicker = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.price_label = New System.Windows.Forms.Label()
        Me.overall_price_label = New System.Windows.Forms.Label()
        CType(Me.ticket_number_text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passenger_name_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passenger_age_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_sail_datepicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.destination_dropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ship_name_dropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accommodation_type_dropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seat_number_dropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fare_type_dropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_booked_datepicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'book_new_customer_label
        '
        Me.book_new_customer_label.AutoSize = True
        Me.book_new_customer_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_new_customer_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.book_new_customer_label.Location = New System.Drawing.Point(21, 17)
        Me.book_new_customer_label.Name = "book_new_customer_label"
        Me.book_new_customer_label.Size = New System.Drawing.Size(335, 39)
        Me.book_new_customer_label.TabIndex = 0
        Me.book_new_customer_label.Text = "Book New Customer"
        '
        'ticket_number_label
        '
        Me.ticket_number_label.AutoSize = True
        Me.ticket_number_label.Location = New System.Drawing.Point(49, 96)
        Me.ticket_number_label.Name = "ticket_number_label"
        Me.ticket_number_label.Size = New System.Drawing.Size(90, 15)
        Me.ticket_number_label.TabIndex = 1
        Me.ticket_number_label.Text = "Ticket Number:"
        '
        'destination_label
        '
        Me.destination_label.AutoSize = True
        Me.destination_label.Location = New System.Drawing.Point(49, 155)
        Me.destination_label.Name = "destination_label"
        Me.destination_label.Size = New System.Drawing.Size(72, 15)
        Me.destination_label.TabIndex = 2
        Me.destination_label.Text = "Destination:"
        '
        'date_sail_label
        '
        Me.date_sail_label.AutoSize = True
        Me.date_sail_label.Location = New System.Drawing.Point(49, 215)
        Me.date_sail_label.Name = "date_sail_label"
        Me.date_sail_label.Size = New System.Drawing.Size(60, 15)
        Me.date_sail_label.TabIndex = 3
        Me.date_sail_label.Text = "Date Sail:"
        '
        'ship_name_label
        '
        Me.ship_name_label.AutoSize = True
        Me.ship_name_label.Location = New System.Drawing.Point(49, 277)
        Me.ship_name_label.Name = "ship_name_label"
        Me.ship_name_label.Size = New System.Drawing.Size(72, 15)
        Me.ship_name_label.TabIndex = 4
        Me.ship_name_label.Text = "Ship Name:"
        '
        'accommodation_type_label
        '
        Me.accommodation_type_label.AutoSize = True
        Me.accommodation_type_label.Location = New System.Drawing.Point(49, 335)
        Me.accommodation_type_label.Name = "accommodation_type_label"
        Me.accommodation_type_label.Size = New System.Drawing.Size(128, 15)
        Me.accommodation_type_label.TabIndex = 5
        Me.accommodation_type_label.Text = "Accommodation Type:"
        '
        'seat_number_label
        '
        Me.seat_number_label.AutoSize = True
        Me.seat_number_label.Location = New System.Drawing.Point(500, 96)
        Me.seat_number_label.Name = "seat_number_label"
        Me.seat_number_label.Size = New System.Drawing.Size(83, 15)
        Me.seat_number_label.TabIndex = 6
        Me.seat_number_label.Text = "Seat Number:"
        '
        'passenger_label
        '
        Me.passenger_label.AutoSize = True
        Me.passenger_label.Location = New System.Drawing.Point(500, 155)
        Me.passenger_label.Name = "passenger_label"
        Me.passenger_label.Size = New System.Drawing.Size(106, 15)
        Me.passenger_label.TabIndex = 7
        Me.passenger_label.Text = "Passenger Name:"
        '
        'passenger_age_label
        '
        Me.passenger_age_label.AutoSize = True
        Me.passenger_age_label.Location = New System.Drawing.Point(500, 215)
        Me.passenger_age_label.Name = "passenger_age_label"
        Me.passenger_age_label.Size = New System.Drawing.Size(93, 15)
        Me.passenger_age_label.TabIndex = 8
        Me.passenger_age_label.Text = "Passenger Age:"
        '
        'fare_type_label
        '
        Me.fare_type_label.AutoSize = True
        Me.fare_type_label.Location = New System.Drawing.Point(500, 277)
        Me.fare_type_label.Name = "fare_type_label"
        Me.fare_type_label.Size = New System.Drawing.Size(64, 15)
        Me.fare_type_label.TabIndex = 9
        Me.fare_type_label.Text = "Fare Type:"
        '
        'date_booked_label
        '
        Me.date_booked_label.AutoSize = True
        Me.date_booked_label.Location = New System.Drawing.Point(500, 335)
        Me.date_booked_label.Name = "date_booked_label"
        Me.date_booked_label.Size = New System.Drawing.Size(81, 15)
        Me.date_booked_label.TabIndex = 10
        Me.date_booked_label.Text = "Date Booked:"
        '
        'ticket_number_text
        '
        Me.ticket_number_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ticket_number_text.Location = New System.Drawing.Point(52, 114)
        Me.ticket_number_text.Name = "ticket_number_text"
        Me.ticket_number_text.ReadOnly = True
        Me.ticket_number_text.Size = New System.Drawing.Size(339, 26)
        Me.ticket_number_text.TabIndex = 11
        Me.ticket_number_text.ThemeName = "Crystal"
        '
        'passenger_name_textbox
        '
        Me.passenger_name_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.passenger_name_textbox.Location = New System.Drawing.Point(503, 173)
        Me.passenger_name_textbox.Name = "passenger_name_textbox"
        Me.passenger_name_textbox.Size = New System.Drawing.Size(339, 26)
        Me.passenger_name_textbox.TabIndex = 16
        Me.passenger_name_textbox.ThemeName = "Crystal"
        '
        'passenger_age_textbox
        '
        Me.passenger_age_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.passenger_age_textbox.Location = New System.Drawing.Point(503, 234)
        Me.passenger_age_textbox.Name = "passenger_age_textbox"
        Me.passenger_age_textbox.Size = New System.Drawing.Size(339, 26)
        Me.passenger_age_textbox.TabIndex = 17
        Me.passenger_age_textbox.ThemeName = "Crystal"
        '
        'book_customer_button
        '
        Me.book_customer_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.book_customer_button.BackColor = System.Drawing.Color.Transparent
        Me.book_customer_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.book_customer_button.BorderRadius = 0
        Me.book_customer_button.ButtonText = "Book Customer"
        Me.book_customer_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.book_customer_button.DisabledColor = System.Drawing.Color.Gray
        Me.book_customer_button.Iconcolor = System.Drawing.Color.Transparent
        Me.book_customer_button.Iconimage = Global.Ship_Star.My.Resources.Resources.right_arrow
        Me.book_customer_button.Iconimage_right = Nothing
        Me.book_customer_button.Iconimage_right_Selected = Nothing
        Me.book_customer_button.Iconimage_Selected = Nothing
        Me.book_customer_button.IconMarginLeft = 0
        Me.book_customer_button.IconMarginRight = 0
        Me.book_customer_button.IconRightVisible = True
        Me.book_customer_button.IconRightZoom = 0R
        Me.book_customer_button.IconVisible = True
        Me.book_customer_button.IconZoom = 80.0R
        Me.book_customer_button.IsTab = False
        Me.book_customer_button.Location = New System.Drawing.Point(650, 391)
        Me.book_customer_button.Name = "book_customer_button"
        Me.book_customer_button.Normalcolor = System.Drawing.Color.Transparent
        Me.book_customer_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.book_customer_button.OnHoverTextColor = System.Drawing.Color.White
        Me.book_customer_button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.book_customer_button.selected = False
        Me.book_customer_button.Size = New System.Drawing.Size(192, 58)
        Me.book_customer_button.TabIndex = 20
        Me.book_customer_button.Text = "Book Customer"
        Me.book_customer_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.book_customer_button.Textcolor = System.Drawing.Color.White
        Me.book_customer_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'clear_all_button
        '
        Me.clear_all_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.clear_all_button.BackColor = System.Drawing.Color.Transparent
        Me.clear_all_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clear_all_button.BorderRadius = 0
        Me.clear_all_button.ButtonText = "Clear All"
        Me.clear_all_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_all_button.DisabledColor = System.Drawing.Color.Gray
        Me.clear_all_button.Iconcolor = System.Drawing.Color.Transparent
        Me.clear_all_button.Iconimage = Global.Ship_Star.My.Resources.Resources._error
        Me.clear_all_button.Iconimage_right = Nothing
        Me.clear_all_button.Iconimage_right_Selected = Nothing
        Me.clear_all_button.Iconimage_Selected = Nothing
        Me.clear_all_button.IconMarginLeft = 0
        Me.clear_all_button.IconMarginRight = 0
        Me.clear_all_button.IconRightVisible = True
        Me.clear_all_button.IconRightZoom = 0R
        Me.clear_all_button.IconVisible = True
        Me.clear_all_button.IconZoom = 80.0R
        Me.clear_all_button.IsTab = False
        Me.clear_all_button.Location = New System.Drawing.Point(52, 391)
        Me.clear_all_button.Name = "clear_all_button"
        Me.clear_all_button.Normalcolor = System.Drawing.Color.Transparent
        Me.clear_all_button.OnHovercolor = System.Drawing.Color.Crimson
        Me.clear_all_button.OnHoverTextColor = System.Drawing.Color.White
        Me.clear_all_button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clear_all_button.selected = False
        Me.clear_all_button.Size = New System.Drawing.Size(192, 55)
        Me.clear_all_button.TabIndex = 21
        Me.clear_all_button.Text = "Clear All"
        Me.clear_all_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clear_all_button.Textcolor = System.Drawing.Color.White
        Me.clear_all_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'date_sail_datepicker
        '
        Me.date_sail_datepicker.AutoSize = False
        Me.date_sail_datepicker.CalendarSize = New System.Drawing.Size(290, 320)
        Me.date_sail_datepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.date_sail_datepicker.ForeColor = System.Drawing.Color.Black
        Me.date_sail_datepicker.Location = New System.Drawing.Point(52, 234)
        Me.date_sail_datepicker.Name = "date_sail_datepicker"
        Me.date_sail_datepicker.Size = New System.Drawing.Size(339, 26)
        Me.date_sail_datepicker.TabIndex = 23
        Me.date_sail_datepicker.TabStop = False
        Me.date_sail_datepicker.Text = "Monday, 9 December 2019"
        Me.date_sail_datepicker.ThemeName = "Crystal"
        Me.date_sail_datepicker.Value = New Date(2019, 12, 9, 11, 5, 1, 362)
        '
        'destination_dropdown
        '
        Me.destination_dropdown.AutoSize = False
        Me.destination_dropdown.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.destination_dropdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "Hilongos to Cebu"
        RadListDataItem2.Text = "Cebu to Hilongos"
        Me.destination_dropdown.Items.Add(RadListDataItem1)
        Me.destination_dropdown.Items.Add(RadListDataItem2)
        Me.destination_dropdown.Location = New System.Drawing.Point(52, 175)
        Me.destination_dropdown.Name = "destination_dropdown"
        Me.destination_dropdown.Size = New System.Drawing.Size(339, 26)
        Me.destination_dropdown.TabIndex = 24
        Me.destination_dropdown.ThemeName = "Crystal"
        '
        'ship_name_dropdown
        '
        Me.ship_name_dropdown.AutoSize = False
        Me.ship_name_dropdown.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ship_name_dropdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ship_name_dropdown.Location = New System.Drawing.Point(52, 295)
        Me.ship_name_dropdown.Name = "ship_name_dropdown"
        Me.ship_name_dropdown.Size = New System.Drawing.Size(339, 26)
        Me.ship_name_dropdown.TabIndex = 25
        Me.ship_name_dropdown.ThemeName = "Crystal"
        '
        'accommodation_type_dropdown
        '
        Me.accommodation_type_dropdown.AutoSize = False
        Me.accommodation_type_dropdown.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.accommodation_type_dropdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem3.Text = "Economy"
        RadListDataItem4.Text = "Tourist"
        RadListDataItem5.Text = "Sitting"
        Me.accommodation_type_dropdown.Items.Add(RadListDataItem3)
        Me.accommodation_type_dropdown.Items.Add(RadListDataItem4)
        Me.accommodation_type_dropdown.Items.Add(RadListDataItem5)
        Me.accommodation_type_dropdown.Location = New System.Drawing.Point(52, 353)
        Me.accommodation_type_dropdown.Name = "accommodation_type_dropdown"
        Me.accommodation_type_dropdown.Size = New System.Drawing.Size(339, 26)
        Me.accommodation_type_dropdown.TabIndex = 26
        Me.accommodation_type_dropdown.ThemeName = "Crystal"
        '
        'seat_number_dropdown
        '
        Me.seat_number_dropdown.AutoSize = False
        Me.seat_number_dropdown.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.seat_number_dropdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seat_number_dropdown.Location = New System.Drawing.Point(503, 114)
        Me.seat_number_dropdown.Name = "seat_number_dropdown"
        Me.seat_number_dropdown.Size = New System.Drawing.Size(339, 26)
        Me.seat_number_dropdown.TabIndex = 27
        Me.seat_number_dropdown.ThemeName = "Crystal"
        '
        'fare_type_dropdown
        '
        Me.fare_type_dropdown.AutoSize = False
        Me.fare_type_dropdown.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.fare_type_dropdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem6.Text = "Regular"
        RadListDataItem7.Text = "Student"
        RadListDataItem8.Text = "Senior"
        RadListDataItem9.Text = "Minor"
        Me.fare_type_dropdown.Items.Add(RadListDataItem6)
        Me.fare_type_dropdown.Items.Add(RadListDataItem7)
        Me.fare_type_dropdown.Items.Add(RadListDataItem8)
        Me.fare_type_dropdown.Items.Add(RadListDataItem9)
        Me.fare_type_dropdown.Location = New System.Drawing.Point(503, 295)
        Me.fare_type_dropdown.Name = "fare_type_dropdown"
        Me.fare_type_dropdown.Size = New System.Drawing.Size(339, 26)
        Me.fare_type_dropdown.TabIndex = 28
        Me.fare_type_dropdown.ThemeName = "Crystal"
        '
        'date_booked_datepicker
        '
        Me.date_booked_datepicker.AutoSize = False
        Me.date_booked_datepicker.CalendarSize = New System.Drawing.Size(290, 320)
        Me.date_booked_datepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.date_booked_datepicker.ForeColor = System.Drawing.Color.Black
        Me.date_booked_datepicker.Location = New System.Drawing.Point(503, 351)
        Me.date_booked_datepicker.Name = "date_booked_datepicker"
        Me.date_booked_datepicker.ReadOnly = True
        Me.date_booked_datepicker.Size = New System.Drawing.Size(339, 26)
        Me.date_booked_datepicker.TabIndex = 29
        Me.date_booked_datepicker.TabStop = False
        Me.date_booked_datepicker.Text = "Monday, 9 December 2019"
        Me.date_booked_datepicker.ThemeName = "Crystal"
        Me.date_booked_datepicker.Value = New Date(2019, 12, 9, 11, 5, 1, 362)
        '
        'price_label
        '
        Me.price_label.AutoSize = True
        Me.price_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_label.Location = New System.Drawing.Point(661, 38)
        Me.price_label.Name = "price_label"
        Me.price_label.Size = New System.Drawing.Size(34, 13)
        Me.price_label.TabIndex = 30
        Me.price_label.Text = "Price:"
        '
        'overall_price_label
        '
        Me.overall_price_label.AutoSize = True
        Me.overall_price_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overall_price_label.Location = New System.Drawing.Point(701, 32)
        Me.overall_price_label.Name = "overall_price_label"
        Me.overall_price_label.Size = New System.Drawing.Size(21, 24)
        Me.overall_price_label.TabIndex = 31
        Me.overall_price_label.Text = "0"
        '
        'New_Book_Customer_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.overall_price_label)
        Me.Controls.Add(Me.price_label)
        Me.Controls.Add(Me.date_booked_datepicker)
        Me.Controls.Add(Me.fare_type_dropdown)
        Me.Controls.Add(Me.seat_number_dropdown)
        Me.Controls.Add(Me.accommodation_type_dropdown)
        Me.Controls.Add(Me.ship_name_dropdown)
        Me.Controls.Add(Me.destination_dropdown)
        Me.Controls.Add(Me.date_sail_datepicker)
        Me.Controls.Add(Me.clear_all_button)
        Me.Controls.Add(Me.book_customer_button)
        Me.Controls.Add(Me.passenger_age_textbox)
        Me.Controls.Add(Me.passenger_name_textbox)
        Me.Controls.Add(Me.ticket_number_text)
        Me.Controls.Add(Me.date_booked_label)
        Me.Controls.Add(Me.fare_type_label)
        Me.Controls.Add(Me.passenger_age_label)
        Me.Controls.Add(Me.passenger_label)
        Me.Controls.Add(Me.seat_number_label)
        Me.Controls.Add(Me.accommodation_type_label)
        Me.Controls.Add(Me.ship_name_label)
        Me.Controls.Add(Me.date_sail_label)
        Me.Controls.Add(Me.destination_label)
        Me.Controls.Add(Me.ticket_number_label)
        Me.Controls.Add(Me.book_new_customer_label)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Name = "New_Book_Customer_View"
        Me.Size = New System.Drawing.Size(870, 449)
        CType(Me.ticket_number_text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passenger_name_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passenger_age_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_sail_datepicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.destination_dropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ship_name_dropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accommodation_type_dropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seat_number_dropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fare_type_dropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_booked_datepicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents book_new_customer_label As Label
    Friend WithEvents ticket_number_label As Label
    Friend WithEvents destination_label As Label
    Friend WithEvents date_sail_label As Label
    Friend WithEvents ship_name_label As Label
    Friend WithEvents accommodation_type_label As Label
    Friend WithEvents seat_number_label As Label
    Friend WithEvents passenger_label As Label
    Friend WithEvents passenger_age_label As Label
    Friend WithEvents fare_type_label As Label
    Friend WithEvents date_booked_label As Label
    Friend WithEvents ticket_number_text As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents passenger_name_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents passenger_age_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents book_customer_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents clear_all_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents CrystalTheme As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents date_sail_datepicker As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents destination_dropdown As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ship_name_dropdown As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents accommodation_type_dropdown As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents seat_number_dropdown As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents fare_type_dropdown As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents date_booked_datepicker As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents price_label As Label
    Friend WithEvents overall_price_label As Label
End Class
