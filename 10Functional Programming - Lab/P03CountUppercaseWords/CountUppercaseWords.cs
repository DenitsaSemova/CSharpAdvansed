using System;
using System.Linq;

namespace P03CountUppercaseWords
{
    internal class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            //Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Where(w => char.IsUpper(w[0]))
            //    .ToList()
            //    .ForEach(Console.WriteLine);

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0]))
                .Select(w =>
                {
                    Console.WriteLine(w);
                    return w;
                })
                .ToList();
        }

    }
}
