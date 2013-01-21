using System;

class FifthExerciseAndReturnIndex
{
    private static bool IsBiggerThanItsNeighbors(int n, int[] arr, int s)
    {
        bool isBigger = false;
        for (int i = 0; i < n; i++)
        {
            if (s == arr[i] && i > 0 && i < n - 1 && arr.Length > 2)
            {
                if (s > arr[i + 1] && s > arr[i - 1])
                {
                    isBigger = true;
                }
            }
        }
        return isBigger;
    }

    static void Main()
    {
        Console.Write("How much elements the array will have? ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0}: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int index = -1;
        for (int i = 0; i < n; i++)
        {
            bool isBigger = IsBiggerThanItsNeighbors(n, arr, arr[i]);
            if (isBigger)
            {
                index = i;
                break;
            }
        }

        Console.WriteLine("The index of the first element with two less elements: {0}", index);
    }
}
