<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComboBoxForm
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
        Me.MainComboBox = New System.Windows.Forms.ComboBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Name = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MainComboBox
        '
        Me.MainComboBox.FormattingEnabled = True
        Me.MainComboBox.Location = New System.Drawing.Point(313, 36)
        Me.MainComboBox.Name = "MainComboBox"
        Me.MainComboBox.Size = New System.Drawing.Size(166, 21)
        Me.MainComboBox.TabIndex = 0
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(29, 155)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(134, 103)
        Me.GoButton.TabIndex = 1
        Me.GoButton.Text = "Button1"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(86, 37)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(134, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(86, 63)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(134, 20)
        Me.AgeTextBox.TabIndex = 3
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(13, 44)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(35, 13)
        Me.Name.TabIndex = 4
        Me.Name.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Age"
        '
        'ComboBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.MainComboBox)
        Me.Name = "ComboBoxForm"
        Me.Text = "Combo Box!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainComboBox As ComboBox
    Friend WithEvents GoButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents Name As Label
    Friend WithEvents Label2 As Label
End Class
