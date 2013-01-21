using System;
using System.Text;

class AddPolynoms
{
    static void Main()
    {
        int[] a = { 5, 0, 1 };
        int[] b = { 2, 2, 2, 2, 2 };
        Console.Write("Polynom a: {0}", PrintPolynom(a));
        Console.Write("Polynom b: {0}", PrintPolynom(b));

        int[] temp = Add(a, b);
        Console.Write("Polynom a + b: {0}", PrintPolynom(temp));
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

    private static string PrintPolynom(int[] temp)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                sb.AppendFormat("{0} ", temp[i]);
            }
            else if (i == 1)
            {
                sb.AppendFormat("{0}x + ", temp[i]);
            }
            else
            {
                sb.AppendFormat("{0}x^{1} + ", temp[i], i);
            }
        }
        sb.AppendLine();
        return sb.ToString();
    }
}
