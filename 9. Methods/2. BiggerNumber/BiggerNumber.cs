using System;

class BiggerNumber
{
    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }

    static int GetMaxFromThreeNumbers(int a, int b, int c)
    {
        return GetMax(a, GetMax(b, c));
    }

    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("GetMax(a, b) = {0}", GetMax(a, b));
        Console.WriteLine("GetMaxFromThreeNumbers(a, b, c) = {0}", GetMaxFromThreeNumbers(a, b, c));
    }
}
