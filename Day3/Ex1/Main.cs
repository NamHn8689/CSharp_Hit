using System;
using System.Collections.Generic;

namespace CSharp
{
    class Ex1
    {
        static void Main(string[] args)
        {
            List<Hang> list = new List<Hang>();
            int n;

            Console.Write("Nhap so luong mat hang: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Hang temp = new Hang();
                temp.Nhap();
                list.Add(temp);
            }

            Hang.SapXep(list);
            foreach (Hang temp in list)
                temp.Xuat();

            Console.ReadKey();
        }
    }
}
