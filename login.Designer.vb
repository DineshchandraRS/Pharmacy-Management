<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.heading = New System.Windows.Forms.Label()
        Me.Username1 = New System.Windows.Forms.TextBox()
        Me.password1 = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.loginButton1 = New System.Windows.Forms.Button()
        Me.admin = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'heading
        '
        Me.heading.AutoSize = True
        Me.heading.Location = New System.Drawing.Point(287, 99)
        Me.heading.Name = "heading"
        Me.heading.Size = New System.Drawing.Size(0, 20)
        Me.heading.TabIndex = 1
        '
        'Username1
        '
        Me.Username1.Location = New System.Drawing.Point(202, 159)
        Me.Username1.Name = "Username1"
        Me.Username1.Size = New System.Drawing.Size(353, 26)
        Me.Username1.TabIndex = 2
        '
        'password1
        '
        Me.password1.Location = New System.Drawing.Point(202, 266)
        Me.password1.Name = "password1"
        Me.password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password1.Size = New System.Drawing.Size(353, 26)
        Me.password1.TabIndex = 3
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.SpringGreen
        Me.username.Location = New System.Drawing.Point(198, 99)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(95, 24)
        Me.username.TabIndex = 4
        Me.username.Text = "Username"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.SpringGreen
        Me.password.Location = New System.Drawing.Point(202, 212)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(89, 24)
        Me.password.TabIndex = 5
        Me.password.Text = "Password"
        '
        'loginButton1
        '
        Me.loginButton1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton1.ForeColor = System.Drawing.Color.SpringGreen
        Me.loginButton1.Location = New System.Drawing.Point(202, 329)
        Me.loginButton1.Name = "loginButton1"
        Me.loginButton1.Size = New System.Drawing.Size(85, 39)
        Me.loginButton1.TabIndex = 6
        Me.loginButton1.Text = "Login"
        Me.loginButton1.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.admin.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin.ForeColor = System.Drawing.Color.SpringGreen
        Me.admin.Location = New System.Drawing.Point(339, 329)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(85, 39)
        Me.admin.TabIndex = 7
        Me.admin.Text = "Admin"
        Me.admin.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.SpringGreen
        Me.header.Location = New System.Drawing.Point(124, 19)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(536, 49)
        Me.header.TabIndex = 8
        Me.header.Text = "Pharmacy Management System"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.loginButton1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.password1)
        Me.Controls.Add(Me.Username1)
        Me.Controls.Add(Me.heading)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents heading As Label
    Friend WithEvents Username1 As TextBox
    Friend WithEvents password1 As TextBox
    Friend WithEvents username As Label
    Friend WithEvents password As Label
    Friend WithEvents loginButton1 As Button
    Friend WithEvents admin As Button
    Friend WithEvents header As Label
End Class
