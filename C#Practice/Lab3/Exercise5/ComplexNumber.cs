using System;
namespace Exercise5
{
    public class ComplexNumber
    {
        private int real;
        private int imaginary;
        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public int Real
        {
            get
            {
                return real;
            }
            set
            {
                real = value;
            }
        }

        public void SetImaginary(int v)
        {
            imaginary = v;
        }

        public int Imaginary
        {
            get
            {
                return imaginary;
            }
            set
            {
                imaginary = value;
            }
        }

        public override string ToString()
        {
            return $"({real},{imaginary})";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
        }

        public void Add(ComplexNumber n) 
        {
            real += n.real;
            imaginary += n.imaginary;
        }
    }
}
