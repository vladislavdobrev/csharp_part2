using System;

class ShortToBin
{
    static void Main()
    {
        Console.Write("Enter number of type short: ");
        short n = short.Parse(Console.ReadLine());

        bool isNegative;
        string binResult;
        ConvertSignedShortToBin(n, out isNegative, out binResult);

        if (isNegative)
        {
            string temp = "1" + binResult.ToUpper().PadLeft(15, '0');
            Console.WriteLine("{0, -9}{1, -8}", temp.Substring(0, 8), temp.Substring(8));
        }
        else
        {
            string temp = binResult.ToUpper().PadLeft(16, '0');
            Console.WriteLine("{0, -9}{1, -8}", temp.Substring(0, 8), temp.Substring(8));
        }
    }

    private static void ConvertSignedShortToBin(short n, out bool isNegative, out string binResult)
    {
        int result = 0;
        isNegative = false;
        if (n < 0)
        {
            isNegative = true;
            n = Math.Abs(n);
            result = (int)Math.Abs(short.MaxValue - n + 1);
        }
        else
        {
            result = n;
        }

        binResult = ConvertDecToBin(result);
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
