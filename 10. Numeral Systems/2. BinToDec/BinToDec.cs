using System;

class BinToDec
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string n = Console.ReadLine();

        int number = ConvertBinToDec(n);

        Console.WriteLine("The decimal representation of the binary number {0} is {1}", n, number);
    }

    private static int ConvertBinToDec(string n)
    {
        int br = 0;
        int number = 0;
        for (int i = n.Length - 1; i >= 0; i--)
        {
            number += (int)(int.Parse(n[br].ToString()) * (Math.Pow(2, i)));
            br++;
        }
        return number;
    }
}
