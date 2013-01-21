using System;

class AlphabetArray
{
    static void Main()
    {
        char[] alphabet = new char[26];
        int br = 0;
        for (int i = 65; i < 91; i++)
        {
            alphabet[br] = (char)i;
            br++;
        }

        string word = Console.ReadLine().ToUpper();
        foreach (char letter in word)
        {
            for (int i = 0; i < 26; i++)
            {
                if (letter == alphabet[i])
                {
                    Console.WriteLine(letter + " => " + i);
                    break;
                }
            }
        }
    }
}
