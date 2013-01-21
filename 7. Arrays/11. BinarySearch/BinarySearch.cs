using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter the searched value: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("How much elements the set will have? ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Sorting the array
        for (int i = 0; i < n; i++)
        {
            int smallest = array[i];
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] <= smallest)
                {
                    smallest = array[j];
                    array[j] = array[i];
                    array[i] = smallest;
                }
            }
        }

        // Binary search
        int lowest = 1;
        int highest = n;
        while (lowest <= highest)
        {
            int middle = lowest + ((highest - lowest) / 2);

            if (array[middle] == s)
            {
                Console.WriteLine("The index is {0}", middle);
                break;
            }
            else if (array[middle] < s)
            {
                lowest = middle + 1;
            }
            else
            {
                highest = middle - 1;
            }
        }
    }
}
