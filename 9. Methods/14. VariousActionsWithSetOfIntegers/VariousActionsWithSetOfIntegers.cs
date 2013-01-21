using System;

class VariousActionsWithSetOfIntegers
{
    static void Main()
    {
        Random rand = new Random();
        int random = rand.Next(1, 10);
        Console.WriteLine("Entering {0} parameters for the methods.", random);

        Console.Write("Parameters: ");
        int[] arr = new int[random];
        for (int i = 0; i < random; i++)
        {
            int elem = rand.Next(1000);
            Console.Write("{0} ", elem);
            arr[i] = elem;
        }
        Console.WriteLine();

        Console.Write("Minimum: {0}", Minimum(arr));
        Console.WriteLine();

        Console.Write("Maximum: {0}", Maximum(arr));
        Console.WriteLine();

        Console.Write("Average: {0:F2}", Average(arr));
        Console.WriteLine();

        Console.Write("Sum: {0}", Sum(arr));
        Console.WriteLine();

        Console.Write("Product: {0}", Product(arr));
        Console.WriteLine();
    }

    public static int Minimum(params int[] arr)
    {
        int a = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < a)
            {
                a = arr[i];
            }
        }
        return a;
    }

    public static int Maximum(params int[] arr)
    {
        int a = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > a)
            {
                a = arr[i];
            }
        }
        return a;
    }

    public static decimal Average(params int[] arr)
    {
        int count = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            count += arr[i];
        }
        return (decimal)count / (decimal)arr.Length;
    }

    public static decimal Sum(params int[] arr)
    {
        decimal count = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            count += arr[i];
        }
        return count;
    }

    public static decimal Product(params int[] arr)
    {
        decimal count = 1;
        for (int i = 1; i < arr.Length; i++)
        {
            count *= arr[i];
        }
        return count;
    }
}
