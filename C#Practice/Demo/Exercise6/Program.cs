using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            Console.WriteLine("Enter the number of rows: ");
            r = Convert.ToInt32(Console.ReadLine());
            int row = r * 2 - r % 2;
            for (int i=0; i<=row; i++)
            {
                int cnt, blank;
                if (i < row/2)
                {
                    blank = r - 1;
                    while (blank > 0)
                    {
                        Console.Write(" ");
                        blank--;
                    }
                    r--;
                    cnt = 1 + i * 2;
                    while (cnt > 0)
                    {
                        Console.Write('*');
                        cnt--;
                    }
                }
                else
                {
                    if (row%2 == 0 && i == row/2)
                        r++;
                    blank = r - 1;
                    while (blank > 0)
                    {
                        Console.Write(" ");
                        blank--;
                    }
                    r++;
                    cnt = 1 + (row - i - 1) * 2;
                    while (cnt > 0)
                    {
                        Console.Write('*');
                        cnt--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
