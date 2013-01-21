using System;

class SequenceOfMaxSum
{
    static void Main()
    {
        Console.Write("How much elements the set will have? ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = 0;
        string maxSequence = null;
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            string sequence = null;
            for (int j = i; j < n; j++)
            {
                sum += array[j];
                sequence += array[j] + ", ";

                if (maxSum < sum)
                {
                    maxSum = sum;
                    maxSequence = sequence;
                }
            }
        }


        Console.WriteLine("Result: {{{0}}}", maxSequence.Substring(0, maxSequence.Length - 2));
    }
}
