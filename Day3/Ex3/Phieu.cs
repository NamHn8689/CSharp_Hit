using System;
using System.Collections.Generic;

namespace CSharp
{
    class Phieu
    {
        String maPhieu;
        Date ngayKiemKe;
        String nhanVienKiemKe;
        String chucVu;
        String maPhong;
        String tenPhongKiemKe;
        String truongPhong;
        TaiSan[] danhSach;
        int n;

        public Phieu() { }
        public void Nhap()
        {
            Console.Write("Nhap ma phieu: ");
            maPhieu = Console.ReadLine();
            ngayKiemKe = new Date();
            Console.WriteLine("Nhap ngay kiem ke");
            ngayKiemKe.nhap();
            Console.Write("Nhap ten nhan vien kiem ke: ");
            nhanVienKiemKe = Console.ReadLine();
            Console.Write("Nhap chuc vu nhan vien kiem ke: ");
            chucVu = Console.ReadLine();
            Console.Write("Nhap ma phong kiem ke: ");
            maPhong = Console.ReadLine();
            Console.Write("Nhap ten phong kiem ke: ");
            tenPhongKiemKe = Console.ReadLine();
            Console.Write("Nhap ten truong phong: ");
            truongPhong = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Nhap so luong tai san: ");
            n = int.Parse(Console.ReadLine());

            danhSach = new TaiSan[n];
            for (int i = 0; i < n; i++)
            {
                danhSach[i] = new TaiSan();
                Console.WriteLine("Nhap thong tin tai san thu " + (i + 1));
                danhSach[i].Nhap();
            }
        }
        public int tongSoTaiSan()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += danhSach[i].SoLuong;
            }
            return sum;
        }
        public void Xuat()
        {
            Console.WriteLine();
            Console.WriteLine("Ma phieu: " + maPhieu);
            Console.Write("Ngay kiem ke: ");
            ngayKiemKe.Xuat();

            Console.WriteLine();
            Console.WriteLine("Danh sach tai san:");
            foreach (TaiSan i in danhSach)
            {
                i.Xuat();
            }
            Console.WriteLine("So tai san da kiem ke: " + n);
            Console.WriteLine("Tong so luong: " + tongSoTaiSan());
        }
    }
}