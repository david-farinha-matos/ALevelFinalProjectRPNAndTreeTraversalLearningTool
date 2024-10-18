Imports System.Data.OleDb
Public Class frmLogin

    Dim usernameAndPasswordCorrect As Boolean


    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        'Change form
        Me.Hide()
        frmCreateNewUser.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        userUsername = txtUserName.Text

        'connection link to database
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")

        'query string to do some command in database
        Dim selectingUsernameAndPassword As String = "SELECT Username, Password FROM Login WHERE Username = @username AND Password = @password"

        'executes commands
        Dim selectingUsernameAndPasswordConnection As New OleDbCommand(selectingUsernameAndPassword)

        'adding values to the parameters
        selectingUsernameAndPasswordConnection.Parameters.AddWithValue("@username", txtUserName.Text)
        selectingUsernameAndPasswordConnection.Parameters.AddWithValue("@password", txtPassword.Text)

        'gets connection
        selectingUsernameAndPasswordConnection.Connection = connectToLoginDB

        'open connection
        connectToLoginDB.Open()


        'executes the query string 
        Dim databaseReader As OleDbDataReader = selectingUsernameAndPasswordConnection.ExecuteReader()

        'checks if the query string leads to a row in the login table which match the parameters
        If databaseReader.HasRows() Then
            usernameAndPasswordCorrect = True

            'close connection
            connectToLoginDB.Close()

            'change form
            Me.Hide()
            frmChooseTopic.Show()
        Else
            lblUsernameOrPasswordIncorrect.Visible = True
            connectToLoginDB.Close()
        End If

        'Dim selectingUserID As String = "SELECT (Login.UserID) FROM Login WHERE Username=@username"
        'Dim selectingUserIDConnection As New OleDbCommand(selectingUserID)
        'selectingUserIDConnection.Parameters.AddWithValue("@username", userUsername)
        'selectingUserIDConnection.Connection = connectToLoginDB
        'connectToLoginDB.Open()

        'currentUserID = selectingUserIDConnection.ExecuteScalar()
        'connectToLoginDB.Close()

    End Sub


    Private Sub btnCloseProgram_Click(sender As Object, e As EventArgs) Handles btnCloseProgram.Click
        End
    End Sub


End Class