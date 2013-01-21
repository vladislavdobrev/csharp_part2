using System;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int n = int.Parse(Console.ReadLine());

        string newNum = ConvertDecToHex(n);

        Console.WriteLine("The hexidecimal representation of the decimal number {0} is {1}", n, newNum);
    }

    private static string ConvertDecToHex(int n)
    {
        int nCopy = n;
        string number = null;
        while (nCopy > 0)
        {
            int currentNum = nCopy % 16;
            switch (currentNum)
            {
                case 10:
                    number += 'A';
                    break;
                case 11:
                    number += 'B';
                    break;
                case 12:
                    number += 'C';
                    break;
                case 13:
                    number += 'D';
                    break;
                case 14:
                    number += 'E';
                    break;
                case 15:
                    number += 'F';
                    break;
                default:
                    number += currentNum;
                    break;
            }

            nCopy /= 16;
        }

        string newNum = null;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            newNum += number[i];
        }
        return newNum;
    }
}
