using System;
using System.Collections.Generic;

namespace Day4
{
    class Classes
    {
        static Student[] list;
        static Leader leader;
        static int soHocVien;
        public void Input()
        {
            Console.WriteLine("\nNhap thong tin leader");
            leader = new Leader();
            leader.input();

            Console.Write("\nNhap so luong hoc vien: ");
            soHocVien = int.Parse(Console.ReadLine());
            list = new Student[soHocVien];
            for (int i = 0; i < soHocVien; i++)
            {
                list[i] = new Student();
                Console.WriteLine("\nNhap thong tin hoc vien thu " + (i + 1));
                list[i].input();
            }
        }
        public void Output()
        {
            Console.Write("\nThong tin leader: \n");
            leader.output();
            Console.Write("\nDanh sach hoc vien: \n");
            for (int i = 0; i < soHocVien; i++)
                list[i].output();
        }
        public void Random()
        {
            Random rd = new Random();
            int i = rd.Next(0, soHocVien - 1);
            Console.Write("\nHoc vien ngau nhien khong co ny: \n");
            while (list[i].Married.CompareTo("co nguoi yeu") == 0)
                i = rd.Next(0, soHocVien - 1);

            list[i].output();
        }
        public void ThanhToan(String name, int money)
        {
            int dem = 0;
            Console.Write("Nhap ten hoc vien can thanh toan:");
            name = Console.ReadLine();
            for (int i = 0; i < soHocVien; i++)
                if (!list[i].Name.Equals(name))
                    dem++;
            if (dem == 0)
                Console.Write("Khong co hoc vien nao ten: " + name);
            else
            {
                Console.Write("Nhap so tien can thanh toan: ");
                money = int.Parse(Console.ReadLine());
                for (int i = 0; i < soHocVien; i++)
                    if (list[i].Name.Equals(name))
                        list[i].ThanhToan(money);

                Console.WriteLine("\nDanh sach hoc vien sau khi thanh toan: ");
                foreach (Student st in list)
                    st.output();
            }
        }
        public void TangCongNo()
        {
            for (int i = 0; i < soHocVien; i++)
                if (list[i].Married.CompareTo("da co ny") == 0)
                    list[i].ThanhToan(-5000);

            Console.WriteLine("\n Danh sach sau khi tang cong no nhung ai co ny");
            foreach (Student st in list)
                st.output();
        }
    }
}



