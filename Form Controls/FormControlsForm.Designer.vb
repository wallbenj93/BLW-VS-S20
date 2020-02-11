<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayLabel
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
        Me.GoButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UsreSelection = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserInputGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(143, 229)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(122, 71)
        Me.GoButton.TabIndex = 0
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(312, 229)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(122, 71)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(555, 335)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(202, 103)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UserInputGroupBox
        '
        Me.UserInputGroupBox.Controls.Add(Me.Label3)
        Me.UserInputGroupBox.Controls.Add(Me.Label2)
        Me.UserInputGroupBox.Controls.Add(Me.Label1)
        Me.UserInputGroupBox.Controls.Add(Me.StateTextBox)
        Me.UserInputGroupBox.Controls.Add(Me.StreetTextBox)
        Me.UserInputGroupBox.Controls.Add(Me.NameTextBox)
        Me.UserInputGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.UserInputGroupBox.Name = "UserInputGroupBox"
        Me.UserInputGroupBox.Size = New System.Drawing.Size(216, 189)
        Me.UserInputGroupBox.TabIndex = 3
        Me.UserInputGroupBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "State"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Street"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(51, 109)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(122, 20)
        Me.StateTextBox.TabIndex = 2
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(51, 70)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(122, 20)
        Me.StreetTextBox.TabIndex = 1
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(51, 33)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(122, 20)
        Me.NameTextBox.TabIndex = 0
        Me.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UsreSelection
        '
        Me.UsreSelection.Location = New System.Drawing.Point(271, 12)
        Me.UsreSelection.Name = "UsreSelection"
        Me.UsreSelection.Size = New System.Drawing.Size(212, 189)
        Me.UsreSelection.TabIndex = 4
        Me.UsreSelection.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(580, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 189)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(604, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 82)
        Me.Label4.TabIndex = 6
        '
        'DisplayLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UsreSelection)
        Me.Controls.Add(Me.UserInputGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.GoButton)
        Me.Name = "DisplayLabel"
        Me.Text = "UserControlInterface"
        Me.UserInputGroupBox.ResumeLayout(False)
        Me.UserInputGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GoButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UserInputGroupBox As GroupBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents UsreSelection As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
