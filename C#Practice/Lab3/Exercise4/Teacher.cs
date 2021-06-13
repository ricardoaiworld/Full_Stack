using System;
namespace Exercise4
{
    public class Teacher : Person
    {
        private string subject;
        public Teacher()
        {
        }

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
