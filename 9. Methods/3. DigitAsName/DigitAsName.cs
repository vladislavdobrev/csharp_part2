using System;

class DigitAsName
{
    static void Main()
    {

        Console.Write("Enter number: ");
        string number = Console.ReadLine();

        string name = GetLastDigitAsName(number);
        Console.WriteLine(name);
    }

    private static string GetLastDigitAsName(string number)
    {
        string name = null;
        switch (number[number.Length - 1])
        {
            case '0':
                name = "zero";
                break;
            case '1':
                name = "one";
                break;
            case '2':
                name = "two";
                break;
            case '3':
                name = "three";
                break;
            case '4':
                name = "four";
                break;
            case '5':
                name = "five";
                break;
            case '6':
                name = "six";
                break;
            case '7':
                name = "seven";
                break;
            case '8':
                name = "eight";
                break;
            case '9':
                name = "nine";
                break;
        }
        return name;
    }
}
