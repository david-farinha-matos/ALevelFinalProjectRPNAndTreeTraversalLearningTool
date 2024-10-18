Imports System.Data.OleDb
Public Class frmResults
    Private Sub btnBackToRPN_Click(sender As Object, e As EventArgs) Handles btnChooseTopic.Click
        Me.Close()
        frmChooseTopic.Show()
    End Sub

    Private Sub btnViewStats_Click(sender As Object, e As EventArgs) Handles btnViewStats.Click

        'sets visibilty of labels
        btnViewStats.Visible = False
        btnChooseTopic.Visible = True
        lblRPNMark.Visible = True
        lblTreeTraversalMark.Visible = True

        'sets the string to show to screen
        lblRPNMark.Text = RPNMark()
        lblTreeTraversalMark.Text = TTMark()
    End Sub


    Function RPNMark()
        Dim total As Integer
        Dim correctNow As Integer
        Dim answer As String
        total = totalNumberOfQuestionsRPN()
        correctNow = totalNumberOfCorrectQuestionsRPN()

        'answer to display
        answer = ("For RPN You now have a total of " & correctNow & "/" & total & " of all questions correct!")
        Return answer
    End Function

    Function totalNumberOfQuestionsRPN()

        'connection link to database
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")

        'query string to do some command in database
        Dim selectingTotalRPNQuestions As String = "SELECT MAX (RPNQuestions.RPNQuestionID) FROM RPNQuestions"

        'executes SQL command
        Dim selectingTotalRPNQuestionsConnection As New OleDbCommand(selectingTotalRPNQuestions)

        'connecting to database
        selectingTotalRPNQuestionsConnection.Connection = connectToLoginDB

        'open connection
        connectToLoginDB.Open()

        Dim numberOfQuestions As Integer

        'executes the query string 
        numberOfQuestions = (selectingTotalRPNQuestionsConnection.ExecuteScalar())

        'close connection
        connectToLoginDB.Close()
        Return numberOfQuestions
    End Function

    Function totalNumberOfCorrectQuestionsRPN()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim selectingTotalRPNCorrectQuestions As String = "SELECT *  FROM RPNQuizResult WHERE RPNCorrect=Yes AND UserID=@userId;"
        Dim selectingTotalRPNCorrectQuestionsConnection As New OleDbCommand(selectingTotalRPNCorrectQuestions)

        'adding values to the parameters
        selectingTotalRPNCorrectQuestionsConnection.Parameters.AddWithValue("@userID", currentUserID)
        selectingTotalRPNCorrectQuestionsConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()
        Dim counter As Integer

        'executes the query string 
        Dim numberOfCorrectQuestions As OleDbDataReader = selectingTotalRPNCorrectQuestionsConnection.ExecuteReader()

        'checks if the query string leads to a row in the login table which match the parameters
        If numberOfCorrectQuestions.HasRows Then
            While numberOfCorrectQuestions.Read()
                counter += 1
            End While
        End If

        Return counter
    End Function





    Function TTMark()
        Dim total As Integer
        Dim correctNow As Integer
        Dim answer As String
        total = totalNumberOfQuestionsTT()
        correctNow = totalNumberOfCorrectQuestionsTT()
        answer = ("For Tree Traversal You now have a total of " & correctNow & "/" & total & " questions correct!")
        Return answer
    End Function

    Function totalNumberOfQuestionsTT()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim selectingTotalTTQuestions As String = "SELECT MAX (TreeTraversalQuestions.TreeTraversalQuestionID) FROM TreeTraversalQuestions"
        Dim selectingTotalTTQuestionsConnection As New OleDbCommand(selectingTotalTTQuestions)
        selectingTotalTTQuestionsConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()

        Dim numberOfQuestions As Integer
        numberOfQuestions = (selectingTotalTTQuestionsConnection.ExecuteScalar())

        connectToLoginDB.Close()
        Return numberOfQuestions
    End Function

    Function totalNumberOfCorrectQuestionsTT()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim selectingTotalCorrectTTQuestions As String = "SELECT *  FROM TreeTraversalQuizResult WHERE TreeTraversalCorrect=Yes AND UserID=@userId;"
        Dim selectingTotalCorrectTTQuestionsConnection As New OleDbCommand(selectingTotalCorrectTTQuestions)
        selectingTotalCorrectTTQuestionsConnection.Parameters.AddWithValue("@userID", currentUserID)
        selectingTotalCorrectTTQuestionsConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()
        Dim counter As Integer

        Dim numberOfCorrectQuestions As OleDbDataReader = selectingTotalCorrectTTQuestionsConnection.ExecuteReader()
        If numberOfCorrectQuestions.HasRows Then
            While numberOfCorrectQuestions.Read()
                counter += 1
            End While
        End If

        Return counter
    End Function


End Class