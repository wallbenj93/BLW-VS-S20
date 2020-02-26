Public Class ListBoxForm
    Private Sub ListBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load 'start doing stuff as soon as form loads
        'DataListBox.Font()
        FirstNameTextBox.Text = "Elmer"
        LastNameTextBox.Text = "Fudd"
        tester()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataListBox.Items.Add(FirstNameTextBox.Text & " " & LastNameTextBox.Text)
        'FirstNameTextBox.Text = ""
        'LastNameTextBox.Text = ""
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DataListBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DataListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListBox.SelectedIndexChanged
        Dim index As Integer

        Me.Text = DataListBox.SelectedIndex.ToString
        index = InStr(DataListBox.SelectedItem.ToString, " ")
        FirstNameTextBox.Text = Trim(Strings.Left(DataListBox.SelectedItem.ToString, index))
        LastNameTextBox.Text = Trim(Strings.Mid(DataListBox.SelectedItem.ToString, index, Len(DataListBox.SelectedItem.ToString)))
    End Sub

    Sub tester()
        Dim someNumber As Double
        someNumber = 10 * Math.Sin(Math.PI)
        Console.WriteLine()

    End Sub

End Class
