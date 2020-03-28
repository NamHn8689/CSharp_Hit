using System;

namespace CSharp
{
    class Date
    {
        String ngay, thang, nam;

        public void nhap()
        {
            Console.Write("Nhap ngay: ");
            ngay = Console.ReadLine();
            Console.Write("Nhap thang: ");
            thang = Console.ReadLine();
            Console.Write("Nhap nam: ");
            nam  = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.Write(ngay + "/" + thang + "/" + nam);
        }
    }
}