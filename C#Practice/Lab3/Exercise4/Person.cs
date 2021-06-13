using System;
namespace Exercise4
{
    public  class Person
    {
        public Person()
        {
            Console.WriteLine("Hello");
        }
        protected int age;
        public void SetAge(int n)
        {
            age = n;
        }
    }
}
