using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IStudent
{
    // Define the IStudent interface
    public interface IStudent
    {
        // Properties
        int StudentId { get; set; }
        string Name { get; set; }

        // Method
        void ShowDetails();
    }

    // Class Dayscholar implementing IStudent interface
    public class Dayscholar : IStudent
    {
        // Properties from IStudent interface
        public int StudentId { get; set; }
        public string Name { get; set; }

        // Implementing the method from IStudent interface
        public void ShowDetails()
        {
            Console.WriteLine("Dayscholar Details:");
            Console.WriteLine("Student ID: {0}", StudentId);
            Console.WriteLine("Name: {0}", Name);
        }
    }

    // Class Resident implementing IStudent interface
    public class Resident : IStudent
    {
        // Properties from IStudent interface
        public int StudentId { get; set; }
        public string Name { get; set; }

        // Implementing the method from IStudent interface
        public void ShowDetails()
        {
            Console.WriteLine("Resident Details:");
            Console.WriteLine("Student ID: {0}", StudentId);
            Console.WriteLine("Name: {0}", Name);
        }
    }

    // Test class to execute the above
    class Test
    {
        static void Main()
        {
            // Creating instances of Dayscholar and Resident
            IStudent dayscholar = new Dayscholar { StudentId = 45, Name = "Ayesha" };
            IStudent resident = new Resident { StudentId = 54, Name = "Muskan" };

            // Calling ShowDetails method to display student details
            dayscholar.ShowDetails();
            Console.WriteLine();

            resident.ShowDetails();

            Console.ReadKey();
        }
    }

}
