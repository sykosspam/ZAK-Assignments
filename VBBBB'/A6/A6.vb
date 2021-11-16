Module Module1

    Sub Main()
        Dim Count As Integer

        Count = 0

        Console.Write("How Many Dounuts Do you want:")
        Count = Console.ReadLine

        If Count < 10 Then
            Console.WriteLine("Number Of Dounuts:" & Count)
        ElseIf Count >= 10 Then
            Console.WriteLine("Number Of Dounuts many")
        End If
        Console.ReadKey()


    End Sub

End Module
