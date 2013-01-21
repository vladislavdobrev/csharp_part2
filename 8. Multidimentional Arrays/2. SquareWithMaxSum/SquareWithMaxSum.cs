using System;

class SquareWithMaxSum
{
    private static void FindTheMaxSquere(int n, int m, int[,] arr, out int maxSum, out int[,] maxSquare)
    {
        maxSum = int.MinValue;
        maxSquare = new int[3, 3];
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                int[] square =
                {
                    arr[i, j],
                    arr[i, j + 1],
                    arr[i, j + 2],
                    arr[i + 1, j],
                    arr[i + 1, j + 1],
                    arr[i + 1, j + 2],
                    arr[i + 2, j],
                    arr[i + 2, j + 1],
                    arr[i + 2, j + 2]
                };
                int sum = 0;
                foreach (int item in square)
                {
                    sum += item;
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    int br = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            maxSquare[k, l] = square[br];
                            br++;
                        }
                    }
                }
            }
        }
    }

    private static void PrintResult(int maxSum, int[,] maxSquare)
    {
        if (maxSum >= 0)
        {
            Console.WriteLine();
            Console.WriteLine("The max sum is {0} and the max squere is:", maxSum);
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0, -10}", maxSquare[i, j]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("There are no squere at all.");
        }
    }

    private static void EnterMatrix(out int n, out int m, out int[,] arr)
    {
        Console.Write("Enter N: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        m = int.Parse(Console.ReadLine());

        arr = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{{{0}, {1}}} = ", i, j);
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void Main()
    {
        int n;
        int m;
        int[,] arr;
        EnterMatrix(out n, out m, out arr);

        int maxSum;
        int[,] maxSquare;
        FindTheMaxSquere(n, m, arr, out maxSum, out maxSquare);

        PrintResult(maxSum, maxSquare);
    }
}
