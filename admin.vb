Imports System.Data.SqlClient


Public Class admin
    Dim connectionString As String = My.Settings.PharmacyDBConnectionString

    Private Sub AdButton1_Click(sender As Object, e As EventArgs) Handles AdButton1.Click

        Dim username1 As String = adminTextBoxusername.Text
        Dim password1 As String = adminTextBoxpassword.Text

        Dim query As String = "SELECT * FROM Admins WHERE Username = @Username AND Password = @Password"

        adminTextBoxpassword.PasswordChar = "*"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username1)
                    command.Parameters.AddWithValue("@Password", password1)


                    If (String.IsNullOrWhiteSpace(username1) And String.IsNullOrWhiteSpace(password1)) Then
                        MessageBox.Show("Please enter username and passwrord.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    If String.IsNullOrWhiteSpace(username1) Then
                        MessageBox.Show("Please enter the username.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If


                    If String.IsNullOrWhiteSpace(password1) Then
                        MessageBox.Show("Please enter the password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If



                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            SessionModule1.LoggedInAdminID = GetAdminIDByUsername(username1)
                            Me.Hide()
                            Dim adminmedicinesForm As New adminpage()
                            adminmedicinesForm.Show()
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

    Private Function GetAdminIDByUsername(username As String) As String
        Dim query As String = "SELECT AdminID FROM Admins WHERE Username = @Username"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)

                    ' ExecuteScalar is used to retrieve a single value (UserID in this case)
                    Dim adminID As Object = command.ExecuteScalar()

                    ' Check if the result is not null before converting to a string
                    If adminID IsNot Nothing Then
                        Return adminID.ToString()
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

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Dim backloginForm As New Login()
        backloginForm.Show()
    End Sub


End Class