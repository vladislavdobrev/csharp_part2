using System;
using System.Text;

class Matrix
{
    private int n;
    private int m;
    private int[,] content;

    public int[,] Content
    {
        get { return content; }
        set
        {
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    this.content[i, j] = value[i, j];
                }
            }
        }
    }

    public int N
    {
        get { return this.n; }
        set { this.n = value; }
    }

    public int M
    {
        get { return this.m; }
        set { this.m = value; }
    }

    public Matrix(int n, int m)
    {
        this.content = new int[n, m];
        this.n = n;
        this.m = m;
    }

    public Matrix(Matrix x)
        : this(x.N, x.M)
    {
        this.N = x.N;
        this.M = x.M;
        this.Content = x.Content;
    }

    public void ReadMatrix()
    {
        for (int i = 0; i < this.n; i++)
        {
            for (int j = 0; j < this.m; j++)
            {
                Console.Write("Enter [{0}, {1}]: ", i, j);
                this.content[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void ReadRandomMatrix()
    {
        Random rand = new Random();
        for (int i = 0; i < this.n; i++)
        {
            for (int j = 0; j < this.m; j++)
            {
                System.Threading.Thread.Sleep(1);
                int newSeed = rand.Next();
                rand = new Random(newSeed);
                int rndNum = rand.Next(100);
                this.content[i, j] = rndNum;
            }
        }
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        Matrix temp = new Matrix(a);
        for (int i = 0; i < temp.N; i++)
        {
            for (int j = 0; j < temp.M; j++)
            {
                temp.Content[i, j] += b.Content[i, j];
            }
        }
        return temp;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        Matrix temp = new Matrix(a);
        for (int i = 0; i < a.N; i++)
        {
            for (int j = 0; j < a.M; j++)
            {
                temp.Content[i, j] -= b.Content[i, j];
            }
        }
        return temp;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        int[,] result = new int[a.N, b.M];
        int iDimention = 0;
        int jDimention = 0;
        int loop = a.N * b.M;
        while (loop > 0)
        {
            int[] iArr = new int[a.M];
            for (int i = 0; i < a.M; i++)
            {
                iArr[i] = a.Content[iDimention, i];
            }

            int[] jArr = new int[b.N];
            for (int i = 0; i < b.N; i++)
            {
                jArr[i] = b.Content[i, jDimention];
            }

            int sum = 0;
            for (int i = 0; i < a.M; i++)
            {
                sum += iArr[i] * jArr[i];
            }

            result[iDimention, jDimention] = sum;
            jDimention++;
            if (jDimention == b.M)
            {
                jDimention = 0;
                iDimention++;
            }
            loop--;
        }
        Matrix temp = new Matrix(a.N, b.M);
        temp.Content = result;
        return temp;
    }

    public int this[int i, int j]
    {
        get { return this.content[i, j]; }
        set { this.content[i, j] = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine();
        for (int i = 0; i < this.n; i++)
        {
            for (int j = 0; j < this.m; j++)
            {
                sb.AppendFormat("{0, -10}", this.content[i, j]);
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }

    static void Main()
    {
        Matrix a = new Matrix(3, 3);
        Matrix b = new Matrix(3, 3);
        a.ReadRandomMatrix();
        b.ReadRandomMatrix();
        Console.WriteLine("Matrix a");
        Console.WriteLine(a.ToString());
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Matrix b");
        Console.WriteLine(b.ToString());
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("a + b");
        Matrix temp = new Matrix(a + b);
        Console.WriteLine(temp.ToString());
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("a - b");
        temp = new Matrix(a - b);
        Console.WriteLine(temp.ToString());
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("a * b");
        temp = new Matrix(a * b);
        Console.WriteLine(temp.ToString());
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Change by indexing");
        Console.WriteLine("a[1, 2] = {0} * 2 = {1}\nb[1, 1] = {2} * 2 = {3}", a[1, 2], a[1, 2] *= 2, b[1, 1], b[1, 1] *= 2);
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("New arrays:");
        Console.WriteLine("Matrix a");
        Console.WriteLine(a.ToString());
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Matrix b");
        Console.WriteLine(b.ToString());
        Console.WriteLine(new string('-', 30));
    }
}
