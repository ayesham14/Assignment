using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform the operations
            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;
            double quotient = 0;

            //  division by zero
            if (num2 != 0)
            {
                quotient = num1 / num2;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            // Display the result
            Console.WriteLine("Results:");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            if (num2 != 0)
            {
                Console.WriteLine("Quotient: " + quotient);
            }

            Console.ReadKey();
        }
    }
}
