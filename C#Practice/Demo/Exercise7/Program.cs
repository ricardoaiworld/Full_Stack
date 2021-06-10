using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin;
            Console.WriteLine("Enter Your Pin Number");
            pin = Convert.ToInt32(Console.ReadLine());
            User u1 = new User(pin);
            Bank b1 = new Bank(u1);
        }
    }
}
