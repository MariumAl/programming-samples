Module Module1

    Sub Main()
        Dim str1 As String
        Dim count, x As Integer
        Dim char1, thischar As Char
        str1 = ""
        count = 0
        char1 = ""
        x = 0
        Console.Write("enter string text: ")
        str1 = Console.ReadLine()
        Console.Write("enter character:")
        char1 = Console.ReadLine()
        For x = 1 To Len(str1)
            thischar = Mid(str1, x, 1)
            If thischar = char1 Then
                count = count + 1
            End If
        Next
        Console.Write("Number of times character appeared: " & count)
        Console.ReadLine()
    End Sub

End Module
