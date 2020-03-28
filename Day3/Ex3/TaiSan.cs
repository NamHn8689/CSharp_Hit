using System;


namespace CSharp
{
    class TaiSan
    {
        String ten;
        int soLuong;
        String tinhTrang;
        public TaiSan()
        {
            ten = "";
            SoLuong = 0;
            tinhTrang = "";
        }

        public int SoLuong { get => soLuong; set => soLuong = value; }

        public void Nhap()
        {
            Console.Write("Nhap ten san pham: ");
            ten = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap trang thai: ");
            tinhTrang = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ten san pham: " + ten + ", So luong: " + SoLuong + ", Trang thai: " + tinhTrang);
        }
    }
}