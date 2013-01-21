using System;
using System.Collections.Generic;

class NumberToArray
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string a = Console.ReadLine();
        Console.Write("Enter second number: ");
        string b = Console.ReadLine();

        int[] aArr = new int[a.Length];
        int[] bArr = new int[b.Length];

        ConvertNumberToArray(a, aArr);
        ConvertNumberToArray(b, bArr);

        List<int> arraysSum = SumTwoArraysOfDigits(aArr, bArr);
        arraysSum.Reverse();
        if (arraysSum[0] == 0)
        {
            arraysSum.RemoveAt(0);
        }
        Console.Write("The result is: ");
        foreach (int digit in arraysSum)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }

    private static List<int> SumTwoArraysOfDigits(int[] aArr, int[] bArr)
    {
        int n = Math.Max(aArr.Length, bArr.Length);
        List<int> result = new List<int>(new int[n + 1]);
        int naUm = 0;
        for (int i = 0; i < aArr.Length; i++)
        {
            result[i] = aArr[i];
        }
        for (int i = 0; i < bArr.Length; i++)
        {
            int num = result[i] + bArr[i];
            int digit = num % 10;
            result[i] = digit + naUm;
            naUm = num / 10;
        }
        result[result.Count - 1] = naUm;
        return result;
    }

    private static void ConvertNumberToArray(string a, int[] aArr)
    {
        int indexA = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            aArr[indexA] = int.Parse(a[i].ToString());
            indexA++;
        }
    }
}
