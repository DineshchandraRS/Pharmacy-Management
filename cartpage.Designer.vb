<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cartpage
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
        Me.components = New System.ComponentModel.Container()
        Me.PharmacyManagementDataSet = New Pharmacy_Management_System.PharmacyManagementDataSet()
        Me.PharmacyManagementDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacyManagementDataSet1 = New Pharmacy_Management_System.PharmacyManagementDataSet1()
        Me.PharmacyManagementDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CashonDelivery = New System.Windows.Forms.RadioButton()
        Me.DataGridViewCart = New System.Windows.Forms.DataGridView()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnhomepage = New System.Windows.Forms.Button()
        CType(Me.PharmacyManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyManagementDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyManagementDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PharmacyManagementDataSet
        '
        Me.PharmacyManagementDataSet.DataSetName = "PharmacyManagementDataSet"
        Me.PharmacyManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PharmacyManagementDataSetBindingSource
        '
        Me.PharmacyManagementDataSetBindingSource.DataSource = Me.PharmacyManagementDataSet
        Me.PharmacyManagementDataSetBindingSource.Position = 0
        '
        'PharmacyManagementDataSet1
        '
        Me.PharmacyManagementDataSet1.DataSetName = "PharmacyManagementDataSet1"
        Me.PharmacyManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PharmacyManagementDataSet1BindingSource
        '
        Me.PharmacyManagementDataSet1BindingSource.DataSource = Me.PharmacyManagementDataSet1
        Me.PharmacyManagementDataSet1BindingSource.Position = 0
        '
        'CashonDelivery
        '
        Me.CashonDelivery.AutoSize = True
        Me.CashonDelivery.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CashonDelivery.Location = New System.Drawing.Point(58, 483)
        Me.CashonDelivery.Name = "CashonDelivery"
        Me.CashonDelivery.Size = New System.Drawing.Size(155, 24)
        Me.CashonDelivery.TabIndex = 1
        Me.CashonDelivery.TabStop = True
        Me.CashonDelivery.Text = "Cash On Delivery"
        Me.CashonDelivery.UseVisualStyleBackColor = False
        '
        'DataGridViewCart
        '
        Me.DataGridViewCart.AutoGenerateColumns = False
        Me.DataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCart.DataSource = Me.PharmacyManagementDataSet1
        Me.DataGridViewCart.Location = New System.Drawing.Point(28, 45)
        Me.DataGridViewCart.Name = "DataGridViewCart"
        Me.DataGridViewCart.RowHeadersWidth = 62
        Me.DataGridViewCart.RowTemplate.Height = 28
        Me.DataGridViewCart.Size = New System.Drawing.Size(894, 341)
        Me.DataGridViewCart.TabIndex = 3
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(780, 467)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(149, 40)
        Me.btnPlaceOrder.TabIndex = 4
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnhomepage
        '
        Me.btnhomepage.Location = New System.Drawing.Point(575, 467)
        Me.btnhomepage.Name = "btnhomepage"
        Me.btnhomepage.Size = New System.Drawing.Size(169, 40)
        Me.btnhomepage.TabIndex = 5
        Me.btnhomepage.Text = "HomePage"
        Me.btnhomepage.UseVisualStyleBackColor = True
        '
        'cartpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 545)
        Me.Controls.Add(Me.btnhomepage)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.DataGridViewCart)
        Me.Controls.Add(Me.CashonDelivery)
        Me.Name = "cartpage"
        Me.Text = "cartpage"
        CType(Me.PharmacyManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyManagementDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyManagementDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PharmacyManagementDataSet1BindingSource As BindingSource
    Friend WithEvents PharmacyManagementDataSet1 As PharmacyManagementDataSet1
    Friend WithEvents PharmacyManagementDataSet As PharmacyManagementDataSet
    Friend WithEvents PharmacyManagementDataSetBindingSource As BindingSource
    Friend WithEvents CashonDelivery As RadioButton
    Friend WithEvents DataGridViewCart As DataGridView
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnhomepage As Button
End Class
