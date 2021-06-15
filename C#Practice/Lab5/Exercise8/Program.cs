using System;

namespace Exercise8
{
    abstract class A
    {
        int x;
        public abstract void f(int n);
        public virtual void g(uint n) // virtual cannot be private
        {
            //x = n as int; // error
            x = (int)n;
        }
        public string ToString()
        {
            return x.ToString();
        }
    }
}
