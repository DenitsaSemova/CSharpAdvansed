using System;
using System.Linq;

namespace P08CustomComparator
{
    internal class CustomComparator
    {
        static void Main(string[] args)
        {
            Action<int[]> print = p => Console.WriteLine(String.Join(" ", p));

            Func<int, int, int> sortFunc = (a, b) =>    //priema int i int i vrushta int 
                                (a % 2 == 0 && b % 2 != 0) ? -1 : //ako e vqrno da vurne -1 (mesti nalqvo) (pri 0 ne se mesti)
                                (a % 2 != 0 && b % 2 == 0) ? 1 :  //ako gornoto ne e vqrno da vurne 1 (mesti nadqsno)
                                a.CompareTo(b);                   //sravnqvane - ako a > b = 1; a = b = 0; a < b = -1;


            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(inputNums, new Comparison<int>(sortFunc));

            print(inputNums);
        }
    }
}
