<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderHistory
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
        Me.DataGridViewOrderHistory = New System.Windows.Forms.DataGridView()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacyManagementDataSet2 = New Pharmacy_Management_System.PharmacyManagementDataSet2()
        Me.btnhomepage = New System.Windows.Forms.Button()
        Me.OrdersTableAdapter = New Pharmacy_Management_System.PharmacyManagementDataSet2TableAdapters.OrdersTableAdapter()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewOrderHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyManagementDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewOrderHistory
        '
        Me.DataGridViewOrderHistory.AutoGenerateColumns = False
        Me.DataGridViewOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrderHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.PaymentModeDataGridViewTextBoxColumn})
        Me.DataGridViewOrderHistory.DataSource = Me.OrdersBindingSource
        Me.DataGridViewOrderHistory.Location = New System.Drawing.Point(12, 55)
        Me.DataGridViewOrderHistory.Name = "DataGridViewOrderHistory"
        Me.DataGridViewOrderHistory.RowHeadersWidth = 62
        Me.DataGridViewOrderHistory.RowTemplate.Height = 28
        Me.DataGridViewOrderHistory.Size = New System.Drawing.Size(991, 348)
        Me.DataGridViewOrderHistory.TabIndex = 0
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.PharmacyManagementDataSet2
        '
        'PharmacyManagementDataSet2
        '
        Me.PharmacyManagementDataSet2.DataSetName = "PharmacyManagementDataSet2"
        Me.PharmacyManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnhomepage
        '
        Me.btnhomepage.Location = New System.Drawing.Point(852, 437)
        Me.btnhomepage.Name = "btnhomepage"
        Me.btnhomepage.Size = New System.Drawing.Size(163, 50)
        Me.btnhomepage.TabIndex = 1
        Me.btnhomepage.Text = "Home Page"
        Me.btnhomepage.UseVisualStyleBackColor = True
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "OrderID"
        Me.OrderIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        Me.OrderIDDataGridViewTextBoxColumn.Width = 150
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.Width = 150
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "Orderdate"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "Orderdate"
        Me.OrderdateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        Me.OrderdateDataGridViewTextBoxColumn.Width = 150
        '
        'PaymentModeDataGridViewTextBoxColumn
        '
        Me.PaymentModeDataGridViewTextBoxColumn.DataPropertyName = "PaymentMode"
        Me.PaymentModeDataGridViewTextBoxColumn.HeaderText = "PaymentMode"
        Me.PaymentModeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PaymentModeDataGridViewTextBoxColumn.Name = "PaymentModeDataGridViewTextBoxColumn"
        Me.PaymentModeDataGridViewTextBoxColumn.Width = 150
        '
        'OrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 510)
        Me.Controls.Add(Me.btnhomepage)
        Me.Controls.Add(Me.DataGridViewOrderHistory)
        Me.Name = "OrderHistory"
        Me.Text = "OrderHistory"
        CType(Me.DataGridViewOrderHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyManagementDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewOrderHistory As DataGridView
    Friend WithEvents btnhomepage As Button
    Friend WithEvents PharmacyManagementDataSet2 As PharmacyManagementDataSet2
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As PharmacyManagementDataSet2TableAdapters.OrdersTableAdapter
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentModeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
