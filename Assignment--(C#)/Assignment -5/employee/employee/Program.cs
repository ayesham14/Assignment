using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Employee
    {
        // Properties
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }

        // Constructor to initialize Empid, Empname, and Salary
        public Employee(int empid, string empname, float salary)
        {
            Empid = empid;
            Empname = empname;
            Salary = salary;
        }

        // Method to display employee details
        public void Display()
        {
            Console.WriteLine("Employee ID: {0}", Empid);
            Console.WriteLine("Employee Name: {0}", Empname);
            Console.WriteLine("Salary: {0}", Salary);
        }
    }

    // Derived class ParttimeEmployee inheriting from Employee
    class ParttimeEmployee : Employee
    {
        // Additional member specific to ParttimeEmployee
        public float Wages { get; set; }

        // Constructor to initialize base class Employee and Wages
        public ParttimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary)
        {
            Wages = wages;
        }

        // Method to display part-time employee details
        public new void Display() // Using 'new' to hide base class Display() method
        {
            base.Display(); // Call base class method to display Empid, Empname, and Salary
            Console.WriteLine("Wages: {0}", Wages); // Display Wages specific to ParttimeEmployee
        }
    }

   
    class Test  // Testing class to execute the above
    {
        static void Main()
        {
            // Create an instance of ParttimeEmployee
            ParttimeEmployee partTimeEmp = new ParttimeEmployee(50, "Ayesha", 45000, 14);

            // Display part-time employee details
            Console.WriteLine("Part-time Employee Details:");
            partTimeEmp.Display();

            Console.ReadKey();
        }
    }
}


