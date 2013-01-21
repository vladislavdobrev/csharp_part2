using System;

class CheckIfElementIsBiggerThanItsNeighbors
{
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

        Console.Write("Which number will be checked? ");
        int s = int.Parse(Console.ReadLine());

        bool isBigger = IsBiggerThanItsNeighbors(n, arr, s);

        Console.WriteLine("Is the element has two less neighbors? {0}", isBigger);
    }

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
}
