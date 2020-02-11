Public Class ExampleForm02

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hello form"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click

        Dim userInput As String

        userInput = UserTextBox.Text

        Me.Text = userInput

    End Sub

End Class
