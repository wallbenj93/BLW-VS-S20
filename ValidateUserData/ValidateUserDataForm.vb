


Public Class ValidateUserDataForm
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Console.WriteLine(sender.ToString)
        Console.WriteLine(e.ToString)

        'Console.WriteLine(UserMessage(TextBox1.Text, "please enter text in textbox1", False))



        'Dim userMessage As String

        'IsEmpty()
        'If IsStringEmpty(TextBox3.Text) = True Then
        '    userMessage = "please enter text in textbox3" & vbNewLine
        '    TextBox3.Select()
        'End If

        'If IsStringEmpty(TextBox2.Text) = True Then
        '    userMessage = "please enter text in textbox2" & vbNewLine
        '    TextBox2.Select()
        'End If

        'If IsStringEmpty(TextBox1.Text) = True Then
        '    userMessage = "please enter text in textbox1" & vbNewLine
        '    TextBox1.Select()
        'End If

        'If userMessage <> "" Then
        '    MsgBox(userMessage)
        'End If

    End Sub

    Function UserMessage(stringToTest As String, uniqueMessage As String, clearUserMessage As Boolean) As String
        Static runningMessage As String = ""

        If clearUserMessage <> True Then
            runningMessage &= Message & vbNewLine
        Else
            runningMessage = ""
        End If

        Return runningMessage
    End Function

    Sub IsEmpty()
        'check each if empty and alert user
        Dim userMessage As String

        If TextBox3.Text = "" Then
            userMessage = "please enter text in textbox3" & vbNewLine
            TextBox3.Select()
        End If

        If TextBox2.Text = "" Then
            userMessage &= "please enter text in textbox2" & vbNewLine
            TextBox2.Select()
        End If

        If TextBox1.Text = "" Then
            userMessage &= "please enter text in textbox1" & vbNewLine
            TextBox1.Select()
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If

        'another way to check condition
        'Select Case ""
        '    Case TextBox3.Text
        '        userMessage &= "please enter text in textbox3" & vbNewLine
        '    Case TextBox2.Text
        '        userMessage &= "please enter text in textbox2" & vbNewLine
        '    Case TextBox1.Text
        '        userMessage &= "please enter text in textbox1" & vbNewLine
        '    Case Else

        'End Select

    End Sub

    Function IsStringEmpty(stringToTest As String) As Boolean
        Dim status As Boolean
        If stringToTest = "" Then
            status = True
        Else
            status = False
        End If
        Return status
    End Function

    Public Function RunningTotal(currentValue As Integer, clearTotal As Boolean) As Integer
        Static total As Integer 'static continues to exist for lifetime of class/module
        'Accumulate running total of argument with clear total option
        If clearTotal <> True Then
            total += currentValue
        Else
            total = 0
        End If

        Return total
    End Function

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click
        Dim tempNumber As Integer
        Const VALUE As Integer = 5
        'Const VALUE = 5I      Same as previous line
        'For i = 1 To 10
        tempNumber = RunningTotal(VALUE, False)
        'Next
        Console.WriteLine(tempNumber)



    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        RunningTotal(0, True)
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Console.WriteLine(sender.ToString)
        Console.WriteLine(e.ToString)

    End Sub
End Class