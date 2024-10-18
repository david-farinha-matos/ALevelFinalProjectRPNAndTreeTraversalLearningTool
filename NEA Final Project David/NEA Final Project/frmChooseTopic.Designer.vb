<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChooseTopic
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
        Me.btnTreeTraversing = New System.Windows.Forms.Button()
        Me.btnRPN = New System.Windows.Forms.Button()
        Me.lblChooseTopic = New System.Windows.Forms.Label()
        Me.btnCloseProgram = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTreeTraversing
        '
        Me.btnTreeTraversing.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreeTraversing.Location = New System.Drawing.Point(70, 152)
        Me.btnTreeTraversing.Name = "btnTreeTraversing"
        Me.btnTreeTraversing.Size = New System.Drawing.Size(160, 60)
        Me.btnTreeTraversing.TabIndex = 0
        Me.btnTreeTraversing.Text = "Tree Traversing"
        Me.btnTreeTraversing.UseVisualStyleBackColor = True
        '
        'btnRPN
        '
        Me.btnRPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRPN.Location = New System.Drawing.Point(307, 152)
        Me.btnRPN.Name = "btnRPN"
        Me.btnRPN.Size = New System.Drawing.Size(160, 60)
        Me.btnRPN.TabIndex = 1
        Me.btnRPN.Text = "Reverse Polish Notation"
        Me.btnRPN.UseVisualStyleBackColor = True
        '
        'lblChooseTopic
        '
        Me.lblChooseTopic.AutoSize = True
        Me.lblChooseTopic.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseTopic.Location = New System.Drawing.Point(19, 41)
        Me.lblChooseTopic.Name = "lblChooseTopic"
        Me.lblChooseTopic.Size = New System.Drawing.Size(503, 29)
        Me.lblChooseTopic.TabIndex = 2
        Me.lblChooseTopic.Text = "Which Topic Would You Like To Revise First?"
        '
        'btnCloseProgram
        '
        Me.btnCloseProgram.Location = New System.Drawing.Point(12, 277)
        Me.btnCloseProgram.Name = "btnCloseProgram"
        Me.btnCloseProgram.Size = New System.Drawing.Size(92, 23)
        Me.btnCloseProgram.TabIndex = 3
        Me.btnCloseProgram.Text = "Close Program"
        Me.btnCloseProgram.UseVisualStyleBackColor = True
        '
        'frmChooseTopic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 312)
        Me.Controls.Add(Me.btnCloseProgram)
        Me.Controls.Add(Me.lblChooseTopic)
        Me.Controls.Add(Me.btnRPN)
        Me.Controls.Add(Me.btnTreeTraversing)
        Me.Location = New System.Drawing.Point(150, 150)
        Me.Name = "frmChooseTopic"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Choose Topic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTreeTraversing As Button
    Friend WithEvents btnRPN As Button
    Friend WithEvents lblChooseTopic As Label
    Friend WithEvents btnCloseProgram As Button
End Class
