using System;

namespace P01ActionPrint
{
    internal class ActionPrint
    {
        static void Main(string[] args)
        {
            Action<string[]> print = names => Console.WriteLine(string.Join("\n", names));

            string[] inputNames = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            print(inputNames);
        }
    }
}
