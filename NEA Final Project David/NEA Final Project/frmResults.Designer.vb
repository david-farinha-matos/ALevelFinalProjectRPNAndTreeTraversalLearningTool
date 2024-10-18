<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResults
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
        Me.btnChooseTopic = New System.Windows.Forms.Button()
        Me.lblRPNMark = New System.Windows.Forms.Label()
        Me.btnViewStats = New System.Windows.Forms.Button()
        Me.lblTreeTraversalMark = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnChooseTopic
        '
        Me.btnChooseTopic.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseTopic.Location = New System.Drawing.Point(279, 77)
        Me.btnChooseTopic.Name = "btnChooseTopic"
        Me.btnChooseTopic.Size = New System.Drawing.Size(146, 81)
        Me.btnChooseTopic.TabIndex = 23
        Me.btnChooseTopic.Text = "Back To Choose A Topic"
        Me.btnChooseTopic.UseVisualStyleBackColor = True
        Me.btnChooseTopic.Visible = False
        '
        'lblRPNMark
        '
        Me.lblRPNMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPNMark.Location = New System.Drawing.Point(12, 196)
        Me.lblRPNMark.Name = "lblRPNMark"
        Me.lblRPNMark.Size = New System.Drawing.Size(301, 193)
        Me.lblRPNMark.TabIndex = 24
        Me.lblRPNMark.Text = "Label1"
        Me.lblRPNMark.Visible = False
        '
        'btnViewStats
        '
        Me.btnViewStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStats.Location = New System.Drawing.Point(279, 12)
        Me.btnViewStats.Name = "btnViewStats"
        Me.btnViewStats.Size = New System.Drawing.Size(146, 59)
        Me.btnViewStats.TabIndex = 25
        Me.btnViewStats.Text = "View Stats"
        Me.btnViewStats.UseVisualStyleBackColor = True
        '
        'lblTreeTraversalMark
        '
        Me.lblTreeTraversalMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreeTraversalMark.Location = New System.Drawing.Point(387, 196)
        Me.lblTreeTraversalMark.Name = "lblTreeTraversalMark"
        Me.lblTreeTraversalMark.Size = New System.Drawing.Size(301, 193)
        Me.lblTreeTraversalMark.TabIndex = 26
        Me.lblTreeTraversalMark.Text = "Label1"
        Me.lblTreeTraversalMark.Visible = False
        '
        'frmResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.lblTreeTraversalMark)
        Me.Controls.Add(Me.btnViewStats)
        Me.Controls.Add(Me.lblRPNMark)
        Me.Controls.Add(Me.btnChooseTopic)
        Me.Location = New System.Drawing.Point(150, 150)
        Me.Name = "frmResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmResults"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnChooseTopic As Button
    Friend WithEvents lblRPNMark As Label
    Friend WithEvents btnViewStats As Button
    Friend WithEvents lblTreeTraversalMark As Label
End Class
