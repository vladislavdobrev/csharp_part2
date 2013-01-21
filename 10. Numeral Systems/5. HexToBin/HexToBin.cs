using System;

class HexToBin
{
    static void Main()
    {
        Console.Write("Enter hexidecimal number: ");
        string n = Console.ReadLine();

        string result = ConvertHexToBinDirectly(n);

        Console.WriteLine("The binary representation of the hexidecimal number {0} is {1}", n, result);
    }

    private static string ConvertHexToBinDirectly(string n)
    {
        n = n.ToUpper();
        string result = null;
        for (int i = n.Length - 1; i >= 0; i--)
        {
            string num = n[i].ToString();
            switch (num)
            {
                case "0":
                    result = result + "0000";
                    break;
                case "1":
                    result = result + "0001";
                    break;
                case "2":
                    result = result + "0010";
                    break;
                case "3":
                    result = result + "0011";
                    break;
                case "4":
                    result = result + "0100";
                    break;
                case "5":
                    result = result + "0101";
                    break;
                case "6":
                    result = result + "0110";
                    break;
                case "7":
                    result = result + "0111";
                    break;
                case "8":
                    result = result + "1000";
                    break;
                case "9":
                    result = result + "1001";
                    break;
                case "A":
                    result = result + "1010";
                    break;
                case "B":
                    result = result + "1011";
                    break;
                case "C":
                    result = result + "1100";
                    break;
                case "D":
                    result = result + "1101";
                    break;
                case "E":
                    result = result + "1110";
                    break;
                case "F":
                    result = result + "1111";
                    break;
            }
        }
        return result;
    }
}
