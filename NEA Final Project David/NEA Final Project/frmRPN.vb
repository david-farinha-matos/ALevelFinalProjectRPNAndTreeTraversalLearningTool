Imports Microsoft.Office.Interop
Public Class frmRPN

    Dim rpnStack As New Stack
    Dim a, b As Double
    Dim rpnExpression As String
    Dim rpnExpressionLength As Integer

    Private Sub btnCalculateRPNAnswer_Click(sender As Object, e As EventArgs) Handles btnCalculateRPNAnswer.Click
        Dim rpnExpressionParts(expressionLength() - 1) As String

        'used to reset the stack and input/output textbox
        lbxRPNStack.Items.Clear()
        rpnExpression = ""
        rpnExpression = txtUserRPNInput.Text
        txtRPNAnswer.Text = ""

        'displays error message if no input is done
        If rpnExpression = "" Then
            MsgBox("That is an invaild input")
            Exit Sub
        End If

        'Splits the inputted expression into individual characters and stores them in an array
        For i = 0 To rpnExpressionLength - 1
            rpnExpressionParts(i) = Mid(rpnExpression, i + 1, 1)
        Next

        For j = 0 To rpnExpressionLength - 1
            'algorithm to workout the answer of a postfix expression
            If Char.IsDigit(rpnExpressionParts(j)) Then

                'double is used to turn the numbers into a decimal incase expression requires the numbers to be decimals
                rpnStack.Push(Double.Parse(rpnExpressionParts(j)))
                lbxRPNStack.Items.Add(rpnStack.Peek)
            ElseIf rpnExpressionParts(j) = "+" Then
                lbxRPNStack.Items.Add(rpnExpressionParts(j))
                b = rpnStack.Pop    'first item in stack stored in b
                a = rpnStack.Pop    'second item in stack stored in a
                rpnStack.Push(a + b)    'execute expression

                'adds top of stack to the listbox (stack viewer in the design)
                lbxRPNStack.Items.Add(rpnStack.Peek)
            ElseIf rpnExpressionParts(j) = "-" Then
                lbxRPNStack.Items.Add(rpnExpressionParts(j))
                b = rpnStack.Pop
                a = rpnStack.Pop
                rpnStack.Push(a - b)
                lbxRPNStack.Items.Add(rpnStack.Peek)
            ElseIf rpnExpressionParts(j) = "*" Then
                lbxRPNStack.Items.Add(rpnExpressionParts(j))
                b = rpnStack.Pop
                a = rpnStack.Pop
                rpnStack.Push(a * b)
                lbxRPNStack.Items.Add(rpnStack.Peek)
            ElseIf rpnExpressionParts(j) = "/" Then
                lbxRPNStack.Items.Add(rpnExpressionParts(j))
                b = rpnStack.Pop
                a = rpnStack.Pop
                rpnStack.Push(a / b)
                lbxRPNStack.Items.Add(rpnStack.Peek)
            Else
                'catches any invaild inputts and displays error message.
                MsgBox("That is an invaild input")
                Exit Sub
            End If
        Next
        'final answer is stored in the stack so it is peeked at to return the result
        txtRPNAnswer.Text = rpnStack.Peek
    End Sub

    Dim operatorStack As New Stack
    Dim outputQueue As New Queue
    Dim rpnExpression2 As String
    Dim rpnExpressionLength2 As Integer
    Dim rpnExpressionCurrentPart As String
    Dim currentItemInStack As String
    Dim currentItemPrecedence As Integer
    Dim itemInStackPrecedence As Integer
    Dim remainingOperatorsInStack As Integer
    Dim lengthOfQueue As Integer
    Dim invaildInput As Boolean

    Private Sub btnCalculateRPNConversion_Click(sender As Object, e As EventArgs) Handles btnCalculateRPNConversion.Click
        'settting that the input is currently valid so that the user can reuse the calculator if they do input an invaild expression.
        invaildInput = False
        Dim rpnExpressionParts(expressionLength2() - 1) As String

        'clearing answer textbox and stack/queue
        txtRPNConversionAnswer.Clear()
        outputQueue.Clear()
        operatorStack.Clear()

        'Splits the inputted expression into individual characters and stores them in an array
        For i = 0 To rpnExpressionLength2 - 1
            rpnExpressionParts(i) = Mid(rpnExpression2, i + 1, 1)
        Next

        'it goes through every cahracter and does a calculation on it 
        For j = 0 To rpnExpressionLength2 - 1
            rpnExpressionCurrentPart = rpnExpressionParts(j)
            'go to calculation subroutine
            calculate()
        Next

        remainingOperatorsInStack = operatorStack.Count
        For k = 1 To remainingOperatorsInStack
            outputQueue.Enqueue(operatorStack.Peek)
            operatorStack.Pop()
        Next

        lengthOfQueue = outputQueue.Count

        If invaildInput = True Then
            Exit Sub
        End If

        For l = 1 To lengthOfQueue
            txtRPNConversionAnswer.Text = txtRPNConversionAnswer.Text & outputQueue.Peek()
            outputQueue.Dequeue()
        Next
    End Sub

    Sub calculate()
        'check if character is a integer, if so add it onto the queue
        If Char.IsDigit(rpnExpressionCurrentPart) Then
            outputQueue.Enqueue(rpnExpressionCurrentPart)

        ElseIf rpnExpressionCurrentPart = "+" Then
            currentItemPrecedence = 2

            'if stack is empty push operator onto the stack
            If operatorStack.Count = 0 Then
                operatorStack.Push(rpnExpressionCurrentPart)

                'if there's at least one item
            ElseIf operatorStack.Count > 0 Then
                currentItemInStack = operatorStack.Peek

                'setsthe precedence of the item on top of the stack
                If currentItemInStack = "+" Or currentItemInStack = "-" Then
                    itemInStackPrecedence = 2
                ElseIf currentItemInStack = "*" Or currentItemInStack = "/" Then
                    itemInStackPrecedence = 3
                ElseIf currentItemInStack = "^" Then
                    itemInStackPrecedence = 4
                ElseIf currentItemInStack = "(" Then
                    itemInStackPrecedence = 0
                End If

                'checks to see if the current item has a lower precedence to the item on the stack
                If currentItemPrecedence <= itemInStackPrecedence Then
                    outputQueue.Enqueue(currentItemInStack)
                    operatorStack.Pop()
                    operatorStack.Push(rpnExpressionCurrentPart)
                ElseIf currentItemPrecedence > itemInStackPrecedence Then
                    operatorStack.Push(rpnExpressionCurrentPart)
                End If

            End If
        ElseIf rpnExpressionCurrentPart = "-" Then
            currentItemPrecedence = 2

            If operatorStack.Count = 0 Then
                operatorStack.Push(rpnExpressionCurrentPart)
            ElseIf operatorStack.Count > 0 Then 'at least one item
                currentItemInStack = operatorStack.Peek

                If currentItemInStack = "+" Or currentItemInStack = "-" Then
                    itemInStackPrecedence = 2
                ElseIf currentItemInStack = "*" Or currentItemInStack = "/" Then
                    itemInStackPrecedence = 3
                ElseIf currentItemInStack = "^" Then
                    itemInStackPrecedence = 4
                ElseIf currentItemInStack = "(" Then
                    itemInStackPrecedence = 0
                End If

                If currentItemPrecedence <= itemInStackPrecedence Then
                    outputQueue.Enqueue(currentItemInStack)
                    operatorStack.Pop()
                    operatorStack.Push(rpnExpressionCurrentPart)
                ElseIf currentItemPrecedence > itemInStackPrecedence Then
                    operatorStack.Push(rpnExpressionCurrentPart)
                End If

            End If

        ElseIf rpnExpressionCurrentPart = "*" Then
            currentItemPrecedence = 3

            If operatorStack.Count = 0 Then
                operatorStack.Push(rpnExpressionCurrentPart)
            ElseIf operatorStack.Count > 0 Then
                currentItemInStack = operatorStack.Peek

                If currentItemInStack = "+" Or currentItemInStack = "-" Then
                    itemInStackPrecedence = 2
                ElseIf currentItemInStack = "*" Or currentItemInStack = "/" Then
                    itemInStackPrecedence = 3
                ElseIf currentItemInStack = "^" Then
                    itemInStackPrecedence = 4
                ElseIf currentItemInStack = "(" Then
                    itemInStackPrecedence = 0
                End If

                If currentItemPrecedence <= itemInStackPrecedence Then
                    outputQueue.Enqueue(currentItemInStack)
                    operatorStack.Pop()
                    operatorStack.Push(rpnExpressionCurrentPart)
                ElseIf currentItemPrecedence > itemInStackPrecedence Then
                    operatorStack.Push(rpnExpressionCurrentPart)
                End If
            End If
        ElseIf rpnExpressionCurrentPart = "/" Then
            currentItemPrecedence = 3

            If operatorStack.Count = 0 Then
                operatorStack.Push(rpnExpressionCurrentPart)
            ElseIf operatorStack.Count > 0 Then
                currentItemInStack = operatorStack.Peek

                If currentItemInStack = "+" Or currentItemInStack = "-" Then
                    itemInStackPrecedence = 2
                ElseIf currentItemInStack = "*" Or currentItemInStack = "/" Then
                    itemInStackPrecedence = 3
                ElseIf currentItemInStack = "^" Then
                    itemInStackPrecedence = 4
                ElseIf currentItemInStack = "(" Then
                    itemInStackPrecedence = 0
                End If

                If currentItemPrecedence <= itemInStackPrecedence Then
                    outputQueue.Enqueue(currentItemInStack)
                    operatorStack.Pop()
                    operatorStack.Push(rpnExpressionCurrentPart)
                ElseIf currentItemPrecedence > itemInStackPrecedence Then
                    operatorStack.Push(rpnExpressionCurrentPart)
                End If

            End If


        ElseIf rpnExpressionCurrentPart = "^" Then
            currentItemPrecedence = 4

            If operatorStack.Count = 0 Then
                operatorStack.Push(rpnExpressionCurrentPart)
            ElseIf operatorStack.Count > 0 Then
                currentItemInStack = operatorStack.Peek

                If currentItemInStack = "+" Or currentItemInStack = "-" Then
                    itemInStackPrecedence = 2
                ElseIf currentItemInStack = "*" Or currentItemInStack = "/" Then
                    itemInStackPrecedence = 3
                ElseIf currentItemInStack = "^" Then
                    itemInStackPrecedence = 4
                ElseIf currentItemInStack = "(" Then
                    itemInStackPrecedence = 0
                End If

                If currentItemPrecedence <= itemInStackPrecedence Then
                    outputQueue.Enqueue(currentItemInStack)
                    operatorStack.Pop()
                    operatorStack.Push(rpnExpressionCurrentPart)
                ElseIf currentItemPrecedence > itemInStackPrecedence Then
                    operatorStack.Push(rpnExpressionCurrentPart)
                End If

            End If

            'if character is a bracket follow different rules.
        ElseIf rpnExpressionCurrentPart = "(" Then
            operatorStack.Push(rpnExpressionCurrentPart)

            'used to remove the brackets from the stack
        ElseIf rpnExpressionCurrentPart = ")" Then
            currentItemInStack = operatorStack.Peek()
            Do Until currentItemInStack = "("
                currentItemInStack = operatorStack.Peek()
                outputQueue.Enqueue(currentItemInStack)
                operatorStack.Pop()
                currentItemInStack = operatorStack.Peek()
            Loop

            operatorStack.Pop()
        Else
            'catches any invaild inputts and displays error message.
            MsgBox("Invaild Input. Try Again")
            invaildInput = True
        End If
    End Sub

    'function used to store the inputted expression and its length into two variables 
    Function expressionLength()
        rpnExpression = ""
        rpnExpression = txtUserRPNInput.Text
        rpnExpressionLength = rpnExpression.Length()

        Return rpnExpressionLength
    End Function

    'function used to store the inputted expression and its length into two variables 
    Function expressionLength2()
        rpnExpression2 = ""
        rpnExpression2 = txtRPNConvertInput.Text
        rpnExpressionLength2 = rpnExpression2.Length()

        Return rpnExpressionLength2
    End Function



    Private Sub btnOpenWordRPN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenWordRPN.Click

        Dim word As Word.Application
        Dim document As Word.Document

        'starts word and opens the document
        word = CreateObject("word.Application")
        Dim startUpPath As String = Application.StartupPath & "\RPNRevision.docx"
        document = word.Documents.Open(startUpPath)
        'makes application visible
        word.Visible = True



    End Sub

    Private Sub btnGoToRPNQuiz_Click(sender As Object, e As EventArgs) Handles btnGoToRPNQuiz.Click
        'change form
        Me.Close()
        frmRPNQuiz.Show()
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        'change form
        Me.Close()
        frmChooseTopic.Show()
    End Sub

    Private Sub btnCloseProgram_Click(sender As Object, e As EventArgs) Handles btnCloseProgram.Click
        'end program
        End
    End Sub

End Class