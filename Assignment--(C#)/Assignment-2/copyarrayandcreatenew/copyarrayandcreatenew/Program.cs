using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyarrayandcreatenew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sourceArray = { 1, 2, 3, 4, 5 };

            int[] destinationArray = new int[sourceArray.Length];

            //to copy the elements
            for (int i = 0; i < sourceArray.Length; i++)
            {
                destinationArray[i] = sourceArray[i];
            }

            Console.WriteLine("Source Array:");
            Console.ReadLine();
            PrintArray(sourceArray);
            

            Console.WriteLine("\nDestination Array (copied from Source Array):");
            Console.ReadLine();
            PrintArray(destinationArray);

             void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
