using System;

class CountNumberInArray
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

        Console.Write("Which number you will count? ");
        int s = int.Parse(Console.ReadLine());

        int count = CountNumber(n, arr, s);
        Console.WriteLine("The number count is {0}", count);

        // Test
        Test();
    }

    private static int CountNumber(int n, int[] arr, int s)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == s)
            {
                count++;
            }
        }
        return count;
    }

    static void Test()
    {
        int[] arr = { 0, 3123, -2, 3123, 442342, -555, 3123, int.MaxValue, -555, int.MinValue };
        int[] s = { 0, 3123, -2, 3123, 442342, -555, 3123, int.MaxValue, -555, int.MinValue };

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Test {0}", i + 1);
            Console.WriteLine(new string('-', 20));
            int result = CountNumber(10, arr, s[i]);
            Console.Write("Array: ");
            foreach (int number in arr)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            Console.WriteLine("Counting number: {0}", s[i]);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
