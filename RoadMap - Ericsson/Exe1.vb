Imports System

Module Exe1
    Sub Main()
        Dim number1 As Integer

        Console.WriteLine("Type a number: ")
        number1 = Console.ReadLine()

        If number1 Mod 2 = 0 Then
            Console.WriteLine("That's a pair number.")
        Else
            Console.WriteLine("That's a odd number.")
        End If


    End Sub
End Module
