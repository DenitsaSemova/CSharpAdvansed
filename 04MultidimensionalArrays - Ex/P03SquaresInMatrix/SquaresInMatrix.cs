using System;
using System.Linq;

namespace P03SquaresInMatrix
{
    internal class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] chars = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    bool areEqual = matrix[row, col] == matrix[row, col + 1] && 
                                    matrix[row, col] == matrix[row + 1, col + 1] && 
                                    matrix[row, col] == matrix[row + 1, col];

                    if (areEqual)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
