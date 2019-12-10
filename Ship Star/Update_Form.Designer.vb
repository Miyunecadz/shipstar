<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.date_booked_datepicker = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.fare_type_dropdown = New Telerik.WinControls.UI.RadDropDownList()
        Me.date_sail_datepicker = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.passenger_name_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.ticket_number_text = New Telerik.WinControls.UI.RadTextBox()
        Me.CrystalTheme = New Telerik.WinControls.Themes.CrystalTheme()
        Me.passenger_age_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.date_booked_label = New System.Windows.Forms.Label()
        Me.fare_type_label = New System.Windows.Forms.Label()
        Me.passenger_age_label = New System.Windows.Forms.Label()
        Me.passenger_label = New System.Windows.Forms.Label()
        Me.seat_number_label = New System.Windows.Forms.Label()
        Me.accommodation_type_label = New System.Windows.Forms.Label()
        Me.ship_name_label = New System.Windows.Forms.Label()
        Me.date_sail_label = New System.Windows.Forms.Label()
        Me.destination_label = New System.Windows.Forms.Label()
        Me.ticket_number_label = New System.Windows.Forms.Label()
        Me.book_new_customer_label = New System.Windows.Forms.Label()
        Me.update_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cancel_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.destination_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.ship_name_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.accomodation_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.seat_number_textbox = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.date_booked_datepicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fare_type_dropdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_sail_datepicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passenger_name_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ticket_number_text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passenger_age_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.destination_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ship_name_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accomodation_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seat_number_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'date_booked_datepicker
        '
        Me.date_booked_datepicker.AutoSize = False
        Me.date_booked_datepicker.CalendarSize = New System.Drawing.Size(290, 320)
        Me.date_booked_datepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.date_booked_datepicker.ForeColor = System.Drawing.Color.Black
        Me.date_booked_datepicker.Location = New System.Drawing.Point(493, 343)
        Me.date_booked_datepicker.Name = "date_booked_datepicker"
        Me.date_booked_datepicker.ReadOnly = True
        Me.date_booked_datepicker.Size = New System.Drawing.Size(339, 26)
        Me.date_booked_datepicker.TabIndex = 77
        Me.date_booked_datepicker.TabStop = False
        Me.date_booked_datepicker.Text = "Monday, 9 December 2019"
        Me.date_booked_datepicker.ThemeName = "Crystal"
        Me.date_booked_datepicker.Value = New Date(2019, 12, 9, 11, 5, 1, 362)
        '
        'fare_type_dropdown
        '
        Me.fare_type_dropdown.AutoSize = False
        Me.fare_type_dropdown.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.fare_type_dropdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "Regular"
        RadListDataItem2.Text = "Student"
        RadListDataItem3.Text = "Senior"
        RadListDataItem4.Text = "Minor"
        Me.fare_type_dropdown.Items.Add(RadListDataItem1)
        Me.fare_type_dropdown.Items.Add(RadListDataItem2)
        Me.fare_type_dropdown.Items.Add(RadListDataItem3)
        Me.fare_type_dropdown.Items.Add(RadListDataItem4)
        Me.fare_type_dropdown.Location = New System.Drawing.Point(493, 287)
        Me.fare_type_dropdown.Name = "fare_type_dropdown"
        Me.fare_type_dropdown.Size = New System.Drawing.Size(339, 26)
        Me.fare_type_dropdown.TabIndex = 76
        Me.fare_type_dropdown.ThemeName = "Crystal"
        '
        'date_sail_datepicker
        '
        Me.date_sail_datepicker.AutoSize = False
        Me.date_sail_datepicker.CalendarSize = New System.Drawing.Size(290, 320)
        Me.date_sail_datepicker.Enabled = False
        Me.date_sail_datepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.date_sail_datepicker.ForeColor = System.Drawing.Color.Black
        Me.date_sail_datepicker.Location = New System.Drawing.Point(42, 226)
        Me.date_sail_datepicker.Name = "date_sail_datepicker"
        Me.date_sail_datepicker.Size = New System.Drawing.Size(339, 26)
        Me.date_sail_datepicker.TabIndex = 71
        Me.date_sail_datepicker.TabStop = False
        Me.date_sail_datepicker.Text = "Monday, 9 December 2019"
        Me.date_sail_datepicker.ThemeName = "Crystal"
        Me.date_sail_datepicker.Value = New Date(2019, 12, 9, 11, 5, 1, 362)
        '
        'passenger_name_textbox
        '
        Me.passenger_name_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.passenger_name_textbox.Location = New System.Drawing.Point(493, 165)
        Me.passenger_name_textbox.Name = "passenger_name_textbox"
        Me.passenger_name_textbox.Size = New System.Drawing.Size(339, 26)
        Me.passenger_name_textbox.TabIndex = 67
        Me.passenger_name_textbox.ThemeName = "Crystal"
        '
        'ticket_number_text
        '
        Me.ticket_number_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ticket_number_text.Location = New System.Drawing.Point(42, 106)
        Me.ticket_number_text.Name = "ticket_number_text"
        Me.ticket_number_text.ReadOnly = True
        Me.ticket_number_text.Size = New System.Drawing.Size(339, 26)
        Me.ticket_number_text.TabIndex = 66
        Me.ticket_number_text.ThemeName = "Crystal"
        '
        'passenger_age_textbox
        '
        Me.passenger_age_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.passenger_age_textbox.Location = New System.Drawing.Point(493, 226)
        Me.passenger_age_textbox.Name = "passenger_age_textbox"
        Me.passenger_age_textbox.Size = New System.Drawing.Size(339, 26)
        Me.passenger_age_textbox.TabIndex = 68
        Me.passenger_age_textbox.ThemeName = "Crystal"
        '
        'date_booked_label
        '
        Me.date_booked_label.AutoSize = True
        Me.date_booked_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.date_booked_label.Location = New System.Drawing.Point(490, 327)
        Me.date_booked_label.Name = "date_booked_label"
        Me.date_booked_label.Size = New System.Drawing.Size(73, 13)
        Me.date_booked_label.TabIndex = 65
        Me.date_booked_label.Text = "Date Booked:"
        '
        'fare_type_label
        '
        Me.fare_type_label.AutoSize = True
        Me.fare_type_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.fare_type_label.Location = New System.Drawing.Point(490, 269)
        Me.fare_type_label.Name = "fare_type_label"
        Me.fare_type_label.Size = New System.Drawing.Size(58, 13)
        Me.fare_type_label.TabIndex = 64
        Me.fare_type_label.Text = "Fare Type:"
        '
        'passenger_age_label
        '
        Me.passenger_age_label.AutoSize = True
        Me.passenger_age_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.passenger_age_label.Location = New System.Drawing.Point(490, 207)
        Me.passenger_age_label.Name = "passenger_age_label"
        Me.passenger_age_label.Size = New System.Drawing.Size(82, 13)
        Me.passenger_age_label.TabIndex = 63
        Me.passenger_age_label.Text = "Passenger Age:"
        '
        'passenger_label
        '
        Me.passenger_label.AutoSize = True
        Me.passenger_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.passenger_label.Location = New System.Drawing.Point(490, 147)
        Me.passenger_label.Name = "passenger_label"
        Me.passenger_label.Size = New System.Drawing.Size(91, 13)
        Me.passenger_label.TabIndex = 62
        Me.passenger_label.Text = "Passenger Name:"
        '
        'seat_number_label
        '
        Me.seat_number_label.AutoSize = True
        Me.seat_number_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.seat_number_label.Location = New System.Drawing.Point(490, 88)
        Me.seat_number_label.Name = "seat_number_label"
        Me.seat_number_label.Size = New System.Drawing.Size(72, 13)
        Me.seat_number_label.TabIndex = 61
        Me.seat_number_label.Text = "Seat Number:"
        '
        'accommodation_type_label
        '
        Me.accommodation_type_label.AutoSize = True
        Me.accommodation_type_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.accommodation_type_label.Location = New System.Drawing.Point(39, 327)
        Me.accommodation_type_label.Name = "accommodation_type_label"
        Me.accommodation_type_label.Size = New System.Drawing.Size(113, 13)
        Me.accommodation_type_label.TabIndex = 60
        Me.accommodation_type_label.Text = "Accommodation Type:"
        '
        'ship_name_label
        '
        Me.ship_name_label.AutoSize = True
        Me.ship_name_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ship_name_label.Location = New System.Drawing.Point(39, 269)
        Me.ship_name_label.Name = "ship_name_label"
        Me.ship_name_label.Size = New System.Drawing.Size(62, 13)
        Me.ship_name_label.TabIndex = 59
        Me.ship_name_label.Text = "Ship Name:"
        '
        'date_sail_label
        '
        Me.date_sail_label.AutoSize = True
        Me.date_sail_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.date_sail_label.Location = New System.Drawing.Point(39, 207)
        Me.date_sail_label.Name = "date_sail_label"
        Me.date_sail_label.Size = New System.Drawing.Size(53, 13)
        Me.date_sail_label.TabIndex = 58
        Me.date_sail_label.Text = "Date Sail:"
        '
        'destination_label
        '
        Me.destination_label.AutoSize = True
        Me.destination_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.destination_label.Location = New System.Drawing.Point(39, 147)
        Me.destination_label.Name = "destination_label"
        Me.destination_label.Size = New System.Drawing.Size(63, 13)
        Me.destination_label.TabIndex = 57
        Me.destination_label.Text = "Destination:"
        '
        'ticket_number_label
        '
        Me.ticket_number_label.AutoSize = True
        Me.ticket_number_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ticket_number_label.Location = New System.Drawing.Point(39, 88)
        Me.ticket_number_label.Name = "ticket_number_label"
        Me.ticket_number_label.Size = New System.Drawing.Size(80, 13)
        Me.ticket_number_label.TabIndex = 56
        Me.ticket_number_label.Text = "Ticket Number:"
        '
        'book_new_customer_label
        '
        Me.book_new_customer_label.AutoSize = True
        Me.book_new_customer_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_new_customer_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.book_new_customer_label.Location = New System.Drawing.Point(11, 9)
        Me.book_new_customer_label.Name = "book_new_customer_label"
        Me.book_new_customer_label.Size = New System.Drawing.Size(335, 39)
        Me.book_new_customer_label.TabIndex = 55
        Me.book_new_customer_label.Text = "Book New Customer"
        '
        'update_button
        '
        Me.update_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.update_button.BackColor = System.Drawing.Color.Transparent
        Me.update_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.update_button.BorderRadius = 0
        Me.update_button.ButtonText = "Update"
        Me.update_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_button.DisabledColor = System.Drawing.Color.Gray
        Me.update_button.Iconcolor = System.Drawing.Color.Transparent
        Me.update_button.Iconimage = Global.Ship_Star.My.Resources.Resources.right_arrow
        Me.update_button.Iconimage_right = Nothing
        Me.update_button.Iconimage_right_Selected = Nothing
        Me.update_button.Iconimage_Selected = Nothing
        Me.update_button.IconMarginLeft = 0
        Me.update_button.IconMarginRight = 0
        Me.update_button.IconRightVisible = True
        Me.update_button.IconRightZoom = 0R
        Me.update_button.IconVisible = True
        Me.update_button.IconZoom = 80.0R
        Me.update_button.IsTab = False
        Me.update_button.Location = New System.Drawing.Point(640, 383)
        Me.update_button.Name = "update_button"
        Me.update_button.Normalcolor = System.Drawing.Color.Transparent
        Me.update_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.update_button.OnHoverTextColor = System.Drawing.Color.White
        Me.update_button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.update_button.selected = False
        Me.update_button.Size = New System.Drawing.Size(192, 58)
        Me.update_button.TabIndex = 69
        Me.update_button.Text = "Update"
        Me.update_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.update_button.Textcolor = System.Drawing.Color.White
        Me.update_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cancel_button
        '
        Me.cancel_button.Activecolor = System.Drawing.Color.Transparent
        Me.cancel_button.BackColor = System.Drawing.Color.Transparent
        Me.cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancel_button.BorderRadius = 0
        Me.cancel_button.ButtonText = "Cancel"
        Me.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel_button.DisabledColor = System.Drawing.Color.Gray
        Me.cancel_button.Iconcolor = System.Drawing.Color.Transparent
        Me.cancel_button.Iconimage = Global.Ship_Star.My.Resources.Resources._error
        Me.cancel_button.Iconimage_right = Nothing
        Me.cancel_button.Iconimage_right_Selected = Nothing
        Me.cancel_button.Iconimage_Selected = Nothing
        Me.cancel_button.IconMarginLeft = 0
        Me.cancel_button.IconMarginRight = 0
        Me.cancel_button.IconRightVisible = True
        Me.cancel_button.IconRightZoom = 0R
        Me.cancel_button.IconVisible = True
        Me.cancel_button.IconZoom = 80.0R
        Me.cancel_button.IsTab = False
        Me.cancel_button.Location = New System.Drawing.Point(42, 383)
        Me.cancel_button.Name = "cancel_button"
        Me.cancel_button.Normalcolor = System.Drawing.Color.Transparent
        Me.cancel_button.OnHovercolor = System.Drawing.Color.Crimson
        Me.cancel_button.OnHoverTextColor = System.Drawing.Color.White
        Me.cancel_button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cancel_button.selected = False
        Me.cancel_button.Size = New System.Drawing.Size(192, 55)
        Me.cancel_button.TabIndex = 70
        Me.cancel_button.Text = "Cancel"
        Me.cancel_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel_button.Textcolor = System.Drawing.Color.White
        Me.cancel_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'destination_textbox
        '
        Me.destination_textbox.Enabled = False
        Me.destination_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.destination_textbox.Location = New System.Drawing.Point(42, 165)
        Me.destination_textbox.Name = "destination_textbox"
        Me.destination_textbox.ReadOnly = True
        Me.destination_textbox.Size = New System.Drawing.Size(339, 26)
        Me.destination_textbox.TabIndex = 78
        Me.destination_textbox.ThemeName = "Crystal"
        '
        'ship_name_textbox
        '
        Me.ship_name_textbox.Enabled = False
        Me.ship_name_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ship_name_textbox.Location = New System.Drawing.Point(42, 285)
        Me.ship_name_textbox.Name = "ship_name_textbox"
        Me.ship_name_textbox.ReadOnly = True
        Me.ship_name_textbox.Size = New System.Drawing.Size(339, 26)
        Me.ship_name_textbox.TabIndex = 79
        Me.ship_name_textbox.ThemeName = "Crystal"
        '
        'accomodation_textbox
        '
        Me.accomodation_textbox.Enabled = False
        Me.accomodation_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.accomodation_textbox.Location = New System.Drawing.Point(42, 343)
        Me.accomodation_textbox.Name = "accomodation_textbox"
        Me.accomodation_textbox.ReadOnly = True
        Me.accomodation_textbox.Size = New System.Drawing.Size(339, 26)
        Me.accomodation_textbox.TabIndex = 80
        Me.accomodation_textbox.ThemeName = "Crystal"
        '
        'seat_number_textbox
        '
        Me.seat_number_textbox.Enabled = False
        Me.seat_number_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.seat_number_textbox.Location = New System.Drawing.Point(493, 106)
        Me.seat_number_textbox.Name = "seat_number_textbox"
        Me.seat_number_textbox.ReadOnly = True
        Me.seat_number_textbox.Size = New System.Drawing.Size(339, 26)
        Me.seat_number_textbox.TabIndex = 81
        Me.seat_number_textbox.ThemeName = "Crystal"
        '
        'Update_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.seat_number_textbox)
        Me.Controls.Add(Me.accomodation_textbox)
        Me.Controls.Add(Me.ship_name_textbox)
        Me.Controls.Add(Me.destination_textbox)
        Me.Controls.Add(Me.date_booked_datepicker)
        Me.Controls.Add(Me.fare_type_dropdown)
        Me.Controls.Add(Me.date_sail_datepicker)
        Me.Controls.Add(Me.update_button)
        Me.Controls.Add(Me.cancel_button)
        Me.Controls.Add(Me.passenger_name_textbox)
        Me.Controls.Add(Me.ticket_number_text)
        Me.Controls.Add(Me.passenger_age_textbox)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Update_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update_Form"
        CType(Me.date_booked_datepicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fare_type_dropdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_sail_datepicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passenger_name_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ticket_number_text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passenger_age_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.destination_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ship_name_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accomodation_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seat_number_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents date_booked_datepicker As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents fare_type_dropdown As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents date_sail_datepicker As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents update_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cancel_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents passenger_name_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ticket_number_text As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents CrystalTheme As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents passenger_age_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents date_booked_label As Label
    Friend WithEvents fare_type_label As Label
    Friend WithEvents passenger_age_label As Label
    Friend WithEvents passenger_label As Label
    Friend WithEvents seat_number_label As Label
    Friend WithEvents accommodation_type_label As Label
    Friend WithEvents ship_name_label As Label
    Friend WithEvents date_sail_label As Label
    Friend WithEvents destination_label As Label
    Friend WithEvents ticket_number_label As Label
    Friend WithEvents book_new_customer_label As Label
    Friend WithEvents destination_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ship_name_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents accomodation_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents seat_number_textbox As Telerik.WinControls.UI.RadTextBox
End Class
