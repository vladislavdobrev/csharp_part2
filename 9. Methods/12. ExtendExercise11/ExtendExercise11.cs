using System;
using System.Text;

class ExtendExercise11
{
    static void Main()
    {
        int[] a = { 5, 0, 1 };
        int[] b = { 2, 2, -2, 2, 2 };
        Console.Write("Polynom a: {0}", PrintPolynom(a));
        Console.Write("Polynom b: {0}", PrintPolynom(b));

        int[] temp = Add(a, b);
        Console.Write("Polynom a + b: {0}", PrintPolynom(temp));

        temp = Substract(a, b);
        Console.Write("Polynom a - b: {0}", PrintPolynom(temp));

        temp = Substract(b, a);
        Console.Write("Polynom b - a: {0}", PrintPolynom(temp));

        temp = Multiply(a, b);
        Console.Write("Polynom a * b: {0}", PrintPolynom(temp));
    }

    public static int[] Add(int[] a, int[] b)
    {
        int[] result = new int[Math.Max(a.Length, b.Length)];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] += a[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            result[i] += b[i];
        }
        return result;
    }

    public static int[] Substract(int[] a, int[] b)
    {
        int[] result = new int[Math.Max(a.Length, b.Length)];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] += a[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            result[i] -= b[i];
        }
        return result;
    }

    public static int[] Multiply(int[] a, int[] b)
    {
        int[] result = new int[Math.Max(a.Length, b.Length)];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 1;
        }

        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            result[i] *= b[i];
        }
        return result;
    }

    private static string PrintPolynom(int[] temp)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                if (temp[i] < 0)
                {
                    sb.AppendFormat("- {0} ", Math.Abs(temp[i]));
                }
                else
                {
                    sb.AppendFormat("+ {0} ", temp[i]);
                }
            }
            else if (i == temp.Length - 1)
            {
                if (temp[i] < 0)
                {
                    sb.AppendFormat("- {0}x^{1} ", Math.Abs(temp[i]), i);
                }
                else
                {
                    sb.AppendFormat("{0}x^{1} ", temp[i], i);
                }
            }
            else
            {
                if (temp[i] < 0)
                {
                    sb.AppendFormat("- {0}x^{1} ", Math.Abs(temp[i]), i);
                }
                else
                {
                    sb.AppendFormat("+ {0}x^{1} ", temp[i], i);
                }
            }
        }
        sb.AppendLine();
        return sb.ToString();
    }
}
