using System;
using System.Collections.Generic;
using System.Linq;

namespace P2SimpleCalculator
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var values = input.Split();

            var calculatorStack = new Stack<string>(values.Reverse());

            while (calculatorStack.Count > 1)
            {
                int firstOperant = Int32.Parse(calculatorStack.Pop());
                string operand = calculatorStack.Pop();
                int secondOperant = Int32.Parse(calculatorStack.Pop());

                switch (operand)
                {
                    case "+":
                        calculatorStack.Push((firstOperant + secondOperant).ToString());
                        break;
                    case "-":
                        calculatorStack.Push((firstOperant - secondOperant).ToString());
                        break;
                    //default:
                    //    calculatorStack.Push(0.ToString());
                    //    break;
                }
            }

            Console.WriteLine(calculatorStack.Pop());
        }
    }
}
