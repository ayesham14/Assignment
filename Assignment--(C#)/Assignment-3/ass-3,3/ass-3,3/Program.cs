using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_3_3
{
    class SaleDetails
    {
        // Data members/fields
        private int SalesNo;
        private int ProductNo;
        private decimal Price;
        private DateTime DateOfSale;
        private int Qty;
        private decimal TotalAmount;

        // Constructor to initialize sale details
        public SaleDetails(int salesNo, int productNo, decimal price, int qty, DateTime dateOfSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;

            // Calculate total amount
            Sales();
        }

        // Method to calculate total amount based on quantity and price
        public void Sales()
        {
            TotalAmount = Qty * Price;
        }

        // Method to display sale data
        public void ShowData()
        {
            Console.WriteLine("Sale Details:");
            Console.WriteLine($"Sales Number: {SalesNo}");
            Console.WriteLine($"Product Number: {ProductNo}");
            Console.WriteLine($"Price per unit: ${Price}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Date of Sale: {DateOfSale.ToShortDateString()}");
            Console.WriteLine($"Total Amount: ${TotalAmount}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of SaleDetails
            DateTime today = DateTime.Today;
            SaleDetails sale = new SaleDetails(1001, 2001, 25.50m, 10, today);

            // Display sale details
            sale.ShowData();
        }
    }
}
