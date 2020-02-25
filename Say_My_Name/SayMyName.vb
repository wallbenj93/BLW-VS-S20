Option Explicit On
Option Strict Off '

'Ben Wallace
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/wallbenj93/BLW-VS-S20

Module SayMyName

    Sub Main()
        'prompt user for a message
        'then display the message
        Dim userMessage As String
        Dim userMoodNumSt As Integer
        Dim restartAnswer As String
Line1:
        Console.WriteLine("What is your name? Press type it and then press enter.")
        userMessage = Console.ReadLine()
        Console.WriteLine("Hello, " & userMessage & "! On a scale of 1-5, how are you feeling today?")
        'Console.WriteLine("You entered " & Chr(34) & userMessage & Chr(34) & " Good job!")
Line2:
        userMoodNumSt = Console.ReadLine()
        Convert.ToInt32(userMoodNumSt)
        If userMoodNumSt = 1 Then
            Console.WriteLine("I'm sorry to hear that. Things can only get better from here!")
        End If
        If userMoodNumSt = 2 Then
            Console.WriteLine("That's no good. I hope you get feeling better.")
        End If
        If userMoodNumSt = 3 Then
            Console.WriteLine("So average. Could be worse, could be better.")
        End If
        If userMoodNumSt = 4 Then
            Console.WriteLine("I'm glad to hear that!")
        End If
        If userMoodNumSt = 5 Then
            Console.WriteLine("That's perfect! I hope all your days are like that!")
        End If
        If userMoodNumSt > 5 Or userMoodNumSt < 1 Then
            Console.WriteLine("That is not a valid response. Please try again.")
            GoTo Line2
        End If
        Console.WriteLine("Would you like to restart? Type Yes to restart, or any other character to end program.")
        restartAnswer = Console.ReadLine()
        If restartAnswer = "Yes" Or restartAnswer = "yes" Then
            Console.WriteLine()
            GoTo Line1
        End If
    End Sub

End Module