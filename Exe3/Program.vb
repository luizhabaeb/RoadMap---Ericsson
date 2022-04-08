Imports System

Module Program
    Sub Main()
        Dim idade As Integer
        Dim nome As String
        Dim var As String = "sim"

        While var = "sim"

            Console.WriteLine("Insira seu nome: ")
            nome = Console.ReadLine()
            Console.WriteLine("Insira sua idade: ")
            idade = Console.ReadLine()

            Console.WriteLine("Seu nome é {0} e você tem {1} anos.", nome, idade)
            Console.ReadLine()

            Console.WriteLine("Deseja Continuar sim/nao?")
            var = Console.ReadLine()

            If var = "sim" Then
                Continue While
            End If

            If var <> "sim" Then
                Exit While
            End If

        End While

    End Sub
End Module


