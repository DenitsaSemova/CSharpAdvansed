using System;
using System.Linq;

namespace P04SymbolInMatrix
{
    internal class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] cols = Console.ReadLine().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cols[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            if (matrix.Cast<char>().Contains(symbol))
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                        if (matrix[row,col] == symbol)
                        {
                            Console.WriteLine($"({row}, {col})");
                            return;
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
        }
    }
}
