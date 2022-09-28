using System;
using System.Collections.Generic;

namespace P02SetsOfElements
{
    internal class SetsOfElements
    {
        static void Main(string[] args)
        {
            var sets = Console.ReadLine().Split();

            int n = int.Parse(sets[0]);
            int m = int.Parse(sets[1]);

            HashSet<int> nSet = new HashSet<int>();
            HashSet<int> mSet = new HashSet<int>();


            //for (int i = 0; i < n; i++)
            //{
            //    nSet.Add(entry);

            //    entry = Int32.Parse(Console.ReadLine());
            //}


            //for (int j = 0; j < m; j++)
            //{                
            //    mSet.Add(entry);

            //    entry = Int32.Parse(Console.ReadLine());
            //}

            for (int i = 0; i < n + m; i++)
            {
                int entry = Int32.Parse(Console.ReadLine());
                
                if (i < n)
                {
                    nSet.Add(entry);
                }
                else
                {
                    mSet.Add(entry);
                }

                
            }


            foreach (var number in nSet)
            {
                if (mSet.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
