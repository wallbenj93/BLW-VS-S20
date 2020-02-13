﻿Public Class ValidateUserDataForm
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Dim userMessage As String

        'IsEmpty()
        If IsStringEmpty(TextBox3.Text) = True Then
            userMessage = "please enter text in textbox3" & vbNewLine
            TextBox3.Select()
        End If


        If IsStringEmpty(TextBox2.Text) = True Then
            userMessage = "please enter text in textbox2" & vbNewLine
            TextBox2.Select()
        End If

        If IsStringEmpty(TextBox1.Text) = True Then
            userMessage = "please enter text in textbox1" & vbNewLine
            TextBox1.Select()
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If


    End Sub

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



End Class
