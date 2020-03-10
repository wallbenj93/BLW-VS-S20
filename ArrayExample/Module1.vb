Module Module1

    Sub Main()
        Dim myArray(3) As Integer

        'ReDim Preserve myArray (4) <- make array bigger or smaller with redim

        'myArray(1, 1) = 5

        myArray = {1, 2, 3, 4}

        myArray(0) = 5

        Console.ReadLine()

        'dim newArray = New Integer (3,2) {{1, 2, 3} {2, 3, 4}} preset values


    End Sub

    Sub AnotherArrayExample()
        'no element definition 
        Dim infoArray() As String

        infoArray = Split("Hello, goodbye, pizza, hungry, Ice Cream", ",")

        'For Each thingy In infoArray
        '    Console.WriteLine(thingy)
        '    infoArray.Contains(thingy)
        'Next

        For i = LBound(infoArray) To UBound(infoArray)
            Console.WriteLine("at " & Str(i) & "Value is: " & infoArray(i))
        Next

        Console.ReadLine()

    End Sub

End Module
