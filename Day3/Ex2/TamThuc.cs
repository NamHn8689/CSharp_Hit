using System;

namespace CSharp
{
    class TamThuc
    {
        double a, b, c;
        public TamThuc() { }
        public TamThuc(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.C = c;
        }


        public void Xuat()
        {
            Console.WriteLine("(" + this.a + ")x^2 + (" + this.b + ")x + (" + this.C + ")");
        }

        public static TamThuc operator -(TamThuc result)
        {
            result.a *= -1;
            result.b *= -1;
            result.C *= -1;
            return result;
        }
        public static TamThuc operator +(TamThuc x, TamThuc y)
        {
            TamThuc result = new TamThuc();
            result.a = x.a + y.a;
            result.b = x.b + y.b;
            result.C = x.C + y.C;
            return result;
        }
        public static TamThuc operator -(TamThuc x, TamThuc y)
        {
            TamThuc result = new TamThuc();
            result.a = x.a - y.a;
            result.b = x.b - y.b;
            result.C = x.C - y.C;
            return result;
        }
    }
}