using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
        private decimal balance;  //private field
        // public property to get the  balance 
        public decimal Balance
        {
            get { return balance; }
        }
        
        //method to deposit money

        public void Deposit (decimal amount)
        {
            if (amount >0 )
            {
                balance += amount; // only  allow positive amount

                Console.WriteLine($"Deposited: {amount:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");

            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}");

            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }

        }   
    }

   
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();

            // Deposit money
            account.Deposit(200);
            Console.WriteLine($"Current Balance: {account.Balance:C}");

            // Withdraw money
            account.Withdraw(50);
            Console.WriteLine($"Current Balance: {account.Balance:C}");

            // Attempt to withdraw more than the balance
            account.Withdraw(180);

            // Final balance
            Console.WriteLine($"Final Balance: {account.Balance:C}");
            Console.ReadKey();

        }
    }
}
