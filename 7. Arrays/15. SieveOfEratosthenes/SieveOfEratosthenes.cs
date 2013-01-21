using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static bool[] AlgoSOE(int range, int start = 2)
    {
        bool[] result = new bool[range + 1];
        for (int i = start; i < Math.Sqrt(range); i++)
        {
            if (result[i] == false)
            {
                for (int j = i * i; j <= range; j += i)
                {
                    result[j] = true;
                }
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter the range: ");
        int n = int.Parse(Console.ReadLine());
        bool[] result = new bool[n];
        result = AlgoSOE(n);

        for (int i = 2; i < result.Length; i++)
        {
            if (!result[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}
