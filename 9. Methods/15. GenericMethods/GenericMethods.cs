using System;

class GenericMethods
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        Random rand = new Random();
        int random = rand.Next(1, 12);
        switch (random)
        {
            case 1:
                Test<sbyte>(rand, random);
                break;
            case 2:
                Test<byte>(rand, random);
                break;
            case 3:
                Test<short>(rand, random);
                break;
            case 4:
                Test<ushort>(rand, random);
                break;
            case 5:
                Test<int>(rand, random);
                break;
            case 6:
                Test<uint>(rand, random);
                break;
            case 7:
                Test<long>(rand, random);
                break;
            case 8:
                Test<ulong>(rand, random);
                break;
            case 9:
                Test<float>(rand, random);
                break;
            case 10:
                Test<double>(rand, random);
                break;
            case 11:
                Test<decimal>(rand, random);
                break;
        }
    }

    private static void Test<T>(Random rand, int random)
    {
        Console.WriteLine("Entering {0} parameters for the methods.", random);
        Console.WriteLine("Chosen type: {0}", typeof(T).Name);
        Console.Write("Parameters: ");
        T[] arr = new T[random];
        for (int i = 0; i < random; i++)
        {
            T elem = (T)(dynamic)rand.Next(10);
            Console.Write("{0} ", elem);
            arr[i] = elem;
        }
        Console.WriteLine();

        Console.Write("Minimum: {0}", Minimum<T>(arr));
        Console.WriteLine();

        Console.Write("Maximum: {0}", Maximum<T>(arr));
        Console.WriteLine();

        Console.Write("Average: {0:F2}", Average<T>(arr));
        Console.WriteLine();

        Console.Write("Sum: {0}", Sum<T>(arr));
        Console.WriteLine();

        Console.Write("Product: {0}", Product<T>(arr));
        Console.WriteLine();
    }

    public static T Minimum<T>(params T[] arr)
    {
        T a = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < (dynamic)a)
            {
                a = arr[i];
            }
        }
        return a;
    }

    public static T Maximum<T>(params T[] arr)
    {
        T a = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > (dynamic)a)
            {
                a = arr[i];
            }
        }
        return a;
    }

    public static T Average<T>(params T[] arr)
    {
        T count = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            count += (dynamic)arr[i];
        }
        if (typeof(T) == typeof(System.UInt64))
        {
            return (T)(count / (dynamic)(UInt64)arr.Length);
        }
        return (T)(count / (dynamic)arr.Length);
    }

    public static T Sum<T>(params T[] arr)
    {
        T count = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            count += (dynamic)arr[i];
        }
        return count;
    }

    public static T Product<T>(params T[] arr)
    {
        T count = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            count *= (dynamic)arr[i];
        }
        return count;
    }
}
