using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfTwoIntAndreturnTripleTheSumIfTwoNoSame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Two Numbers: ");

            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //sum
            int sum = num1 + num2;

            //Check if numbers are same
            if (num1 == num2)
            {
                int result = 3 * sum;
                Console.WriteLine($"The numbers are same, the triple of the integer is: {result}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"The sum of the two integers is: {sum}");
                Console.ReadLine();
                
            }


        }
    }
}
