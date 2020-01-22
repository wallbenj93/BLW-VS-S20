Option Explicit On
Option Strict On

Module MoreOperators

    Sub Main()
        'prompt user for a message
        'then display the message
        Dim userMessage As String

        'userMessage = "Hello"

        Console.WriteLine("Please Enter a message. Press enter when done.")
        userMessage = Console.ReadLine()
        Console.WriteLine("You entered " & Chr(34) & userMessage & Chr(34) & " Good job!")
        Console.ReadLine()

    End Sub

End Module

'Ben Wallace
'RCET0265
'Spring 2020
'More Operators