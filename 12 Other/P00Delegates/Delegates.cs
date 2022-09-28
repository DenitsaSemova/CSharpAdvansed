using System;

namespace P00Delegates
{
    internal class Delegates
    {
        public delegate string BynaryOperator(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator(4, 5, Multiply));
            Console.WriteLine(Calculator(4, 5, Add));
            Console.WriteLine(Calculator(4, 5, IsGreater));
        }

        public static string Calculator(int x, int y, BynaryOperator opr)
        {
            return opr(x, y);
        }

        public static string Multiply(int x, int y)
        {
            return (x * y).ToString();
        }

        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }

        public static string IsGreater(int z, int m)
        {
            return (z > m).ToString();
        }
    }
}
