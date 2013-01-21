using System;
using System.Collections.Generic;

class Permutation
{
    static void Permute(int[] n, int min, int max)
    {
        for (int i = min; i <= max; i++)
        {
            Swap(ref n[min], ref n[i]);
            if (min == max)
            {
                Print(n);
            }

            Permute(n, min + 1, max);
            Swap(ref n[min], ref n[i]);
        }
    }

    static void Print(int[] n)
    {
        foreach (int item in n)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Swap(ref int a, ref int b)
    {
        if (a == b)
        {
            return;
        }
        a ^= b;
        b ^= a;
        a ^= b;
    }

    static void Main()
    {
        Console.Write("Enter a number? ");
        int n = int.Parse(Console.ReadLine());

        int br = 0;
        int[] array = new int[n];
        for (int i = 1; i <= n; i++)
        {
            array[br] = i;
            br++;
        }
        Permute(array, 0, array.Length - 1);
    }
}
