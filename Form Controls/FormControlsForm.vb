﻿Public Class DisplayLabel
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim displayText As String

        displayText = NameTextBox.Text & StreetTextBox.Text & StreetTextBox.Text
        DisplayLabel.Text = displayText

    End Sub
End Class
