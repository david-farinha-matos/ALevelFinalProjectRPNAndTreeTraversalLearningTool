Imports Microsoft.Office.Interop
Public Class frmTreeTraversing
    Dim nodeValuesArray(9) As String
    Dim counter As Integer = 0

    Dim t As New Tree
    Private Sub btnPreOrder_Click(sender As Object, e As EventArgs) Handles btnPreOrder.Click
        'stores the result of the traversal 
        Dim preOrderArray(counter) As String

        'error handling to stop the program breaking when no names are inputted.
        If counter = 0 Then
            MsgBox("You need atleast one name in the tree.")
            Exit Sub
        End If

        'traverse the tree
        preOrderArray = t.PreorderTraversal()

        'output the result of the traversal to the screen
        For j = 0 To (counter - 1)
            lbxPreorder.Items.Add(preOrderArray(j))
        Next
    End Sub

    Private Sub btnInOrder_Click(sender As Object, e As EventArgs) Handles btnInOrder.Click
        'stores the result of the traversal 
        Dim inOrderArray(counter) As String

        'error handling to stop the program breaking when no names are inputted.
        If nodeValuesArray.Length = 1 Then
            MsgBox("You need atleast one name in the tree.")
            Exit Sub
        End If

        'traverse the tree
        inOrderArray = t.InorderTraversal()

        'output the result of the traversal to the screen
        For j = 0 To (counter - 1)
            lbxInorder.Items.Add(inOrderArray(j))
        Next
    End Sub

    Private Sub btnPostOrder_Click(sender As Object, e As EventArgs) Handles btnPostOrder.Click
        Dim postOrderArray(counter) As String

        'error handling to stop the program breaking when no names are inputted.
        If nodeValuesArray.Length = 1 Then
            MsgBox("You need atleast one name in the tree.")
            Exit Sub
        End If

        'traverse the tree
        postOrderArray = t.PostorderTraversal()

        'output the result of the traversal to the screen
        For j = 0 To (counter - 1)
            lbxPostorder.Items.Add(postOrderArray(j))
        Next
    End Sub

    Private Sub btnInsertNode_Click(sender As Object, e As EventArgs) Handles btnInsertNode.Click
        If lbxPreorder.Items.Count > 0 Or lbxInorder.Items.Count > 0 Or lbxPostorder.Items.Count > 0 Then
            MsgBox("Invail, Please reset first")
            'stops the program if the user doesn't reset after traversing
            Exit Sub
        End If
        If counter <> 10 Then
            'sets nodes value
            nodeValuesArray(counter) = txtInsertNode.Text
            txtInsertNode.Text = ""

            'builds the tree
            t.InsertNode(nodeValuesArray(counter))
            counter += 1
        Else
            'error message for when more than 10 names are inputted
            MsgBox("You can only input 10 names so last input was invaild and removed.")
            Exit Sub
        End If
    End Sub

    Private Sub frmTreeTraversing_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim blackPen As New Drawing.Pen(Color.Black, 1)

        'drawing the tree lines
        e.Graphics.DrawLine(blackPen, 440, 465, 380, 505)        '(blackpen, X start, Y start, X end, Y end)
        e.Graphics.DrawLine(blackPen, 440, 465, 500, 505)
        e.Graphics.DrawLine(blackPen, 360, 525, 340, 565)
        e.Graphics.DrawLine(blackPen, 360, 525, 380, 565)
        e.Graphics.DrawLine(blackPen, 520, 525, 500, 565)
        e.Graphics.DrawLine(blackPen, 520, 525, 540, 565)
    End Sub

    Dim xCoordinate As Double
    Dim yCoordinate As Double
    Dim animationCounter As Integer
    Dim currentTypeOfTraversal As String
    Private Sub btnPreorderVisual_Click(sender As Object, e As EventArgs) Handles btnPreorderVisual.Click

        'goes to subroutine to clear nodes.
        clearBoxes()
        xCoordinate = 437
        yCoordinate = 465
        animationCounter = 0

        'determine the tpe of trasversal to do
        currentTypeOfTraversal = "preorder"

        txtNode1.BackColor = Color.Coral
        txtNode1.Text = "1"
        txtNode1.BorderStyle = BorderStyle.FixedSingle

        'start animation
        AnimationNode1To2()
    End Sub

    Private Sub btnInorderVisual_Click(sender As Object, e As EventArgs) Handles btnInorderVisual.Click
        clearBoxes()
        xCoordinate = 437
        yCoordinate = 465
        animationCounter = 0

        'determine the tpe of trasversal to do
        currentTypeOfTraversal = "inorder"

        'start animation
        AnimationNode1To2()
    End Sub

    Private Sub btnPostorderVisual_Click(sender As Object, e As EventArgs) Handles btnPostorderVisual.Click
        clearBoxes()
        xCoordinate = 437
        yCoordinate = 465
        animationCounter = 0
        'determine the tpe of trasversal to do

        currentTypeOfTraversal = "postorder"

        'start animation
        AnimationNode1To2()
    End Sub

    Sub clearBoxes()

        'clears all nodes
        txtNode1.BackColor = Color.White
        txtNode1.Text = ""
        txtNode2.BackColor = Color.White
        txtNode2.Text = ""
        txtNode3.BackColor = Color.White
        txtNode3.Text = ""
        txtNode4.BackColor = Color.White
        txtNode4.Text = ""
        txtNode5.BackColor = Color.White
        txtNode5.Text = ""
        txtNode6.BackColor = Color.White
        txtNode6.Text = ""
        txtNode7.BackColor = Color.White
        txtNode7.Text = ""
    End Sub

    Sub AnimationNode1To2()
        animationCounter += 1

        'show spot
        pbxSpot.Visible = True

        'change position
        xCoordinate -= 2
        yCoordinate += (4 / 3)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)

        'start timer
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode2To4()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate -= 2
        yCoordinate += (4)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode4To2()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate += 2
        yCoordinate -= (4)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode2To5()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate += 2
        yCoordinate += (4)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode5To2()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate -= 2
        yCoordinate -= (4)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode2To1()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate += 2
        yCoordinate -= (4 / 3)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode1To3()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate += 2
        yCoordinate += (4 / 3)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode3To6()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate -= 2
        yCoordinate += (4)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode6To3()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate += 2
        yCoordinate -= (4)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode3To7()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate += 2
        yCoordinate += (4)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode7To3()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate -= 2
        yCoordinate -= (4)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub
    Sub AnimationNode3To1()
        animationCounter += 1
        pbxSpot.Visible = True
        xCoordinate -= 2
        yCoordinate -= (4 / 3)
        pbxSpot.Location = New Point(xCoordinate, yCoordinate)
        tmrTreeTraversal.Start()
    End Sub


    Private Sub tmrTreeTraversal_Tick(sender As Object, e As EventArgs) Handles tmrTreeTraversal.Tick

        'stop showing spot
        pbxSpot.Visible = False

        'stop timer
        tmrTreeTraversal.Stop()
        If currentTypeOfTraversal = "preorder" Then

            'each tick increments counter by one
            'a certain numbers of the counter, the spot moves in a certain way given by the subroutines.
            If animationCounter < 29 Then
                AnimationNode1To2()
            ElseIf animationCounter = 29 Then
                animationCounter += 1
                txtNode2.BackColor = Color.Coral
                txtNode2.Text = "2"
                txtNode2.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 357
                yCoordinate = 525
                AnimationNode2To4()
            ElseIf animationCounter > 29 And animationCounter < 40 Then
                AnimationNode2To4()
            ElseIf animationCounter = 40 Then
                animationCounter += 1
                txtNode4.BackColor = Color.Coral
                txtNode4.Text = "3"
                txtNode4.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 337
                yCoordinate = 565
                AnimationNode4To2()
            ElseIf animationCounter > 40 And animationCounter < 51 Then
                AnimationNode4To2()
            ElseIf animationCounter = 51 Then
                animationCounter += 1
                txtNode2.BackColor = Color.Coral
                txtNode2.Text = "2"
                txtNode2.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 357
                yCoordinate = 525
                AnimationNode2To5()
            ElseIf animationCounter > 51 And animationCounter < 62 Then
                AnimationNode2To5()
            ElseIf animationCounter = 62 Then
                animationCounter += 1
                txtNode5.BackColor = Color.Coral
                txtNode5.Text = "4"
                txtNode5.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 377
                yCoordinate = 565
                AnimationNode5To2()
            ElseIf animationCounter > 62 And animationCounter < 73 Then
                AnimationNode5To2()
            ElseIf animationCounter = 73 Then
                xCoordinate = 380
                yCoordinate = 503
                AnimationNode2To1()
            ElseIf animationCounter > 73 And animationCounter < 102 Then
                AnimationNode2To1()
            ElseIf animationCounter = 102 Then
                AnimationNode1To3()
            ElseIf animationCounter > 102 And animationCounter < 131 Then
                AnimationNode1To3()
            ElseIf animationCounter = 131 Then
                animationCounter += 1
                txtNode3.BackColor = Color.Coral
                txtNode3.Text = "5"
                txtNode3.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 517
                yCoordinate = 525
                AnimationNode3To6()
            ElseIf animationCounter > 131 And animationCounter < 142 Then
                AnimationNode3To6()
            ElseIf animationCounter = 142 Then
                animationCounter += 1
                txtNode6.BackColor = Color.Coral
                txtNode6.Text = "6"
                txtNode6.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 497
                yCoordinate = 565
                AnimationNode6To3()
            ElseIf animationCounter > 142 And animationCounter < 153 Then
                AnimationNode6To3()
            ElseIf animationCounter = 153 Then
                animationCounter += 1
                xCoordinate = 517
                yCoordinate = 525
                AnimationNode3To7()
            ElseIf animationCounter > 153 And animationCounter < 164 Then
                AnimationNode3To7()
            ElseIf animationCounter = 164 Then
                animationCounter += 1
                txtNode7.BackColor = Color.Coral
                txtNode7.Text = "7"
                txtNode7.BorderStyle = BorderStyle.FixedSingle
                AnimationNode7To3()
            ElseIf animationCounter > 164 And animationCounter < 175 Then
                AnimationNode7To3()
            ElseIf animationCounter = 175 Then
                animationCounter += 1
                xCoordinate = 497
                yCoordinate = 505
                AnimationNode3To1()
            ElseIf animationCounter > 175 And animationCounter < 208 Then
                AnimationNode3To1()
            End If

        ElseIf currentTypeOfTraversal = "inorder" Then
            If animationCounter < 29 Then
                AnimationNode1To2()
            ElseIf animationCounter = 29 Then
                animationCounter += 1
                xCoordinate = 357
                yCoordinate = 525
                AnimationNode2To4()
            ElseIf animationCounter > 29 And animationCounter < 40 Then
                AnimationNode2To4()
            ElseIf animationCounter = 40 Then
                animationCounter += 1
                txtNode4.BackColor = Color.Coral
                txtNode4.Text = "1"
                txtNode4.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 337
                yCoordinate = 565
                AnimationNode4To2()
            ElseIf animationCounter > 40 And animationCounter < 51 Then
                AnimationNode4To2()
            ElseIf animationCounter = 51 Then
                animationCounter += 1
                txtNode2.BackColor = Color.Coral
                txtNode2.Text = "2"
                txtNode2.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 357
                yCoordinate = 525
                AnimationNode2To5()
            ElseIf animationCounter > 51 And animationCounter < 62 Then
                AnimationNode2To5()
            ElseIf animationCounter = 62 Then
                animationCounter += 1
                txtNode5.BackColor = Color.Coral
                txtNode5.Text = "3"
                txtNode5.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 377
                yCoordinate = 565
                AnimationNode5To2()
            ElseIf animationCounter > 62 And animationCounter < 73 Then
                AnimationNode5To2()
            ElseIf animationCounter = 73 Then
                xCoordinate = 380
                yCoordinate = 503
                AnimationNode2To1()
            ElseIf animationCounter > 73 And animationCounter < 102 Then
                AnimationNode2To1()
            ElseIf animationCounter = 102 Then
                txtNode1.BackColor = Color.Coral
                txtNode1.Text = "4"
                txtNode1.BorderStyle = BorderStyle.FixedSingle
                AnimationNode1To3()
            ElseIf animationCounter > 102 And animationCounter < 131 Then
                AnimationNode1To3()
            ElseIf animationCounter = 131 Then
                animationCounter += 1
                xCoordinate = 517
                yCoordinate = 525
                AnimationNode3To6()
            ElseIf animationCounter > 131 And animationCounter < 142 Then
                AnimationNode3To6()
            ElseIf animationCounter = 142 Then
                animationCounter += 1
                txtNode6.BackColor = Color.Coral
                txtNode6.Text = "5"
                txtNode6.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 497
                yCoordinate = 565
                AnimationNode6To3()
            ElseIf animationCounter > 142 And animationCounter < 153 Then
                AnimationNode6To3()
            ElseIf animationCounter = 153 Then
                animationCounter += 1
                txtNode3.BackColor = Color.Coral
                txtNode3.Text = "6"
                txtNode3.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 517
                yCoordinate = 525
                AnimationNode3To7()
            ElseIf animationCounter > 153 And animationCounter < 164 Then
                AnimationNode3To7()
            ElseIf animationCounter = 164 Then
                animationCounter += 1
                txtNode7.BackColor = Color.Coral
                txtNode7.Text = "7"
                txtNode7.BorderStyle = BorderStyle.FixedSingle
                AnimationNode7To3()
            ElseIf animationCounter > 164 And animationCounter < 175 Then
                AnimationNode7To3()
            ElseIf animationCounter = 175 Then
                animationCounter += 1
                xCoordinate = 497
                yCoordinate = 505
                AnimationNode3To1()
            ElseIf animationCounter > 175 And animationCounter < 208 Then
                AnimationNode3To1()
            End If

        ElseIf currentTypeOfTraversal = "postorder" Then
            If animationCounter < 29 Then
                AnimationNode1To2()
            ElseIf animationCounter = 29 Then
                animationCounter += 1
                xCoordinate = 357
                yCoordinate = 525
                AnimationNode2To4()
            ElseIf animationCounter > 29 And animationCounter < 40 Then
                AnimationNode2To4()
            ElseIf animationCounter = 40 Then
                animationCounter += 1
                txtNode4.BackColor = Color.Coral
                txtNode4.Text = "1"
                txtNode4.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 337
                yCoordinate = 565
                AnimationNode4To2()
            ElseIf animationCounter > 40 And animationCounter < 51 Then
                AnimationNode4To2()
            ElseIf animationCounter = 51 Then
                animationCounter += 1
                xCoordinate = 357
                yCoordinate = 525
                AnimationNode2To5()
            ElseIf animationCounter > 51 And animationCounter < 62 Then
                AnimationNode2To5()
            ElseIf animationCounter = 62 Then
                animationCounter += 1
                txtNode5.BackColor = Color.Coral
                txtNode5.Text = "2"
                txtNode5.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 377
                yCoordinate = 565
                AnimationNode5To2()
            ElseIf animationCounter > 62 And animationCounter < 73 Then
                AnimationNode5To2()
            ElseIf animationCounter = 73 Then
                txtNode2.BackColor = Color.Coral
                txtNode2.Text = "3"
                txtNode2.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 380
                yCoordinate = 503
                AnimationNode2To1()
            ElseIf animationCounter > 73 And animationCounter < 102 Then
                AnimationNode2To1()
            ElseIf animationCounter = 102 Then
                AnimationNode1To3()
            ElseIf animationCounter > 102 And animationCounter < 131 Then
                AnimationNode1To3()
            ElseIf animationCounter = 131 Then
                animationCounter += 1
                xCoordinate = 517
                yCoordinate = 525
                AnimationNode3To6()
            ElseIf animationCounter > 131 And animationCounter < 142 Then
                AnimationNode3To6()
            ElseIf animationCounter = 142 Then
                animationCounter += 1
                txtNode6.BackColor = Color.Coral
                txtNode6.Text = "4"
                txtNode6.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 497
                yCoordinate = 565
                AnimationNode6To3()
            ElseIf animationCounter > 142 And animationCounter < 153 Then
                AnimationNode6To3()
            ElseIf animationCounter = 153 Then
                animationCounter += 1
                xCoordinate = 517
                yCoordinate = 525
                AnimationNode3To7()
            ElseIf animationCounter > 153 And animationCounter < 164 Then
                AnimationNode3To7()
            ElseIf animationCounter = 164 Then
                animationCounter += 1
                txtNode7.BackColor = Color.Coral
                txtNode7.Text = "5"
                txtNode7.BorderStyle = BorderStyle.FixedSingle
                AnimationNode7To3()
            ElseIf animationCounter > 164 And animationCounter < 175 Then
                AnimationNode7To3()
            ElseIf animationCounter = 175 Then
                animationCounter += 1
                txtNode3.BackColor = Color.Coral
                txtNode3.Text = "6"
                txtNode3.BorderStyle = BorderStyle.FixedSingle
                xCoordinate = 497
                yCoordinate = 505
                AnimationNode3To1()
            ElseIf animationCounter > 175 And animationCounter < 208 Then
                AnimationNode3To1()
                If animationCounter = 208 Then
                    txtNode1.BackColor = Color.Coral
                    txtNode1.Text = "7"
                    txtNode1.BorderStyle = BorderStyle.FixedSingle
                End If
            End If
        End If
    End Sub



    Private Sub btnCloseProgram_Click(sender As Object, e As EventArgs) Handles btnCloseProgram.Click

        'close program
        End
    End Sub

    Private Sub btnGoToTreeTraversalQuiz_Click(sender As Object, e As EventArgs) Handles btnGoToTreeTraversalQuiz.Click

        'chnage form
        Me.Close()
        frmTreeTraversalQuiz.Show()
    End Sub

    Private Sub btnResetTree_Click(sender As Object, e As EventArgs) Handles btnResetTree.Click

        'restarts form
        Dim thisForm As New frmTreeTraversing
        thisForm.Show()
        Me.Close()
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click

        'change form
        Me.Close()
        frmChooseTopic.Show()
    End Sub

    Private Sub btnOpenWordTreeTraversal_Click(sender As Object, e As EventArgs) Handles btnOpenWordTreeTraversal.Click
        Dim word As Word.Application
        Dim document As Word.Document

        'starts wird and opens the document
        word = CreateObject("word.Application")
        Dim StartUpPath As String = Application.StartupPath & "\TreeTraversalRevision.docx"
        document = word.Documents.Open(StartUpPath)

        'makes appicaltion visible
        word.Visible = True
    End Sub
End Class


Public Class Tree
    Dim root As TreeNode
    Public Sub InsertNode(ByVal NewValue As String)
        'used to build the tree
        If root Is Nothing Then
            root = New TreeNode(NewValue)
        Else
            root.Insert(NewValue)
        End If
    End Sub

    Dim preorderArray(9) As String
    Dim inorderArray(9) As String
    Dim postorderArray(9) As String
    Dim counterpre As Integer = 0
    Dim counterin As Integer = -1
    Dim counterpost As Integer = -1

    Public Function PreorderTraversal()

        'used to launch the recursive traversal and pass it a tree's root node 
        Call Preorder(root)
        Return preorderArray
    End Function
    Public Sub Preorder(ByVal node As TreeNode)

        'algorithm for  preorder traversal
        preorderArray(counterpre) = node.Data
        If node.LeftNode IsNot Nothing Then
            counterpre += 1
            Call Preorder(node.LeftNode)
        End If
        If node.RightNode IsNot Nothing Then
            counterpre += 1
            Call Preorder(node.RightNode)
        End If
    End Sub


    Public Function InorderTraversal()
        Call Inorder(root)
        Return inorderArray
    End Function
    Public Sub Inorder(ByVal node As TreeNode)

        'algorithm for  inorder traversal
        If node.LeftNode IsNot Nothing Then
            Call Inorder(node.LeftNode)
        End If
        counterin += 1
        inorderArray(counterin) = node.Data
        If node.RightNode IsNot Nothing Then
            Call Inorder(node.RightNode)
        End If
    End Sub


    Public Function PostorderTraversal()
        Call Postorder(root)
        Return postorderArray
    End Function
    Public Sub Postorder(ByVal node As TreeNode)

        'algorithm for  postorder traversal
        If node.LeftNode IsNot Nothing Then
            Call Postorder(node.LeftNode)
        End If
        If node.RightNode IsNot Nothing Then
            Call Postorder(node.RightNode)
        End If
        counterpost += 1
        postorderArray(counterpost) = node.Data
    End Sub

End Class

Public Class TreeNode

    'each node could have a node at its left and right
    Public LeftNode As TreeNode
    Public RightNode As TreeNode

    'each node carries some data
    Public Data As String

    Public Sub New(ByVal nodeData As String)

        'when a new node is created its property is initialised and right/let child is set to nothing
        Me.Data = nodeData
        Me.LeftNode = Nothing
        Me.RightNode = Nothing
    End Sub
    Public Sub Insert(ByVal NewValue As String)

        'inserts node into tree based on if it comes before or after the current node
        If NewValue < Me.Data Then
            If Me.LeftNode Is Nothing Then
                Me.LeftNode = New TreeNode(NewValue)
            Else
                Me.LeftNode.Insert(NewValue)
            End If
        ElseIf NewValue > Me.Data Then
            If Me.RightNode Is Nothing Then
                Me.RightNode = New TreeNode(NewValue)
            Else
                Me.RightNode.Insert(NewValue)
            End If
        End If
    End Sub

End Class