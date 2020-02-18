Module Module1
    Dim aName As String = "Pete" 'startup value
    'aName = "Chucky"

    Sub Main()
        Dim aNumber As Integer
        Dim anotherName As String
        aNumber = 5
        aName = "Chucky"
        anotherName = "Jason"
        'Console.WriteLine(aNumber)
        Console.WriteLine(aName)
        Console.WriteLine(anotherName)
        MySub()
        'Console.WriteLine(aNumber)
        Console.WriteLine(aName)
        Console.WriteLine(anotherName)
        Console.ReadLine()
    End Sub

    Sub MySub()
        Dim aNumber As Integer
        Dim anotherName As String
        aNumber = 3
        aName = "Billy"
        anotherName = "Freddie"
    End Sub

End Module
