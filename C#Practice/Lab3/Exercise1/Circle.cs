using System;
namespace Exercise1
{
    class Circle : Shape1
    {
        public Circle()
        {
            GetData();
        }

        public override float Area()
        {
            return (float)Math.PI * (float)Math.Pow(R, 2);
        }

        public override float Circumference()
        {
            return (float)Math.PI * 2 * R;
        }

        public void GetData()
        {
            Console.WriteLine("Enter radius");
            R = Convert.ToInt32(Console.ReadLine());
        }
    }
}
