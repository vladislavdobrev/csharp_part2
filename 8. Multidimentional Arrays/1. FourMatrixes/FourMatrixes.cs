using System;

class FourMatrixes
{
    static int EnterN()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        return n;
    }

    static int[,] CreateFirstMatrix(int n)
    {
        int[,] arr1 = new int[n, n];
        int br = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr1[j, i] = br;
                br++;
            }
        }
        return arr1;
    }

    static int[,] CreateSecondMatrix(int n)
    {
        int[,] arr2 = new int[n, n];
        int br = 1;
        bool direction = true;
        for (int i = 0; i < n; i++)
        {
            if (direction)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[j, i] = br;
                    br++;
                }
                direction = false;
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    arr2[j, i] = br;
                    br++;
                }
                direction = true;
            }
        }
        return arr2;
    }

    private static int[,] CreateThirdMatrix(int n)
    {
        int[,] arr3 = new int[n, n];
        int br = 1;
        int iStart = n - 1;
        int iEnd = n - 1;
        int jStart = 0;
        int jEnd = 0;

        int steps = n * n;
        int[] iArr = new int[steps];
        int[] jArr = new int[steps];
        int iIndex = 0;
        int jIndex = 0;
        while (steps != 0)
        {
            steps--;
            for (int i = iStart; i <= iEnd; i++)
            {
                iArr[iIndex] = i;
                iIndex++;
            }
            if (iStart > 0)
            {
                iStart--;
            }
            else
            {
                iEnd--;
            }
        }

        steps = n * n;
        while (steps != 0)
        {
            steps--;
            for (int j = jStart; j <= jEnd; j++)
            {
                jArr[jIndex] = j;
                jIndex++;
            }
            if (jEnd < n - 1)
            {
                jEnd++;
            }
            else
            {
                jStart++;
            }
        }

        for (int i = 0; i < n * n; i++)
        {
            arr3[iArr[i], jArr[i]] = br;
            br++;
        }
        return arr3;
    }

    static int[,] CreateFourthMatrix(int n)
    {
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = true;

        int loopLenght = n;
        int countLoop = 1;
        int counter = 1;
        int lastX = -1;
        int lastY = 0;
        int[,] spiral = new int[n, n];
        int temp = 1;
        while (temp <= 2 * n - 1)
        {
            if (right)
            {
                int constanta = lastY + 1;
                for (int i = constanta; i <= loopLenght + constanta - 1; i++)
                {
                    spiral[lastX, i] = counter;
                    counter++;
                    lastY++;
                }

                countLoop++;
                if (countLoop % 2 == 0)
                {
                    loopLenght--;
                }
            }
            else if (down)
            {
                int constanta = lastX + 1;
                for (int i = constanta; i <= loopLenght + constanta - 1; i++)
                {
                    spiral[i, lastY] = counter;
                    counter++;
                    lastX++;
                }

                countLoop++;
                if (countLoop % 2 == 0)
                {
                    loopLenght--;
                }
            }
            else if (left)
            {
                int constanta = lastY - 1;
                for (int i = constanta; i >= constanta - loopLenght + 1; i--)
                {
                    spiral[lastX, i] = counter;
                    counter++;
                    lastY--;
                }

                countLoop++;
                if (countLoop % 2 == 0)
                {
                    loopLenght--;
                }
            }
            else if (up)
            {
                int constanta = lastX - 1;
                for (int i = constanta; i >= constanta - loopLenght + 1; i--)
                {
                    spiral[i, lastY] = counter;
                    counter++;
                    lastX--;
                }

                countLoop++;
                if (countLoop % 2 == 0)
                {
                    loopLenght--;
                }
            }

            if (right)
            {
                right = false;
                up = true;
            }
            else if (down)
            {
                down = false;
                right = true;
            }
            else if (left)
            {
                left = false;
                down = true;
            }
            else if (up)
            {
                up = false;
                left = true;
            }

            temp++;
        }

        return spiral;
    }

    static void PrintMatrix(int n, int[,] arr)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, -5}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = EnterN();

        // First matrix
        int[,] arr1 = CreateFirstMatrix(n);
        Console.WriteLine();
        Console.WriteLine("First matrix:");
        PrintMatrix(n, arr1);

        // Second matrix
        Console.WriteLine();
        Console.WriteLine("Second matrix:");
        int[,] arr2 = CreateSecondMatrix(n);
        PrintMatrix(n, arr2);

        // Third matrix
        // 3,0
        // 2,0; 3,1
        // 1,0; 2,1; 3,2
        // 0,0; 1,1; 2,2; 3;3
        // 0,1; 1,2; 2,3
        // 0,2; 1,3
        // 0,3
        // i = 3 2 3 1 2 3 0 1 2 3 0 1 2 0 1 0
        // j = 0 0 1 0 1 2 0 1 2 3 1 2 3 2 3 3
        Console.WriteLine();
        Console.WriteLine("Third matrix:");
        int[,] arr3 = CreateThirdMatrix(n);
        PrintMatrix(n, arr3);

        // Fourth matrix
        Console.WriteLine();
        Console.WriteLine("Fourth matrix:");
        int[,] arr4 = CreateFourthMatrix(n);
        PrintMatrix(n, arr4);
    }
}
