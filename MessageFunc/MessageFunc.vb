Module MessageFunc

    Sub Main()
        'MsgBox(UserMessages(True, "hello", False))
        UserMessages(True, "hello 1", False)
        UserMessages(True, "hello 2", False)
        UserMessages(True, "hello 3", False)
        MsgBox(UserMessages(False, "", False))
    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String '= ""

        formattedMessages &= message & vbNewLine

        Return formattedMessages

    End Function

End Module
