using System;
using System.Collections.Generic;

namespace P09SimpleTextEditor
{
    internal class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string text = string.Empty;

            int operationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < operationsCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string currCommand = input[0];

                if (currCommand == "1")
                {
                    string currText = input[1];
                    stack.Push(text);

                    text += currText;
                }
                else if (currCommand == "2")
                {
                    int count = int.Parse(input[1]);

                    if (count > text.Length)
                    {
                        count = Math.Min(count, text.Length);
                    }

                    stack.Push(text);
                    text = text.Substring(0, text.Length - count);
                }
                else if (currCommand == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (currCommand == "4")
                {
                    text = stack.Pop();
                }
            }
        }
    }
}
