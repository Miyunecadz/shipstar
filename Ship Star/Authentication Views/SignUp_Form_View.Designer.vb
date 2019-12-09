<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp_Form_View
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
        Me.member_signup_label = New System.Windows.Forms.Label()
        Me.fullname_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.fullname_label = New System.Windows.Forms.Label()
        Me.username_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.username_label = New System.Windows.Forms.Label()
        Me.password_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.password_label = New System.Windows.Forms.Label()
        Me.branch_label = New System.Windows.Forms.Label()
        Me.signup_button = New System.Windows.Forms.Button()
        Me.branch_dropdown = New System.Windows.Forms.ComboBox()
        CType(Me.fullname_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.username_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.password_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'member_signup_label
        '
        Me.member_signup_label.AutoSize = True
        Me.member_signup_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.member_signup_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.member_signup_label.Location = New System.Drawing.Point(73, 11)
        Me.member_signup_label.Name = "member_signup_label"
        Me.member_signup_label.Size = New System.Drawing.Size(297, 33)
        Me.member_signup_label.TabIndex = 5
        Me.member_signup_label.Text = "Member Signup Form"
        '
        'fullname_textbox
        '
        Me.fullname_textbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_textbox.Location = New System.Drawing.Point(45, 75)
        Me.fullname_textbox.Name = "fullname_textbox"
        Me.fullname_textbox.Size = New System.Drawing.Size(348, 27)
        Me.fullname_textbox.TabIndex = 7
        Me.fullname_textbox.ThemeName = "Crystal"
        '
        'fullname_label
        '
        Me.fullname_label.AutoSize = True
        Me.fullname_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.fullname_label.Location = New System.Drawing.Point(42, 54)
        Me.fullname_label.Name = "fullname_label"
        Me.fullname_label.Size = New System.Drawing.Size(67, 15)
        Me.fullname_label.TabIndex = 6
        Me.fullname_label.Text = "Full Name:"
        '
        'username_textbox
        '
        Me.username_textbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_textbox.Location = New System.Drawing.Point(45, 132)
        Me.username_textbox.Name = "username_textbox"
        Me.username_textbox.Size = New System.Drawing.Size(348, 27)
        Me.username_textbox.TabIndex = 3
        Me.username_textbox.ThemeName = "Crystal"
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.username_label.Location = New System.Drawing.Point(42, 111)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(68, 15)
        Me.username_label.TabIndex = 2
        Me.username_label.Text = "Username:"
        '
        'password_textbox
        '
        Me.password_textbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_textbox.Location = New System.Drawing.Point(45, 191)
        Me.password_textbox.Name = "password_textbox"
        Me.password_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_textbox.Size = New System.Drawing.Size(348, 27)
        Me.password_textbox.TabIndex = 9
        Me.password_textbox.ThemeName = "Crystal"
        '
        'password_label
        '
        Me.password_label.AutoSize = True
        Me.password_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.password_label.Location = New System.Drawing.Point(42, 170)
        Me.password_label.Name = "password_label"
        Me.password_label.Size = New System.Drawing.Size(64, 15)
        Me.password_label.TabIndex = 8
        Me.password_label.Text = "Password:"
        '
        'branch_label
        '
        Me.branch_label.AutoSize = True
        Me.branch_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branch_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.branch_label.Location = New System.Drawing.Point(42, 235)
        Me.branch_label.Name = "branch_label"
        Me.branch_label.Size = New System.Drawing.Size(49, 15)
        Me.branch_label.TabIndex = 10
        Me.branch_label.Text = "Branch:"
        '
        'signup_button
        '
        Me.signup_button.FlatAppearance.BorderSize = 0
        Me.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signup_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signup_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.signup_button.Location = New System.Drawing.Point(144, 271)
        Me.signup_button.Name = "signup_button"
        Me.signup_button.Size = New System.Drawing.Size(148, 42)
        Me.signup_button.TabIndex = 12
        Me.signup_button.Text = "Signup"
        Me.signup_button.UseVisualStyleBackColor = True
        '
        'branch_dropdown
        '
        Me.branch_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.branch_dropdown.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.branch_dropdown.FormattingEnabled = True
        Me.branch_dropdown.Items.AddRange(New Object() {"Cebu", "Hilongos"})
        Me.branch_dropdown.Location = New System.Drawing.Point(97, 229)
        Me.branch_dropdown.Name = "branch_dropdown"
        Me.branch_dropdown.Size = New System.Drawing.Size(138, 28)
        Me.branch_dropdown.TabIndex = 13
        '
        'SignUp_Form_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.branch_dropdown)
        Me.Controls.Add(Me.signup_button)
        Me.Controls.Add(Me.branch_label)
        Me.Controls.Add(Me.password_textbox)
        Me.Controls.Add(Me.password_label)
        Me.Controls.Add(Me.username_textbox)
        Me.Controls.Add(Me.username_label)
        Me.Controls.Add(Me.fullname_textbox)
        Me.Controls.Add(Me.fullname_label)
        Me.Controls.Add(Me.member_signup_label)
        Me.Name = "SignUp_Form_View"
        Me.Size = New System.Drawing.Size(442, 329)
        CType(Me.fullname_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.username_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.password_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents member_signup_label As Label
    Friend WithEvents fullname_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents fullname_label As Label
    Friend WithEvents username_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents username_label As Label
    Friend WithEvents password_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents password_label As Label
    Friend WithEvents branch_label As Label
    Friend WithEvents signup_button As Button
    Friend WithEvents branch_dropdown As ComboBox
End Class
