using System;

namespace Exercise1
{
    class Rectangle : Shape1
    {
        public Rectangle()
        {
            GetData();
        }

        public override float Area()
        {
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }

        public void GetData()
        {
            Console.WriteLine("Enter length");
            L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            B = Convert.ToInt32(Console.ReadLine());
        }
    }
}
