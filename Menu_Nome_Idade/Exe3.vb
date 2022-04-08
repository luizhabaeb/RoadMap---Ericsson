Imports System

Module Exe3
    Sub Main()
        Dim list As Integer
        Dim number As Integer

        For list = 1 To 10 Step 1
            number = Console.WriteLine(list)
        Next

        For Each number In list Mod 2 <> 0
            Console.WriteLine(number)
        Next

    End Sub
End Module
