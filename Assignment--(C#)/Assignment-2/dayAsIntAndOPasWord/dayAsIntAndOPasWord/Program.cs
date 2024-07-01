using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayAsIntAndOPasWord
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a day Number(1-7)");
            int dayNum = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            switch (dayNum)
            {
                case 1:
                    Console.WriteLine("Monday \n");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Tuesday \n");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Wednesday \n");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Thursday \n");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Friday \n");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Saturday \n");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Sunday \n");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Enter Valid Number");
                    Console.ReadLine();
                    break;
            }

        }



    }
}

