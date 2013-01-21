using System;

class DecToBin
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int n = int.Parse(Console.ReadLine());

        string newNum = ConvertDecToBin(n);

        Console.WriteLine("The binary representation of the decimal number {0} is {1}", n, newNum);
    }

    private static string ConvertDecToBin(int n)
    {
        int nCopy = n;
        string number = null;
        do
        {
            number += (nCopy % 2);
            nCopy /= 2;
        }
        while (nCopy > 0);

        string newNum = null;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            newNum += number[i];
        }
        return newNum;
    }
}
