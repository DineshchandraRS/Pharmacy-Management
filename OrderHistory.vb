Imports System.Data.SqlClient

Public Class OrderHistory
    Dim connectionString As String = My.Settings.PharmacyDBConnectionString
    Private orderHistoryBindingSource As New BindingSource()

    Private Sub LoadOrderHistory(userID As String)
        Try
            orderHistoryBindingSource.Clear()

            AddColumnsToDataGridView()

            Dim query As String = "SELECT OrderID, TotalAmount, OrderDate, PaymentMode FROM Orders WHERE UserID = @UserID ORDER BY OrderDate DESC"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            If Not reader.IsDBNull(0) Then
                                Dim orderID As String = reader.GetString(0)
                                Dim totalAmount As Decimal = reader.GetDecimal(1)
                                Dim orderDate As DateTime = reader.GetDateTime(2)
                                Dim paymentMode As String = reader.GetString(3)

                                ' Add a new row to the BindingSource
                                orderHistoryBindingSource.Add(New OrderHistoryItem(orderID, totalAmount, orderDate, paymentMode))
                            End If
                        End While
                    End Using
                End Using

                connection.Close()
            End Using

            ' Set the DataSource property of the DataGridView 
            If DataGridViewOrderHistory.InvokeRequired Then
                DataGridViewOrderHistory.Invoke(Sub() DataGridViewOrderHistory.DataSource = Nothing)
                DataGridViewOrderHistory.Invoke(Sub() DataGridViewOrderHistory.DataSource = orderHistoryBindingSource)
            Else
                DataGridViewOrderHistory.DataSource = Nothing
                DataGridViewOrderHistory.DataSource = orderHistoryBindingSource
            End If

            Console.WriteLine($"Loaded {orderHistoryBindingSource.Count} rows for UserID: {userID}")

        Catch ex As Exception
            ShowErrorMessageBox($"Error loading order history. Error: {ex.Message}")
        End Try
    End Sub


    Private Sub OrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userID As String = SessionModule.LoggedInUserID

        If Not String.IsNullOrEmpty(userID) Then
            LoadOrderHistory(userID)
        Else
            MessageBox.Show("User is not logged in.")
        End If
    End Sub

    Private Sub AddColumnsToDataGridView()
        If DataGridViewOrderHistory.InvokeRequired Then
            DataGridViewOrderHistory.Invoke(
                Sub()
                    If DataGridViewOrderHistory.Columns.Count = 0 Then
                        DataGridViewOrderHistory.Columns.Add("OrderID", "Order ID")
                        DataGridViewOrderHistory.Columns.Add("TotalAmount", "Total Amount")
                        DataGridViewOrderHistory.Columns.Add("OrderDate", "Order Date")
                        DataGridViewOrderHistory.Columns.Add("PaymentMode", "Payment Mode")

                    End If
                End Sub)
        Else
            If DataGridViewOrderHistory.Columns.Count = 0 Then
                DataGridViewOrderHistory.Columns.Add("OrderID", "Order ID")
                DataGridViewOrderHistory.Columns.Add("TotalAmount", "Total Amount")
                DataGridViewOrderHistory.Columns.Add("OrderDate", "Order Date")
                DataGridViewOrderHistory.Columns.Add("PaymentMode", "Payment Mode")

            End If
        End If
    End Sub

    Private Sub InvokeIfRequired(control As Control, action As Action)
        If control.InvokeRequired Then
            control.Invoke(New MethodInvoker(Sub() action()))
        Else
            action()
        End If
    End Sub

    Private Sub ShowErrorMessageBox(message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Class OrderHistoryItem
        Public Property OrderID As String
        Public Property TotalAmount As Decimal
        Public Property OrderDate As DateTime
        Public Property PaymentMode As String

        Public Sub New(orderID As String, totalAmount As Decimal, orderDate As DateTime, paymentMode As String)
            Me.OrderID = orderID
            Me.TotalAmount = totalAmount
            Me.OrderDate = orderDate
            Me.PaymentMode = paymentMode
        End Sub
    End Class

    Private Sub DataGridViewOrderHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrderHistory.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Assuming OrderID is the first column (index 0)
            If DataGridViewOrderHistory.Columns(e.ColumnIndex).Name = "OrderID" Then
                Dim selectedOrderID As String = DataGridViewOrderHistory.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

                MessageBox.Show($"Selected Order ID: {selectedOrderID}")
            End If
        End If
    End Sub

    Private Sub btnhomepage_Click(sender As Object, e As EventArgs) Handles btnhomepage.Click
        Me.Hide()
        Dim homeForm As New homepage()
        homeForm.Show()
    End Sub
End Class
