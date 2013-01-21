using System;
using System.Text;

class MultitaskProgram
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        while (true)
        {
            Console.WriteLine("1. Reverse digits of a number");
            Console.WriteLine("2. Calulate the average of a sequence of integers");
            Console.WriteLine("3. Solve the linear equation a * x + b = 0");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("Input: ");
            string n = Console.ReadLine();

            if (n == "1")
            {
                Point1();
            }
            else if (n == "2")
            {
                Point2();
            }
            else if (n == "3")
            {
                Point3();
            }
            if (n == "4")
            {
                break;
            }
        }
    }

    private static void Point3()
    {
        decimal result;
        do
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a should not be 0 (zero)");
                continue;
            }
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            result = SolveLinearEquation(a, b);

            Console.WriteLine();
            Console.WriteLine("X is {0:F2}", result);
            Console.WriteLine();
            break;
        } while (true);
    }

    private static decimal SolveLinearEquation(int a, int b)
    {
        return (-b) / a;
    }

    private static void Point2()
    {
        decimal average;
        do
        {
            Console.WriteLine("Enter as much numbers as you like, separated with spaces.\nIf you wish to stop, just press Enter.");
            string numbers = Console.ReadLine();

            average = CountTheAverage(numbers);

            Console.WriteLine();
            if (average != -1)
            {
                Console.WriteLine("The average if the sequence is {0:F2}", average);
            }
            else
            {
                Console.WriteLine("The sequence is empty or has invalid members.");
            }
            Console.WriteLine();
        } while (average == -1);
    }

    private static decimal CountTheAverage(string numbers)
    {
        string[] nums = numbers.Split();
        int count = 0;
        int amount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != "")
            {
                int a;
                bool isCorrect = int.TryParse(nums[i], out a);
                if (isCorrect)
                {
                    count += a;
                    amount++;
                }
                else
                {
                    return -1;
                }
            }
        }

        if (amount == 0)
        {
            return -1;
        }
        else
        {
            return (decimal)count / (decimal)amount;
        }
    }

    private static void Point1()
    {
        decimal number;
        do
        {
            Console.Write("Enter decimal non-negative number: ");
            string strNumber = Console.ReadLine();
            number = ReverseNumber(strNumber);

            Console.WriteLine();
            if (number != -1)
            {
                Console.WriteLine("The reversed number is {0}", number);
            }
            else
            {
                Console.WriteLine("The number is negative or invalid.");
            }
            Console.WriteLine();
        } while (number == -1);
    }

    private static decimal ReverseNumber(string number)
    {
        StringBuilder sb = new StringBuilder();
        decimal num = 0M;
        bool isCorrect = decimal.TryParse(number, out num);
        for (int i = number.Length - 1; i >= 0; i--)
        {
            sb.Append(number[i]);
        }

        if (!isCorrect)
        {
            return -1;
        }

        return decimal.Parse(sb.ToString());
    }
}
