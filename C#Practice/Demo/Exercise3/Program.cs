using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            char[] array = str.ToCharArray();
            string reversed = String.Empty;
            for (int i=array.Length-1;i >=0; i--)
            {
                reversed += array[i];
            }
            Console.WriteLine($"Reversed string: {reversed}");
        }
    }
}
