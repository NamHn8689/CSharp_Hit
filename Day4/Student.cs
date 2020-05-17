using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Student : StudentHaui
    {
        int liabilities;

        public int Liabilities { get => liabilities; set => liabilities = value; }

        public Student()
        {
            this.Liabilities = 10000;
        }
        public void ThanhToan(int money)
        {
            this.Liabilities -= money;
        }
        public void input()
        {
            base.input();
        }
        public void output()
        {
            base.output();
            Console.Write(" Cong no: " + this.Liabilities + "\n");
        }
    }
}
