using System;

class HexToDec
{
    static void Main()
    {
        Console.Write("Enter hexidecimal number: ");
        string n = Console.ReadLine();

        int number = ConvertHexToDec(n);

        Console.WriteLine("The decimal representation of the hexidecimal number {0} is {1}", n, number);
    }

    private static int ConvertHexToDec(string n)
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
            number += (int)(temp * (Math.Pow(16, i)));
            br++;
        }
        return number;
    }
}
