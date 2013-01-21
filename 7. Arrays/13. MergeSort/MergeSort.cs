using System;
using System.Collections.Generic;

class MergeSort
{
    static List<int> MergeSortint(List<int> arr)
    {
        if (arr.Count <= 1)
        {
            return arr;
        }

        int middle = arr.Count / 2;

        List<int> leftList = new List<int>();
        List<int> rightList = new List<int>();
        for (int i = 0; i < arr.Count; i++)
        {
            if (i >= middle)
            {
                rightList.Add(arr[i]);
            }
            else
            {
                leftList.Add(arr[i]);
            }
        }

        leftList = MergeSortint(leftList);
        rightList = MergeSortint(rightList);

        return Merge(leftList, rightList);
    }

    private static List<int> Merge(List<int> leftList, List<int> rightList)
    {
        List<int> result = new List<int>();

        while (leftList.Count > 0 || rightList.Count > 0)
        {
            if (leftList.Count > 0 && rightList.Count > 0)
            {
                if (leftList[0] <= rightList[0])
                {
                    result.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }
                else
                {
                    result.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }
            else if (leftList.Count > 0)
            {
                result.Add(leftList[0]);
                leftList.RemoveAt(0);
            }
            else if (rightList.Count > 0)
            {
                result.Add(rightList[0]);
                rightList.RemoveAt(0);
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("How much elements the array will have? ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        foreach (var item in MergeSortint(new List<int>(array)))
        {
            Console.WriteLine(item);
        }
    }
}
