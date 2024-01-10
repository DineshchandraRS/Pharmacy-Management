Imports System.Data.SqlClient

Public Class cartpage
    Dim connectionString As String = My.Settings.PharmacyDBConnectionString
    Dim selectedMedicines As List(Of SelectedMedicine)
    Dim homepageReference As homepage

    Public Sub New(selectedMedicines As List(Of SelectedMedicine), homepageReference As homepage)
        InitializeComponent()

        Me.selectedMedicines = selectedMedicines
        Me.homepageReference = homepageReference

        RefreshCart(selectedMedicines)
    End Sub

    Public Sub RefreshCart(selectedMedicines As List(Of SelectedMedicine))
        DataGridViewCart.DataSource = Nothing


        DataGridViewCart.Columns.Add("MedicineIDColumn", "Medicine ID")
        DataGridViewCart.Columns.Add("MedicineNameColumn", "Medicine Name")
        DataGridViewCart.Columns.Add("CountColumn", "Count")
        DataGridViewCart.Columns.Add("TotalAmountColumn", "Total Amount")

        Dim deleteButtonColumn As New DataGridViewButtonColumn()
        deleteButtonColumn.Name = "DeleteColumn"
        deleteButtonColumn.HeaderText = "Delete"
        deleteButtonColumn.Text = "Delete"
        deleteButtonColumn.UseColumnTextForButtonValue = True
        DataGridViewCart.Columns.Add(deleteButtonColumn)


        DataGridViewCart.Columns("CountColumn").ValueType = GetType(Integer)

        ' Add each selected medicine to the DataGridView
        For Each medicine In selectedMedicines
            Dim rowIndex As Integer = DataGridViewCart.Rows.Add(medicine.MedicineID, medicine.MedicineName, medicine.Count, CalculateTotalAmount(medicine))
            DataGridViewCart.Rows(rowIndex).Tag = medicine
        Next
    End Sub

    Private Function CalculateTotalAmount(selectedMedicine As SelectedMedicine) As Decimal
        Return selectedMedicine.Count * selectedMedicine.Price
    End Function

    Private Sub PlaceOrder(paymentMode As String)

        Dim userID As String = SessionModule.LoggedInUserID

        If Not String.IsNullOrEmpty(userID) Then
            Dim orderID As String = GenerateOrderID(userID)

            ' Calculate the total amount for the order
            Dim totalAmount As Decimal = selectedMedicines.Sum(Function(medicine) CalculateTotalAmount(medicine))

            Dim orderDate As DateTime = DateTime.Now

            InsertOrderDetails(orderID, userID, totalAmount, orderDate, paymentMode)

            MessageBox.Show($"Order placed successfully! Order ID: {orderID}")

            selectedMedicines.Clear()
            RefreshCart(selectedMedicines)

            For Each row As DataGridViewRow In homepageReference.DataGridView1.Rows
                row.Cells("CountColumn").Value = 0
            Next

            homepageReference.ClearCartAndRefresh()

            ' Navigate back to the updated homepage
            homepageReference.Show()

            Me.Close()

        Else
            MessageBox.Show("User is not logged in.")
        End If
    End Sub

    Private Function GenerateOrderID(userID As String) As String
        ' Generate an order ID using the user ID (you can use a unique identifier like a GUID)
        Return $"{userID}_{Guid.NewGuid()}"
    End Function

    Private Sub InsertOrderDetails(orderID As String, userID As String, totalAmount As Decimal, orderDate As DateTime, paymentMode As String)

        Dim insertQuery As String = "INSERT INTO Orders (OrderID, UserID, TotalAmount, OrderDate, PaymentMode) VALUES (@OrderID, @UserID, @TotalAmount, @OrderDate, @PaymentMode)"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using insertCommand As New SqlCommand(insertQuery, connection)
                    insertCommand.Parameters.AddWithValue("@OrderID", orderID)
                    insertCommand.Parameters.AddWithValue("@UserID", userID)
                    insertCommand.Parameters.AddWithValue("@TotalAmount", totalAmount)
                    insertCommand.Parameters.AddWithValue("@OrderDate", orderDate)
                    insertCommand.Parameters.AddWithValue("@PaymentMode", paymentMode)

                    insertCommand.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Order placed successfully!")

        Catch ex As Exception
            MessageBox.Show($"Error inserting order details: {ex.Message}")
        End Try
    End Sub

    Private Sub DataGridViewCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCart.CellContentClick
        If e.ColumnIndex = DataGridViewCart.Columns("DeleteColumn").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedMedicine As SelectedMedicine = CType(DataGridViewCart.Rows(e.RowIndex).Tag, SelectedMedicine)

            selectedMedicines.Remove(selectedMedicine)

            DataGridViewCart.Rows.RemoveAt(e.RowIndex)

            RefreshCart(selectedMedicines)
            homepageReference.RefreshCart(selectedMedicines, True)
        End If
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If selectedMedicines.Count = 0 Then
            MessageBox.Show("Please add medicines to the cart before placing an order.")
            Return
        End If

        ' Cash on delivery is the default payment method
        Dim paymentMode As String = "Cash On Delivery"

        PlaceOrder(paymentMode)
    End Sub

    Private Sub ClearCart()
        selectedMedicines.Clear()
    End Sub

    Private Sub btnhomepage_Click(sender As Object, e As EventArgs) Handles btnhomepage.Click

        Me.Hide()
        Dim homeForm As New homepage()
        homeForm.Show()
    End Sub

End Class