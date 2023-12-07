Module Module2
    'Write a program that prompts the user to enter b to convert a decimal number to binary and 

    'd to convert a binary number to decimal, and q to quit 

    'B, D and Q in any case should be supported. 

    'if the user chooses to convert to binary, make sure a valid integer is given. 

    'Do not try to convert anything that is not a number 

    'if invalid input is given, report the error and prompt again. 

    'when valid input is given, do the conversion and then print out: 

    '{integer} converted to binary is {binaryStr} 

    'if the user chooses to convert to decimal (from binary), 

    'make sure the string given contains only 0s and 1s. If it contains anything else, report the error 

    'and ask for a new binary string 

    'When a valid string is given print out the conversion as  

    '{binary str} converted to decimal is : {decimal num} 

    'DO NOT HAVE ANY SUBS OR FUNCTIONS WITH MORE THAN 25 LINES 
    Sub main()
        Dim INPUT As String
        Dim BN As Double
        Do
            Console.WriteLine("Enter b to convert to binary (base 2), d to convert to base 10, q to quit.  -> ")
            INPUT = Console.ReadLine.ToUpper

            If INPUT = "B" Then
                'do decimal to binary conversion
                Console.WriteLine("You are now converting to Binary")
                Console.Write("what number are you converting to Binary? -> ")
                BN = Console.ReadLine
                DecimalToBinary()
            ElseIf INPUT = "D" Then
                'do binary to decimal conversion
                BinaryToDecimal()
            End If
        Loop While INPUT <> "Q"
        Console.WriteLine("Have a nice day!")
    End Sub

    Sub DecimalToBinary()
        Console.WriteLine("Converting from Decimal to Binary")
    End Sub

    Sub BinaryToDecimal()
        Console.WriteLine("Converting from Binary to Decimal")
    End Sub
End Module
