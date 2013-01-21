using System;
using System.Collections.Generic;

class SortArrayOfStringsByLength
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        List<string> arr = new List<string>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter string #{0}: ", i);
            arr.Add(Console.ReadLine());
        }

        Comparison<string> comparison = new Comparison<string>(CompareStrings);
        arr.Sort(comparison);

        foreach (string item in arr)
        {
            Console.WriteLine(item);
        }
    }

    static int CompareStrings(string a, string b)
    {
        return a.Length.CompareTo(b.Length);
    }
}
