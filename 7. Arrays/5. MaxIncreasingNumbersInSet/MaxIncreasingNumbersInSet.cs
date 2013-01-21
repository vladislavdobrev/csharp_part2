using System;

class MaxIncreasingNumbersInSet
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

        int maxLen = 0;
        string maxSequence = null;
        for (int i = 0; i < n; i++)
        {
            int number = array[i];
            int len = 0;
            string sequence = null;
            for (int j = i; j < n; j++)
            {
                if (j == i)
                {
                    len++;
                    sequence += number + ", ";

                    if (n == 1)
                    {
                        maxSequence = sequence;
                    }
                }
                else
                {
                    if (number < array[j])
                    {
                        len++;
                        sequence += array[j] + ", ";

                        if (j == n - 1)
                        {
                            if (len > maxLen)
                            {
                                maxLen = len;
                                maxSequence = sequence;
                            }
                        }
                    }
                    else
                    {
                        if (len > maxLen)
                        {
                            maxLen = len;
                            maxSequence = sequence;
                        }
                        break;
                    }
                }
            }
        }


        Console.WriteLine("Result: {{{0}}}", maxSequence.Substring(0, maxSequence.Length - 2));
    }
}
