using System;
using System.Linq;

namespace P03PrimaryDiagonal
{
    internal class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[0]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var cols = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cols[col];
                }
            }

            int sum = 0;
            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, row];
                                
            }

            Console.WriteLine(sum);
            
        }
    }
}
