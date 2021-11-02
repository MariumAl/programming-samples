Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim thisChar, Char1 As Char
        Dim Count As Integer
        Str1 = ""
        Str2 = ""
        thisChar = ""
        Count = 0
        Console.Write("Enter text: ")
        Str1 = Console.ReadLine
        Console.Write("Enter character to delete:")
        Char1 = Console.ReadLine
        For Count = 1 To Len(Str1)
            thisChar = Mid(Str1, Count, 1)
            If thisChar <> Char1 Then
                Str2 = Str2 & thisChar
            End If
        Next
        Console.WriteLine("processed string:" & Str2)
        Console.ReadLine()
    End Sub

End Module
