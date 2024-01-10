<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.AdButton1 = New System.Windows.Forms.Button()
        Me.adminusername = New System.Windows.Forms.Label()
        Me.adminpassword = New System.Windows.Forms.Label()
        Me.adminTextBoxusername = New System.Windows.Forms.TextBox()
        Me.adminTextBoxpassword = New System.Windows.Forms.TextBox()
        Me.adminheader = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AdButton1
        '
        Me.AdButton1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdButton1.ForeColor = System.Drawing.Color.SpringGreen
        Me.AdButton1.Location = New System.Drawing.Point(243, 334)
        Me.AdButton1.Name = "AdButton1"
        Me.AdButton1.Size = New System.Drawing.Size(111, 46)
        Me.AdButton1.TabIndex = 1
        Me.AdButton1.Text = "Login"
        Me.AdButton1.UseVisualStyleBackColor = True
        '
        'adminusername
        '
        Me.adminusername.AutoSize = True
        Me.adminusername.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminusername.ForeColor = System.Drawing.Color.SpringGreen
        Me.adminusername.Location = New System.Drawing.Point(239, 99)
        Me.adminusername.Name = "adminusername"
        Me.adminusername.Size = New System.Drawing.Size(95, 24)
        Me.adminusername.TabIndex = 2
        Me.adminusername.Text = "Username"
        '
        'adminpassword
        '
        Me.adminpassword.AutoSize = True
        Me.adminpassword.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminpassword.ForeColor = System.Drawing.Color.SpringGreen
        Me.adminpassword.Location = New System.Drawing.Point(239, 214)
        Me.adminpassword.Name = "adminpassword"
        Me.adminpassword.Size = New System.Drawing.Size(89, 24)
        Me.adminpassword.TabIndex = 3
        Me.adminpassword.Text = "Password"
        '
        'adminTextBoxusername
        '
        Me.adminTextBoxusername.Location = New System.Drawing.Point(243, 145)
        Me.adminTextBoxusername.Name = "adminTextBoxusername"
        Me.adminTextBoxusername.Size = New System.Drawing.Size(330, 26)
        Me.adminTextBoxusername.TabIndex = 4
        '
        'adminTextBoxpassword
        '
        Me.adminTextBoxpassword.Location = New System.Drawing.Point(243, 257)
        Me.adminTextBoxpassword.Name = "adminTextBoxpassword"
        Me.adminTextBoxpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.adminTextBoxpassword.Size = New System.Drawing.Size(330, 26)
        Me.adminTextBoxpassword.TabIndex = 5
        '
        'adminheader
        '
        Me.adminheader.AutoSize = True
        Me.adminheader.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminheader.ForeColor = System.Drawing.Color.SpringGreen
        Me.adminheader.Location = New System.Drawing.Point(136, 18)
        Me.adminheader.Name = "adminheader"
        Me.adminheader.Size = New System.Drawing.Size(536, 49)
        Me.adminheader.TabIndex = 6
        Me.adminheader.Text = "Pharmacy Management System"
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(459, 334)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(114, 46)
        Me.btnback.TabIndex = 7
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 537)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.adminheader)
        Me.Controls.Add(Me.adminTextBoxpassword)
        Me.Controls.Add(Me.adminTextBoxusername)
        Me.Controls.Add(Me.adminpassword)
        Me.Controls.Add(Me.adminusername)
        Me.Controls.Add(Me.AdButton1)
        Me.ForeColor = System.Drawing.Color.SpringGreen
        Me.Name = "admin"
        Me.Text = "users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdButton1 As Button
    Friend WithEvents adminusername As Label
    Friend WithEvents adminpassword As Label
    Friend WithEvents adminTextBoxusername As TextBox
    Friend WithEvents adminTextBoxpassword As TextBox
    Friend WithEvents adminheader As Label
    Friend WithEvents btnback As Button
End Class
