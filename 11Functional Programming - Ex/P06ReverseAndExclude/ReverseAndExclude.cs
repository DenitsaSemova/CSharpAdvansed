using System;
using System.Collections.Generic;
using System.Linq;

namespace P06ReverseAndExclude
{
    internal class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divNum = int.Parse(Console.ReadLine());

            Action<List<int>> print = p => Console.WriteLine(String.Join(" ", p));
            Action<List<int>> reverseFunc = nums => nums.Reverse();
            Func<List<int>, List<int>> removeNums = numbers => numbers.Where(x => x % divNum != 0).ToList();  
            //priema List<int> i vrushta List<int>


            reverseFunc(inputNumbers);
            inputNumbers = removeNums(inputNumbers);
            print(inputNumbers);

        }
    }
}
