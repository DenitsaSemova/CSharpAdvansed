using System;
using System.Collections.Generic;
using System.Linq;

namespace P03MaximumElement
{
    internal class MaximumElement
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();

            int operationsCount = int.Parse(Console.ReadLine());
            maxNumbers.Push(int.MinValue);

            for (int i = 0; i < operationsCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int command = input[0];

                if (command == 1)
                {
                    int currNum = input[1];
                    numbers.Push(currNum);

                    if (numbers.Peek() > maxNumbers.Peek())
                    {
                        maxNumbers.Push(currNum);
                    }
                }
                else if (command == 2)
                {
                    if (numbers.Pop() == maxNumbers.Peek())
                    {
                        maxNumbers.Pop();
                    }
                }
                else if (command == 3)
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
