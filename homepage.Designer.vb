<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homepage
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MedicinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacyManagementDataSet = New Pharmacy_Management_System.PharmacyManagementDataSet()
        Me.MedicinesTableAdapter = New Pharmacy_Management_System.PharmacyManagementDataSetTableAdapters.MedicinesTableAdapter()
        Me.cart = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.RadioButton()
        Me.btnorderhistory = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.MedicineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicineID, Me.MedicineName, Me.Price, Me.Count})
        Me.DataGridView1.DataSource = Me.MedicinesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 234)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(995, 369)
        Me.DataGridView1.TabIndex = 0
        '
        'MedicinesBindingSource
        '
        Me.MedicinesBindingSource.DataMember = "Medicines"
        Me.MedicinesBindingSource.DataSource = Me.PharmacyManagementDataSet
        '
        'PharmacyManagementDataSet
        '
        Me.PharmacyManagementDataSet.DataSetName = "PharmacyManagementDataSet"
        Me.PharmacyManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicinesTableAdapter
        '
        Me.MedicinesTableAdapter.ClearBeforeFill = True
        '
        'cart
        '
        Me.cart.Location = New System.Drawing.Point(815, 673)
        Me.cart.Name = "cart"
        Me.cart.Size = New System.Drawing.Size(192, 40)
        Me.cart.TabIndex = 1
        Me.cart.Text = "Cart"
        Me.cart.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.AutoSize = True
        Me.btnlogout.Location = New System.Drawing.Point(916, 12)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(91, 24)
        Me.btnlogout.TabIndex = 2
        Me.btnlogout.TabStop = True
        Me.btnlogout.Text = "Log Out"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btnorderhistory
        '
        Me.btnorderhistory.Location = New System.Drawing.Point(841, 77)
        Me.btnorderhistory.Name = "btnorderhistory"
        Me.btnorderhistory.Size = New System.Drawing.Size(166, 35)
        Me.btnorderhistory.TabIndex = 3
        Me.btnorderhistory.Text = "Order History"
        Me.btnorderhistory.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblUsername.Location = New System.Drawing.Point(65, 37)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(78, 29)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Label1"
        '
        'MedicineID
        '
        Me.MedicineID.DataPropertyName = "MedicineID"
        Me.MedicineID.HeaderText = "MedicineID"
        Me.MedicineID.MinimumWidth = 8
        Me.MedicineID.Name = "MedicineID"
        Me.MedicineID.ReadOnly = True
        Me.MedicineID.Width = 150
        '
        'MedicineName
        '
        Me.MedicineName.DataPropertyName = "MedicineName"
        Me.MedicineName.HeaderText = "MedicineName"
        Me.MedicineName.MinimumWidth = 8
        Me.MedicineName.Name = "MedicineName"
        Me.MedicineName.Width = 150
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 8
        Me.Price.Name = "Price"
        Me.Price.Width = 150
        '
        'Count
        '
        Me.Count.DataPropertyName = "Count"
        Me.Count.HeaderText = "Count"
        Me.Count.MinimumWidth = 8
        Me.Count.Name = "Count"
        Me.Count.Width = 150
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 749)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnorderhistory)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.cart)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "homepage"
        Me.Text = "homepage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PharmacyManagementDataSet As PharmacyManagementDataSet
    Friend WithEvents MedicinesBindingSource As BindingSource
    Friend WithEvents MedicinesTableAdapter As PharmacyManagementDataSetTableAdapters.MedicinesTableAdapter
    Friend WithEvents cart As Button
    Friend WithEvents btnlogout As RadioButton
    Friend WithEvents btnorderhistory As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents MedicineID As DataGridViewTextBoxColumn
    Friend WithEvents MedicineName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Count As DataGridViewTextBoxColumn
End Class
