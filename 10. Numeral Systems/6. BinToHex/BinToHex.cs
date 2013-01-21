using System;

class BinToHex
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string n = Console.ReadLine();

        string result = ConvertBinToHexDirectly(n);

        Console.WriteLine("The hexidecimal representation of the binary number {0} is {1}", n, result);
    }

    private static string ConvertBinToHexDirectly(string n)
    {
        int adding = n.Length % 4;
        n = n.PadLeft(n.Length + adding, '0');
        string result = null;
        for (int i = n.Length - 4; i >= 0; i -= 4)
        {
            string num = n.Substring(i, 4);
            switch (num)
            {
                case "0000":
                    result = result + '0';
                    break;
                case "0001":
                    result = result + '1';
                    break;
                case "0010":
                    result = result + '2';
                    break;
                case "0011":
                    result = result + '3';
                    break;
                case "0100":
                    result = result + '4';
                    break;
                case "0101":
                    result = result + '5';
                    break;
                case "0110":
                    result = result + '6';
                    break;
                case "0111":
                    result = result + '7';
                    break;
                case "1000":
                    result = result + '8';
                    break;
                case "1001":
                    result = result + '9';
                    break;
                case "1010":
                    result = result + 'A';
                    break;
                case "1011":
                    result = result + 'B';
                    break;
                case "1100":
                    result = result + 'C';
                    break;
                case "1101":
                    result = result + 'D';
                    break;
                case "1110":
                    result = result + 'E';
                    break;
                case "1111":
                    result = result + 'F';
                    break;
            }
        }
        return result;
    }
}
