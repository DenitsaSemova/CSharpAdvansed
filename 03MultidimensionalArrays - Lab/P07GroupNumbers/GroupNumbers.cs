using System;
using System.Linq;

namespace P07GroupNumbers
{
    internal class GroupNumbers
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                int remainder = Math.Abs(number % 3);
                sizes[remainder]++;
            }

            int[][] matrix =
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]],
            };

            int[] offsets = new int[3];

            foreach (var number in numbers)
            {
                int remainder = Math.Abs(number % 3);
                int index = offsets[remainder];
                matrix[remainder][index] = number;
                offsets[remainder]++;
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }


            //int[][] jaggedArray = new int[3][];

            //int[] input = Console.ReadLine()
            //    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(Int32.Parse)
            //    .ToArray();

            //jaggedArray[0] = input
            //    .Where(x => Math.Abs(x) % 3 == 0)
            //    .ToArray();

            //jaggedArray[1] = input
            //    .Where(x => Math.Abs(x) % 3 == 1)
            //    .ToArray();

            //jaggedArray[2] = input
            //    .Where(x => Math.Abs(x) % 3 == 2)
            //    .ToArray();

            //foreach (var item in jaggedArray)
            //{
            //    Console.WriteLine(String.Join(" ", item));
            //}
        }
    }
}
