'Ben Wallace
'RCET0265
'Spring 2020
'Dice Roll
Module DiceAssignment
    Sub Main()
        Dim sum As Integer
        Dim MyArray(12, 3) As Decimal
        Dim rollNum As Integer = 1000
        Dim totalPercent As Decimal
        For i = 1 To rollNum
            Randomize()
            sum = Int((6 * Rnd()) + 1) + Int((6 * Rnd()) + 1)
            'Console.WriteLine(sum)
            'add a count to the corresponding sum
            MyArray(sum, 2) += 1

            'myArray(row, column)
            For j = 2 To 12
                'display the number of the row (possible sums)
                MyArray(j, 1) = j
                'calculate chance of roll
                MyArray(j, 3) = Decimal.Round(MyArray(j, 2) / rollNum * 100, 1)
            Next
        Next

        'display array
        'Console.WriteLine("      Total Dice    Times Rolled        % Chance")
        Console.WriteLine("Roll of the dice".PadLeft(70))
        For i = 1 To 3
            If i = 1 Then
                Console.Write("Total of Roll: ")
            End If
            If i = 2 Then
                Console.Write("Times Rolled:  ")
            End If
            If i = 3 Then
                Console.Write(" % of rolls:   ")
            End If
            For j = 2 To 12
                'Console.WriteLine(MyArray(i, j))
                Console.Write(MyArray(j, i).ToString().PadLeft(7) & "|")
            Next
            Console.WriteLine()
        Next
        'For i = 2 To 12
        '    totalPercent += MyArray(i, 3)
        'Next
        'Console.WriteLine(totalPercent.ToString().PadLeft(47) & "|")
        Console.ReadLine()
    End Sub
End Module
'code line count: 5 to write total % column. 24 for everything else not counting empty lines and comments