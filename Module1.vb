Module Module1

    Sub Main()
        Dim input As String
        Do
            Dim Valid As Boolean

            Dim num As Integer
            Console.Write("Enter a Integer and I will tell you if it is even or odd alright? -> ")
            input = Console.ReadLine
            Valid = Integer.TryParse(input, num)
            If Valid Then
                If num Mod 2 = 0 Then
                    Console.WriteLine("That's Even")
                Else
                    Console.WriteLine("Thats Odd")
                End If

            Else
                Console.WriteLine("PUT A NUMBER!!")
            End If
        Loop While input.ToUpper() <> "Q"
    End Sub

    Sub stringwalking(somestr As String)
        'assumes string is 3 character long
        Dim value As String = $"Original String -> {somestr}"
        Console.WriteLine($"The first character is the string -> {somestr(0)}")
        Console.WriteLine($"The second character is the string -> {somestr(1)}")
        Console.WriteLine($"The third character is the string -> {somestr(2)}")



        For i As Integer = 0 To somestr.Length - 1
            Console.WriteLine(somestr(i))
        Next


    End Sub

End Module
