using System;
using System.Collections.Generic;
using System.Linq;

namespace P05SequenceWithQueue
{
    internal class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());

            Queue<long> queue = new Queue<long>();
            List<long> resultNumbers = new List<long>();

            queue.Enqueue(inputNumber);
            resultNumbers.Add(inputNumber);

            for (int i = 0; i < 17; i++)
            {

                long currNum = queue.Dequeue();

                long a = currNum + 1;
                long b = currNum * 2 + 1;
                long c = currNum + 2;

                queue.Enqueue(a);
                queue.Enqueue(b);
                queue.Enqueue(c);

                resultNumbers.Add(a);
                resultNumbers.Add(b);
                resultNumbers.Add(c);

            }

            Console.WriteLine(String.Join(" ", resultNumbers.Take(50)));
        }
    }
}
