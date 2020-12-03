using System;

namespace GitUnitTestDemo
{
    public class Math
    {
        public int a, b;

        public Math()
        {
            a = 1;
            b = 1;
        }

        public Math(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Add()
        {
            return a + b;
        }

        public int Subtract()
        {
            return a - b;
        }

        public int Multiply()
        {
            return a * b;
        }

        public float Divide()
        {
            if (b != 0)
                return (float)a / b;
            else
            {
                return Single.PositiveInfinity;
            }
        }

        public int SumDigits()
        {
            int n = a;
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        public string Binary()
        {
            return Convert.ToString(a, 2);
        }



    }
}