using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i=n1; i<=n2; i++)
            {
                int curr = i, armstrong = 0;
                while (curr>0)
                {
                    armstrong += Convert.ToInt32(Math.Pow((curr%10),3));
                    curr /= 10;
                }
                if (armstrong == i)
                    Console.WriteLine(i);
            }
        }
    }
}
