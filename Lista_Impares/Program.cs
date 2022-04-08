using System;
using System.Collections.Generic;

List<int> odds = new List<int>();

for (int i = 0; i <= 10; i++)
{
    odds.Add(i);
}

foreach (int i in odds)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(odds[i]);
    }

}

