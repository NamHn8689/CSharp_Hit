using System;
using System.Collections.Generic;

namespace CSharp
{
    public class Hang
    {
        string maHang;
        string tenHang;
        int donGia;
        int soLuong;
        public Hang() {}
        public void Nhap()
        {
            Console.Write("Nhap ma hang: ");
            maHang = Console.ReadLine();
            Console.Write("Nhap ten hang: ");
            tenHang = Console.ReadLine();
            Console.Write("Nhap don gia: ");
            donGia = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ma hang: " + maHang);
            Console.WriteLine("Ten hang: " + tenHang);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("So luong: " + soLuong);
            Console.WriteLine("Thanh tien: " + ThanhTien());
            Console.WriteLine();
        }
        public long ThanhTien()
        {
            return soLuong * donGia;
        }
        public static void SapXep(List<Hang> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
                for (int j = i + 1; j < list.Count; j++)
                    if (list[i].ThanhTien() > list[j].ThanhTien())
                    {
                        Hang temp = new Hang();
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
        }
    }
}