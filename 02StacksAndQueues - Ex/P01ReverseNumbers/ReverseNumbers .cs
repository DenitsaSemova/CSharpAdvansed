using System;
using System.Collections.Generic;
using System.Linq;

namespace P01ReverseNumbers
{
    internal class ReverseNumbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stackOfNums = new Stack<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                stackOfNums.Push(nums[i]);
            }

            while (stackOfNums.Count > 0)
            {
                Console.Write(stackOfNums.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
