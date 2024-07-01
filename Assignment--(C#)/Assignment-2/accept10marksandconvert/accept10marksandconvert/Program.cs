using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept10marksandconvert
{
    internal class Program
    {
        static void Main()
        {

            int[] marks = new int[10];
            Console.WriteLine("Enter ten marks: ");

            for (int i=0; i<10; i++) //to get input from the user
            {
                Console.WriteLine("Marks {0}: ", i+1);
                marks[i] = int.Parse(Console.ReadLine());
            }

            int t = CalculateT(marks); //to cal total marks
            Console.WriteLine("Total Marks : " + t);

            double average = CalculateAvg(marks);
            Console.WriteLine($"Average Marks: {average}");

            int min = FindMin(marks);
            Console.WriteLine($"Minimum Marks: {min}");

            int max = FindMin(marks);
            Console.WriteLine($"Minimum Marks: {max}");

            int[] ascending = SortAscending(marks);
            Console.WriteLine($"Marks in Ascending order: {ascending}");
            PrintArray(ascending);

            int[] descending = SortAscending(marks);
            Console.WriteLine($"Marks in descending order: {descending}");
            PrintArray(descending);
        }

        static int CalculateT(int[] marks)
        {
            int sum = 0;
            foreach (int m in marks)
            {
                
                sum =  marks + sum;
            }
            return sum;
        }

        static double CalculateAvg(int[] marks)
        {
            int sum = 0;
            foreach (int num in marks)
            {
                sum += num;
            }
            return (double)sum / marks.Length;
        }

        static int FindMin(int[] marks)
        {
            int min = marks[0];
            foreach (int m in marks)
            {
                if(m < min)
                {
                    min = m;
                }
            }
            return min;
        }
        static int FindMax(int[] marks)
        {
            int min = marks[0];
            foreach (int m in marks)
            {
                if (m > min)
                {
                    min = m;
                }
            }
            return min;
        }
        static int[] SortAscending(int[] marks)
        {
            int[] ascendingOrder = new int[marks.Length];
            Array.Copy(marks, ascendingOrder, marks.Length);
            Array.Sort(ascendingOrder);
            return ascendingOrder;
        }
        static int[] SortDescending(int[] marks)
        {
            int[] descendingOrder = new int[marks.Length];
            Array.Copy(marks, descendingOrder, marks.Length);
            Array.Sort(descendingOrder);
            Array.Reverse(descendingOrder);
            return descendingOrder;
        }
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    }
}
