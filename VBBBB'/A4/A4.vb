Module Module1

    Sub Main()
        Dim Char1, Char2, Char3 As Char
        Dim Highest, Count, a, b As Integer
        Dim Str1 As String

        Char1 = ""
        Highest = 0
        Count = 0
      
        Console.Write("Enter a Phrase: ")
        Str1 = Console.ReadLine

        For a = 1 To Len(Str1)
            Char3 = Mid(Str1, a, 1)
            Count = 0
            For b = 1 To Len(Str1)
                Char2 = Mid(Str1, b, 1)
                If Char2 = Char3 Then Count = Count + 1
            Next

            If Count > Highest Then
                Highest = Count
                Char1 = Char3
            End If
        Next
        Console.WriteLine(Char1 & " appeared " & Highest & " number of times.")
        Console.ReadKey()

    End Sub

End Module
