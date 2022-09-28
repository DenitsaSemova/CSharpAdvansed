using System;
using System.Collections.Generic;

namespace P08StackFibonacci
{
    internal class StackFibonacci
    {
        static void Main(string[] args)
        {
            Stack<long> fibonacci = new Stack<long>();

            int n = int.Parse(Console.ReadLine());

            fibonacci.Push(0);
            fibonacci.Push(1);
            // 0 1 1 2 3 4 8 13 21...

            for (int i = 0; i < n - 1; i++)
            {
                long firstNum = fibonacci.Pop();
                long secondNum = fibonacci.Peek();

                fibonacci.Push(firstNum);
                fibonacci.Push(firstNum + secondNum);
            }

            Console.WriteLine(fibonacci.Peek());
        }
    }
}
