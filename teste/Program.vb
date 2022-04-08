Imports System

Module Program
    Sub Main()

        Dim n As Integer = 1
        Dim P As Integer = 0
        Dim I As Integer = 0
        Dim a As String

        While n <= 10
            Console.WriteLine()
            a = Console.ReadLine()
            n = n + 1
            If a Mod 2 = 1 Then
                a = P
                P = P + 1
            Else
                a = I
                I = I + 1
            End If
            Console.WriteLine("A qtd de números pares é: ", P)
            Console.WriteLine("A qtd de números ímpares é: ", I)
        End While

    End Sub
End Module
