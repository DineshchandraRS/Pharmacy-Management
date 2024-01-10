<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminpage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMedicineName = New System.Windows.Forms.TextBox()
        Me.txtMedicinePrice = New System.Windows.Forms.TextBox()
        Me.txtMedicineQuantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.MedicineNames = New System.Windows.Forms.ListBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label1.Location = New System.Drawing.Point(31, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Medicine Name"
        '
        'txtMedicineName
        '
        Me.txtMedicineName.Location = New System.Drawing.Point(35, 133)
        Me.txtMedicineName.Name = "txtMedicineName"
        Me.txtMedicineName.Size = New System.Drawing.Size(361, 26)
        Me.txtMedicineName.TabIndex = 1
        '
        'txtMedicinePrice
        '
        Me.txtMedicinePrice.Location = New System.Drawing.Point(35, 253)
        Me.txtMedicinePrice.Name = "txtMedicinePrice"
        Me.txtMedicinePrice.Size = New System.Drawing.Size(361, 26)
        Me.txtMedicinePrice.TabIndex = 2
        '
        'txtMedicineQuantity
        '
        Me.txtMedicineQuantity.Location = New System.Drawing.Point(35, 380)
        Me.txtMedicineQuantity.Name = "txtMedicineQuantity"
        Me.txtMedicineQuantity.Size = New System.Drawing.Size(361, 26)
        Me.txtMedicineQuantity.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label2.Location = New System.Drawing.Point(31, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Medicine Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label3.Location = New System.Drawing.Point(31, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantity"
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.SpringGreen
        Me.btnadd.Location = New System.Drawing.Point(44, 507)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(86, 42)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.SpringGreen
        Me.btnupdate.Location = New System.Drawing.Point(174, 507)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(95, 42)
        Me.btnupdate.TabIndex = 7
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.Color.SpringGreen
        Me.delete.Location = New System.Drawing.Point(315, 506)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(90, 43)
        Me.delete.TabIndex = 8
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'MedicineNames
        '
        Me.MedicineNames.FormattingEnabled = True
        Me.MedicineNames.ItemHeight = 20
        Me.MedicineNames.Location = New System.Drawing.Point(568, 75)
        Me.MedicineNames.Name = "MedicineNames"
        Me.MedicineNames.Size = New System.Drawing.Size(389, 364)
        Me.MedicineNames.TabIndex = 9
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(823, 480)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(92, 28)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Logout"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.SpringGreen
        Me.btnclear.Location = New System.Drawing.Point(471, 507)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(110, 42)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblUsername.Location = New System.Drawing.Point(35, 13)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(78, 29)
        Me.lblUsername.TabIndex = 13
        Me.lblUsername.Text = "Label4"
        '
        'adminpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 594)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.MedicineNames)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMedicineQuantity)
        Me.Controls.Add(Me.txtMedicinePrice)
        Me.Controls.Add(Me.txtMedicineName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminpage"
        Me.Text = "adminpage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMedicineName As TextBox
    Friend WithEvents txtMedicinePrice As TextBox
    Friend WithEvents txtMedicineQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents delete As Button
    Friend WithEvents MedicineNames As ListBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnclear As Button
    Friend WithEvents lblUsername As Label
End Class
