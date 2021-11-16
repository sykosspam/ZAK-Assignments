Module Module1

    Sub Main()
        Dim Str1, Str2, Char1 As String
        Dim Count As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Count = 0

        Console.Write("Enter A String:")
        Str1 = Console.ReadLine
        Char1 = Left(Str1, 2)
        Str2 = Str2 + Char1
        Char1 = Right(Str1, 2)
        Str2 = Str2 + Char1

        If Len(Str1) < 2 Then
            Console.WriteLine("Not enough characters." & Str1)
        Else
            Console.WriteLine("After Extraction:" & Str2)
        End If
        Console.ReadKey()

    End Sub

End Module
