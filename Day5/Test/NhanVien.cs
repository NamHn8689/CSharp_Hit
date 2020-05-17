using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class NhanVien
    {

        //Một công ty sản xuất máy in quản lý thông tin về nhân viên bao gồm : Mã nhân viên, họ tên, hệ số lương, số ngày công, trợ cấp.
        private String maNv;
        private String hoTen;
        private double heSoLuong;
        private int soNgayCong;
        private double troCap;

        public NhanVien() { }

        public string MaNv { get => maNv; set => maNv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int SoNgayCong { get => soNgayCong; set => soNgayCong = value; }
        public double TroCap { get => troCap; set => troCap = value; }

        public double Luong()
        {
            if (SoNgayCong >= 26)
                return HeSoLuong * 150000 * SoNgayCong + TroCap;
            else
                return HeSoLuong * 150000 * SoNgayCong - ((30 - SoNgayCong) * HeSoLuong * 10000);
        }
        public void input()
        {
            Console.Write("Nhap ma nhan vien: "); MaNv = Console.ReadLine();
            Console.Write("Nhap ten nhan vien: "); HoTen = Console.ReadLine();
            Console.Write("Nhap he so luong: "); HeSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay cong: "); SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap tro cap: "); TroCap = double.Parse(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine();
            Console.WriteLine("Ma nhan vien: " + MaNv);
            Console.WriteLine("Ten nhan vien: " + HoTen);
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("So ngay cong: " + SoNgayCong);
            Console.WriteLine("Tro cap: " + TroCap);
            Console.WriteLine("Luong: " + this.Luong());
            Console.WriteLine("===============================");
        }
    }
}
