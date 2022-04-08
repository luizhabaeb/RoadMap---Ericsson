Imports System
Module Program
    Sub Main()
        Dim number1, number2 As String
        Dim Result As Double

        Console.WriteLine("Digite um número: ")
        number1 = Console.ReadLine()
        Console.WriteLine("Digite outro número: ")
        number2 = Console.ReadLine()

        'Quero dividir um número pelo outro, e, caso o usuário digite uma letra, o Bloco abaixo identifique como uma exceção/erro e não trave o programa'
        Try
            Result = CDbl(number1) / CDbl(number2)
            Console.WriteLine("A divisão de {0} por {1} é {2:0.00}", number1, number2, Result)
        Catch ex As Exception ' excessão/erro
            Console.WriteLine("Letras ou caracteres não podem ser calculados. Tente novamente!")
            Console.ReadLine()
        Finally


        End Try


    End Sub
End Module
