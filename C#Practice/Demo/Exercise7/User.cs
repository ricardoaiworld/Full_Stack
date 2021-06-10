using System;
namespace Exercise7
{
    public class User
    {
        private int pinNumber;
        private decimal balance;
        public User(int pinNumber, decimal balance=1000m) 
        {
            this.pinNumber = pinNumber;
            this.balance = balance;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposit succeed. Current balance is {balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (balance - amount < 0)
            {
                Console.WriteLine($"Withdraw Denied. Insufficent balance {balance}");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdraw succeed. Current balance is {balance}");
            }
        }
    }
}
