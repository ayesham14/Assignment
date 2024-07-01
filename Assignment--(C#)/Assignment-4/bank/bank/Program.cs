using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class bank
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() { }
        public InsufficientBalanceException(string message) : base(message) { }
        public InsufficientBalanceException(string message, Exception innerException) : base(message, innerException) { }
    }

    // BankAccount class representing a bank account
    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
            this.balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
            Console.WriteLine($"Deposited: ${amount}, Current Balance: ${balance}");
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (balance < amount)
            {
                throw new InsufficientBalanceException("Insufficient balance for withdrawal.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount}, Current Balance: ${balance}");
        }

        // Method to check the current balance
        public double GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Creating a bank account with initial balance of $1000
                BankAccount account = new BankAccount(1000);

                // Performing transactions
                account.Deposit(500);
                account.Withdraw(200);
                account.Withdraw(1500); // This should throw InsufficientBalanceException

                // Displaying final balance
                Console.WriteLine($"Final Balance: ${account.GetBalance()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Insufficient Balance Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.ReadKey();
        }
    }

}
