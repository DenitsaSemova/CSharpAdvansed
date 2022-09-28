using System;

namespace P00PrintingMatrix
{
    internal class PrintingMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 6, 4, 8, 3 },
                { 2, 3, 5, 7, 23 },
                { 2, 3, 5, 7, 23 },
                { 2, 3, 5, 7, 23 },
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    if (col < (matrix.GetLength(1) - 1))
                    {
                        Console.Write($"{matrix[row, col]}, ");
                    }
                    else
                    {
                        Console.Write($"{matrix[row, col]}; ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
