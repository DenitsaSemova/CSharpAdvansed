using System;
using System.Collections.Generic;
using System.Linq;

namespace P04EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //trqbva da printira samo pyrvoto chislo, koeto se povtarq. 
            //vtoroto reshenie printira vsichki povtarqshti se chisla

            Dictionary<int, int> countOfNumbers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (countOfNumbers.ContainsKey(currNum) == false)
                {
                    countOfNumbers.Add(currNum, 1);
                }
                else
                {
                    countOfNumbers[currNum]++;
                }
            }

            var evenNumber = countOfNumbers.First(x => x.Value % 2 == 0).Key;

            Console.WriteLine(evenNumber);


            //int n = int.Parse(Console.ReadLine());

            //HashSet<int> odd = new HashSet<int>();
            //HashSet<int> even = new HashSet<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());

            //    if (odd.Contains(number))
            //    {
            //        even.Add(number);
            //    }
            //    else
            //    {
            //        odd.Add(number);
            //    }
            //}

            //foreach (var num in even)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}
