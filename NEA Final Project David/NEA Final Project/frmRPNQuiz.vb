Imports System.Data.OleDb
Public Class frmRPNQuiz
    Dim wrongQuestionsArray(totalNumberOfWrongQuestions() - 1) As String              'Wrong question's
    Dim correctQuestionsArray(totalNumberOfCorrectQuestions() - 1)
    Dim wrongQuestionIDArray(totalNumberOfWrongQuestions() - 1) As String           'ID of wrong questions
    Dim correctQuestionIDArray(totalNumberOfCorrectQuestions() - 1) As String          'ID of correct questions
    Dim possibleAnswersArrayWrong((totalNumberOfWrongQuestions() * 4) - 1) As String 'All possible answers for wrong questions
    Dim possibleAnswerArrayCorrect((totalNumberOfCorrectQuestions() * 4) - 1) As String
    Dim resultsArrayYesOrNO(totalNumberOfQuestions() - 1) As String                   'Array that stores if the user got the question right
    Dim resultsArrayId(totalNumberOfQuestions() - 1) As String
    Dim currentQuestion As Integer = 0
    Dim currentQuestionHelper As Integer = 0
    Dim guessA As String
    Dim guessB As String
    Dim guessC As String
    Dim guessD As String
    Dim mainCounterForWrong As Integer = 0
    Dim mainCounterForCorrect As Integer = 0

    Dim timeLeft As Integer = 600
    Dim minuteCounter As Integer
    Dim secondCounter As Integer

    Private Sub btnStartQuiz_Click(sender As Object, e As EventArgs) Handles btnStartQuiz.Click
        'goes to each subroutine

        startquiz()
        VisibleTrue()
        selectingInfoNeeded()
        selectingQuestions()
        selectingMoreQuestionsNeeded()
        questionAnswerChoicesWrong()
        questionAnswerChoicesCorrect()

        currentQuestion = 1
        changeQuestion()
    End Sub

    Private Sub btnGuessA_Click(sender As Object, e As EventArgs) Handles btnGuessA.Click

        'sets the guess to what is inside the label
        guessA = lblAnswerA.Text

        'checks answers and reutrns result
        If guessA = checkAnswer() Then
            MsgBox("Well Done! You Got The Answer Correct!")

            'sets next availible position in array to Yes
            resultsArrayYesOrNO(currentQuestion - 1) = "Yes"
            currentQuestion += 1
        Else
            MsgBox("Unlucky, That Answer Is Incorrect.")

            'sets next availible position in array to No
            resultsArrayYesOrNO(currentQuestion - 1) = "No"
            currentQuestion += 1
        End If

        changeQuestion()
    End Sub

    Private Sub btnGuessB_Click(sender As Object, e As EventArgs) Handles btnGuessB.Click
        guessB = lblAnswerB.Text
        If guessB = checkAnswer() Then
            MsgBox("Well Done! You Got The Answer Correct!")
            resultsArrayYesOrNO(currentQuestion - 1) = "Yes"
            currentQuestion += 1
        Else
            MsgBox("Unlucky, That Answer Is Incorrect.")
            resultsArrayYesOrNO(currentQuestion - 1) = "No"
            currentQuestion += 1
        End If

        changeQuestion()
    End Sub

    Private Sub btnGuessC_Click(sender As Object, e As EventArgs) Handles btnGuessC.Click
        guessC = lblAnswerC.Text
        If guessC = checkAnswer() Then
            MsgBox("Well Done! You Got The Answer Correct!")
            resultsArrayYesOrNO(currentQuestion - 1) = "Yes"
            currentQuestion += 1
        Else
            MsgBox("Unlucky, That Answer Is Incorrect.")
            resultsArrayYesOrNO(currentQuestion - 1) = "No"
            currentQuestion += 1
        End If

        changeQuestion()
    End Sub

    Private Sub btnGuessD_Click(sender As Object, e As EventArgs) Handles btnGuessD.Click
        guessD = lblAnswerD.Text
        If guessD = checkAnswer() Then
            MsgBox("Well Done! You Got The Answer Correct!")
            resultsArrayYesOrNO(currentQuestion - 1) = "Yes"
            currentQuestion += 1
        Else
            MsgBox("Unlucky, That Answer Is Incorrect.")
            resultsArrayYesOrNO(currentQuestion - 1) = "No"
            currentQuestion += 1
        End If

        changeQuestion()
    End Sub

    Sub changeQuestion()
        Dim noOfWrongQuestions As Integer

        'selects number of wrong questions in array
        noOfWrongQuestions = wrongQuestionsArray.Length()
        If currentQuestion < 11 Then
            'changes questions label
            lblQuestionNumber.Text = "Question " & currentQuestion
        End If
        If currentQuestion <> 11 Then

            'sets the possible answers to the labels
            If currentQuestion > noOfWrongQuestions Then
                lblQuestion.Text = correctQuestionsArray(currentQuestionHelper)
                currentQuestionHelper += 1
                lblAnswerA.Text = possibleAnswerArrayCorrect(mainCounterForCorrect)
                mainCounterForCorrect += 1
                lblAnswerB.Text = possibleAnswerArrayCorrect(mainCounterForCorrect)
                mainCounterForCorrect += 1
                lblAnswerC.Text = possibleAnswerArrayCorrect(mainCounterForCorrect)
                mainCounterForCorrect += 1
                lblAnswerD.Text = possibleAnswerArrayCorrect(mainCounterForCorrect)
                mainCounterForCorrect += 1
            Else
                lblQuestion.Text = wrongQuestionsArray(currentQuestion - 1)
                lblAnswerA.Text = possibleAnswersArrayWrong(mainCounterForWrong)
                mainCounterForWrong += 1
                lblAnswerB.Text = possibleAnswersArrayWrong(mainCounterForWrong)
                mainCounterForWrong += 1
                lblAnswerC.Text = possibleAnswersArrayWrong(mainCounterForWrong)
                mainCounterForWrong += 1
                lblAnswerD.Text = possibleAnswersArrayWrong(mainCounterForWrong)
                mainCounterForWrong += 1
            End If

            'after 10 questions end program and change form
        ElseIf currentQuestion = 11 Then

            'inserts results into database
            insertingResults()
            MsgBox("The Quiz Is Complete")

            'change form
            Me.Close()
            frmResults.Show()
        End If
    End Sub

    Sub selectingInfoNeeded()

        'connection link to database
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")

        'query string to do some command in database
        Dim selectingCorrectQuestionsID As String = "SELECT RPNQuestionID FROM RPNQuizResult WHERE RPNCorrect=Yes AND UserID=@userID"
        Dim selectingWrongQuestionsID As String = "SELECT RPNQuestionID FROM RPNQuizResult WHERE RPNCorrect=No AND UserID=@userID;"

        'executes SQL command
        Dim selectingCorrectQuestionsIDConnection As New OleDbCommand(selectingCorrectQuestionsID)

        'adding values to the parameters
        selectingCorrectQuestionsIDConnection.Parameters.AddWithValue("@userID", currentUserID)

        Dim selectingWrongQuestionsIDConnection As New OleDbCommand(selectingWrongQuestionsID)
        selectingWrongQuestionsIDConnection.Parameters.AddWithValue("@userID", currentUserID)

        'connecting to database
        selectingCorrectQuestionsIDConnection.Connection = connectToLoginDB
        selectingWrongQuestionsIDConnection.Connection = connectToLoginDB

        'open connection
        connectToLoginDB.Open()
        Dim counter As Byte

        Dim totalQuestions As Integer = totalNumberOfQuestions()

        'executes the query string 
        Dim readFieldsCorrect As OleDbDataReader = selectingCorrectQuestionsIDConnection.ExecuteReader()
        counter = 0

        'checks if the query string leads to a row in the login table which match the parameters
        If readFieldsCorrect.HasRows Then
            While readFieldsCorrect.Read()

                'insert the data into the array
                correctQuestionIDArray(counter) = readFieldsCorrect.GetInt32(0)
                counter += 1
            End While
        End If

        Dim readFieldsWrong As OleDbDataReader = selectingWrongQuestionsIDConnection.ExecuteReader()
        counter = 0
        If readFieldsWrong.HasRows Then
            While readFieldsWrong.Read()
                wrongQuestionIDArray(counter) = readFieldsWrong.GetInt32(0)
                counter += 1
            End While
        End If

        'close connection
        connectToLoginDB.Close()

    End Sub

    Sub selectingQuestions()
        Dim currentQuestionId As Integer
        Dim counter As Byte

        For i = 0 To totalNumberOfWrongQuestions() - 1
            currentQuestionId = wrongQuestionIDArray(i)
            Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
            Dim selectingWrongQuestions As String = "SELECT (RPNQuestions.RPNQuestion) FROM RPNQuestions WHERE RPNQuestionID = @question"
            Dim selectingWrongQuestionsConnection As New OleDbCommand(selectingWrongQuestions)
            selectingWrongQuestionsConnection.Parameters.AddWithValue("@questions", currentQuestionId)
            selectingWrongQuestionsConnection.Connection = connectToLoginDB
            connectToLoginDB.Open()

            Dim readFieldWrongQuestions As OleDbDataReader = selectingWrongQuestionsConnection.ExecuteReader()
            If readFieldWrongQuestions.HasRows Then
                While readFieldWrongQuestions.Read()
                    wrongQuestionsArray(counter) = readFieldWrongQuestions.GetString(0)
                    counter += 1
                End While
            End If
            connectToLoginDB.Close()
            resultsArrayId(i) = currentQuestionId
        Next

    End Sub

    Sub selectingMoreQuestionsNeeded()
        Dim usedQuestionsTotal As Integer
        usedQuestionsTotal = wrongQuestionIDArray.Length()
        Dim numberOfMoreQuestionsNeeded As Integer
        Dim currentQuestionID As Integer
        Dim counter As Byte

        numberOfMoreQuestionsNeeded = 10 - usedQuestionsTotal

        Dim lengthOfResultArray As Integer
        lengthOfResultArray = totalNumberOfWrongQuestions()

        'checks if more questions are needed by finding how many questions have been currently selected
        If usedQuestionsTotal < 10 And numberOfMoreQuestionsNeeded <= totalNumberOfCorrectQuestions() Then
            For i = 0 To numberOfMoreQuestionsNeeded - 1
                currentQuestionID = correctQuestionIDArray(i)
                Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
                Dim selectingCorrectQuestions As String = "SELECT (RPNQuestions.RPNQuestion) FROM RPNQuestions WHERE RPNQuestionID = @questions"
                Dim selectingCorrectQuestionsConnection As New OleDbCommand(selectingCorrectQuestions)
                selectingCorrectQuestionsConnection.Parameters.AddWithValue("@questions", currentQuestionID)
                selectingCorrectQuestionsConnection.Connection = connectToLoginDB
                connectToLoginDB.Open()

                Dim readFieldCorrectQuestions As OleDbDataReader = selectingCorrectQuestionsConnection.ExecuteReader()
                If readFieldCorrectQuestions.HasRows Then
                    While readFieldCorrectQuestions.Read()
                        correctQuestionsArray(counter) = readFieldCorrectQuestions.GetString(0)
                        counter += 1
                    End While
                End If
                connectToLoginDB.Close()

                lengthOfResultArray += 1
                resultsArrayId(lengthOfResultArray - 1) = currentQuestionID
            Next
        End If
    End Sub

    Sub questionAnswerChoicesWrong()
        Dim currentQuestionId As Integer
        Dim counter As Byte

        For i = 0 To totalNumberOfWrongQuestions() - 1
            currentQuestionId = wrongQuestionIDArray(i)
            Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
            Dim selectingPossibleAnswersWrong As String = "SELECT (RPNAnswers.possibleAnswers) FROM RPNAnswers WHERE RPNQuestionID = @question"
            Dim selectingPossibleAnswersWrongConnection As New OleDbCommand(selectingPossibleAnswersWrong)
            selectingPossibleAnswersWrongConnection.Parameters.AddWithValue("@questions", currentQuestionId)
            selectingPossibleAnswersWrongConnection.Connection = connectToLoginDB
            connectToLoginDB.Open()

            Dim readFieldPossibleAnswers As OleDbDataReader = selectingPossibleAnswersWrongConnection.ExecuteReader()
            If readFieldPossibleAnswers.HasRows Then
                While readFieldPossibleAnswers.Read()
                    possibleAnswersArrayWrong(counter) = readFieldPossibleAnswers.GetString(0)
                    counter += 1
                End While
            End If
            connectToLoginDB.Close()
        Next

    End Sub

    Sub questionAnswerChoicesCorrect()
        Dim currentQuestionId As Integer
        Dim counter As Byte


        For i = 0 To totalNumberOfCorrectQuestions() - 1
            currentQuestionId = correctQuestionIDArray(i)
            Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
            Dim selectingPossibleAnswersCorrect As String = "SELECT (RPNAnswers.possibleAnswers) FROM RPNAnswers WHERE RPNQuestionID = @question"
            Dim selectingPossibleAnswersCorrectConnection As New OleDbCommand(selectingPossibleAnswersCorrect)
            selectingPossibleAnswersCorrectConnection.Parameters.AddWithValue("@questions", currentQuestionId)
            selectingPossibleAnswersCorrectConnection.Connection = connectToLoginDB
            connectToLoginDB.Open()

            Dim readFieldPossibleAnswersCorrect As OleDbDataReader = selectingPossibleAnswersCorrectConnection.ExecuteReader()
            If readFieldPossibleAnswersCorrect.HasRows Then
                While readFieldPossibleAnswersCorrect.Read()
                    possibleAnswerArrayCorrect(counter) = readFieldPossibleAnswersCorrect.GetString(0)
                    counter += 1
                End While
            End If
            connectToLoginDB.Close()
        Next
    End Sub

    Function totalNumberOfQuestions()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim selectingNumberOfQuestions As String = "SELECT MAX (RPNQuestions.RPNQuestionID) FROM RPNQuestions"
        Dim selectingNumberOfQuestionsConnection As New OleDbCommand(selectingNumberOfQuestions)
        selectingNumberOfQuestionsConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()

        Dim numberOfQuestions As Integer
        numberOfQuestions = (selectingNumberOfQuestionsConnection.ExecuteScalar())

        connectToLoginDB.Close()
        Return numberOfQuestions
    End Function

    Function totalNumberOfCorrectQuestions()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim selectingNumberOfCorrectQuestions As String = "SELECT *  FROM RPNQuizResult WHERE RPNCorrect=Yes AND UserID=@userId;"
        Dim selectingNumberOfCorrectQuestionsConnection As New OleDbCommand(selectingNumberOfCorrectQuestions)
        selectingNumberOfCorrectQuestionsConnection.Parameters.AddWithValue("@userID", currentUserID)
        selectingNumberOfCorrectQuestionsConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()
        Dim numberOfFieldsCorrect As Integer

        Dim readFieldNumberOfCorrectQuestions As OleDbDataReader = selectingNumberOfCorrectQuestionsConnection.ExecuteReader()
        If readFieldNumberOfCorrectQuestions.HasRows Then
            While readFieldNumberOfCorrectQuestions.Read()
                numberOfFieldsCorrect += 1
            End While
        End If

        Return numberOfFieldsCorrect
    End Function

    Function totalNumberOfWrongQuestions()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim selectingNumberOfWrongQuestions As String = "SELECT *  FROM RPNQuizResult WHERE RPNCorrect=No AND UserID=@userId;"
        Dim selectingNumberOfWrongQuestionsConnection As New OleDbCommand(selectingNumberOfWrongQuestions)
        selectingNumberOfWrongQuestionsConnection.Parameters.AddWithValue("@userID", currentUserID)
        selectingNumberOfWrongQuestionsConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()
        Dim numberOfFieldsWrong As Integer

        Dim readFieldNumberOfWrongQuestions As OleDbDataReader = selectingNumberOfWrongQuestionsConnection.ExecuteReader()
        If readFieldNumberOfWrongQuestions.HasRows Then
            While readFieldNumberOfWrongQuestions.Read()
                numberOfFieldsWrong += 1
            End While
        End If

        Return numberOfFieldsWrong
    End Function

    Function checkAnswer()
        Dim answer As String
        Dim questionToCheckWrong As Integer
        Dim questionToCheckCorrect As Integer
        Dim noOfWrongQuestions As Integer
        noOfWrongQuestions = wrongQuestionsArray.Length()

        If currentQuestion <= noOfWrongQuestions Then
            questionToCheckWrong = wrongQuestionIDArray(currentQuestion - 1)

            Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
            Dim selectingWrongAnswer As String = "SELECT (RPNAnswers.possibleAnswers) FROM RPNAnswers WHERE RPNQuestionID = @question AND Correct=Yes"
            Dim selectingWrongnswerConnection As New OleDbCommand(selectingWrongAnswer)
            selectingWrongnswerConnection.Parameters.AddWithValue("@questions", questionToCheckWrong)
            selectingWrongnswerConnection.Connection = connectToLoginDB
            connectToLoginDB.Open()

            Dim readFieldAnswersWrong As OleDbDataReader = selectingWrongnswerConnection.ExecuteReader()
            If readFieldAnswersWrong.HasRows Then
                While readFieldAnswersWrong.Read()
                    answer = readFieldAnswersWrong.GetString(0)
                End While
            End If
            connectToLoginDB.Close()

        ElseIf currentQuestion > noOfWrongQuestions Then
            questionToCheckCorrect = correctQuestionIDArray(currentQuestionHelper - 1)

            Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
            Dim selectingCorrectAnswer As String = "SELECT (RPNAnswers.possibleAnswers) FROM RPNAnswers WHERE RPNQuestionID = @question AND Correct=Yes"
            Dim selectingCorrectAnswerConnection As New OleDbCommand(selectingCorrectAnswer)
            selectingCorrectAnswerConnection.Parameters.AddWithValue("@questions", questionToCheckCorrect)
            selectingCorrectAnswerConnection.Connection = connectToLoginDB
            connectToLoginDB.Open()

            Dim readFieldAnswersCorrect As OleDbDataReader = selectingCorrectAnswerConnection.ExecuteReader()
            If readFieldAnswersCorrect.HasRows Then
                While readFieldAnswersCorrect.Read()
                    answer = readFieldAnswersCorrect.GetString(0)
                End While
            End If
            connectToLoginDB.Close()
        End If
        Return answer
    End Function

    Dim updateHelperWrong As Integer
    Dim updateHelperCorrect As Integer

    Sub insertingResults()
        Dim lengthOfWrongQuestionsArray As Integer = wrongQuestionsArray.Length()
        Dim lengthOfCorrectQuestionsArray As Integer = correctQuestionsArray.Length()
        Dim updateComplete As Boolean = False


        Do Until updateComplete = True

            'checks what is in the array at every position and inserts that in order the questions asked
            For i = 0 To 9
                If resultsArrayYesOrNO(i) = "Yes" Then
                    updateHelperCorrect = resultsArrayId(i)
                    updatingTableCorrect()
                Else
                    updateHelperWrong = resultsArrayId(i)
                    updatingTableWrong()
                End If

            Next
            updateComplete = True
        Loop

        'checks if time has ran out to end quiz
        If timeLeft = 0 Then
            MsgBox("You ran out of time, all remaining questions will be marked as wrong")

            'change form
            Me.Close()
            frmResults.Show()
        End If

    End Sub

    Function updatingTableCorrect()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim updatingCorrect As String = "UPDATE RPNQuizResult SET RPNCorrect=Yes WHERE UserId=@userID AND RPNQuestionID=@questionID"
        Dim updatingCorrectConnection As New OleDbCommand(updatingCorrect)
        updatingCorrectConnection.Parameters.AddWithValue("@userID", currentUserID)
        updatingCorrectConnection.Parameters.AddWithValue("@questionID", updateHelperCorrect)
        updatingCorrectConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()
        Dim readFieldCorrect As OleDbDataReader = updatingCorrectConnection.ExecuteReader()
        connectToLoginDB.Close()

        Return readFieldCorrect
    End Function

    Function updatingTableWrong()
        Dim connectToLoginDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Login_Database.accdb")
        Dim updatingWrong As String = "UPDATE RPNQuizResult SET RPNCorrect=No WHERE UserId=@userID AND RPNQuestionID=@questionID"
        Dim updatingWrongConnection As New OleDbCommand(updatingWrong)
        updatingWrongConnection.Parameters.AddWithValue("@userID", currentUserID)
        updatingWrongConnection.Parameters.AddWithValue("@questionID", updateHelperWrong)
        updatingWrongConnection.Connection = connectToLoginDB
        connectToLoginDB.Open()
        Dim readFieldWrong As OleDbDataReader = updatingWrongConnection.ExecuteReader()
        connectToLoginDB.Close()

        Return readFieldWrong
    End Function


    Sub VisibleTrue()

        'sets the visibilty of buttons and labels.
        btnStartQuiz.Hide()
        lblTimeRemaining.Visible = True
        lblMinutes.Visible = True
        lblColon.Visible = True
        lblSeconds.Visible = True
        lblQuestionNumber.Visible = True
        lblQuestion.Visible = True
        lblAnswerA.Visible = True
        btnGuessA.Visible = True
        lblAnswerB.Visible = True
        btnGuessB.Visible = True
        lblAnswerC.Visible = True
        btnGuessC.Visible = True
        lblAnswerD.Visible = True
        btnGuessD.Visible = True
    End Sub

    Sub startquiz()
        timeLeft = 600
        minuteCounter = 9
        secondCounter = 60

        'starts quiz timer
        tmrQuizTime.Start()
    End Sub


    Private Sub tmrQuizTime_Tick() Handles tmrQuizTime.Tick

        'each tick decrements time remaining by one second
        'based on the time remaining, determines the values shown on the label
        If timeLeft > 550 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 550 And timeLeft > 540 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 540 Then
            timeLeft -= 1
            minuteCounter -= 1
            secondCounter = 59
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft < 540 And timeLeft > 490 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 490 And timeLeft > 480 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 480 Then
            timeLeft -= 1
            minuteCounter -= 1
            secondCounter = 59
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft < 480 And timeLeft > 430 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 430 And timeLeft > 420 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 420 Then
            timeLeft -= 1
            minuteCounter -= 1
            secondCounter = 59
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft < 420 And timeLeft > 370 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 370 And timeLeft > 360 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 360 Then
            timeLeft -= 1
            minuteCounter -= 1
            secondCounter = 59
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft < 360 And timeLeft > 310 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 310 And timeLeft > 300 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 300 Then
            timeLeft -= 1
            minuteCounter -= 1
            secondCounter = 59
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft < 300 And timeLeft > 250 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 250 And timeLeft > 240 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 240 Then
            timeLeft -= 1
            minuteCounter -= 1
            secondCounter = 59
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft < 240 And timeLeft > 190 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 190 And timeLeft > 180 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 180 Then
            timeLeft -= 1
            minuteCounter -= 1
            secondCounter = 59
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft < 180 And timeLeft > 130 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 130 And timeLeft > 120 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 120 Then
            timeLeft -= 1
            minuteCounter -= 1
            secondCounter = 59
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft < 120 And timeLeft > 70 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 70 And timeLeft > 60 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 60 Then
            timeLeft -= 1
            minuteCounter -= 1
            secondCounter = 59
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft < 60 And timeLeft > 10 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = secondCounter
        ElseIf timeLeft <= 10 And timeLeft > 0 Then
            timeLeft -= 1
            secondCounter -= 1
            lblMinutes.Text = minuteCounter
            lblSeconds.Text = "0" & secondCounter
        ElseIf timeLeft = 0 Then

            'when there's no time remaining start inserting results
            insertingResults()
        End If
    End Sub
End Class