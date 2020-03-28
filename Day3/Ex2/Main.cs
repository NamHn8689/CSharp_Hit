using System;

namespace CSharp
{
    class Ex2
    {
        static void Main(string[] args)
        {
            TamThuc a = new TamThuc(1, 1, 1);
            TamThuc b = new TamThuc(2, 2, 2);

            a = -a;
            b = -b;

            a.Xuat();
            b.Xuat();
            Console.WriteLine();
            Console.Write("Tong:");
            (a + b).Xuat();
            Console.Write("Hieu:");
            (a - b).Xuat();
            Console.ReadKey();
        }
    }
}
