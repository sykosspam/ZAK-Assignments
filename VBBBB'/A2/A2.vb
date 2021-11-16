Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Char1, Char2, Char3 As Char
        Dim Count As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        Count = 0

        Console.Write("Enter the string: ")
        Str1 = (Console.ReadLine)

        Console.Write("Enter the character which has to be replace:")
        Char1 = (Console.ReadLine)

        Console.Write("Enter the character to replace with:")
        Char2 = (Console.ReadLine)

        For Count = 1 To Len(Str1)
            Char3 = Mid(Str1, Count, 1)
            If Char3 = Char1 Then
                Str2 = Str2 & Char2
            Else
                Str2 = Str2 & Char3
            End If
        Next
        Console.WriteLine("Substituted String=" & Str2)
        Console.ReadKey()

    End Sub

End Module
