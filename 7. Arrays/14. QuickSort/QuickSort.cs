using System;
using System.Collections.Generic;

class QuickSort
{
    static List<string> QuickSorting(List<string> arr)
    {
        if (arr.Count <= 1)
        {
            return arr;
        }

        int middle = arr.Count / 2;
        string pivot = arr[middle];
        arr.RemoveAt(middle);

        List<string> leftList = new List<string>();
        List<string> rightList = new List<string>();
        foreach (string item in arr)
        {
            if (pivot.CompareTo(item) == 1 || pivot.CompareTo(item) == 0)
            {
                leftList.Add(item);
            }
            else
            {
                rightList.Add(item);
            }
        }

        return Concat(QuickSorting(leftList), pivot, QuickSorting(rightList));
    }

    static List<string> Concat(List<string> leftList, string pivot, List<string> rightList)
    {
        List<string> result = new List<string>();
        foreach (string item in leftList)
        {
            result.Add(item);
        }
        result.Add(pivot);
        foreach (string item in rightList)
        {
            result.Add(item);
        }

        return result;
    }

    static void Main()
    {
        Console.Write("How much elements the array will have? ");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter string {0}: ", i + 1);
            array[i] = Console.ReadLine();
        }

        foreach (var item in QuickSorting(new List<string>(array)))
        {
            Console.WriteLine(item);
        }
    }
}
