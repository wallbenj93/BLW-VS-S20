


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
        ResetAllControls()
    End Sub

    Sub ResetAllControls()

        'clear all text boxes
        NameTextBox.Text = ""
        StreetTextBox.Text = "
"

        'start up selection
        RadioButton1.Checked = True
        RadioButton4.Checked = True

        'disabled by default
        GoButton.Enabled = False
        UpdateButton.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False


        'UsreSelection.Enabled = False



    End Sub

    Private Sub AnyTextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged, StateTextBox.TextChanged, StreetTextBox.TextChanged
        Console.WriteLine(sender)
        Console.WriteLine(e)
        Console.WriteLine()
    End Sub

    Sub EvaluateTextBoxes()

        If NameTextBox.Text <> "" And StreetTextBox.Text <> "" Then

        End If
    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        Dim tempNumber As Integer
        Try
            tempNumber = CInt(AgeTextBox.Text)
            If tempNumber > 15 And tempNumber < 27 Then
                MsgBox("good work")
            Else
                MsgBox("sorry try the kiddy ride")
            End If
        Catch ex As Exception
            MsgBox("Please enter a valid age")
        End Try



    End Sub
End Class
