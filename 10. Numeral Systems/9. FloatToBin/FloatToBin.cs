using System;
using System.Globalization;
using System.Threading;

class FloatToBin
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter number of type float: ");
        float nFloat = float.Parse(Console.ReadLine());

        int sign;
        string exp;
        string mantissa;
        CreateFloatPresentation(nFloat, out sign, out exp, out mantissa);

        Console.WriteLine();
        Console.WriteLine("{0, -10}{1, -5}{2, -10}{3, -25}", "Number", "Sign", "Exponent", "Mantissa");
        Console.WriteLine("{0, -10}{1, -5}{2, -10}{3, -25}", nFloat, sign, exp, mantissa);
    }

    private static void CreateFloatPresentation(float nFloat, out int sign, out string exp, out string mantissa)
    {
        if (nFloat == 0.0F)
        {
            sign = 0;
            exp = new string('0', 8);
            mantissa = new string('0', 23);
            return;
        }

        bool isPositive = nFloat <= 1.0F ? false : true;

        // Sign
        sign = nFloat < 0.0F ? 1 : 0;

        // Exponent
        string binResult;
        short n = 0;
        nFloat = Math.Abs(nFloat);
        for (int i = sbyte.MinValue + 1; i <= sbyte.MaxValue + 1; i++)
        {
            double a = Math.Pow(2, i);
            if (a > (double)nFloat)
            {
                n = (short)(i - 1);
                break;
            }
        }
        ConvertSignedShortToBin(n, isPositive, out binResult);
        exp = binResult.ToUpper().PadLeft(8, '0');

        // Mantissa
        float absN = Math.Abs(nFloat);
        if (absN > 2.0F)
        {
            while (absN >= 2.0F)
            {
                absN /= 2.0F;
            }
        }
        else
        {
            while (absN < 1.0F)
            {
                absN *= 2.0F;
            }
        }

        mantissa = "";
        if (absN > 1.0F)
        {
            string strMant = absN.ToString();
            strMant = strMant.Substring(1);
            absN = float.Parse(strMant);
        }

        int steps = 0;
        while (absN != 1.0F && steps < 23)
        {
            absN *= 2.0F;
            if (absN > 1.0F)
            {
                mantissa += '1';
                string strMant = absN.ToString();
                strMant = strMant.Substring(1);
                absN = float.Parse(strMant);
            }
            else if (absN == 1.0F)
            {
                mantissa += '1';
                break;
            }
            else
            {
                mantissa += '0';
            }
            steps++;
        }
        mantissa = mantissa.PadRight(23, '0');
    }

    private static void ConvertSignedShortToBin(short n, bool isPositive, out string binResult)
    {
        int result = 0;
        if (isPositive)
        {
            n -= 1;
            result = Math.Abs(sbyte.MaxValue + n + 1);
        }
        else
        {
            result = Math.Abs(sbyte.MaxValue + n);
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
