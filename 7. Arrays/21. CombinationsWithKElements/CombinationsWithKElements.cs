using System;
using System.Collections.Generic;
using System.Text;

class CombinationsWithKElements
{
    static void Combination(List<int> arr, int k, StringBuilder sb)
    {
        if (k == 0)
        {
            Console.WriteLine(sb.ToString());
        }
        else
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (sb.ToString().Substring(sb.Length - 2, 1).CompareTo(arr[i].ToString()) == -1 && 
                    !sb.ToString().Contains(arr[i].ToString()))
                {
                    
                    sb.AppendFormat("{0} ", arr[i]);
                    Combination(arr, k - 1, sb);
                    sb.Remove(sb.Length - 2, 2);
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a number? ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k? ");
        int k = int.Parse(Console.ReadLine());

        List<int> arr = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            arr.Add(i);
        }

        StringBuilder sb = new StringBuilder("  ");
        Combination(arr, k, sb);
    }
}
