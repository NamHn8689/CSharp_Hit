using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Leader : StudentHaui
    {
        String position;
        public string Position { get => position; set => position = value; }
        public Leader() { }

        public void input()
        {
            base.input();
            Console.Write("Nhap chuc vu: ");
            this.position = Console.ReadLine();
        }
        public void output()
        {
            base.output();
            Console.Write("Chuc vu: " + this.position + "\n");
        }
    }
}
