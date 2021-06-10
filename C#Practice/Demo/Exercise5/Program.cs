using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, prev = 0;
            Console.WriteLine("Enter the number of rows: ");
            row = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<=row; i++)
            {
                for (int j=0; j<=i; j++)
                {
                    if (prev == 0)
                    {
                        Console.Write(1);
                        prev = 1;
                    }
                    else
                    {
                        Console.Write(0);
                        prev = 0;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
