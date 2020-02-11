<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExampleForm02
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 116)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(303, 109)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(114, 116)
        Me.Update.TabIndex = 1
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(286, 56)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(355, 20)
        Me.UserTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'ExampleForm02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ExampleForm02"
        Me.Text = "WinFormExample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Update As Button
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
