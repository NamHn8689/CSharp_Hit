using System;


namespace Day4
{
    class StudentHaui
    {
        private String name;
        private String sex;
        private String country;
        private String married;

        public string Name { get => name; set => name = value; }

        public string Country { get => country; set => country = value; }
        public string Married { get => married; set => married = value; }
        public string Sex { get => sex; set => sex = value; }

        public StudentHaui() { }

        public void input()
        {
            Console.Write("Nhap ho ten : ");
            this.name = Console.ReadLine();
            Console.Write("Nhap gioi tinh : ");
            this.sex = Console.ReadLine();
            Console.Write("Nhap que quan : ");
            this.country = Console.ReadLine();
            Console.Write("Da cos ny ?: ");
            this.Married = Console.ReadLine();
        }
        public void output()
        {
            Console.Write("Ho ten: " + this.name + ", Gioi tinh: " + this.sex + ", Que quan: " + this.country + ", Tinh trang hon nhan: " + this.married + ", ");
        }
    }
}
