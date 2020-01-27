Option Explicit On
Option Strict Off
Option Compare Binary

'Ben Wallace
'RCET0265
'Spring 2020
'Say My Name Again
'https://github.com/wallbenj93/BLW-VS-S20

Module SayMyNameAgain

    Sub Main()
        'prompt user for a message
        'then display the message
        Dim userName As String
        Dim userMoodNumSt As Integer
        Dim restartAnswer As String
Line1:
        Console.WriteLine("What is your name? Press type it and then press enter.")
        userName = Console.ReadLine()


        If userName = "Emily" Or userName = "Joe" Then
            Console.WriteLine("Hello, " & userName & ", how are you doing today? Please rate your mood from 1-5")
        ElseIf userName = "Ben" Or userName = "ben" Then
            Console.WriteLine("Hello Ben, my favorite user of all time! How is your day going? Enter your mood from 1-5")
        Else
            Console.WriteLine("I have no idea who you are. Leave me alone.")
            GoTo Line3
        End If
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
Line3:
        Console.WriteLine("Would you like to restart? Type Yes to restart, or any other character to end program.")
        restartAnswer = Console.ReadLine()
        If restartAnswer = "Yes" Or restartAnswer = "yes" Then
            Console.WriteLine()
            GoTo Line1
        End If
    End Sub

End Module
