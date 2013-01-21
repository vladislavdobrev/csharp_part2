using System;
using System.Collections.Generic;

class MaxSumWithKNumbers
{
    static void Main()
    {
        Console.Write("How much elements the set will have? ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("From how much elements the max sum will be? ");
        int k = int.Parse(Console.ReadLine());

        List<int> array = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            array.Add(int.Parse(Console.ReadLine()));
        }

        array.Sort();

        int maxSum = 0;
        string maxElements = null;
        for (int i = array.Count - 1; i > array.Count - k - 1; i--)
        {
            maxElements += array[i] + ", ";
            maxSum += array[i];
        }

        Console.WriteLine("Max sum of {0} elements comes from the elements {{{1}}} and it's count is {2}", 
            k, maxElements.Substring(0, maxElements.Length - 2), maxSum);
    }
}
