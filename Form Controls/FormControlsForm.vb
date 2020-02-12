


Public Class FormControlsForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim displayText As String

        displayText = NameTextBox.Text & vbNewLine & StreetTextBox.Text & vbNewLine & StateTextBox.Text

        Label4.Text = displayText

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        If CheckBox1.Checked = True Then
            Label4.Text = NameTextBox.Text
        End If

        If CheckBox2.Checked = True Then
            MsgBox("Hello")
        End If

        If CheckBox3.Checked = True Then
            PictureBox1.Image = My.Resources.kitten
        Else
            PictureBox1.Image = Nothing
        End If


    End Sub

    Private Sub FormControlsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioButton1.Checked = True

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
