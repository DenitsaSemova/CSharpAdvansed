using System;
using System.Collections.Generic;
using System.Linq;

namespace P07BalancedParenthesis
{
    internal class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            Stack<char> stackOfParenthesis = new Stack<char>();

            string parenthesis = Console.ReadLine();

            char[] openParenthesis = new char[] { '(', '[', '{' };

            bool isValid = true;

            for (int i = 0; i < parenthesis.Length; i++)
            {
                char currBracket = parenthesis[i];

                if (openParenthesis.Contains(currBracket))
                {
                    stackOfParenthesis.Push(currBracket);
                    continue;
                }

                if (stackOfParenthesis.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParenthesis.Peek() == '(' && currBracket == ')')
                {
                    stackOfParenthesis.Pop();
                }
                else if (stackOfParenthesis.Peek() == '[' && currBracket == ']')
                {
                    stackOfParenthesis.Pop();
                }
                else if (stackOfParenthesis.Peek() == '{' && currBracket == '}')
                {
                    stackOfParenthesis.Pop();
                }
            }

            if (stackOfParenthesis.Count == 0 && isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
