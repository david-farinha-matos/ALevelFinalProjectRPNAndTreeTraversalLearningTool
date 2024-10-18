<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreeTraversalQuiz
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
        Me.btnStartQuiz = New System.Windows.Forms.Button()
        Me.lblAnswerA = New System.Windows.Forms.Label()
        Me.lblAnswerD = New System.Windows.Forms.Label()
        Me.lblAnswerC = New System.Windows.Forms.Label()
        Me.lblAnswerB = New System.Windows.Forms.Label()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnGuessA = New System.Windows.Forms.Button()
        Me.btnGuessB = New System.Windows.Forms.Button()
        Me.btnGuessD = New System.Windows.Forms.Button()
        Me.btnGuessC = New System.Windows.Forms.Button()
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblColon = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.tmrQuizTime = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnStartQuiz
        '
        Me.btnStartQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartQuiz.Location = New System.Drawing.Point(259, 12)
        Me.btnStartQuiz.Name = "btnStartQuiz"
        Me.btnStartQuiz.Size = New System.Drawing.Size(146, 35)
        Me.btnStartQuiz.TabIndex = 1
        Me.btnStartQuiz.Text = "Start Quiz"
        Me.btnStartQuiz.UseVisualStyleBackColor = True
        '
        'lblAnswerA
        '
        Me.lblAnswerA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerA.Location = New System.Drawing.Point(59, 119)
        Me.lblAnswerA.Name = "lblAnswerA"
        Me.lblAnswerA.Size = New System.Drawing.Size(146, 66)
        Me.lblAnswerA.TabIndex = 17
        Me.lblAnswerA.Text = "Label1"
        Me.lblAnswerA.Visible = False
        '
        'lblAnswerD
        '
        Me.lblAnswerD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerD.Location = New System.Drawing.Point(443, 281)
        Me.lblAnswerD.Name = "lblAnswerD"
        Me.lblAnswerD.Size = New System.Drawing.Size(146, 70)
        Me.lblAnswerD.TabIndex = 18
        Me.lblAnswerD.Text = "Label1"
        Me.lblAnswerD.Visible = False
        '
        'lblAnswerC
        '
        Me.lblAnswerC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerC.Location = New System.Drawing.Point(59, 281)
        Me.lblAnswerC.Name = "lblAnswerC"
        Me.lblAnswerC.Size = New System.Drawing.Size(146, 70)
        Me.lblAnswerC.TabIndex = 19
        Me.lblAnswerC.Text = "Label1"
        Me.lblAnswerC.Visible = False
        '
        'lblAnswerB
        '
        Me.lblAnswerB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerB.Location = New System.Drawing.Point(446, 119)
        Me.lblAnswerB.Name = "lblAnswerB"
        Me.lblAnswerB.Size = New System.Drawing.Size(146, 70)
        Me.lblAnswerB.TabIndex = 20
        Me.lblAnswerB.Text = "Label1"
        Me.lblAnswerB.Visible = False
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(259, 30)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(146, 26)
        Me.lblQuestionNumber.TabIndex = 22
        Me.lblQuestionNumber.Text = "Label1"
        Me.lblQuestionNumber.Visible = False
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(256, 56)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(146, 171)
        Me.lblQuestion.TabIndex = 23
        Me.lblQuestion.Text = "Label1"
        Me.lblQuestion.Visible = False
        '
        'btnGuessA
        '
        Me.btnGuessA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessA.Location = New System.Drawing.Point(62, 192)
        Me.btnGuessA.Name = "btnGuessA"
        Me.btnGuessA.Size = New System.Drawing.Size(146, 35)
        Me.btnGuessA.TabIndex = 24
        Me.btnGuessA.Text = "A"
        Me.btnGuessA.UseVisualStyleBackColor = True
        Me.btnGuessA.Visible = False
        '
        'btnGuessB
        '
        Me.btnGuessB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessB.Location = New System.Drawing.Point(446, 192)
        Me.btnGuessB.Name = "btnGuessB"
        Me.btnGuessB.Size = New System.Drawing.Size(146, 35)
        Me.btnGuessB.TabIndex = 25
        Me.btnGuessB.Text = "B"
        Me.btnGuessB.UseVisualStyleBackColor = True
        Me.btnGuessB.Visible = False
        '
        'btnGuessD
        '
        Me.btnGuessD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessD.Location = New System.Drawing.Point(443, 354)
        Me.btnGuessD.Name = "btnGuessD"
        Me.btnGuessD.Size = New System.Drawing.Size(146, 35)
        Me.btnGuessD.TabIndex = 26
        Me.btnGuessD.Text = "D"
        Me.btnGuessD.UseVisualStyleBackColor = True
        Me.btnGuessD.Visible = False
        '
        'btnGuessC
        '
        Me.btnGuessC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessC.Location = New System.Drawing.Point(62, 354)
        Me.btnGuessC.Name = "btnGuessC"
        Me.btnGuessC.Size = New System.Drawing.Size(146, 35)
        Me.btnGuessC.TabIndex = 27
        Me.btnGuessC.Text = "C"
        Me.btnGuessC.UseVisualStyleBackColor = True
        Me.btnGuessC.Visible = False
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.Location = New System.Drawing.Point(12, 421)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(127, 20)
        Me.lblTimeRemaining.TabIndex = 28
        Me.lblTimeRemaining.Text = "Time Remaining:"
        Me.lblTimeRemaining.Visible = False
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(145, 421)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(27, 20)
        Me.lblMinutes.TabIndex = 29
        Me.lblMinutes.Text = "10"
        Me.lblMinutes.Visible = False
        '
        'lblColon
        '
        Me.lblColon.AutoSize = True
        Me.lblColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon.Location = New System.Drawing.Point(178, 421)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(13, 20)
        Me.lblColon.TabIndex = 30
        Me.lblColon.Text = ":"
        Me.lblColon.Visible = False
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(197, 421)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(27, 20)
        Me.lblSeconds.TabIndex = 31
        Me.lblSeconds.Text = "00"
        Me.lblSeconds.Visible = False
        '
        'tmrQuizTime
        '
        Me.tmrQuizTime.Enabled = True
        Me.tmrQuizTime.Interval = 1000
        '
        'frmTreeTraversalQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 450)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblColon)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.btnGuessC)
        Me.Controls.Add(Me.btnGuessD)
        Me.Controls.Add(Me.btnGuessB)
        Me.Controls.Add(Me.btnGuessA)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.lblAnswerB)
        Me.Controls.Add(Me.lblAnswerC)
        Me.Controls.Add(Me.lblAnswerD)
        Me.Controls.Add(Me.lblAnswerA)
        Me.Controls.Add(Me.btnStartQuiz)
        Me.Location = New System.Drawing.Point(150, 150)
        Me.Name = "frmTreeTraversalQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmTreeTraversalQuiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartQuiz As Button
    Friend WithEvents lblAnswerA As Label
    Friend WithEvents lblAnswerD As Label
    Friend WithEvents lblAnswerC As Label
    Friend WithEvents lblAnswerB As Label
    Friend WithEvents lblQuestionNumber As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnGuessA As Button
    Friend WithEvents btnGuessB As Button
    Friend WithEvents btnGuessD As Button
    Friend WithEvents btnGuessC As Button
    Friend WithEvents lblTimeRemaining As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblColon As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents tmrQuizTime As Timer
End Class
