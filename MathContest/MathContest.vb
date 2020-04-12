'Ben Wallace
'RCET0265
'Spring 2020
'Math Contest
'https://github.com/wallbenj93/BLW-VS-S20



Public Class MathContest
    'declare variables here to make them universally available
    Dim numOfProbs As Integer = 0 'confirm default value
    Dim numProbsCorrect As Integer = 0
    Dim studentAge As Integer
    Dim studentGrade As Integer
    Dim firstNum As Integer
    Dim secondNum As Integer
    Dim studAnswer As Integer
    Dim actAnswer As Integer
    Dim studentName As String = ""
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        'exit with close button
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'depending on which one is chosen, do one of the following math operations
        Dim userMessage As String
        If AddButton.Checked = True Then
            actAnswer = firstNum + secondNum
        ElseIf SubtractButton.Checked = True Then
            actAnswer = firstNum - secondNum
        ElseIf DivideButton.Checked = True Then
            actAnswer = firstNum / secondNum
        ElseIf MultiplyButton.Checked = True Then
            actAnswer = firstNum * secondNum
        End If

        If studAnswer = actAnswer Then
            'message to congradulate user
            userMessage = "Good job, " & studentName & ", that is correct!"
            numProbsCorrect += 1
            'add one to the count of correct answers
        Else
            'sorry billy youre wrong
            userMessage = "Sorry, " & studentName & ", that is not correct. The correct " _
                        & "answer was " & actAnswer & "."
        End If
        MsgBox(userMessage)
        FirstNumTextBox.Text = "" 'clear number boxes after Each submission
        SecondNumTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        SummaryButton.Enabled = True
        numOfProbs += 1
        'add one to the number of problems
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clear all text boxes and reset values
        numOfProbs = 0
        numProbsCorrect = 0
        NameTextBox.Text = ""
        GradeTextBox.Text = ""
        AgeTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        FirstNumTextBox.Text = ""
        SecondNumTextBox.Text = ""
        ResetAllControls()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox("You got " & numProbsCorrect & " answers correct out of a possible " & numOfProbs)
        'display a message box showing the results
    End Sub

    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles Me.Load
        'on startup, these are the defaults
        ResetAllControls()
    End Sub

    Sub ResetAllControls()
        'sub to reset values
        AddButton.Enabled = False
        SubtractButton.Enabled = False
        MultiplyButton.Enabled = False
        DivideButton.Enabled = False
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        FirstNumTextBox.Enabled = False
        SecondNumTextBox.Enabled = False
        StudentAnswerTextBox.Enabled = False
        AddButton.Checked = True
        NameTextBox.Enabled = True
        AgeTextBox.Enabled = True
        GradeTextBox.Enabled = True
        ValidateButton.Enabled = True
    End Sub

    Private Sub ValidateClick(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Dim userMessage As String = ""
        Dim AgeBad As Boolean = False
        Dim GradeBad As Boolean = False
        If NameTextBox.Text = "" Then
            userMessage = "Please enter the students name." & vbNewLine
        Else
            studentName = NameTextBox.Text
        End If

        Try
            'try to convert the entered age to integer. if it converts, check the value 
            'with the required range
            studentAge = CInt(AgeTextBox.Text)
            If studentAge > 6 And studentAge < 12 Then
                'student can compete
            Else
                userMessage &= "Sorry, only students that are between 7 and 11 may compete" & vbNewLine
            End If
        Catch ex As Exception
            userMessage &= "Please enter a valid age" & vbNewLine
            AgeBad = True
        End Try
        Try
            'try to convert the entered grade to integer. if it converts, check the value 
            'with the required range
            studentGrade = CInt(GradeTextBox.Text)
            If studentGrade > 0 And studentGrade < 5 Then
                'student can compete
            Else
                userMessage &= "Sorry, only students that are in grades 1 through 4 may compete" & vbNewLine
            End If
        Catch ex As Exception
            userMessage &= "Please enter a valid grade" & vbNewLine
            GradeBad = True
        End Try
        If userMessage <> "" Then
            MsgBox(userMessage)
            'following 2 ifs clears bad data
            If AgeBad = True Then
                AgeTextBox.Text = ""
            End If
            If GradeBad = True Then
                GradeTextBox.Text = ""
            End If
            'chooses which box to select to correct
            If NameTextBox.Text = "" Then
                NameTextBox.Select()
            ElseIf AgeBad = True Then
                AgeTextBox.Select()
            ElseIf GradeBad = True Then
                GradeTextBox.Select()
            End If
        Else
            'begin competition
            AddButton.Enabled = True
            SubtractButton.Enabled = True
            MultiplyButton.Enabled = True
            DivideButton.Enabled = True
            FirstNumTextBox.Enabled = True
            SecondNumTextBox.Enabled = True
            StudentAnswerTextBox.Enabled = True
            'dont allow name, age and grade to be changed once its verified
            NameTextBox.Enabled = False
            AgeTextBox.Enabled = False
            GradeTextBox.Enabled = False
            ValidateButton.Enabled = False
        End If
    End Sub

    Private Sub AnyNumTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumTextBox.TextChanged, SecondNumTextBox.TextChanged, StudentAnswerTextBox.TextChanged
        'try catch for each number entered with cint
        Dim userMessage As String = ""
        Dim firstNumGood As Boolean
        Dim secNumGood As Boolean
        Dim studAnsGood As Boolean
        firstNumGood = False
        secNumGood = False
        studAnsGood = False

        'if any number box value changed, check if its an integer(and not too high)
        If FirstNumTextBox.Text <> "" Then
            Try
                firstNum = CInt(FirstNumTextBox.Text)
                If firstNum < 13 Then
                    'num is ok
                    firstNumGood = True
                Else
                    userMessage &= "Please enter a number less than 13 in number 1 box" & vbNewLine
                End If
            Catch ex As Exception
                'if not valid, prompt user, then clear bad data
                MsgBox("Please enter a valid number in box 1")
                FirstNumTextBox.Text = ""
            End Try
        End If
        If SecondNumTextBox.Text <> "" Then
            Try
                secondNum = CInt(SecondNumTextBox.Text)
                If firstNum < 13 Then
                    'num is ok
                    secNumGood = True
                Else
                    userMessage &= "Please enter a number less than 13 in number 2 box" & vbNewLine
                End If
            Catch ex As Exception
                MsgBox("Please enter a valid number in box 2")
                SecondNumTextBox.Text = ""
            End Try
        End If

        If StudentAnswerTextBox.Text <> "" Then
            Try
                'studAnswer = CInt(StudentAnswerTextBox.Text)
                studAnsGood = True
            Catch ex As Exception
                MsgBox("Please enter a valid answer")
            End Try
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        Else
            'SubmitButton.Enabled = True
        End If
        If firstNumGood = True And secNumGood = True And studAnsGood = True Then
            SubmitButton.Enabled = True
            'as long as each are sucessfully converted to int, enable submit button
        Else
            SubmitButton.Enabled = False
            'this line added so that if each number was verified but then changed to an 
            'invalid value, the submit button would disable again
        End If
    End Sub

    'Private Sub SubmitButton_Validated(sender As Object, e As EventArgs) Handles AgeTextBox.
    '    MsgBox("error")
    'End Sub

    '
End Class
