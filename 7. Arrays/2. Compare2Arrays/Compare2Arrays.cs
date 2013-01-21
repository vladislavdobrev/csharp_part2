using System;

class Compare2Arrays
{
    static void Main()
    {
        int n;
        Console.Write("How much elements the 2 arrays will have? ");
        n = int.Parse(Console.ReadLine());

        object[] a = new object[n];
        object[] b = new object[n];
        for (int i = 1; i <= 2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Array {0}, element {1}: ", i, j);
                if (i == 1)
                {
                    a[j] = Console.ReadLine();
                }
                else
                {
                    b[j] = Console.ReadLine();
                }
            }
        }

        bool equal = true;
        for (int i = 0; i < n; i++)
        {
            if (!a[i].Equals(b[i]))
            {
                equal = false;
                break;
            }
        }

        Console.WriteLine("The arrays are {0}.", equal ? "equal": "not equal");
    }
}
