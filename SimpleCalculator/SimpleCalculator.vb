﻿Option Explicit On
Option Strict Off

'Ben Wallace
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/wallbenj93/BLW-VS-S20

Module SimpleCalculator

    Sub Main()

        Dim num1 As Decimal
        Dim num2 As Decimal
        Dim restartAnswer As String
        Dim operationOption As String
        Dim answer As Decimal

        Console.WriteLine("Hello user! Welcome to the simple calculator!")
Line1:
        Console.WriteLine("Please enter your first number.")
        num1 = Console.ReadLine()
        Console.WriteLine("Choose one of the following operations: ^, +, -, * or /")
Line2:
        operationOption = Console.ReadLine()
        If operationOption = "^" Or operationOption = "+" Or operationOption = "-" Or operationOption = "*" Or operationOption = "/" Then
            GoTo Line3
        Else
            Console.WriteLine("The operation you have chosen is not valid. Please try again and enter ^, +, -, * or /")
            GoTo Line2
        End If
Line3:
        Console.WriteLine("Enter your second number.")
        num2 = Console.ReadLine()
        answer = 0
        If operationOption = "^" Then
            answer = num1 ^ num2
        ElseIf operationOption = "+" Then
            answer = num1 + num2
        ElseIf operationOption = "-" Then
            answer = num1 - num2
        ElseIf operationOption = "*" Then
            answer = num1 * num2
        ElseIf operationOption = "/" Then
            answer = num1 / num2
        Else Console.WriteLine("Error to programmer: This should not be happening???")
            Console.ReadLine()
        End If

        Console.WriteLine("Final equation: " & num1 & operationOption & num2 & " = " & answer & ".")
        Console.WriteLine("Would you like to restart? Type Yes to restart, or any other character to end program.")
        restartAnswer = Console.ReadLine()
        If restartAnswer = "Yes" Or restartAnswer = "yes" Then
            Console.WriteLine()
            GoTo Line1
        End If
    End Sub

End Module