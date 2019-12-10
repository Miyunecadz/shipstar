<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu_Form
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
        Me.taskbar_panel = New System.Windows.Forms.Panel()
        Me.titlebar_panel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menubar_panel = New System.Windows.Forms.Panel()
        Me.logout_button = New System.Windows.Forms.Button()
        Me.view_records_button = New System.Windows.Forms.Button()
        Me.available_ship_button = New System.Windows.Forms.Button()
        Me.book_new_customer_button = New System.Windows.Forms.Button()
        Me.content_panel = New System.Windows.Forms.Panel()
        Me.titlebar_panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menubar_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'taskbar_panel
        '
        Me.taskbar_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.taskbar_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.taskbar_panel.Location = New System.Drawing.Point(0, 0)
        Me.taskbar_panel.Name = "taskbar_panel"
        Me.taskbar_panel.Size = New System.Drawing.Size(870, 25)
        Me.taskbar_panel.TabIndex = 0
        '
        'titlebar_panel
        '
        Me.titlebar_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.titlebar_panel.Controls.Add(Me.PictureBox1)
        Me.titlebar_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlebar_panel.Location = New System.Drawing.Point(0, 25)
        Me.titlebar_panel.Name = "titlebar_panel"
        Me.titlebar_panel.Size = New System.Drawing.Size(870, 81)
        Me.titlebar_panel.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ship_Star.My.Resources.Resources.logo_shipstar11
        Me.PictureBox1.Location = New System.Drawing.Point(222, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'menubar_panel
        '
        Me.menubar_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.menubar_panel.Controls.Add(Me.logout_button)
        Me.menubar_panel.Controls.Add(Me.view_records_button)
        Me.menubar_panel.Controls.Add(Me.available_ship_button)
        Me.menubar_panel.Controls.Add(Me.book_new_customer_button)
        Me.menubar_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.menubar_panel.Location = New System.Drawing.Point(0, 106)
        Me.menubar_panel.Name = "menubar_panel"
        Me.menubar_panel.Size = New System.Drawing.Size(870, 45)
        Me.menubar_panel.TabIndex = 2
        '
        'logout_button
        '
        Me.logout_button.FlatAppearance.BorderSize = 0
        Me.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.logout_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.logout_button.Location = New System.Drawing.Point(654, 3)
        Me.logout_button.Name = "logout_button"
        Me.logout_button.Size = New System.Drawing.Size(210, 39)
        Me.logout_button.TabIndex = 4
        Me.logout_button.Text = "Logout"
        Me.logout_button.UseVisualStyleBackColor = True
        '
        'view_records_button
        '
        Me.view_records_button.FlatAppearance.BorderSize = 0
        Me.view_records_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.view_records_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.view_records_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.view_records_button.Location = New System.Drawing.Point(438, 3)
        Me.view_records_button.Name = "view_records_button"
        Me.view_records_button.Size = New System.Drawing.Size(210, 39)
        Me.view_records_button.TabIndex = 3
        Me.view_records_button.Text = "View Records"
        Me.view_records_button.UseVisualStyleBackColor = True
        '
        'available_ship_button
        '
        Me.available_ship_button.FlatAppearance.BorderSize = 0
        Me.available_ship_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.available_ship_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.available_ship_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.available_ship_button.Location = New System.Drawing.Point(222, 3)
        Me.available_ship_button.Name = "available_ship_button"
        Me.available_ship_button.Size = New System.Drawing.Size(210, 39)
        Me.available_ship_button.TabIndex = 2
        Me.available_ship_button.Text = "Available Ship"
        Me.available_ship_button.UseVisualStyleBackColor = True
        '
        'book_new_customer_button
        '
        Me.book_new_customer_button.FlatAppearance.BorderSize = 0
        Me.book_new_customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.book_new_customer_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.book_new_customer_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.book_new_customer_button.Location = New System.Drawing.Point(6, 3)
        Me.book_new_customer_button.Name = "book_new_customer_button"
        Me.book_new_customer_button.Size = New System.Drawing.Size(210, 39)
        Me.book_new_customer_button.TabIndex = 0
        Me.book_new_customer_button.Text = "Book New Customer"
        Me.book_new_customer_button.UseVisualStyleBackColor = True
        '
        'content_panel
        '
        Me.content_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.content_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.content_panel.Location = New System.Drawing.Point(0, 151)
        Me.content_panel.Name = "content_panel"
        Me.content_panel.Size = New System.Drawing.Size(870, 449)
        Me.content_panel.TabIndex = 3
        '
        'MainMenu_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 600)
        Me.Controls.Add(Me.content_panel)
        Me.Controls.Add(Me.menubar_panel)
        Me.Controls.Add(Me.titlebar_panel)
        Me.Controls.Add(Me.taskbar_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.titlebar_panel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menubar_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents taskbar_panel As Panel
    Friend WithEvents titlebar_panel As Panel
    Friend WithEvents menubar_panel As Panel
    Friend WithEvents content_panel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents book_new_customer_button As Button
    Friend WithEvents view_records_button As Button
    Friend WithEvents logout_button As Button
    Friend WithEvents available_ship_button As Button
End Class
