Imports System
Module Program
    Sub Main()
        Dim number1, number2 As String
        Dim Result As Double

        Console.WriteLine("Digite um n�mero: ")
        number1 = Console.ReadLine()
        Console.WriteLine("Digite outro n�mero: ")
        number2 = Console.ReadLine()

        'Quero dividir um n�mero pelo outro, e, caso o usu�rio digite uma letra, o Bloco abaixo identifique como uma exce��o/erro e n�o trave o programa'
        Try
            Result = CDbl(number1) / CDbl(number2)
            Console.WriteLine("A divis�o de {0} por {1} � {2:0.00}", number1, number2, Result)
        Catch ex As Exception ' excess�o/erro
            Console.WriteLine("Letras ou caracteres n�o podem ser calculados. Tente novamente!")
            Console.ReadLine()
        Finally


        End Try


    End Sub
End Module
