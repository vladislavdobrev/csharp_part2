using System;
using System.Collections.Generic;

class RemoveElementsFromArrayAndKeepItIncreasing
{
    static void Main()
    {
        Console.Write("How much elements the array will have? ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        List<int> intList = new List<int>(array);
        intList.Sort();

        int[] maxArr = new int[0];
        for (int index = 0; index < intList.Count; index++)
        {
            int currLen = 0;
            int currIndex = 0;
            List<int> innerList = new List<int>();
            for (int i = index; i < intList.Count; i++)
            {
                int number = intList[i];
                for (int j = currIndex; j < intList.Count; j++)
                {
                    if (array[j] == number)
                    {
                        currLen++;
                        currIndex = j + 1;
                        innerList.Add(number);
                        break;
                    }
                }
            }

            if (innerList.Count > maxArr.Length)
            {
                maxArr = new int[innerList.Count];
                innerList.CopyTo(maxArr);
            }
        }

        Console.Write("The longest sequence of fowolling numbers is: {");
        for (int i = 0; i < maxArr.Length; i++)
        {
            if (i != maxArr.Length - 1)
            {
                Console.Write("{0}, ", maxArr[i]);
            }
            else
            {
                Console.Write("{0}}}", maxArr[i]);
            }
        }
        Console.WriteLine();
    }
}
