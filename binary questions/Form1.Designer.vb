<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.answerbox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.confirm = New System.Windows.Forms.Button()
        Me.correct = New System.Windows.Forms.Label()
        Me.incorrect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(326, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 109)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(866, 40)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 106)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "New Question"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'answerbox
        '
        Me.answerbox.Location = New System.Drawing.Point(272, 242)
        Me.answerbox.Multiline = True
        Me.answerbox.Name = "answerbox"
        Me.answerbox.Size = New System.Drawing.Size(495, 77)
        Me.answerbox.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(653, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 66)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "·"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(308, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 66)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "*2^"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'confirm
        '
        Me.confirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.confirm.Location = New System.Drawing.Point(423, 331)
        Me.confirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(189, 106)
        Me.confirm.TabIndex = 5
        Me.confirm.Text = "confirm answer"
        Me.confirm.UseVisualStyleBackColor = False
        '
        'correct
        '
        Me.correct.AutoSize = True
        Me.correct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.correct.ForeColor = System.Drawing.Color.White
        Me.correct.Location = New System.Drawing.Point(30, 40)
        Me.correct.Name = "correct"
        Me.correct.Size = New System.Drawing.Size(16, 17)
        Me.correct.TabIndex = 6
        Me.correct.Text = "0"
        '
        'incorrect
        '
        Me.incorrect.AutoSize = True
        Me.incorrect.BackColor = System.Drawing.Color.Red
        Me.incorrect.ForeColor = System.Drawing.Color.White
        Me.incorrect.Location = New System.Drawing.Point(52, 40)
        Me.incorrect.Name = "incorrect"
        Me.incorrect.Size = New System.Drawing.Size(16, 17)
        Me.incorrect.TabIndex = 7
        Me.incorrect.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.incorrect)
        Me.Controls.Add(Me.correct)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.answerbox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents answerbox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents confirm As Button
    Friend WithEvents correct As Label
    Friend WithEvents incorrect As Label
End Class
