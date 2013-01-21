using System;

class SortArray
{
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

        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }
}
