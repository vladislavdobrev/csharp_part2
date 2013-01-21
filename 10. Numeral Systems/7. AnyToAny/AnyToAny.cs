/*
 * 10   13
 * ------
 * 0    0   
 * 1    1
 * 2    2
 * 3    3
 * 4    4
 * 5    5
 * 6    6
 * 7    7
 * 8    8
 * 9    9
 * 10   a
 * 11   b
 * 12   c
 * 13   10
 * 14   11
 * 15   12
 */

using System;

class AnyToAny
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string n = Console.ReadLine();
        Console.Write("From base: ");
        string s = Console.ReadLine();
        Console.Write("To base: ");
        string d = Console.ReadLine();

        int dec = ConvertToDec(n,  s);
        string result = ConvertToAny(dec, d);

        Console.WriteLine("The representation from base {0} to base {1} of the number {2} is {3}", s, d , n, result);
    }

    private static int ConvertToDec(string n, string s)
    {
        n = n.ToUpper();
        int br = 0;
        int number = 0;
        for (int i = n.Length - 1; i >= 0; i--)
        {
            char currentNum = n[br];
            int temp = 0;
            switch (currentNum)
            {
                case 'A':
                    temp = 10;
                    break;
                case 'B':
                    temp = 11;
                    break;
                case 'C':
                    temp = 12;
                    break;
                case 'D':
                    temp = 13;
                    break;
                case 'E':
                    temp = 14;
                    break;
                case 'F':
                    temp = 15;
                    break;
                default:
                    temp = int.Parse(currentNum.ToString());
                    break;
            }
            number += (int)(temp * (Math.Pow(int.Parse(s), i)));
            br++;
        }
        return number;
    }

    private static string ConvertToAny(int n, string d)
    {
        int nCopy = n;
        string number = null;
        while (nCopy > 0)
        {
            int currentNum = nCopy % int.Parse(d);
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

            nCopy /= int.Parse(d);
        }

        string newNum = null;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            newNum += number[i];
        }
        return newNum;
    }
}
