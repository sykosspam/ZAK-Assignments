Module Module1

    Sub Main()
        Dim Str1, Str2 As String

        Str1 = ""
        Str2 = ""

        Console.WriteLine("Enter The String:")
        Str1 = Console.ReadLine
        Str2 = UCase(Str1)

        If Str1 = Str2 Then
            Console.WriteLine("All Alphabets Are capital")
        Else
            Console.WriteLine("Alphabets Are Small")
        End If
        Console.ReadKey()

    End Sub

End Module
