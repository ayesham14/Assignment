using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 7, 2, 30 };

            var result = numbers.Where(n => n * n > 20)
                                 .Select(n => $"{n} - {n * n}");

            foreach (var item in result)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}
