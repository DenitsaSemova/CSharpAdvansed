using System;
using System.Linq;

namespace P1MatrixOfPalindromes
{
    internal class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            int rows = input[0];
            int cols = input[1];

            string[][] matrixOfPalindromes = new string[rows][];

            for (int row = 0; row < matrixOfPalindromes.Length; row++)
            {
                matrixOfPalindromes[row] = new string[cols];

                for (int col = 0; col < matrixOfPalindromes[row].Length; col++)
                {
                    char firstLetter = alphabet[row];
                    char middleLetter = alphabet[row + col];
                   
                    matrixOfPalindromes[row][col] = $"{firstLetter}{middleLetter}{firstLetter}";

                    Console.Write($"{matrixOfPalindromes[row][col]} ");
                }
                Console.WriteLine();
            }            
        }
    }
}
