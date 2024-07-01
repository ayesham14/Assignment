using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping: num1 = " + num1 + ", num2 = " + num2);

            // Swap 
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Before swapping: num1 = " + num1 + ", num2 = " + num2);

            Console.ReadKey();
        }
    }
}
