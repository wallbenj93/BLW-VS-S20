﻿Option Explicit On
Option Strict On

'Ben Wallace
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/wallbenj/BLW-VS-S20

Module SayMyName

    Sub Main()
        'prompt user for a message
        'then display the message
        Dim userMessage As String

        Console.WriteLine("What is your name? Press type it and then press enter.")
        userMessage = Console.ReadLine()
        Console.WriteLine("Hello, " & userMessage & " , how are you doing today?")
        'Console.WriteLine("You entered " & Chr(34) & userMessage & Chr(34) & " Good job!")
        Console.ReadLine()

    End Sub

End Module