using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp1
{
    internal class NumberIfStatement
    {

        public void ReturnIfNotSameOrMultiply()
        {
            Console.WriteLine("Please enter a number:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.WriteLine("Please enter the second number:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.WriteLine("If you enter two numbers that are the same I will add the together");
            Console.WriteLine("If you enter two numbers that are different I will multiply them");

             if (num1 == num2)
            {
                double sum = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {sum}");
            }
            else
            {
                double sum = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {sum}");
            }
        }
    }
}
