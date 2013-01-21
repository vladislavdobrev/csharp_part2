using System;
using System.Collections.Generic;

class NFactByNumberRepresentedAsArray
{
    static void Main()
    {
        Console.Write("Enter n for n!: ");
        int n = int.Parse(Console.ReadLine());

        List<int> result = MultiplyNFactWithNumberAsArray(n);

        Console.Write("{0}! = ", n);
        foreach (var item in result)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

    private static List<int> MultiplyNFactWithNumberAsArray(int n)
    {
        List<int> result = new List<int>();
        ConvertNumberToArray("1", result);
        int naUm = 0;
        for (int i = 1; i <= n; i++)
        {
            int num = 0;
            for (int j = 0; j < result.Count; j++)
            {
                num = result[j] * i;
                int res = num % 10;
                int x = res + naUm;
                if (x > 9)
                {
                    result[j] = x % 10;
                    naUm = x / 10 + num / 10;
                }
                else
                {
                    result[j] = x;
                    naUm = num / 10;
                }
            }
            if (num > 0)
            {
                if (naUm > 9)
                {
                    for (int j = naUm.ToString().Length - 1; j >= 0; j--)
                    {
                        result.Add(int.Parse(naUm.ToString()[j].ToString()));
                    }
                }
                else
                {
                    result.Add(naUm);
                }
                naUm = 0;
            }
        }
        result.Reverse();
        if (result[0] == 0)
        {
            result.RemoveAt(0);
        }
        return result;
    }

    private static void ConvertNumberToArray(string a, List<int> aArr)
    {
        for (int i = a.Length - 1; i >= 0; i--)
        {
            aArr.Add(int.Parse(a[i].ToString()));
        }
    }
}
