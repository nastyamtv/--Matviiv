using System;
using System.Collections.Generic;

class Program
{
    static LinkedList<LinkedList<int>> SplitArray(int[,] array)
    {
        LinkedList<int> zeros = new LinkedList<int>();
        LinkedList<int> ones = new LinkedList<int>();

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int value = array[i, j];
                if (value == 0)
                    zeros.AddLast(value);
                else if (value == 1)
                    ones.AddLast(value);
            }
        }

        LinkedList<LinkedList<int>> result = new LinkedList<LinkedList<int>>();
        result.AddLast(zeros);
        result.AddLast(ones);

        return result;
    }

    static void PrintLinkedList(LinkedList<int> linkedList)
    {
        foreach (int value in linkedList)
        {
            Console.Write(value + " ");
        }
    }

    static void Main()
    {
        int[,] array = {
            { 0, 1, 0 },
            { 1, 0, 1 },
            { 0, 0, 1 }
        };

        LinkedList<LinkedList<int>> result = SplitArray(array);

        Console.WriteLine("Array of zeros:");
        PrintLinkedList(result.First.Value);

        Console.WriteLine("\nArray of ones:");
        PrintLinkedList(result.Last.Value);
    }

    
}
