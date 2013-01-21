using System;

class LexicographCompare
{
    static void Main()
    {
        int n;
        Console.Write("How much elements the 2 arrays will have? ");
        n = int.Parse(Console.ReadLine());

        char[] a = new char[n];
        char[] b = new char[n];
        for (int i = 1; i <= 2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Array {0}, element {1}: ", i, j);
                if (i == 1)
                {
                    a[j] = Console.ReadLine()[0];
                }
                else
                {
                    b[j] = Console.ReadLine()[0];
                }
            }
        }

        bool first = false;
        bool second = false;
        for (int i = 0; i < n; i++)
        {
            if (a[i] < b[i])
            {
                first = true;
                break;
            }
            else if (a[i] > b[i])
            {
                second = true;
                break;
            }
        }

        Console.WriteLine("The {0} of the arrays is lexicographicly first.", first ? "first" : second ? "second" : "none");
    }
}
