Option Strict On
Option Explicit On

Module Module1

    Sub Main()

        'Dim myNumber As Integer
        'myNumber = 7
        'Console.WriteLine("In sub main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()

        'MySub(myNumber)
        'Console.WriteLine("In sub main")
        'Console.WriteLine(myNumber)

        'myNumber = MyFunc(myNumber)
        'Console.WriteLine("In sub main")
        'Console.WriteLine(myNumber)
        'Console.writeline("in sub main")
        'doMath(7, 5, "Add")
        Console.WriteLine("What is your name?")
        Dim userName As String
        userName = Console.ReadLine()
        For i = 1 To 5 'Step 20
            ShowPattern(20, userName)
        Next
        beep()
        Console.ReadLine()
    End Sub

    Sub MySub(myNumber As Integer)
        'Dim myNumber As Integer
        'myNumber = myNumber + 2. same as next line
        myNumber += 2
        Console.WriteLine("In sub MySub")
        Console.WriteLine(myNumber)
        Console.ReadLine()
    End Sub

    Function MyFunc(myNumber As Integer) As Integer
        'Dim myNumber As Integer
        myNumber -= 3
        Console.WriteLine("In Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber
    End Function

    Sub DoMath(firstNumber As Integer, secondNumber As Integer, operatorChoice As String)
        Dim result As Double

        If operatorChoice = "Add" Then
            result = firstNumber + secondNumber
        ElseIf operatorChoice = "Subtract" Then
            result = firstNumber - secondNumber
        ElseIf operatorChoice = "Multiply" Then
            result = firstNumber * secondNumber
        ElseIf operatorChoice = "Divide" Then
            result = firstNumber / secondNumber
        End If

        Console.WriteLine(result)
    End Sub

    Sub ShowPattern(length As Integer, character As String)
        'Dim character As String
        Dim pattern As String
        Console.WriteLine(Len(character))
        'character = "*"
        pattern = ""
        For index = 1 To length Step 1
            pattern &= character
            Console.WriteLine(pattern)
        Next

        For index = length - 1 To 1 Step -1
            pattern = Left(pattern, index * Len(character))
            Console.WriteLine(pattern)
        Next

    End Sub

    Sub beep()
        Console.Beep(392, 500) 'G4'
        Console.Beep(440, 500) 'A4' frequency, ms (range
        Console.Beep(349, 750) 'F4'
        Console.Beep(196, 750) 'G3'
        Console.Beep(262, 900) 'C4'
        Console.BackgroundColor = ConsoleColor.Blue
        Console.WriteLine("oh no you broke it")
    End Sub



End Module


'every chunk of code should have one job
