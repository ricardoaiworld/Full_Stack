using System;
namespace Exercise7
{
    public class Bank
    {
        User u;
        public Bank(User u)
        {
            this.u = u;
            int opt = 0;
            Console.WriteLine("********Welcome to ATM Service**************");
            while (opt != 4)
            {
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine("4. Quit");
                Console.WriteLine("*****************************************");
                Console.WriteLine("Enter Your Choice:");
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Check();
                        break;
                    case 2:
                        Withdraw();
                        break;
                    case 3:
                        Deposit();
                        break;
                    case 4:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        break;
                }
            }
        }
        public void Check()
        {
            Console.WriteLine($"YOU’RE BALANCE IN Rs: {u.GetBalance()}");
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter the amount you want to withdraw: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            u.Withdraw(amount);
        }
        public void Deposit()
        {
            Console.WriteLine("Enter the amount you want to deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            u.Deposit(amount);
        }
    }
}
