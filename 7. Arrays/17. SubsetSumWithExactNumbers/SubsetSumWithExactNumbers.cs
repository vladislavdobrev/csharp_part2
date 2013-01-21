using System;
using System.Collections.Generic;

class SubsetSumWithExactNumbers
{
    static void Main()
    {
        Console.Write("What will be the asked sum? ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("How much elements will need to be in it? ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("How much elements the array will have? ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();

        for (int i = 0; i < n; i++)
        {
            int num = array[i];
            Dictionary<int, List<int>> temp = new Dictionary<int, List<int>>(result);
            foreach (int key in temp.Keys)
            {
                int countOfNumbers = 1;
                if (result.ContainsKey(num + key))
                {
                    result[num + key][0]++;
                }
                else
                {
                    bool flag = false;
                    for (int j = 1; j < result[key].Count; j++)
                    {
                        if (result[key][j] + countOfNumbers == k)
                        {
                            flag = true;
                            countOfNumbers += result[key][j];
                        }
                    }
                    if (!flag)
                    {
                        countOfNumbers += result[key][1];
                    }
                    result.Add(num + key, new List<int>(new int[] { 1, countOfNumbers }));
                }
            }

            if (!result.ContainsKey(num))
            {
                result.Add(num, new List<int>(new int[] { 1, 1 }));
            }
            else
            {
                result[num][0]++;
                result[num].Add(1);
            }
        }

        bool flag2 = false;
        if (result.ContainsKey(s))
        {
            for (int i = 1; i < result[s].Count; i++)
            {
                if (result[s][i] == k)
                {
                    flag2 = true;
                    Console.WriteLine("Yes, there're subset with {0} numbers and sum of {1}", result[s][i], s);
                }
            }
        }
        if (!flag2)
        {
            Console.WriteLine("No, there're no such subset");
        }
    }
}
