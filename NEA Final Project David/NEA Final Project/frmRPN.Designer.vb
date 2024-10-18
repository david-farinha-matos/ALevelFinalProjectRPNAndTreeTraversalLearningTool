<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRPN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCloseProgram = New System.Windows.Forms.Button()
        Me.txtUserRPNInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRPNAnswer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculateRPNAnswer = New System.Windows.Forms.Button()
        Me.lbxRPNStack = New System.Windows.Forms.ListBox()
        Me.lblStack = New System.Windows.Forms.Label()
        Me.txtRPNConvertInput = New System.Windows.Forms.TextBox()
        Me.btnCalculateRPNConversion = New System.Windows.Forms.Button()
        Me.txtRPNConversionAnswer = New System.Windows.Forms.TextBox()
        Me.btnGoToRPNQuiz = New System.Windows.Forms.Button()
        Me.btnOpenWordRPN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCloseProgram
        '
        Me.btnCloseProgram.Location = New System.Drawing.Point(12, 382)
        Me.btnCloseProgram.Name = "btnCloseProgram"
        Me.btnCloseProgram.Size = New System.Drawing.Size(92, 23)
        Me.btnCloseProgram.TabIndex = 4
        Me.btnCloseProgram.Text = "Close Program"
        Me.btnCloseProgram.UseVisualStyleBackColor = True
        '
        'txtUserRPNInput
        '
        Me.txtUserRPNInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserRPNInput.Location = New System.Drawing.Point(53, 154)
        Me.txtUserRPNInput.Name = "txtUserRPNInput"
        Me.txtUserRPNInput.Size = New System.Drawing.Size(195, 31)
        Me.txtUserRPNInput.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Please Input a RPN equation to Workout"
        '
        'txtRPNAnswer
        '
        Me.txtRPNAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPNAnswer.Location = New System.Drawing.Point(53, 292)
        Me.txtRPNAnswer.Name = "txtRPNAnswer"
        Me.txtRPNAnswer.ReadOnly = True
        Me.txtRPNAnswer.Size = New System.Drawing.Size(195, 31)
        Me.txtRPNAnswer.TabIndex = 8
        Me.txtRPNAnswer.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Answer"
        '
        'btnCalculateRPNAnswer
        '
        Me.btnCalculateRPNAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateRPNAnswer.Location = New System.Drawing.Point(53, 191)
        Me.btnCalculateRPNAnswer.Name = "btnCalculateRPNAnswer"
        Me.btnCalculateRPNAnswer.Size = New System.Drawing.Size(195, 34)
        Me.btnCalculateRPNAnswer.TabIndex = 12
        Me.btnCalculateRPNAnswer.Text = "Calculate Answer"
        Me.btnCalculateRPNAnswer.UseVisualStyleBackColor = True
        '
        'lbxRPNStack
        '
        Me.lbxRPNStack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxRPNStack.FormattingEnabled = True
        Me.lbxRPNStack.ItemHeight = 20
        Me.lbxRPNStack.Location = New System.Drawing.Point(289, 191)
        Me.lbxRPNStack.Name = "lbxRPNStack"
        Me.lbxRPNStack.Size = New System.Drawing.Size(64, 124)
        Me.lbxRPNStack.TabIndex = 14
        '
        'lblStack
        '
        Me.lblStack.AutoSize = True
        Me.lblStack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStack.Location = New System.Drawing.Point(294, 165)
        Me.lblStack.Name = "lblStack"
        Me.lblStack.Size = New System.Drawing.Size(50, 20)
        Me.lblStack.TabIndex = 15
        Me.lblStack.Text = "Stack"
        '
        'txtRPNConvertInput
        '
        Me.txtRPNConvertInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPNConvertInput.Location = New System.Drawing.Point(511, 164)
        Me.txtRPNConvertInput.Name = "txtRPNConvertInput"
        Me.txtRPNConvertInput.Size = New System.Drawing.Size(195, 31)
        Me.txtRPNConvertInput.TabIndex = 16
        '
        'btnCalculateRPNConversion
        '
        Me.btnCalculateRPNConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateRPNConversion.Location = New System.Drawing.Point(511, 201)
        Me.btnCalculateRPNConversion.Name = "btnCalculateRPNConversion"
        Me.btnCalculateRPNConversion.Size = New System.Drawing.Size(195, 34)
        Me.btnCalculateRPNConversion.TabIndex = 17
        Me.btnCalculateRPNConversion.Text = "Calculate Answer"
        Me.btnCalculateRPNConversion.UseVisualStyleBackColor = True
        '
        'txtRPNConversionAnswer
        '
        Me.txtRPNConversionAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPNConversionAnswer.Location = New System.Drawing.Point(511, 291)
        Me.txtRPNConversionAnswer.Name = "txtRPNConversionAnswer"
        Me.txtRPNConversionAnswer.ReadOnly = True
        Me.txtRPNConversionAnswer.Size = New System.Drawing.Size(195, 31)
        Me.txtRPNConversionAnswer.TabIndex = 18
        Me.txtRPNConversionAnswer.Text = " "
        '
        'btnGoToRPNQuiz
        '
        Me.btnGoToRPNQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToRPNQuiz.Location = New System.Drawing.Point(593, 371)
        Me.btnGoToRPNQuiz.Name = "btnGoToRPNQuiz"
        Me.btnGoToRPNQuiz.Size = New System.Drawing.Size(195, 34)
        Me.btnGoToRPNQuiz.TabIndex = 19
        Me.btnGoToRPNQuiz.Text = "Go To RPN Quiz"
        Me.btnGoToRPNQuiz.UseVisualStyleBackColor = True
        '
        'btnOpenWordRPN
        '
        Me.btnOpenWordRPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenWordRPN.Location = New System.Drawing.Point(275, 12)
        Me.btnOpenWordRPN.Name = "btnOpenWordRPN"
        Me.btnOpenWordRPN.Size = New System.Drawing.Size(237, 52)
        Me.btnOpenWordRPN.TabIndex = 20
        Me.btnOpenWordRPN.Text = "Click Here To Do Some RPN Revision"
        Me.btnOpenWordRPN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "e.g. 56+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(429, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(359, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Please Input An Infix Equation to Convert To RPN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(579, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "e.g. (5+6)*7"
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(110, 382)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(92, 23)
        Me.btnGoBack.TabIndex = 23
        Me.btnGoBack.Text = "Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'frmRPN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 417)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOpenWordRPN)
        Me.Controls.Add(Me.btnGoToRPNQuiz)
        Me.Controls.Add(Me.txtRPNConversionAnswer)
        Me.Controls.Add(Me.btnCalculateRPNConversion)
        Me.Controls.Add(Me.txtRPNConvertInput)
        Me.Controls.Add(Me.lblStack)
        Me.Controls.Add(Me.lbxRPNStack)
        Me.Controls.Add(Me.btnCalculateRPNAnswer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRPNAnswer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUserRPNInput)
        Me.Controls.Add(Me.btnCloseProgram)
        Me.Location = New System.Drawing.Point(150, 150)
        Me.Name = "frmRPN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCloseProgram As Button
    Friend WithEvents txtUserRPNInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRPNAnswer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculateRPNAnswer As Button
    Friend WithEvents lbxRPNStack As ListBox
    Friend WithEvents lblStack As Label
    Friend WithEvents txtRPNConvertInput As TextBox
    Friend WithEvents btnCalculateRPNConversion As Button
    Friend WithEvents txtRPNConversionAnswer As TextBox
    Friend WithEvents btnGoToRPNQuiz As Button
    Friend WithEvents btnOpenWordRPN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGoBack As Button
End Class
