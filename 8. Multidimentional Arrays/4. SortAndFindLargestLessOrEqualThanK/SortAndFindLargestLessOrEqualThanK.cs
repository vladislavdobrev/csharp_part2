using System;
using System.Collections.Generic;

class SortAndFindLargestLessOrEqualThanK
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        List<int> arr = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element #{0}: ", i);
            arr.Add(int.Parse(Console.ReadLine()));
        }

        arr.Sort();
        int index = Array.BinarySearch(arr.ToArray(), k);
        int result = int.MinValue;
        if ((index < arr.Count - 1) && (arr[index + 1] == k))
        {
            result = arr[index + 1];
        }
        else if (index > 0)
        {
            result = arr[index - 1];
        }

        Console.WriteLine("The largest number less or equal than k is {0}", result);
    }
}
