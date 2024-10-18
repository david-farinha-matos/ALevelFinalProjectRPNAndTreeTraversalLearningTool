<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRPNQuiz
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
        Me.components = New System.ComponentModel.Container()
        Me.btnStartQuiz = New System.Windows.Forms.Button()
        Me.btnGuessA = New System.Windows.Forms.Button()
        Me.btnGuessB = New System.Windows.Forms.Button()
        Me.btnGuessD = New System.Windows.Forms.Button()
        Me.btnGuessC = New System.Windows.Forms.Button()
        Me.tmrQuizTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblColon = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblAnswerA = New System.Windows.Forms.Label()
        Me.lblAnswerB = New System.Windows.Forms.Label()
        Me.lblAnswerC = New System.Windows.Forms.Label()
        Me.lblAnswerD = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStartQuiz
        '
        Me.btnStartQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartQuiz.Location = New System.Drawing.Point(189, 12)
        Me.btnStartQuiz.Name = "btnStartQuiz"
        Me.btnStartQuiz.Size = New System.Drawing.Size(146, 35)
        Me.btnStartQuiz.TabIndex = 0
        Me.btnStartQuiz.Text = "Start Quiz"
        Me.btnStartQuiz.UseVisualStyleBackColor = True
        '
        'btnGuessA
        '
        Me.btnGuessA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessA.Location = New System.Drawing.Point(52, 181)
        Me.btnGuessA.Name = "btnGuessA"
        Me.btnGuessA.Size = New System.Drawing.Size(146, 35)
        Me.btnGuessA.TabIndex = 1
        Me.btnGuessA.Text = "A"
        Me.btnGuessA.UseVisualStyleBackColor = True
        Me.btnGuessA.Visible = False
        '
        'btnGuessB
        '
        Me.btnGuessB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessB.Location = New System.Drawing.Point(320, 181)
        Me.btnGuessB.Name = "btnGuessB"
        Me.btnGuessB.Size = New System.Drawing.Size(146, 35)
        Me.btnGuessB.TabIndex = 2
        Me.btnGuessB.Text = "B"
        Me.btnGuessB.UseVisualStyleBackColor = True
        Me.btnGuessB.Visible = False
        '
        'btnGuessD
        '
        Me.btnGuessD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessD.Location = New System.Drawing.Point(320, 332)
        Me.btnGuessD.Name = "btnGuessD"
        Me.btnGuessD.Size = New System.Drawing.Size(146, 35)
        Me.btnGuessD.TabIndex = 3
        Me.btnGuessD.Text = "D"
        Me.btnGuessD.UseVisualStyleBackColor = True
        Me.btnGuessD.Visible = False
        '
        'btnGuessC
        '
        Me.btnGuessC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuessC.Location = New System.Drawing.Point(52, 332)
        Me.btnGuessC.Name = "btnGuessC"
        Me.btnGuessC.Size = New System.Drawing.Size(146, 35)
        Me.btnGuessC.TabIndex = 4
        Me.btnGuessC.Text = "C"
        Me.btnGuessC.UseVisualStyleBackColor = True
        Me.btnGuessC.Visible = False
        '
        'tmrQuizTime
        '
        Me.tmrQuizTime.Enabled = True
        Me.tmrQuizTime.Interval = 1000
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.Location = New System.Drawing.Point(12, 422)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(127, 20)
        Me.lblTimeRemaining.TabIndex = 6
        Me.lblTimeRemaining.Text = "Time Remaining:"
        Me.lblTimeRemaining.Visible = False
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(145, 422)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(27, 20)
        Me.lblMinutes.TabIndex = 7
        Me.lblMinutes.Text = "10"
        Me.lblMinutes.Visible = False
        '
        'lblColon
        '
        Me.lblColon.AutoSize = True
        Me.lblColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon.Location = New System.Drawing.Point(178, 422)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(13, 20)
        Me.lblColon.TabIndex = 8
        Me.lblColon.Text = ":"
        Me.lblColon.Visible = False
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(197, 422)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(27, 20)
        Me.lblSeconds.TabIndex = 9
        Me.lblSeconds.Text = "00"
        Me.lblSeconds.Visible = False
        '
        'lblAnswerA
        '
        Me.lblAnswerA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerA.Location = New System.Drawing.Point(52, 137)
        Me.lblAnswerA.Name = "lblAnswerA"
        Me.lblAnswerA.Size = New System.Drawing.Size(146, 41)
        Me.lblAnswerA.TabIndex = 16
        Me.lblAnswerA.Text = "Label1"
        Me.lblAnswerA.Visible = False
        '
        'lblAnswerB
        '
        Me.lblAnswerB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerB.Location = New System.Drawing.Point(320, 137)
        Me.lblAnswerB.Name = "lblAnswerB"
        Me.lblAnswerB.Size = New System.Drawing.Size(146, 41)
        Me.lblAnswerB.TabIndex = 17
        Me.lblAnswerB.Text = "Label1"
        Me.lblAnswerB.Visible = False
        '
        'lblAnswerC
        '
        Me.lblAnswerC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerC.Location = New System.Drawing.Point(52, 288)
        Me.lblAnswerC.Name = "lblAnswerC"
        Me.lblAnswerC.Size = New System.Drawing.Size(146, 41)
        Me.lblAnswerC.TabIndex = 18
        Me.lblAnswerC.Text = "Label1"
        Me.lblAnswerC.Visible = False
        '
        'lblAnswerD
        '
        Me.lblAnswerD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerD.Location = New System.Drawing.Point(320, 288)
        Me.lblAnswerD.Name = "lblAnswerD"
        Me.lblAnswerD.Size = New System.Drawing.Size(146, 41)
        Me.lblAnswerD.TabIndex = 19
        Me.lblAnswerD.Text = "Label1"
        Me.lblAnswerD.Visible = False
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(186, 50)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(146, 87)
        Me.lblQuestion.TabIndex = 20
        Me.lblQuestion.Text = "Label1"
        Me.lblQuestion.Visible = False
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(186, 21)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(146, 26)
        Me.lblQuestionNumber.TabIndex = 21
        Me.lblQuestionNumber.Text = "Label1"
        Me.lblQuestionNumber.Visible = False
        '
        'frmRPNQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(510, 451)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblAnswerD)
        Me.Controls.Add(Me.lblAnswerC)
        Me.Controls.Add(Me.lblAnswerB)
        Me.Controls.Add(Me.lblAnswerA)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblColon)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.btnGuessC)
        Me.Controls.Add(Me.btnGuessD)
        Me.Controls.Add(Me.btnGuessB)
        Me.Controls.Add(Me.btnGuessA)
        Me.Controls.Add(Me.btnStartQuiz)
        Me.Location = New System.Drawing.Point(150, 150)
        Me.Name = "frmRPNQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmRPNQuiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartQuiz As Button
    Friend WithEvents btnGuessA As Button
    Friend WithEvents btnGuessB As Button
    Friend WithEvents btnGuessD As Button
    Friend WithEvents btnGuessC As Button
    Friend WithEvents tmrQuizTime As Timer
    Friend WithEvents lblTimeRemaining As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblColon As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblAnswerA As Label
    Friend WithEvents lblAnswerB As Label
    Friend WithEvents lblAnswerC As Label
    Friend WithEvents lblAnswerD As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblQuestionNumber As Label
End Class
