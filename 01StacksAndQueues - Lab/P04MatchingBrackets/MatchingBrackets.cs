using System;
using System.Collections;
using System.Collections.Generic;

namespace P04MatchingBrackets
{
    internal class MatchingBrackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var expressionFinder = new Stack<int>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    expressionFinder.Push(i);
                }

                if (input[i] == ')')
                {
                    int start = expressionFinder.Pop();
                    Console.WriteLine(input.Substring(start, i - start + 1));
                }
            }
        }
    }
}
