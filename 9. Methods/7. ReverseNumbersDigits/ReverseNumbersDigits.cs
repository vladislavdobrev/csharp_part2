using System;
using System.Text;

class ReverseNumbersDigits
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        string number = Console.ReadLine();

        string result = ReverseNumber(number);
        Console.WriteLine(result);
    }

    private static string ReverseNumber(string number)
    {
        StringBuilder sb = new StringBuilder();
        bool isNegative = decimal.Parse(number) < 0 ? true : false;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (number[i] != '-')
            {
                sb.Append(number[i]);
            }
        }

        string result = null;
        if (isNegative)
        {
            result = string.Format("The result is -{0}", sb.ToString());
        }
        else
        {
            result = string.Format("The result is {0}", sb.ToString());
        }

        return result;
    }
}
