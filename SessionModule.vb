Module SessionModule
    Private _loggedInUserID As String

    Public Property LoggedInUserID As String
        Get
            Return _loggedInUserID
        End Get
        Set(value As String)
            _loggedInUserID = value
        End Set
    End Property
End Module

Public Module SessionModule1
    Private _loggedInAdminID As Integer

    Public Property LoggedInAdminID As Integer
        Get
            Return _loggedInAdminID
        End Get
        Set(value As Integer)
            _loggedInAdminID = value
        End Set
    End Property
End Module