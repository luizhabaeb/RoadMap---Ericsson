Imports System

Module Program
    Sub Main()
        'Crie uma lista com valores de 1 a 10. Utilize uma das estruturas para percorrer a lista  e exiba somente os números impares'

        Dim list() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

        For Each x As Integer In list
            If x Mod 2 = 1 Then
                Console.WriteLine(x)
            End If
        Next

    End Sub

End Module
