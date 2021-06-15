using System;

namespace Exercise9
{
    class A
    {
        int n;
        string s;
        public A(int n)
        {
            this.n = n;
        }
        public int getN()
        {
            return n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A[] v = new A[10];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = new A(10 - i);
            }
            foreach (A item in v)
            {
                Console.WriteLine(item.getN());
            }
            Console.WriteLine("After Sorting");
            Array.Sort(v, delegate (A a, A b) { return a.getN().CompareTo(b.getN()); });
            foreach (A item in v)
            {
                Console.WriteLine(item.getN());
            }
        }

    }
}