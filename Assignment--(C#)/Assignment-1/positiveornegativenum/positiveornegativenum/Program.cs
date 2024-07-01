using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveornegativenum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            // Check 
            if (num > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (num< 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            Console.ReadKey();
        }
    }
}
