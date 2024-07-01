using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class scholarships
{
    public class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            double scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2 * fees; // 20% fees
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3 * fees; // 30% fees
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5 * fees; // 50% fees
            }
            else
            {
                throw new ArgumentException("Invalid marks. Marks should be between 70 and 100.");
            }

            return scholarshipAmount;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Scholarship scholarship = new Scholarship();

                // Test cases
                int marks1 = 75;
                double fees1 = 10000;
                Console.WriteLine($"Marks: {marks1}, Fees: ${fees1}");
                Console.WriteLine($"Scholarship Amount: ${scholarship.Merit(marks1, fees1)}");

                int marks2 = 85;
                double fees2 = 12000;
                Console.WriteLine($"Marks: {marks2}, Fees: ${fees2}");
                Console.WriteLine($"Scholarship Amount: ${scholarship.Merit(marks2, fees2)}");

                int marks3 = 95;
                double fees3 = 15000;
                Console.WriteLine($"Marks: {marks3}, Fees: ${fees3}");
                Console.WriteLine($"Scholarship Amount: ${scholarship.Merit(marks3, fees3)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.ReadKey();
        }
    }


}
