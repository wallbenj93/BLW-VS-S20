Option Explicit On
Option Strict Off
Option Compare Text

'Ben Wallace
'RCET0265
'Spring 2020
'Better Calculator
'https://github.com/wallbenj93/BLW-VS-S20

Module BetterCalculator

    Sub Main()

        Dim num1 As String
        Dim num2 As String
        Dim quitAnswer As Boolean
        Dim promptUser As Boolean
        Dim operationOption As String
        Dim answer As Decimal

        quitAnswer = False
        promptUser = True

        num1 = 0
        num2 = 0

        Do While quitAnswer = False

            Console.WriteLine("Please enter two numbers. Enter ""Q"" at any time to quit.")
            Do While promptUser = True
                Console.Write("Choose a number: ")
                num1 = Console.ReadLine()
                Try
                    Convert.ToInt64(num1)
                    Console.WriteLine("You entered """ & num1 & """")
                    promptUser = False
                Catch ex As Exception
                    If num1 = "q" Then
                        quitAnswer = True
                        promptUser = False
                    Else
                        Console.WriteLine("You entered """ & num1 & """, please enter a whole number.")
                        promptUser = True
                    End If
                End Try
            Loop
            promptUser = True
            Do While promptUser = True And quitAnswer = False
                Console.Write("Choose a number: ")
                num2 = Console.ReadLine()
                Try
                    Convert.ToInt64(num2)
                    Console.WriteLine("You entered """ & num2 & """")
                    promptUser = False
                Catch ex As Exception
                    If num2 = "q" Then
                        quitAnswer = True
                        promptUser = False
                    Else
                        Console.WriteLine("You entered """ & num2 & """, please enter a whole number.")
                        promptUser = True
                    End If
                End Try
            Loop
            promptUser = True
            operationOption = "q"
            Do While promptUser = True And quitAnswer = False
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                operationOption = Console.ReadLine()
                If operationOption = "1" Or operationOption = "2" Or operationOption = "3" Or operationOption = "4" Then
                    Console.WriteLine("You entered """ & operationOption & """")
                    promptUser = False
                ElseIf operationOption = "q" Then
                    promptUser = False
                    quitAnswer = True
                Else
                    promptUser = True
                    Console.WriteLine("You entered """ & operationOption & """")
                End If
            Loop
            promptUser = True
            If operationOption = "6" Then
                Console.WriteLine("????")
            ElseIf operationOption = "1" Then
                answer = num1 + num2
                Console.WriteLine(num1 & " + " & num2 & " = " & answer)
            ElseIf operationOption = "2" Then
                answer = num1 - num2
                Console.WriteLine(num1 & " - " & num2 & " = " & answer)
            ElseIf operationOption = "3" Then
                answer = num1 * num2
                Console.WriteLine(num1 & " * " & num2 & " = " & answer)
            ElseIf operationOption = "4" Then
                answer = num1 / num2
                Console.WriteLine(num1 & " / " & num2 & " = " & answer)
            ElseIf operationOption = "q" Then
                'do nothing
            Else
                Console.WriteLine("Error to programmer: This should not be happening???")
                Console.ReadLine()
            End If
        Loop

        'If Q is entered:
        Console.WriteLine("You entered ""q""")
        Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close this window")
        Console.ReadLine()

    End Sub

End Module
