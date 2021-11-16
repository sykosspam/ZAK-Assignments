Module Module1

    Sub Main()
        Dim str1, str2, str3, str4, str5, str6 As String

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        str5 = ""
        str6 = ""

        Console.Write("Enter 1st String:")
        str1 = Console.ReadLine

        Console.Write("Enter 2nd String:")
        str2 = Console.ReadLine

        str3 = Left(str1, 2)
        str4 = Left(str2, 2)
        str5 = Mid(str1, 3, Len(str1))
        str6 = Mid(str2, 3, Len(str2))

        Console.WriteLine(str4 & str5 & "  " & str3 & str6)
        Console.ReadKey()

    End Sub

End Module
