Imports System.Data.OleDb
Public Class frmCreateNewUser


    Dim password As String
    Dim totalNumberOfQuestions As Integer

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click

        userUsername = txtUserName.Text

        Dim userExists As Boolean

        'goes to subroutine to search if user exists
        userExists = checkIfUserExists()

        'checks if username inputted is already taken
        If userExists Then
            lblUserAlreadyExists.Visible = True
            Exit Sub

            'if no name is inputted it doesn't allow you to continue
        ElseIf userUsername = "" Then
            lblUserAlreadyExists.Visible = True
            Exit Sub
        End If

        'goes to subroutine that inserts new user
        insertingUser()

        'change form
        Me.Close()
        frmChooseTopic.Show()


    End Sub

    Sub insertingUser()

        'connection link to database
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")

        'query string to do some command in database
        Dim selectingNumberOfusers As String = "SELECT MAX(Login.UserID) FROM Login"

        'executes SQL command
        Dim selectingNumberOfusersConnection As New OleDbCommand(selectingNumberOfusers)

        'connecting to database
        selectingNumberOfusersConnection.Connection = connectToLoginDB

        'open connection
        connectToLoginDB.Open()


        Dim maxID As Integer
        Dim ID As Integer

        'executes the query string 
        maxID = selectingNumberOfusersConnection.ExecuteScalar()

        password = txtPassword.Text
        'select next vaild ID
        ID = maxID + 1
        currentUserID = ID

        'query string to do some command in database
        Dim insertIntoTable As String = "INSERT INTO login VALUES (@id , @username , @password)"

        'executes commands
        Using customerParameters As OleDbCommand = New OleDbCommand

            With customerParameters

                'gets connection
                .Connection = connectToLoginDB
                .CommandType = CommandType.Text

                'gets the query string
                .CommandText = insertIntoTable

                'adding values to the parameters
                .Parameters.AddWithValue("@id", ID)
                .Parameters.AddWithValue("@username", txtUserName.Text)
                .Parameters.AddWithValue("@password", txtPassword.Text)
            End With

            ' executes the query string
            customerParameters.ExecuteNonQuery()

        End Using

        Dim defaultResult As Boolean = False

        totalNumberOfQuestions = totalQuestionsRPN()
        Dim insertIntoTableRPN As String = "INSERT INTO RPNQuizResult VALUES (@questionID, @userID, @correct)"
        For i = 1 To totalNumberOfQuestions
            Using customerParameters2 As OleDbCommand = New OleDbCommand
                With customerParameters2
                    .Connection = connectToLoginDB
                    .CommandType = CommandType.Text
                    .CommandText = insertIntoTableRPN
                    .Parameters.AddWithValue("@questionID", i)
                    .Parameters.AddWithValue("@userID", currentUserID)
                    .Parameters.AddWithValue("@correct", defaultResult)
                End With

                customerParameters2.ExecuteNonQuery()

            End Using
        Next

        totalNumberOfQuestions = totalQuestionsTT()
        Dim insertIntoTableTreeTraversal As String = "INSERT INTO TreeTraversalQuizResult VALUES (@questionID, @userID, @correct)"
        For i = 1 To totalNumberOfQuestions
            Using customerParameters3 As OleDbCommand = New OleDbCommand
                With customerParameters3
                    .Connection = connectToLoginDB
                    .CommandType = CommandType.Text
                    .CommandText = insertIntoTableTreeTraversal
                    .Parameters.AddWithValue("@questionID", i)
                    .Parameters.AddWithValue("@userID", currentUserID)
                    .Parameters.AddWithValue("@correct", defaultResult)
                End With

                customerParameters3.ExecuteNonQuery()

            End Using
        Next
    End Sub

    Function checkIfUserExists()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim selectingAllUsers As String = "SELECT Username FROM Login WHERE Username = @username "
        Dim selectingAllUsersConnection As New OleDbCommand(selectingAllUsers)
        selectingAllUsersConnection.Parameters.AddWithValue("@username", txtUserName.Text)
        selectingAllUsersConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()

        Dim userExists As Boolean = False

        'executes the query string  
        Dim readFieldUsers As OleDbDataReader = selectingAllUsersConnection.ExecuteReader()

        'Checks if the query string leads to a row in the login table that matches the parameter
        If readFieldUsers.HasRows() Then
            userExists = True
            Return userExists = True
        End If

        Return userExists

    End Function

    Function totalQuestionsRPN()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim selectingNumberOfQuestions As String = "SELECT MAX (RPNQuestions.RPNQuestionID) FROM RPNQuestions"
        Dim selectingNumberOfQuestionsConnection As New OleDbCommand(selectingNumberOfQuestions)
        selectingNumberOfQuestionsConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()

        Dim numberOfQuestionsRPN As Integer

        'executes query string
        numberOfQuestionsRPN = selectingNumberOfQuestionsConnection.ExecuteScalar()

        connectToLoginDB.Close()
        Return numberOfQuestionsRPN
    End Function

    Function totalQuestionsTT()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim selectingNumberOfQuestions As String = "SELECT MAX (TreeTraversalQuestions.TreeTraversalQuestionID) FROM TreeTraversalQuestions"
        Dim selectingNumberOfQuestionsConnection As New OleDbCommand(selectingNumberOfQuestions)
        selectingNumberOfQuestionsConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()

        Dim numberOfQuestionsTT As Integer
        numberOfQuestionsTT = selectingNumberOfQuestionsConnection.ExecuteScalar()

        connectToLoginDB.Close()
        Return numberOfQuestionsTT
    End Function

    Private Sub btnCloseProgram_Click(sender As Object, e As EventArgs) Handles btnCloseProgram.Click
        End
    End Sub
End Class