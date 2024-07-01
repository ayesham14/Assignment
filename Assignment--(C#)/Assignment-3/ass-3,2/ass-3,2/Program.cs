using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_3_2
{
    class Student
    {
        // Data members/fields
        private int rollNo;
        private string name;
        private string className;
        private string semester;
        private string branch;
        private int[] marks = new int[5]; // Array to store marks of 5 subjects

        // Constructor to initialize student details
        public Student(int rollNo, string name, string className, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        // Method to input marks for 5 subjects
        public void GetMarks()
        {
            Console.WriteLine($"Enter marks for {name}:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Method to display result based on average marks
        public void DisplayResult()
        {
            // Calculate average marks
            double average = CalculateAverage();

            // Check conditions for passing or failing
            bool isFailed = false;
            foreach (int mark in marks)
            {
                if (mark < 35)
                {
                    isFailed = true;
                    break;
                }
            }

            if (!isFailed && average >= 50)
            {
                Console.WriteLine($"Result: Passed");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Result: Failed");
                Console.ReadLine();
            }
        }

        // Method to calculate average marks
        private double CalculateAverage()
        {
            double sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return sum / marks.Length;
        }

        // Method to display all student data
        public void DisplayData()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Roll Number: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
                Console.ReadLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of Student
            Student student = new Student(1001, "John Doe", "XII", "Spring 2024", "Science");

            // Input marks for the student
            student.GetMarks();

            // Display student data
            student.DisplayData();

            // Display result based on marks
            student.DisplayResult();
        }
    }
}
