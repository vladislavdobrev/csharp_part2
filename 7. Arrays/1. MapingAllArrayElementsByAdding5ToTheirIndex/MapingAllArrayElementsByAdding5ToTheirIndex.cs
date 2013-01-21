using System;

class MapingAllArrayElementsByAdding5ToTheirIndex
{
    static void Main()
    {
        int[] newArray = new int[20];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = i * 5;
        }

        foreach (int elem in newArray)
        {
            Console.WriteLine(elem);
        }
    }
}
