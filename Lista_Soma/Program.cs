using System;
using System.Collections.Generic;

List<int> odds = new List<int>();
int soma = 0;


for (int i = 0; i <= 10; i++)
{
    odds.Add(i);
    Console.WriteLine(odds[i]);
}
Console.WriteLine();

foreach (int number in odds)
{
    soma += number;
}

Console.WriteLine($"Soma dos números da lista: {soma} ");

