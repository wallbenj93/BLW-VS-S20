Option Explicit On
Option Strict On
'option compare string (turn off case sensitive)

Module LoopExample

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        firstNumber = 5
        secondNumber = 7

        result = firstNumber + secondNumber

        For i = 0 To 25 Step 5
            result = result + 3
            Console.WriteLine(i)
        Next

        Console.WriteLine("result = " & result)
        Console.ReadLine()

        'cast ex As InvalidCastException


    End Sub

End Module
