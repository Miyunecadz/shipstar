<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentication_Form
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
        Me.menu_panel = New System.Windows.Forms.Panel()
        Me.signup_button_menu_panel = New System.Windows.Forms.Button()
        Me.login_button_menu_panel = New System.Windows.Forms.Button()
        Me.CrystalTheme = New Telerik.WinControls.Themes.CrystalTheme()
        Me.taskbar_panel = New System.Windows.Forms.Panel()
        Me.content_panel = New System.Windows.Forms.Panel()
        Me.Exit_button = New System.Windows.Forms.Button()
        Me.menu_panel.SuspendLayout()
        Me.taskbar_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_panel
        '
        Me.menu_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.menu_panel.Controls.Add(Me.signup_button_menu_panel)
        Me.menu_panel.Controls.Add(Me.login_button_menu_panel)
        Me.menu_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.menu_panel.Location = New System.Drawing.Point(0, 31)
        Me.menu_panel.Name = "menu_panel"
        Me.menu_panel.Size = New System.Drawing.Size(442, 51)
        Me.menu_panel.TabIndex = 1
        '
        'signup_button_menu_panel
        '
        Me.signup_button_menu_panel.FlatAppearance.BorderSize = 0
        Me.signup_button_menu_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signup_button_menu_panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signup_button_menu_panel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.signup_button_menu_panel.Location = New System.Drawing.Point(228, 6)
        Me.signup_button_menu_panel.Name = "signup_button_menu_panel"
        Me.signup_button_menu_panel.Size = New System.Drawing.Size(211, 39)
        Me.signup_button_menu_panel.TabIndex = 1
        Me.signup_button_menu_panel.Text = "Sign Up"
        Me.signup_button_menu_panel.UseVisualStyleBackColor = True
        '
        'login_button_menu_panel
        '
        Me.login_button_menu_panel.FlatAppearance.BorderSize = 0
        Me.login_button_menu_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_button_menu_panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_button_menu_panel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.login_button_menu_panel.Location = New System.Drawing.Point(3, 6)
        Me.login_button_menu_panel.Name = "login_button_menu_panel"
        Me.login_button_menu_panel.Size = New System.Drawing.Size(213, 39)
        Me.login_button_menu_panel.TabIndex = 0
        Me.login_button_menu_panel.Text = "Login"
        Me.login_button_menu_panel.UseVisualStyleBackColor = True
        '
        'taskbar_panel
        '
        Me.taskbar_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.taskbar_panel.Controls.Add(Me.Exit_button)
        Me.taskbar_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.taskbar_panel.Location = New System.Drawing.Point(0, 0)
        Me.taskbar_panel.Name = "taskbar_panel"
        Me.taskbar_panel.Size = New System.Drawing.Size(442, 31)
        Me.taskbar_panel.TabIndex = 2
        '
        'content_panel
        '
        Me.content_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.content_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.content_panel.Location = New System.Drawing.Point(0, 82)
        Me.content_panel.Name = "content_panel"
        Me.content_panel.Size = New System.Drawing.Size(442, 329)
        Me.content_panel.TabIndex = 3
        '
        'Exit_button
        '
        Me.Exit_button.BackgroundImage = Global.Ship_Star.My.Resources.Resources._error
        Me.Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Exit_button.FlatAppearance.BorderSize = 0
        Me.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Exit_button.Location = New System.Drawing.Point(4, 5)
        Me.Exit_button.Name = "Exit_button"
        Me.Exit_button.Size = New System.Drawing.Size(23, 23)
        Me.Exit_button.TabIndex = 0
        Me.Exit_button.UseVisualStyleBackColor = True
        '
        'Authentication_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 411)
        Me.Controls.Add(Me.content_panel)
        Me.Controls.Add(Me.menu_panel)
        Me.Controls.Add(Me.taskbar_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Authentication_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.menu_panel.ResumeLayout(False)
        Me.taskbar_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents menu_panel As Panel
    Friend WithEvents login_button_menu_panel As Button
    Friend WithEvents signup_button_menu_panel As Button
    Friend WithEvents CrystalTheme As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents taskbar_panel As Panel
    Friend WithEvents content_panel As Panel
    Friend WithEvents Exit_button As Button
End Class
