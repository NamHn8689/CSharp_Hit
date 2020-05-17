using System;
using System.Collections.Generic;

namespace Day5
{
    class main
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong nhan vien: ");
            n = int.Parse(Console.ReadLine());
            NhanVien[] list = new NhanVien[n];

            //Cau1
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin nhan vien thu " + (i + 1) + ":");
                list[i] = new NhanVien();
                list[i].input();
            }
            showList(list);
            //======================================
            //Cau2
            Console.Write("\nNhap ten nhan vien can tim: ");
            String name = Console.ReadLine();
            NhanVien a = findByName(list, n, name);
            if (a == null)
                Console.WriteLine("\nKhong tim thay nhan vien nay");
            else
            {
                Console.WriteLine("\nThong tin nhan vien can tim:");
                a.output();
            }
            //Cau3
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (list[i].Luong() < list[j].Luong())
                    {
                        NhanVien temp;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }


            Console.WriteLine("\n***********Sau sap xep:");
            showList(list);

            Console.ReadKey();
        }
        static void showList(NhanVien[] list)
        {
            Console.WriteLine("Danh sach nhan vien:");
            foreach (NhanVien a in list)
                a.output();
        }
        static NhanVien findByName(NhanVien[] list, int n, String name)
        {
            for (int i = 0; i < n; i++)
                if (string.Equals(list[i].HoTen, name))
                    return list[i];
            return null;
        }

    }
}
