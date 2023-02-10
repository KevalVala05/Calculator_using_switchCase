using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;

            Console.WriteLine("Enter the first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Operator :");
            string operand = Console.ReadLine();

            Console.WriteLine("Enter the second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {
                case "+":
                    result = num1+ num2;
                    Console.WriteLine("Addition " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Subtraction " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Multiplication " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine("Division " + result);
                    break;

                default:
                    Console.WriteLine("Sorry, You entered a wrong operand !");
                    break;
            }

            Console.ReadLine();
        }
    }
}
