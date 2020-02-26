<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathContest
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
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumLabel = New System.Windows.Forms.Label()
        Me.SecondNumTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumLabel = New System.Windows.Forms.Label()
        Me.FirstNumTextBox = New System.Windows.Forms.TextBox()
        Me.ProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyButton = New System.Windows.Forms.RadioButton()
        Me.SubtractButton = New System.Windows.Forms.RadioButton()
        Me.AddButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.MathProblemGroupBox.SuspendLayout()
        Me.ProblemTypeGroupBox.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(25, 21)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(296, 69)
        Me.StudentInfoGroupBox.TabIndex = 0
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(223, 21)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(36, 13)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(177, 21)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 21)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(226, 37)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(21, 20)
        Me.GradeTextBox.TabIndex = 2
        Me.GradeTextBox.Text = "_"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(180, 37)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(23, 20)
        Me.AgeTextBox.TabIndex = 1
        Me.AgeTextBox.Text = "__"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 37)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(147, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'MathProblemGroupBox
        '
        Me.MathProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumTextBox)
        Me.MathProblemGroupBox.Location = New System.Drawing.Point(25, 96)
        Me.MathProblemGroupBox.Name = "MathProblemGroupBox"
        Me.MathProblemGroupBox.Size = New System.Drawing.Size(165, 174)
        Me.MathProblemGroupBox.TabIndex = 1
        Me.MathProblemGroupBox.TabStop = False
        Me.MathProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 122)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLabel.TabIndex = 8
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(6, 138)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(147, 20)
        Me.StudentAnswerTextBox.TabIndex = 7
        '
        'SecondNumLabel
        '
        Me.SecondNumLabel.AutoSize = True
        Me.SecondNumLabel.Location = New System.Drawing.Point(6, 75)
        Me.SecondNumLabel.Name = "SecondNumLabel"
        Me.SecondNumLabel.Size = New System.Drawing.Size(65, 13)
        Me.SecondNumLabel.TabIndex = 6
        Me.SecondNumLabel.Text = "2nd Number"
        '
        'SecondNumTextBox
        '
        Me.SecondNumTextBox.Location = New System.Drawing.Point(6, 91)
        Me.SecondNumTextBox.Name = "SecondNumTextBox"
        Me.SecondNumTextBox.Size = New System.Drawing.Size(147, 20)
        Me.SecondNumTextBox.TabIndex = 5
        '
        'FirstNumLabel
        '
        Me.FirstNumLabel.AutoSize = True
        Me.FirstNumLabel.Location = New System.Drawing.Point(6, 28)
        Me.FirstNumLabel.Name = "FirstNumLabel"
        Me.FirstNumLabel.Size = New System.Drawing.Size(61, 13)
        Me.FirstNumLabel.TabIndex = 4
        Me.FirstNumLabel.Text = "1st Number"
        '
        'FirstNumTextBox
        '
        Me.FirstNumTextBox.Location = New System.Drawing.Point(6, 44)
        Me.FirstNumTextBox.Name = "FirstNumTextBox"
        Me.FirstNumTextBox.Size = New System.Drawing.Size(147, 20)
        Me.FirstNumTextBox.TabIndex = 1
        '
        'ProblemTypeGroupBox
        '
        Me.ProblemTypeGroupBox.Controls.Add(Me.DivideButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.MultiplyButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.SubtractButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.AddButton)
        Me.ProblemTypeGroupBox.Location = New System.Drawing.Point(196, 96)
        Me.ProblemTypeGroupBox.Name = "ProblemTypeGroupBox"
        Me.ProblemTypeGroupBox.Size = New System.Drawing.Size(125, 174)
        Me.ProblemTypeGroupBox.TabIndex = 2
        Me.ProblemTypeGroupBox.TabStop = False
        Me.ProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'DivideButton
        '
        Me.DivideButton.AutoSize = True
        Me.DivideButton.Location = New System.Drawing.Point(6, 94)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(55, 17)
        Me.DivideButton.TabIndex = 3
        Me.DivideButton.TabStop = True
        Me.DivideButton.Text = "Divide"
        Me.DivideButton.UseVisualStyleBackColor = True
        '
        'MultiplyButton
        '
        Me.MultiplyButton.AutoSize = True
        Me.MultiplyButton.Location = New System.Drawing.Point(6, 73)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(60, 17)
        Me.MultiplyButton.TabIndex = 2
        Me.MultiplyButton.TabStop = True
        Me.MultiplyButton.Text = "Multiply"
        Me.MultiplyButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.AutoSize = True
        Me.SubtractButton.Location = New System.Drawing.Point(6, 51)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(65, 17)
        Me.SubtractButton.TabIndex = 1
        Me.SubtractButton.TabStop = True
        Me.SubtractButton.Text = "Subtract"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.AutoSize = True
        Me.AddButton.Checked = True
        Me.AddButton.Location = New System.Drawing.Point(6, 28)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(44, 17)
        Me.AddButton.TabIndex = 0
        Me.AddButton.TabStop = True
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.ClearButton)
        Me.GroupBox4.Controls.Add(Me.SubmitButton)
        Me.GroupBox4.Location = New System.Drawing.Point(355, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(157, 249)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(6, 60)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(134, 47)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(6, 10)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(134, 47)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 47)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Summar&y"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 160)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 47)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "&Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 290)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ProblemTypeGroupBox)
        Me.Controls.Add(Me.MathProblemGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Name = "MathContest"
        Me.Text = "Math Contest"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.MathProblemGroupBox.ResumeLayout(False)
        Me.MathProblemGroupBox.PerformLayout()
        Me.ProblemTypeGroupBox.ResumeLayout(False)
        Me.ProblemTypeGroupBox.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents MathProblemGroupBox As GroupBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents SecondNumLabel As Label
    Friend WithEvents SecondNumTextBox As TextBox
    Friend WithEvents FirstNumLabel As Label
    Friend WithEvents FirstNumTextBox As TextBox
    Friend WithEvents ProblemTypeGroupBox As GroupBox
    Friend WithEvents DivideButton As RadioButton
    Friend WithEvents MultiplyButton As RadioButton
    Friend WithEvents SubtractButton As RadioButton
    Friend WithEvents AddButton As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
