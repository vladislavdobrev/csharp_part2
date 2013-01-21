using System;

class MaxElementFromGivenPositionAndSortIt
{
    static void Main()
    {
        int[] arr = { 2, 32, 33, 1, 3, 42, 345, 32, 66, 324, 6, 87, 0, 34, 5, 65 };
        Console.Write("What will be the index you will start searching (range 0-{0}): ", arr.Length - 1);
        int k = int.Parse(Console.ReadLine());

        int biggest = FindBiggestElementStartingFromPosition(arr, k);
        Console.WriteLine("The biggest element in the array starting from position {0} is {1}", k, biggest);

        Console.WriteLine();
        Console.WriteLine("Original array: ");
        PrintArray(arr);

        // Sorting in descending order
        Console.WriteLine();
        Console.WriteLine("Sorting the array in descending order: ");
        SortArray(arr, false);
        PrintArray(arr);

        // Sorting in ascending order
        Console.WriteLine();
        Console.WriteLine("Sorting the array in ascending order: ");
        SortArray(arr);
        PrintArray(arr);
    }

    private static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }

    private static void SortArray(int[] arr, bool asc = true)
    {
        if (asc)
        {
            SortArray(arr, false);
            Array.Reverse(arr);
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int biggest = FindBiggestElementStartingFromPosition(arr, i);
                int index = Array.IndexOf(arr, biggest, i);
                int temp = arr[i];
                arr[i] = biggest;
                arr[index] = temp;
            }
        }
    }

    private static int FindBiggestElementStartingFromPosition(int[] arr, int k)
    {
        int biggest = arr[k];
        for (int i = k; i < arr.Length; i++)
        {
            if (arr[i] > biggest)
            {
                biggest = arr[i];
            }
        }
        return biggest;
    }
}
