<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form_View
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.username_label = New System.Windows.Forms.Label()
        Me.username_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.password_textbox = New Telerik.WinControls.UI.RadTextBox()
        Me.password_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.login_button = New System.Windows.Forms.Button()
        CType(Me.username_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.password_textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.username_label.Location = New System.Drawing.Point(49, 99)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(68, 15)
        Me.username_label.TabIndex = 0
        Me.username_label.Text = "Username:"
        '
        'username_textbox
        '
        Me.username_textbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_textbox.Location = New System.Drawing.Point(52, 120)
        Me.username_textbox.Name = "username_textbox"
        Me.username_textbox.Size = New System.Drawing.Size(348, 27)
        Me.username_textbox.TabIndex = 1
        Me.username_textbox.ThemeName = "Crystal"
        '
        'password_textbox
        '
        Me.password_textbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_textbox.Location = New System.Drawing.Point(52, 188)
        Me.password_textbox.Name = "password_textbox"
        Me.password_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_textbox.Size = New System.Drawing.Size(348, 27)
        Me.password_textbox.TabIndex = 3
        Me.password_textbox.ThemeName = "Crystal"
        '
        'password_label
        '
        Me.password_label.AutoSize = True
        Me.password_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.password_label.Location = New System.Drawing.Point(49, 167)
        Me.password_label.Name = "password_label"
        Me.password_label.Size = New System.Drawing.Size(64, 15)
        Me.password_label.TabIndex = 2
        Me.password_label.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(123, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Member Login"
        '
        'login_button
        '
        Me.login_button.FlatAppearance.BorderSize = 0
        Me.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.login_button.Location = New System.Drawing.Point(149, 255)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(148, 42)
        Me.login_button.TabIndex = 5
        Me.login_button.Text = "Login"
        Me.login_button.UseVisualStyleBackColor = True
        '
        'Login_Form_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.password_textbox)
        Me.Controls.Add(Me.password_label)
        Me.Controls.Add(Me.username_textbox)
        Me.Controls.Add(Me.username_label)
        Me.Name = "Login_Form_View"
        Me.Size = New System.Drawing.Size(442, 329)
        CType(Me.username_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.password_textbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_label As Label
    Friend WithEvents username_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents password_textbox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents password_label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents login_button As Button
End Class
