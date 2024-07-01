using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avgminmaxarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 23, 45, 67, 84, 88, 10 }; //array of integers

            //cal avg value 
            double avg = CalculateAvg(num);
            Console.WriteLine($"Average value of array elements is: {avg}");

            //finding min
            int min = Minimum(num);
            Console.WriteLine($"Minimum value in the array: {min}");

            int max = Maximum(num);
            Console.WriteLine($"Maximum value in the array: {max}");

        }

        static double CalculateAvg(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }

        static int Minimum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i<arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

        }
    } 
}
