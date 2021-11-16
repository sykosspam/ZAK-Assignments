Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Char1 As Char
        Dim a, characters, alphabets, digits As Integer

        Str1 = ""
        Char1 = ""
        a = 0
        alphabets = 0
        digits = 0
        characters = 0

        Console.Write("Enter Statement to process:")
        Str1 = Console.ReadLine

        characters = Len(Str1)

        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            Char1 = UCase(Char1)
            If Char1 >= "A" And Char1 <= "Z" Then
                alphabets = alphabets + 1
            ElseIf Char1 >= "0" And Char1 <= "9" Then
                digits = digits + 1
            End If
        Next
        Console.WriteLine("Alphabets are: " & alphabets)
        Console.WriteLine("Digits are: " & digits)
        Console.WriteLine("characters are:" & characters)
        Console.ReadKey()


    End Sub

End Module
