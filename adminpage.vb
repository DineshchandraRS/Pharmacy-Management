Imports System.Data.SqlClient

Public Class adminpage
    Dim connectionString As String = My.Settings.PharmacyDBConnectionString

    Private Sub LoadMedicineNames()
        Try
            MedicineNames.Items.Clear()
            Dim query As String = "SELECT MedicineName FROM Medicines"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)

                    Using reader As SqlDataReader = command.ExecuteReader()

                        While reader.Read()

                            If Not reader.IsDBNull(0) Then
                                MedicineNames.Items.Add(reader.GetString(0))
                            End If
                        End While
                    End Using
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading medicine names: " & ex.Message)
        End Try
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadMedicineNames()

        Dim adminID As String = SessionModule1.LoggedInAdminID
        If Not String.IsNullOrEmpty(adminID) Then

            lblUsername.Text = $"Hi, {DBHelpers.GetfullnamebyAdminID(adminID)}"
        Else
            lblUsername.Text = "Hi, Guest"
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.Hide()
        Dim logoutForm As New Login()
        logoutForm.Show()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Try
            If MedicineNames.SelectedIndex <> -1 Then
                Dim selectedMedicine As String = MedicineNames.SelectedItem.ToString()

                MedicineNames.Items.Remove(selectedMedicine)

                RemoveMedicineFromDatabase(selectedMedicine)
            Else
                MessageBox.Show("Please select a medicine to delete.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting medicine: " & ex.Message)
        End Try
    End Sub

    Private Sub RemoveMedicineFromDatabase(medicineName As String)
        Dim query As String = "DELETE FROM Medicines WHERE MedicineName = @MedicineName"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@MedicineName", medicineName)

                command.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            Dim medicineName As String = txtMedicineName.Text.Trim
            Dim quantity As Integer
            Dim price As Decimal
            Dim adminID As Integer = SessionModule1.LoggedInAdminID

            If String.IsNullOrWhiteSpace(medicineName) AndAlso
               String.IsNullOrWhiteSpace(txtMedicineQuantity.Text) AndAlso
               String.IsNullOrWhiteSpace(txtMedicinePrice.Text) Then
                MessageBox.Show("Please fill the medicine details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtMedicineQuantity.Text) AndAlso
               String.IsNullOrWhiteSpace(txtMedicinePrice.Text) Then
                MessageBox.Show("Please fill the medicine details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(medicineName) AndAlso
               String.IsNullOrWhiteSpace(txtMedicineQuantity.Text) Then
                MessageBox.Show("Please fill the medicine details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(medicineName) AndAlso
               String.IsNullOrWhiteSpace(txtMedicinePrice.Text) Then
                MessageBox.Show("Please fill the medicine details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Decimal.TryParse(txtMedicinePrice.Text, price) OrElse price <= 0 Then
                MessageBox.Show("Please fill valid medicine price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Integer.TryParse(txtMedicineQuantity.Text, quantity) OrElse quantity <= 0 Then
                MessageBox.Show("Please fill valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(medicineName) Then
                MessageBox.Show("Please fill Medicine Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MedicineExists(medicineName) Then
                MessageBox.Show("This medicine already exists in the database.", "Duplicate Medicine", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                AddnewMedicineToDatabase(adminID, medicineName, quantity, price)

                MedicineNames.Items.Add(medicineName)

                MessageBox.Show("Medicine added successfully.")
            End If

        Catch ex As Exception

            MessageBox.Show("Please fill the valid details.", "Error Adding Medicine", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function MedicineExists(medicineName As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Medicines WHERE MedicineName = @MedicineName"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@MedicineName", medicineName)

                Dim count As Integer = CInt(command.ExecuteScalar())

                ' If count > 0, the medicine already exists
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub AddnewMedicineToDatabase(adminID As Integer, medicineName As String, price As Decimal, quantity As Integer)
        Dim query As String = "INSERT INTO Medicines (MedicineName, Count, Price, AdminID, DataTime) VALUES (@MedicineName, @Quantity, @Price, @AdminID, @CreatedDate)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@MedicineName", medicineName)
                command.Parameters.AddWithValue("@Quantity", quantity)
                command.Parameters.AddWithValue("@Price", price)
                command.Parameters.AddWithValue("@AdminId", adminID)
                command.Parameters.AddWithValue("@CreatedDate", DateTime.Now)

                command.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub UpdateMedicineDetails(adminID As Integer, medicineName As String, newQuantity As Integer, newPrice As Decimal)
        Dim query As String = "UPDATE Medicines SET AdminID = @AdminID, Count = @NewQuantity, Price = @NewPrice, DataTime = @LastModifiedDate WHERE MedicineName = @MedicineName"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@MedicineName", medicineName)
                command.Parameters.AddWithValue("@NewQuantity", newQuantity)
                command.Parameters.AddWithValue("@NewPrice", newPrice)
                command.Parameters.AddWithValue("@AdminId", adminID)
                command.Parameters.AddWithValue("@LastModifiedDate", DateTime.Now) ' Set the current datetime

                command.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub ClearTextBoxFields()
        txtMedicineName.Text = String.Empty
        txtMedicineQuantity.Text = String.Empty
        txtMedicinePrice.Text = String.Empty
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        ClearTextBoxFields()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Dim selectedMedicine As String = txtMedicineName.Text.Trim().ToString()
            Dim newQuantity As Integer
            Dim newPrice As Decimal
            Dim adminID As Integer = SessionModule1.LoggedInAdminID

            If String.IsNullOrWhiteSpace(selectedMedicine) AndAlso
               String.IsNullOrWhiteSpace(txtMedicineQuantity.Text) AndAlso
               String.IsNullOrWhiteSpace(txtMedicinePrice.Text) Then
                MessageBox.Show("Please fill the medicine details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtMedicineQuantity.Text) AndAlso
               String.IsNullOrWhiteSpace(txtMedicinePrice.Text) Then
                MessageBox.Show("Please fill the medicine details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(selectedMedicine) AndAlso
               String.IsNullOrWhiteSpace(txtMedicineQuantity.Text) Then
                MessageBox.Show("Please fill the medicine details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(selectedMedicine) AndAlso
               String.IsNullOrWhiteSpace(txtMedicinePrice.Text) Then
                MessageBox.Show("Please fill the medicine details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Decimal.TryParse(txtMedicinePrice.Text, newPrice) OrElse newPrice <= 0 Then
                MessageBox.Show("Please fill valid medicine price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Integer.TryParse(txtMedicineQuantity.Text, newQuantity) OrElse newQuantity <= 0 Then
                MessageBox.Show("Please fill valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(selectedMedicine) Then
                MessageBox.Show("Please fill Medicine Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not MedicineExists(selectedMedicine) Then
                MessageBox.Show("This medicine not exists in the database to update.", "Duplicate Medicine", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                UpdateMedicineDetails(adminID, selectedMedicine, newQuantity, newPrice)
                MedicineNames.Refresh()
                MessageBox.Show("Medicine details updated successfully.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating medicine details: " & ex.Message)
        End Try
    End Sub

End Class

Public Class DBHelpers
    Private Shared ReadOnly connectionString As String = My.Settings.PharmacyDBConnectionString

    Public Shared Function GetfullnamebyAdminID(adminID As String) As String
        Dim username As String = String.Empty

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT [Full Name] FROM Admins WHERE AdminID = @AdminID"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@AdminID", adminID)

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
