using System;
using System.Text;

class VariationsWithKElements
{
    static void Variation(int[] arr, int k, StringBuilder sb)
    {
        if (k == 0)
        {
            Console.WriteLine(sb.ToString());
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sb.AppendFormat("{0} ", arr[i]);
                Variation(arr, k - 1, sb);
                sb.Remove(sb.Length - 2, 2);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a number? ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k? ");
        int k = int.Parse(Console.ReadLine());

        int br = 0;
        int[] arr = new int[n];
        for (int i = 1; i <= n; i++)
        {
            arr[br] = i;
            br++;
        }

        StringBuilder sb = new StringBuilder();
        Variation(arr, k, sb);
    }
}
