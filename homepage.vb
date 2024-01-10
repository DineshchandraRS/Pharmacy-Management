Imports System.Data.SqlClient

Public Class homepage
    Dim connectionString As String = My.Settings.PharmacyDBConnectionString
    Shared selectedMedicines As New List(Of SelectedMedicine)()

    Private Sub LoadMedicineDetails()
        Dim query As String = "SELECT MedicineID, MedicineName, Price, Count FROM Medicines"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable
                End Using
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub AddToCart(rowIndex As Integer, selectedQuantity As Integer)
        Dim medicineName As String = DataGridView1.Rows(rowIndex).Cells("MedicineName").Value.ToString()
        Dim availableCount As Integer = CInt(DataGridView1.Rows(rowIndex).Cells("Count").Value)

        If selectedQuantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity greater than zero.")
            Return
        End If

        If selectedQuantity > availableCount Then
            MessageBox.Show($"Selected quantity exceeds available stock for {medicineName}.")
            Return
        End If

        Dim selectedMedicine As New SelectedMedicine()

        selectedMedicine.MedicineID = CInt(DataGridView1.Rows(rowIndex).Cells("MedicineID").Value)
        selectedMedicine.MedicineName = medicineName
        selectedMedicine.Count = selectedQuantity
        selectedMedicine.Price = CDec(DataGridView1.Rows(rowIndex).Cells("Price").Value)

        selectedMedicines.Add(selectedMedicine)

        If Application.OpenForms.OfType(Of cartpage).Any() Then
            DirectCast(Application.OpenForms.OfType(Of cartpage).First(), cartpage).RefreshCart(selectedMedicines)
        End If

        MessageBox.Show($"{selectedMedicine.Count} {selectedMedicine.MedicineName}(s) added to the cart.")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("AddToCartButtonColumn").Index AndAlso e.RowIndex >= 0 Then
            Try
                Dim rowIndex As Integer = e.RowIndex
                Dim countColumnIndex As Integer = DataGridView1.Columns("CountColumn").Index

                Dim selectedCount As Integer = CInt(DataGridView1.Rows(rowIndex).Cells(countColumnIndex).Value)
                Dim userID As String = SessionModule.LoggedInUserID

                AddToCart(rowIndex, selectedCount)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicineDetails()
        AddAddToCartButtonColumn()
        AddCountTextBoxColumn()

        Dim userID As String = SessionModule.LoggedInUserID
        If Not String.IsNullOrEmpty(userID) Then
            lblUsername.Text = $"Hi, {DBHelper.GetfullnamebyUserID(userID)}"
        Else
            lblUsername.Text = "Hi, Guest"
        End If
    End Sub

    Private Sub AddAddToCartButtonColumn()

        Dim addToCartButtonColumn As New DataGridViewButtonColumn()
        With addToCartButtonColumn
            .HeaderText = "Add to Cart"
            .Name = "AddToCartButtonColumn"
            .Text = "Add to Cart"
            .UseColumnTextForButtonValue = True
        End With

        DataGridView1.Columns.Add(addToCartButtonColumn)
    End Sub

    Private Sub AddCountTextBoxColumn()
        Dim countTextBoxColumn As New DataGridViewTextBoxColumn()
        With countTextBoxColumn
            .HeaderText = "Quantity"
            .Name = "CountColumn"
        End With

        DataGridView1.Columns.Add(countTextBoxColumn)
    End Sub

    Private Sub UpdateQuantityInDatabase(medicineID As Integer, selectedQuantity As Integer)

        Dim rowIndex As Integer = FindRowIndexByMedicineID(medicineID)

        If rowIndex >= 0 Then
            Dim currentCount As Integer = CInt(DataGridView1.Rows(rowIndex).Cells("CountColumn").Value)

            If currentCount >= selectedQuantity Then
                DataGridView1.Rows(rowIndex).Cells("CountColumn").Value = currentCount - selectedQuantity
            Else
                MessageBox.Show("Insufficient stock to fulfill the request.")
            End If
        Else
            MessageBox.Show("Selected medicine not found in the homepage.")
        End If
    End Sub

    Private Function FindRowIndexByMedicineID(medicineID As Integer) As Integer
        For Each row As DataGridViewRow In DataGridView1.Rows
            If CInt(row.Cells("MedicineID").Value) = medicineID Then
                Return row.Index
            End If
        Next
        Return -1
    End Function

    Private Sub cart_Click(sender As Object, e As EventArgs) Handles cart.Click
        Me.Hide()
        Dim cartForm As New cartpage(selectedMedicines, Me)
        cartForm.Show()
    End Sub

    Public Sub RefreshCart(selectedMedicines As List(Of SelectedMedicine), updateCount As Boolean)
        LoadMedicineDetails()

        For Each medicine In selectedMedicines
            For Each row As DataGridViewRow In DataGridView1.Rows
                If CInt(row.Cells("MedicineID").Value) = medicine.MedicineID Then
                    row.Cells("CountColumn").Value = If(updateCount, medicine.Count, 0)
                    Exit For
                End If
            Next
        Next
    End Sub

    Public Sub ClearCartAndRefresh()
        selectedMedicines.Clear()

        LoadMedicineDetails()

        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("CountColumn").Value = 0
        Next
    End Sub

    Private Sub btnlogout_CheckedChanged(sender As Object, e As EventArgs) Handles btnlogout.CheckedChanged
        Me.Hide()
        Dim logOutForm As New Login()
        logOutForm.Show()
    End Sub

    Private Sub btnorderhistory_Click(sender As Object, e As EventArgs) Handles btnorderhistory.Click
        Me.Hide()
        Dim historyForm As New OrderHistory()
        historyForm.Show()
    End Sub

End Class

Public Class SelectedMedicine
    Public Property MedicineID As Integer
    Public Property MedicineName As String
    Public Property Count As Integer
    Public Property Price As Decimal
End Class

Public Class DBHelper
    Private Shared ReadOnly connectionString As String = My.Settings.PharmacyDBConnectionString

    Public Shared Function GetfullnamebyUserID(userID As String) As String
        Dim username As String = String.Empty

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT [Full Name] FROM Users WHERE UserID = @UserID"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)

                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        username = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error retrieving fullname: {ex.Message}")
        End Try

        Return username
    End Function

End Class
