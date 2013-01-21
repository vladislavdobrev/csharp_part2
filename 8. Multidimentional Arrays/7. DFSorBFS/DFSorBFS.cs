/*
 * Breadth-first search
 * Queue
 */

using System;
using System.Collections.Generic;

class DFSorBFS
{
    struct Element
    {
        private int number;
        private int x;
        private int y;

        public Element(int num, int x, int y)
        {
            this.number = num;
            this.x = x;
            this.y = y;
        }

        public int Number
        {
            get
            {
                return this.number;
            }
        }
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public static Element[,] ArrayOfIntegersToArrayOfStructs(int[,] matrix)
        {
            Element[,] arr = new Element[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    arr[i, j] = new Element(matrix[i, j], i, j);
                }
            }
            return arr;
        }
    }

    static void Main()
    {
        int[,] matrix =
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1},
        };

        Element[,] arr = Element.ArrayOfIntegersToArrayOfStructs(matrix);

        int maxLen;
        int maxInt;
        DoTheMagic(arr, out maxLen, out maxInt);

        Console.WriteLine("The count of the largest area of equal\nelements is {0} and the element is {1}.", maxLen, maxInt);
    }

    private static void DoTheMagic(Element[,] arr, out int maxLen, out int maxInt)
    {
        maxLen = 0;
        maxInt = 0;
        List<Element> visited = new List<Element>();
        Queue<Element> queue = new Queue<Element>();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            bool flag = false;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (visited.Count == arr.Length)
                {
                    flag = true;
                    break;
                }

                int len = 1;
                int currElem = 0;
                do
                {
                    Element currentElem;
                    if (queue.Count == 0)
                    {
                        currentElem = arr[i, j];
                    }
                    else
                    {
                        currentElem = queue.Dequeue();
                    }
                    currElem = currentElem.Number;
                    visited.Add(currentElem);
                    int x = currentElem.X;
                    int y = currentElem.Y;

                    // Check up
                    if (currentElem.X > 0 && arr[x - 1, y].Number == currentElem.Number && !visited.Contains(arr[x - 1, y]))
                    {
                        queue.Enqueue(arr[x - 1, y]);
                        len++;
                    }

                    // Check right
                    if (currentElem.Y < arr.GetLength(1) - 1 && arr[x, y + 1].Number == currentElem.Number && !visited.Contains(arr[x, y + 1]))
                    {
                        queue.Enqueue(arr[x, y + 1]);
                        len++;
                    }

                    // Check bottom
                    if (currentElem.X < arr.GetLength(0) - 1 && arr[x + 1, y].Number == currentElem.Number && !visited.Contains(arr[x + 1, y]))
                    {
                        queue.Enqueue(arr[x + 1, y]);
                        len++;
                    }

                    // Check left
                    if (currentElem.Y > 0 && arr[x, y - 1].Number == currentElem.Number && !visited.Contains(arr[x, y - 1]))
                    {
                        queue.Enqueue(arr[x, y - 1]);
                        len++;
                    }
                } while (queue.Count > 0);

                if (len > maxLen)
                {
                    maxLen = len;
                    maxInt = currElem;
                }
            }
            if (flag)
            {
                break;
            }
        }
    }
}
