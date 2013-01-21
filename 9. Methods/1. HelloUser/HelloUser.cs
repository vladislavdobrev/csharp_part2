using System;

class HelloUser
{
    static void Main()
    {
        PrintName();
        Console.WriteLine();
        Console.WriteLine(new string('-', 15));
        Console.WriteLine("Tests:");
        Console.WriteLine(new string('-', 15));
        Test();
    }

    private static void Test()
    {
        string[] names =
        {
            "",
            "Vlado",
            "Sasho",
            null,
            "Mitko"
        };

        foreach (string name in names)
        {
            PrintName(name);
        }
    }

    private static void PrintName(string n = null)
    {
        string name = null;
        if (n == null)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }
        else
        {
            name = n;
        }

        Console.WriteLine("Hello, {0}!", name);
    }
}
