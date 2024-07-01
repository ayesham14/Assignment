﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctor
{
    public class Doctor
    {
        // Private fields
        private int regnNo;
        private string name;
        private double feesCharged;

        // Property for RegnNo with both getter and setter
        public int RegnNo
        {
            get { return regnNo; }
            set { regnNo = value; }
        }

        // Property for Name with both getter and setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Property for FeesCharged with both getter and setter
        public double FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }

        // Constructor to initialize the Doctor object
        public Doctor(int regnNo, string name, double feesCharged)
        {
            RegnNo = regnNo;
            Name = name;
            FeesCharged = feesCharged;
        }

        // Method to display Doctor information
        public void DisplayDoctorInfo()
        {
            Console.WriteLine($"Doctor Details:");
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fees Charged: ${FeesCharged}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating a Doctor object and setting properties
            Doctor doctor1 = new Doctor(1234, "Dr. Smith", 1500.0);

            // Displaying doctor information using the DisplayDoctorInfo method
            doctor1.DisplayDoctorInfo();

            // Using properties to change and display values
            Console.WriteLine("\nUpdating Doctor Information:");
            doctor1.Name = "Dr. John";
            doctor1.FeesCharged = 2000.0;
            doctor1.DisplayDoctorInfo();


            Console.ReadKey();
        }
    }
}