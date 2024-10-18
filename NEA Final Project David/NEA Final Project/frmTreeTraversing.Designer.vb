<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreeTraversing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCloseProgram = New System.Windows.Forms.Button()
        Me.btnPreOrder = New System.Windows.Forms.Button()
        Me.btnInOrder = New System.Windows.Forms.Button()
        Me.btnPostOrder = New System.Windows.Forms.Button()
        Me.txtNode1 = New System.Windows.Forms.TextBox()
        Me.txtNode2 = New System.Windows.Forms.TextBox()
        Me.txtNode3 = New System.Windows.Forms.TextBox()
        Me.txtNode5 = New System.Windows.Forms.TextBox()
        Me.txtNode7 = New System.Windows.Forms.TextBox()
        Me.txtNode4 = New System.Windows.Forms.TextBox()
        Me.txtNode6 = New System.Windows.Forms.TextBox()
        Me.btnOpenWordTreeTraversal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPreOrder = New System.Windows.Forms.Label()
        Me.lblPreOrder1 = New System.Windows.Forms.Label()
        Me.lblPreOrder2 = New System.Windows.Forms.Label()
        Me.lblPreOrder3 = New System.Windows.Forms.Label()
        Me.lblInOrder = New System.Windows.Forms.Label()
        Me.lblInOrder2 = New System.Windows.Forms.Label()
        Me.lblPostOrder2 = New System.Windows.Forms.Label()
        Me.lblPostOrder1 = New System.Windows.Forms.Label()
        Me.lblPostOrder3 = New System.Windows.Forms.Label()
        Me.lblInOrder1 = New System.Windows.Forms.Label()
        Me.lblInOrder3 = New System.Windows.Forms.Label()
        Me.lblPostOrder = New System.Windows.Forms.Label()
        Me.txtInsertNode = New System.Windows.Forms.TextBox()
        Me.btnInsertNode = New System.Windows.Forms.Button()
        Me.lbxPreorder = New System.Windows.Forms.ListBox()
        Me.lbxInorder = New System.Windows.Forms.ListBox()
        Me.lbxPostorder = New System.Windows.Forms.ListBox()
        Me.btnPreorderVisual = New System.Windows.Forms.Button()
        Me.btnPostorderVisual = New System.Windows.Forms.Button()
        Me.btnInorderVisual = New System.Windows.Forms.Button()
        Me.tmrTreeTraversal = New System.Windows.Forms.Timer(Me.components)
        Me.pbxSpot = New System.Windows.Forms.PictureBox()
        Me.btnGoToTreeTraversalQuiz = New System.Windows.Forms.Button()
        Me.btnResetTree = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        CType(Me.pbxSpot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCloseProgram
        '
        Me.btnCloseProgram.Location = New System.Drawing.Point(12, 626)
        Me.btnCloseProgram.Name = "btnCloseProgram"
        Me.btnCloseProgram.Size = New System.Drawing.Size(92, 23)
        Me.btnCloseProgram.TabIndex = 4
        Me.btnCloseProgram.Text = "Close Program"
        Me.btnCloseProgram.UseVisualStyleBackColor = True
        '
        'btnPreOrder
        '
        Me.btnPreOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreOrder.Location = New System.Drawing.Point(215, 106)
        Me.btnPreOrder.Name = "btnPreOrder"
        Me.btnPreOrder.Size = New System.Drawing.Size(92, 45)
        Me.btnPreOrder.TabIndex = 5
        Me.btnPreOrder.Text = "Pre Order Traversal"
        Me.btnPreOrder.UseVisualStyleBackColor = True
        '
        'btnInOrder
        '
        Me.btnInOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInOrder.Location = New System.Drawing.Point(395, 106)
        Me.btnInOrder.Name = "btnInOrder"
        Me.btnInOrder.Size = New System.Drawing.Size(92, 45)
        Me.btnInOrder.TabIndex = 6
        Me.btnInOrder.Text = "In Order Traversal"
        Me.btnInOrder.UseVisualStyleBackColor = True
        '
        'btnPostOrder
        '
        Me.btnPostOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostOrder.Location = New System.Drawing.Point(585, 106)
        Me.btnPostOrder.Name = "btnPostOrder"
        Me.btnPostOrder.Size = New System.Drawing.Size(92, 45)
        Me.btnPostOrder.TabIndex = 7
        Me.btnPostOrder.Text = "Post Order Traversal"
        Me.btnPostOrder.UseVisualStyleBackColor = True
        '
        'txtNode1
        '
        Me.txtNode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNode1.ForeColor = System.Drawing.Color.Black
        Me.txtNode1.Location = New System.Drawing.Point(420, 445)
        Me.txtNode1.Name = "txtNode1"
        Me.txtNode1.ReadOnly = True
        Me.txtNode1.Size = New System.Drawing.Size(40, 20)
        Me.txtNode1.TabIndex = 25
        Me.txtNode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNode2
        '
        Me.txtNode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNode2.Location = New System.Drawing.Point(340, 505)
        Me.txtNode2.Name = "txtNode2"
        Me.txtNode2.ReadOnly = True
        Me.txtNode2.Size = New System.Drawing.Size(40, 20)
        Me.txtNode2.TabIndex = 26
        Me.txtNode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNode3
        '
        Me.txtNode3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNode3.Location = New System.Drawing.Point(500, 505)
        Me.txtNode3.Name = "txtNode3"
        Me.txtNode3.ReadOnly = True
        Me.txtNode3.Size = New System.Drawing.Size(40, 20)
        Me.txtNode3.TabIndex = 27
        Me.txtNode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNode5
        '
        Me.txtNode5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNode5.Location = New System.Drawing.Point(380, 565)
        Me.txtNode5.Name = "txtNode5"
        Me.txtNode5.ReadOnly = True
        Me.txtNode5.Size = New System.Drawing.Size(40, 20)
        Me.txtNode5.TabIndex = 28
        Me.txtNode5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNode7
        '
        Me.txtNode7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNode7.Location = New System.Drawing.Point(540, 565)
        Me.txtNode7.Name = "txtNode7"
        Me.txtNode7.ReadOnly = True
        Me.txtNode7.Size = New System.Drawing.Size(40, 20)
        Me.txtNode7.TabIndex = 29
        Me.txtNode7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNode4
        '
        Me.txtNode4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNode4.Location = New System.Drawing.Point(300, 565)
        Me.txtNode4.Name = "txtNode4"
        Me.txtNode4.ReadOnly = True
        Me.txtNode4.Size = New System.Drawing.Size(40, 20)
        Me.txtNode4.TabIndex = 30
        Me.txtNode4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNode6
        '
        Me.txtNode6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNode6.Location = New System.Drawing.Point(460, 565)
        Me.txtNode6.Name = "txtNode6"
        Me.txtNode6.ReadOnly = True
        Me.txtNode6.Size = New System.Drawing.Size(40, 20)
        Me.txtNode6.TabIndex = 31
        Me.txtNode6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOpenWordTreeTraversal
        '
        Me.btnOpenWordTreeTraversal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenWordTreeTraversal.Location = New System.Drawing.Point(29, 30)
        Me.btnOpenWordTreeTraversal.Name = "btnOpenWordTreeTraversal"
        Me.btnOpenWordTreeTraversal.Size = New System.Drawing.Size(135, 121)
        Me.btnOpenWordTreeTraversal.TabIndex = 32
        Me.btnOpenWordTreeTraversal.Text = "Click Here To Do Some Tree Traversal Revision"
        Me.btnOpenWordTreeTraversal.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 36)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Please Enter Up To A Total Of 10 Names" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You Like To Use For The Tree Traversal"
        '
        'lblPreOrder
        '
        Me.lblPreOrder.AutoSize = True
        Me.lblPreOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreOrder.Location = New System.Drawing.Point(9, 203)
        Me.lblPreOrder.Name = "lblPreOrder"
        Me.lblPreOrder.Size = New System.Drawing.Size(188, 16)
        Me.lblPreOrder.TabIndex = 36
        Me.lblPreOrder.Text = "Pre-order Traversal Algorithm:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPreOrder1
        '
        Me.lblPreOrder1.AutoSize = True
        Me.lblPreOrder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreOrder1.Location = New System.Drawing.Point(9, 219)
        Me.lblPreOrder1.Name = "lblPreOrder1"
        Me.lblPreOrder1.Size = New System.Drawing.Size(93, 13)
        Me.lblPreOrder1.TabIndex = 38
        Me.lblPreOrder1.Text = "1. Visit Root Node"
        '
        'lblPreOrder2
        '
        Me.lblPreOrder2.AutoSize = True
        Me.lblPreOrder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreOrder2.Location = New System.Drawing.Point(9, 234)
        Me.lblPreOrder2.Name = "lblPreOrder2"
        Me.lblPreOrder2.Size = New System.Drawing.Size(180, 13)
        Me.lblPreOrder2.TabIndex = 39
        Me.lblPreOrder2.Text = "2. Recursively Traverse Left Subtree"
        '
        'lblPreOrder3
        '
        Me.lblPreOrder3.AutoSize = True
        Me.lblPreOrder3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreOrder3.Location = New System.Drawing.Point(9, 247)
        Me.lblPreOrder3.Name = "lblPreOrder3"
        Me.lblPreOrder3.Size = New System.Drawing.Size(187, 13)
        Me.lblPreOrder3.TabIndex = 40
        Me.lblPreOrder3.Text = "3. Recursively Traverse Right Subtree"
        '
        'lblInOrder
        '
        Me.lblInOrder.AutoSize = True
        Me.lblInOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOrder.Location = New System.Drawing.Point(9, 283)
        Me.lblInOrder.Name = "lblInOrder"
        Me.lblInOrder.Size = New System.Drawing.Size(177, 16)
        Me.lblInOrder.TabIndex = 41
        Me.lblInOrder.Text = "In-order Traversal Algorithm:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblInOrder2
        '
        Me.lblInOrder2.AutoSize = True
        Me.lblInOrder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOrder2.Location = New System.Drawing.Point(9, 312)
        Me.lblInOrder2.Name = "lblInOrder2"
        Me.lblInOrder2.Size = New System.Drawing.Size(93, 13)
        Me.lblInOrder2.TabIndex = 42
        Me.lblInOrder2.Text = "2. Visit Root Node"
        '
        'lblPostOrder2
        '
        Me.lblPostOrder2.AutoSize = True
        Me.lblPostOrder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostOrder2.Location = New System.Drawing.Point(9, 387)
        Me.lblPostOrder2.Name = "lblPostOrder2"
        Me.lblPostOrder2.Size = New System.Drawing.Size(187, 13)
        Me.lblPostOrder2.TabIndex = 43
        Me.lblPostOrder2.Text = "2. Recursively Traverse Right Subtree"
        '
        'lblPostOrder1
        '
        Me.lblPostOrder1.AutoSize = True
        Me.lblPostOrder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostOrder1.Location = New System.Drawing.Point(9, 374)
        Me.lblPostOrder1.Name = "lblPostOrder1"
        Me.lblPostOrder1.Size = New System.Drawing.Size(180, 13)
        Me.lblPostOrder1.TabIndex = 44
        Me.lblPostOrder1.Text = "1. Recursively Traverse Left Subtree"
        '
        'lblPostOrder3
        '
        Me.lblPostOrder3.AutoSize = True
        Me.lblPostOrder3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostOrder3.Location = New System.Drawing.Point(9, 400)
        Me.lblPostOrder3.Name = "lblPostOrder3"
        Me.lblPostOrder3.Size = New System.Drawing.Size(93, 13)
        Me.lblPostOrder3.TabIndex = 45
        Me.lblPostOrder3.Text = "3. Visit Root Node"
        '
        'lblInOrder1
        '
        Me.lblInOrder1.AutoSize = True
        Me.lblInOrder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOrder1.Location = New System.Drawing.Point(9, 299)
        Me.lblInOrder1.Name = "lblInOrder1"
        Me.lblInOrder1.Size = New System.Drawing.Size(180, 13)
        Me.lblInOrder1.TabIndex = 46
        Me.lblInOrder1.Text = "1. Recursively Traverse Left Subtree"
        '
        'lblInOrder3
        '
        Me.lblInOrder3.AutoSize = True
        Me.lblInOrder3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOrder3.Location = New System.Drawing.Point(9, 325)
        Me.lblInOrder3.Name = "lblInOrder3"
        Me.lblInOrder3.Size = New System.Drawing.Size(187, 13)
        Me.lblInOrder3.TabIndex = 47
        Me.lblInOrder3.Text = "3. Recursively Traverse Right Subtree"
        '
        'lblPostOrder
        '
        Me.lblPostOrder.AutoSize = True
        Me.lblPostOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostOrder.Location = New System.Drawing.Point(9, 358)
        Me.lblPostOrder.Name = "lblPostOrder"
        Me.lblPostOrder.Size = New System.Drawing.Size(194, 16)
        Me.lblPostOrder.TabIndex = 48
        Me.lblPostOrder.Text = "Post-order Traversal Algorithm:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtInsertNode
        '
        Me.txtInsertNode.Location = New System.Drawing.Point(328, 67)
        Me.txtInsertNode.Name = "txtInsertNode"
        Me.txtInsertNode.Size = New System.Drawing.Size(92, 20)
        Me.txtInsertNode.TabIndex = 49
        '
        'btnInsertNode
        '
        Me.btnInsertNode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertNode.Location = New System.Drawing.Point(460, 54)
        Me.btnInsertNode.Name = "btnInsertNode"
        Me.btnInsertNode.Size = New System.Drawing.Size(92, 43)
        Me.btnInsertNode.TabIndex = 50
        Me.btnInsertNode.Text = "Add Name"
        Me.btnInsertNode.UseVisualStyleBackColor = True
        '
        'lbxPreorder
        '
        Me.lbxPreorder.FormattingEnabled = True
        Me.lbxPreorder.Location = New System.Drawing.Point(215, 172)
        Me.lbxPreorder.Name = "lbxPreorder"
        Me.lbxPreorder.Size = New System.Drawing.Size(92, 95)
        Me.lbxPreorder.TabIndex = 51
        '
        'lbxInorder
        '
        Me.lbxInorder.FormattingEnabled = True
        Me.lbxInorder.Location = New System.Drawing.Point(395, 172)
        Me.lbxInorder.Name = "lbxInorder"
        Me.lbxInorder.Size = New System.Drawing.Size(92, 95)
        Me.lbxInorder.TabIndex = 52
        '
        'lbxPostorder
        '
        Me.lbxPostorder.FormattingEnabled = True
        Me.lbxPostorder.Location = New System.Drawing.Point(585, 172)
        Me.lbxPostorder.Name = "lbxPostorder"
        Me.lbxPostorder.Size = New System.Drawing.Size(92, 95)
        Me.lbxPostorder.TabIndex = 53
        '
        'btnPreorderVisual
        '
        Me.btnPreorderVisual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreorderVisual.Location = New System.Drawing.Point(215, 394)
        Me.btnPreorderVisual.Name = "btnPreorderVisual"
        Me.btnPreorderVisual.Size = New System.Drawing.Size(92, 45)
        Me.btnPreorderVisual.TabIndex = 54
        Me.btnPreorderVisual.Text = "Pre Order Visually"
        Me.btnPreorderVisual.UseVisualStyleBackColor = True
        '
        'btnPostorderVisual
        '
        Me.btnPostorderVisual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostorderVisual.Location = New System.Drawing.Point(585, 394)
        Me.btnPostorderVisual.Name = "btnPostorderVisual"
        Me.btnPostorderVisual.Size = New System.Drawing.Size(92, 45)
        Me.btnPostorderVisual.TabIndex = 55
        Me.btnPostorderVisual.Text = "Post Order Visually"
        Me.btnPostorderVisual.UseVisualStyleBackColor = True
        '
        'btnInorderVisual
        '
        Me.btnInorderVisual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInorderVisual.Location = New System.Drawing.Point(395, 394)
        Me.btnInorderVisual.Name = "btnInorderVisual"
        Me.btnInorderVisual.Size = New System.Drawing.Size(92, 45)
        Me.btnInorderVisual.TabIndex = 56
        Me.btnInorderVisual.Text = "In Order Visually"
        Me.btnInorderVisual.UseVisualStyleBackColor = True
        '
        'tmrTreeTraversal
        '
        Me.tmrTreeTraversal.Interval = 1
        '
        'pbxSpot
        '
        Me.pbxSpot.BackColor = System.Drawing.Color.Black
        Me.pbxSpot.ImageLocation = ""
        Me.pbxSpot.Location = New System.Drawing.Point(437, 465)
        Me.pbxSpot.Name = "pbxSpot"
        Me.pbxSpot.Size = New System.Drawing.Size(6, 6)
        Me.pbxSpot.TabIndex = 58
        Me.pbxSpot.TabStop = False
        Me.pbxSpot.Visible = False
        '
        'btnGoToTreeTraversalQuiz
        '
        Me.btnGoToTreeTraversalQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToTreeTraversalQuiz.Location = New System.Drawing.Point(594, 599)
        Me.btnGoToTreeTraversalQuiz.Name = "btnGoToTreeTraversalQuiz"
        Me.btnGoToTreeTraversalQuiz.Size = New System.Drawing.Size(118, 50)
        Me.btnGoToTreeTraversalQuiz.TabIndex = 59
        Me.btnGoToTreeTraversalQuiz.Text = "Go To Tree Traversal Quiz"
        Me.btnGoToTreeTraversalQuiz.UseVisualStyleBackColor = True
        '
        'btnResetTree
        '
        Me.btnResetTree.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetTree.Location = New System.Drawing.Point(558, 54)
        Me.btnResetTree.Name = "btnResetTree"
        Me.btnResetTree.Size = New System.Drawing.Size(119, 43)
        Me.btnResetTree.TabIndex = 60
        Me.btnResetTree.Text = "Reset Names"
        Me.btnResetTree.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(110, 626)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(92, 23)
        Me.btnGoBack.TabIndex = 61
        Me.btnGoBack.Text = "Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'frmTreeTraversing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 661)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnResetTree)
        Me.Controls.Add(Me.btnGoToTreeTraversalQuiz)
        Me.Controls.Add(Me.pbxSpot)
        Me.Controls.Add(Me.btnInorderVisual)
        Me.Controls.Add(Me.btnPostorderVisual)
        Me.Controls.Add(Me.btnPreorderVisual)
        Me.Controls.Add(Me.lbxPostorder)
        Me.Controls.Add(Me.lbxInorder)
        Me.Controls.Add(Me.lbxPreorder)
        Me.Controls.Add(Me.btnInsertNode)
        Me.Controls.Add(Me.txtInsertNode)
        Me.Controls.Add(Me.lblPostOrder)
        Me.Controls.Add(Me.lblInOrder3)
        Me.Controls.Add(Me.lblInOrder1)
        Me.Controls.Add(Me.lblPostOrder3)
        Me.Controls.Add(Me.lblPostOrder1)
        Me.Controls.Add(Me.lblPostOrder2)
        Me.Controls.Add(Me.lblInOrder2)
        Me.Controls.Add(Me.lblInOrder)
        Me.Controls.Add(Me.lblPreOrder3)
        Me.Controls.Add(Me.lblPreOrder2)
        Me.Controls.Add(Me.lblPreOrder1)
        Me.Controls.Add(Me.lblPreOrder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOpenWordTreeTraversal)
        Me.Controls.Add(Me.txtNode6)
        Me.Controls.Add(Me.txtNode4)
        Me.Controls.Add(Me.txtNode7)
        Me.Controls.Add(Me.txtNode5)
        Me.Controls.Add(Me.txtNode3)
        Me.Controls.Add(Me.txtNode2)
        Me.Controls.Add(Me.txtNode1)
        Me.Controls.Add(Me.btnPostOrder)
        Me.Controls.Add(Me.btnInOrder)
        Me.Controls.Add(Me.btnPreOrder)
        Me.Controls.Add(Me.btnCloseProgram)
        Me.Location = New System.Drawing.Point(150, 150)
        Me.Name = "frmTreeTraversing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tree Traversing"
        CType(Me.pbxSpot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCloseProgram As Button
    Friend WithEvents btnPreOrder As Button
    Friend WithEvents btnInOrder As Button
    Friend WithEvents btnPostOrder As Button
    Friend WithEvents txtNode1 As TextBox
    Friend WithEvents txtNode2 As TextBox
    Friend WithEvents txtNode3 As TextBox
    Friend WithEvents txtNode5 As TextBox
    Friend WithEvents txtNode7 As TextBox
    Friend WithEvents txtNode4 As TextBox
    Friend WithEvents txtNode6 As TextBox
    Friend WithEvents btnOpenWordTreeTraversal As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPreOrder As Label
    Friend WithEvents lblPreOrder1 As Label
    Friend WithEvents lblPreOrder2 As Label
    Friend WithEvents lblPreOrder3 As Label
    Friend WithEvents lblInOrder As Label
    Friend WithEvents lblInOrder2 As Label
    Friend WithEvents lblPostOrder2 As Label
    Friend WithEvents lblPostOrder1 As Label
    Friend WithEvents lblPostOrder3 As Label
    Friend WithEvents lblInOrder1 As Label
    Friend WithEvents lblInOrder3 As Label
    Friend WithEvents lblPostOrder As Label
    Friend WithEvents txtInsertNode As TextBox
    Friend WithEvents btnInsertNode As Button
    Friend WithEvents lbxPreorder As ListBox
    Friend WithEvents lbxInorder As ListBox
    Friend WithEvents lbxPostorder As ListBox
    Friend WithEvents btnPreorderVisual As Button
    Friend WithEvents btnPostorderVisual As Button
    Friend WithEvents btnInorderVisual As Button
    Friend WithEvents tmrTreeTraversal As Timer
    Friend WithEvents pbxSpot As PictureBox
    Friend WithEvents btnGoToTreeTraversalQuiz As Button
    Friend WithEvents btnResetTree As Button
    Friend WithEvents btnGoBack As Button
End Class
