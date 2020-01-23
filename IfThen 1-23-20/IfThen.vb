'Ben Wallace
'RCET0265
'Spring 2020
'IfThen
'https://github.com/wallbenj93/BLW-VS-S20

Module IfThen

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim restartAnswer As String
        Dim attemptNum As Integer
        Dim password As String

        attemptNum = 1
Line1:
        Console.WriteLine("Comparison number: " & attemptNum & ".")
        Console.WriteLine("Please enter an integer")
        firstNumber = Console.ReadLine()
        Console.WriteLine("Please enter a second integer")
        secondNumber = Console.ReadLine()
        Console.WriteLine("You have entered " & firstNumber & " and " & secondNumber & ".")

        If firstNumber > secondNumber Then
            Console.WriteLine("First number is bigger...")
        ElseIf firstNumber < secondNumber Then
            Console.WriteLine("Second number is bigger...")
        ElseIf firstNumber = secondNumber Then
            Console.WriteLine("the numbers are equal")
        End If

        If firstNumber <= secondNumber Then
            Console.WriteLine("first number is smaller or equal")
        ElseIf firstNumber >= secondNumber Then
            Console.WriteLine("first number is bigger or equal")
        ElseIf firstNumber <> secondNumber Then
            Console.WriteLine("The numbers are not equal")
        Else
            Console.WriteLine("Some other thing???")
        End If
        Console.WriteLine("")
        Console.WriteLine("Would you like to try again? Enter Yes to retry, or any other key to end program")
        restartAnswer = Console.ReadLine()
        If restartAnswer = "Yes" Or restartAnswer = "yes" Then
            Console.WriteLine("")
            Console.WriteLine("")
            If attemptNum <= 2 Then
                attemptNum = attemptNum + 1
                GoTo Line1
            Else
                Console.WriteLine("Sorry, you have exceeded the maximum amount of comparison. The program will now end.")
                password = Console.ReadLine()
                If password = "please" Then
                    Console.WriteLine("Okay, since you asked nicely I'll grant you one more comparison.")
                    Console.WriteLine("")
                    Console.WriteLine("")
                    attemptNum = attemptNum + 1
                    GoTo Line1
                End If
            End If
        End If
    End Sub

End Module

'with multiple else ifs in one if, code stops at first true statemtent and then leaves the if, even if another else if is also true in that if