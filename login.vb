Imports System.Data.SqlClient

Public Class Login
    Dim connectionString As String = My.Settings.PharmacyDBConnectionString

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginButton1.Click
        Dim username As String = Username1.Text
        Dim password As String = password1.Text

        Dim query As String = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password"

        password1.PasswordChar = "*"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)

                    If (String.IsNullOrWhiteSpace(username) And String.IsNullOrWhiteSpace(password)) Then
                        MessageBox.Show("Please enter username and passwrord.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    If String.IsNullOrWhiteSpace(username) Then
                        MessageBox.Show("Please enter the username.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If


                    If String.IsNullOrWhiteSpace(password) Then
                        MessageBox.Show("Please enter the password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            SessionModule.LoggedInUserID = GetUserIDByUsername(username)

                            Me.Hide()
                            Dim homeForm As New homepage()
                            homeForm.Show()
                        Else
                            MessageBox.Show("Invalid username or password.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Function GetUserIDByUsername(username As String) As String
        Dim query As String = "SELECT UserID FROM Users WHERE Username = @Username"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)

                    ' ExecuteScalar is used to retrieve a single value (UserID in this case)
                    Dim userID As Object = command.ExecuteScalar()

                    If userID IsNot Nothing Then
                        Return userID.ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error getting user ID: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        ' Return an empty string if the user ID is not found
        Return String.Empty
    End Function

    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        Me.Hide()
        Dim adminForm As New admin()
        adminForm.Show()

    End Sub

End Class
