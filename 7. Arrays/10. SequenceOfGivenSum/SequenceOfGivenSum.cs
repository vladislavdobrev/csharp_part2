using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter the sum: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("How much elements the set will have? ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        string theSequence = n == 1 ? ", " : null;
        for (int i = 0; i < n; i++)
        {
            int currentSum = 0;
            string sequence = null;
            bool findIt = false;
            for (int j = i; j < n; j++)
            {
                currentSum += array[j];
                sequence += array[j] + ", ";
                if (currentSum == s)
                {
                    findIt = true;
                    theSequence = sequence;
                    break;
                }
            }

            if (findIt)
            {
                break;
            }
        }

        Console.WriteLine("Result: {{{0}}}", theSequence.Substring(0, theSequence.Length - 2));
    }
}
