using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        Console.WriteLine("До сортировки:");
        PrintArray(a);

        SortArray(ref a);

        Console.WriteLine("После сортировки:");
        PrintArray(a);
    }

    private static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    private static void SortArray(ref int[,] array)
    {
        int[] flatArray = new int[array.Length];
        int index = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                flatArray[index++] = array[i, j];
            }
        }
        
        Array.Sort(flatArray);

        index = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = flatArray[index++];
            }
        }
    }
}
