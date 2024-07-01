using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_3._4
{
    class Customer
    {
        // Data members/fields
        public int CustomerId;
        public string Name;
        public int Age;
        public string Phone;
        public string City;

        // Constructor with no arguments
        public Customer()
        {
            Console.WriteLine("Default constructor called.");
        }

        // Constructor with all information
        public Customer(int customerId, string name, int age, string phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
            Console.WriteLine("Parameterized constructor called.");
        }

        // Method to display customer information
        public void DisplayCustomer()
        {
            Console.WriteLine($"\nCustomer Details:");
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"City: {City}");
        }

        // Destructor
        ~Customer()
        {
            Console.WriteLine($"Destructor called for customer {Name}.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of Customer using default constructor
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.Name = "John Doe";
            customer1.Age = 30;
            customer1.Phone = "123-456-7890";
            customer1.City = "New York";

            customer1.DisplayCustomer();

           
            Customer customer2 = new Customer(2, "Jane Smith", 25, "987-654-3210", "Los Angeles");

   
            customer2.DisplayCustomer();

          
            Customer.DisplayCustomer();

          
        }

        
        static void DisplayCustomer()
        {
            Console.WriteLine("\nStatic method DisplayCustomer called directly without object.");
            Console.WriteLine("This method is not associated with any specific object instance.");
        }
    }
}
