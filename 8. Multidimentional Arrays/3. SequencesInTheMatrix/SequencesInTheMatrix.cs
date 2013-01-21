using System;
using System.Collections.Generic;

class SequencesInTheMatrix
{
    static void Main()
    {
        int n;
        int m;
        string[,] arr;
        EnterMatrix(out n, out m, out arr);

        string longuestSeq;
        int longuestSeqLen;
        SearchHorizontal(n, m, arr, out longuestSeq, out longuestSeqLen);
        SearchVertical(n, m, arr, ref longuestSeq, ref longuestSeqLen);
        SearchFirstDiagonal(n, m, arr, ref longuestSeq, ref longuestSeqLen);
        SearchSecondDiagonal(n, m, arr, ref longuestSeq, ref longuestSeqLen);

        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0, -10}", arr[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Longuest = {0}\nLength = {1}", longuestSeq, longuestSeqLen);
    }

    private static void SearchSecondDiagonal(int n, int m, string[,] arr, ref string longuestSeq, ref int longuestSeqLen)
    {
        int iStart = 0;
        int iEnd = 0;
        int jStart = 0;
        int jEnd = 0;
        int steps = n * m;
        int forTurns = 0;
        List<int> iArr = new List<int>();
        List<int> jArr = new List<int>();
        while (steps != 0)
        {
            steps--;
            for (int i = iStart; i >= iEnd; i--)
            {
                iArr.Add(i);
            }

            forTurns++;

            if (iStart < n - 1)
            {
                iStart++;
            }
            else if (forTurns >= m)
            {
                iEnd++;
            }
        }

        forTurns = 0;
        steps = n * m;
        while (steps != 0)
        {
            steps--;
            for (int j = jStart; j <= jEnd; j++)
            {
                jArr.Add(j);
            }

            forTurns++;

            if (jEnd < m - 1)
            {
                jEnd++;
            }

            if (forTurns >= n)
            {
                jStart++;
            }
        }

        for (int i = 0; i < n * m; i++)
        {
            string seq = arr[iArr[i], jArr[i]];
            int len = 1;
            for (int j = i + 1; j < n * m; j++)
            {
                if (arr[iArr[j], jArr[j]] == seq)
                {
                    len++;
                }
                else
                {
                    if (len > longuestSeqLen)
                    {
                        longuestSeqLen = len;
                        longuestSeq = seq;
                    }
                    seq = arr[iArr[j], jArr[j]];
                    len = 1;
                }
            }

            if (len > longuestSeqLen)
            {
                longuestSeqLen = len;
                longuestSeq = seq;
            }
        }
    }

    private static void SearchFirstDiagonal(int n, int m, string[,] arr, ref string longuestSeq, ref int longuestSeqLen)
    {
        int iStart = n - 1;
        int iEnd = n - 1;
        int jStart = 0;
        int jEnd = 0;
        int steps = n * m;
        int forTurns = 0;
        List<int> iArr = new List<int>();
        List<int> jArr = new List<int>();
        while (steps != 0)
        {
            steps--;
            for (int i = iStart; i <= iEnd; i++)
            {
                iArr.Add(i);
            }

            forTurns++;

            if (iStart > 0)
            {
                iStart--;
            }
            else if (forTurns >= m)
            {
                iEnd--;
            }
        }

        forTurns = 0;
        steps = n * m;
        while (steps != 0)
        {
            steps--;
            for (int j = jStart; j <= jEnd; j++)
            {
                jArr.Add(j);
            }

            forTurns++;

            if (jEnd < m - 1)
            {
                jEnd++;
            }

            if (forTurns >= n)
            {
                jStart++;
            }
        }

        for (int i = 0; i < n * m; i++)
        {
            string seq = arr[iArr[i], jArr[i]];
            int len = 1;
            for (int j = i + 1; j < n * m; j++)
            {
                if (arr[iArr[j], jArr[j]] == seq)
                {
                    len++;
                }
                else
                {
                    if (len > longuestSeqLen)
                    {
                        longuestSeqLen = len;
                        longuestSeq = seq;
                    }
                    seq = arr[iArr[j], jArr[j]];
                    len = 1;
                }
            }

            if (len > longuestSeqLen)
            {
                longuestSeqLen = len;
                longuestSeq = seq;
            }
        }
    }

    private static void SearchVertical(int n, int m, string[,] arr, ref string longuestSeq, ref int longuestSeqLen)
    {
        for (int i = 0; i < m; i++)
        {
            string seq = arr[0, i];
            int len = 1;
            for (int j = 1; j < n; j++)
            {
                if (arr[j, i] == seq)
                {
                    len++;
                }
                else
                {
                    if (len > longuestSeqLen)
                    {
                        longuestSeqLen = len;
                        longuestSeq = seq;
                    }
                    seq = arr[j, i];
                    len = 1;
                }
            }

            if (len > longuestSeqLen)
            {
                longuestSeqLen = len;
                longuestSeq = seq;
            }
        }
    }

    private static void SearchHorizontal(int n, int m, string[,] arr, out string longuestSeq, out int longuestSeqLen)
    {
        longuestSeq = null;
        longuestSeqLen = 0;
        for (int i = 0; i < n; i++)
        {
            string seq = arr[i, 0];
            int len = 1;
            for (int j = 1; j < m; j++)
            {
                if (arr[i, j] == seq)
                {
                    len++;
                }
                else
                {
                    if (len > longuestSeqLen)
                    {
                        longuestSeqLen = len;
                        longuestSeq = seq;
                    }
                    seq = arr[i, j];
                    len = 1;
                }
            }

            if (len > longuestSeqLen)
            {
                longuestSeqLen = len;
                longuestSeq = seq;
            }
        }
    }

    private static void EnterMatrix(out int n, out int m, out string[,] arr)
    {
        Console.Write("Enter N: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        m = int.Parse(Console.ReadLine());

        arr = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{{{0}, {1}}} = ", i, j);
                arr[i, j] = Console.ReadLine();
            }
        }
    }
}
