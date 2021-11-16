Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Counter, vowelsCount As Integer
        Const vowel = "AEIOUaeiou"

        Str1 = ""
        Str2 = ""
        vowelsCount = 0
        Counter = 0

        Console.Write("Enter string to look for vowels: ")
        Str1 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            Str2 = Mid(Str1, Counter, 1)
            If InStr(vowel, Str2) > 0 Then
                vowelsCount = vowelsCount + 1
            End If
        Next

        Console.WriteLine("Number of vowels in the given string = " & vowelsCount)
        Console.ReadKey()

    End Sub

End Module
