using System;
using System.Collections.Generic;

class SubsetSum
{
    static void Main()
    {
        Console.Write("What will be the asked sum? ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("How much elements the array will have? ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Dictionary<int, int> result = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int num = array[i];
            Dictionary<int, int> temp = new Dictionary<int, int>(result);
            foreach (int key in temp.Keys)
            {
                if (result.ContainsKey(num + key))
                {
                    result[num + key]++;
                }
                else
                {
                    result.Add(num + key, 1);
                }
            }
            
            if(!result.ContainsKey(num))
            {
                result.Add(num, 1);
            }
            else
            {
                result[num]++;
            }
        }

        if (result.ContainsKey(s))
        {
            Console.WriteLine("Yes, there're {0} subset(s) with the sum of {1}", result[s], s);
        }
        else
        {
            Console.WriteLine("No, there're no subset with the sum of {0}", s);
        }
    }
}
