using System;
using System.Collections;
using System.Collections.Generic;

namespace P00LabStacksAndQueues
{
    internal class ReverseStrings
    {
        static void Main(string[] args)
        {
            Stack<char> stringReverser = new Stack<char>();

            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                stringReverser.Push(ch);
            }

            foreach (var item in stringReverser)
            {
                Console.Write(item);
            }

            

            //while (stringReverser.Count >= 0)
            //{
            //    char element;

            //    if (stringReverser.TryPop(out element))
            //    {
            //        Console.Write(element);

            //    }
            //    else
            //    {
            //        break;
            //    }

            //}

            

            Console.WriteLine();
        }
    }
}
