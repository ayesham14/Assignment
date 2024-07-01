using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_3_1
{
    internal class Account
    {
        
            class Accounts
        {
            // Data members/fields
            private int accountNumber;
            private string customerName;
            private string accountType;
            private char transactionType;
            private decimal amount;
            private decimal balance;

            // Constructor
            public Accounts(int accNo, string custName, string accType)
            {
                accountNumber = accNo;
                customerName = custName;
                accountType = accType;
                balance = 0; // Initial balance is set to 0
            }

            // Method to deposit amount
            public void Deposit(decimal depositAmount)
            {
                if (depositAmount > 0)
                {
                    transactionType = 'D';
                    amount = depositAmount;
                    balance += amount;
                    Console.WriteLine($"Successfully deposited ${amount}. Current balance: ${balance}");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount. Please enter a positive amount.");
                }
            }

            // Method to withdraw amount
            public void Withdraw(decimal withdrawAmount)
            {
                if (withdrawAmount > 0 && withdrawAmount <= balance)
                {
                    transactionType = 'W';
                    amount = withdrawAmount;
                    balance -= amount;
                    Console.WriteLine($"Successfully withdrew ${amount}. Current balance: ${balance}");
                }
                else if (withdrawAmount <= 0)
                {
                    Console.WriteLine("Invalid withdrawal amount. Please enter a positive amount.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance. Withdrawal amount exceeds current balance.");
                }
            }

            // Method to display account information
            public void DisplayAccountInfo()
            {
                Console.WriteLine("\nAccount Information:");
                Console.WriteLine($"Account Number: {accountNumber}");
                Console.WriteLine($"Customer Name: {customerName}");
                Console.WriteLine($"Account Type: {accountType}");
                Console.WriteLine($"Current Balance: ${balance}");
            }
        }

        class Program
        {
            static void Main()
            {
                // Creating an instance of Accounts
                Accounts account = new Accounts(1001, "John Doe", "Savings");

                // Perform transactions
                account.Deposit(500); // Deposit $500
                account.Withdraw(200); // Withdraw $200
                account.Deposit(1000); // Deposit $1000

                // Display account information
                account.DisplayAccountInfo();
            }
        }
    }
}
