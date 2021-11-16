Module Module1

    Sub Main() '
        Dim Str1, Str2 As String
        Dim Char2, Char1, Char3 As Char
        Dim Count As Integer

        Str1 = ""
        Str2 = ""
        Char2 = ""
        Count = 0

        Console.Write("Enter A String:")
        Str1 = Console.ReadLine
        Char1 = Left(Str1, 1)
        Str2 = Str2 & Char1

        For Count = 2 To Len(Str1)
            Char2 = Mid(Str1, Count, 2)
            If Char2 = Char1 Then
                Str2 = Str2 & "*"
            Else
                Str2 = Str2 & Char2
            End If
        Next
        Console.WriteLine("Altered string: " & Str2)
        Console.ReadKey()
    End Sub

End Module
