using System;

class MostFriquentNumber
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

        int maxNumber = 0;
        int maxCount = 0;
        for (int i = 0; i < n; i++)
        {
            int number = array[i];
            int count = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] == number)
                {
                    count++;
                }
            }

            if (maxCount < count)
            {
                maxCount = count;
                maxNumber = number;
            }
        }

        Console.WriteLine("The most frequent number is {0} and it's count is {1}", maxNumber, maxCount);
    }
}
