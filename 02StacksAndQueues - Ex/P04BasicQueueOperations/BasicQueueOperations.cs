using System;
using System.Collections.Generic;
using System.Linq;

namespace P04BasicQueueOperations
{
    internal class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            Queue<int> stackOfNums = new Queue<int>();

            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int toPush = operations[0];
            int toPop = operations[1];
            int magicNum = operations[2];

            for (int i = 0; i < toPush && i < numbers.Length; i++)
            {
                stackOfNums.Enqueue(numbers[i]);
            }

            for (int i = 0; i < toPop && stackOfNums.Count > 0; i++)
            {
                stackOfNums.Dequeue();
            }

            if (stackOfNums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stackOfNums.Contains(magicNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stackOfNums.Min());
            }
        }
    }
}
