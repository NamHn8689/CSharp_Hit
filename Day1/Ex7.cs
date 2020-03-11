using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Day1
    {
        static void Main(string[] args)
        {
            Console.Write("Input x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            float c = float.Parse(Console.ReadLine());

            float t = 1, m = 1, i = 1;
            float ex = 0;
            while ((t / m) >= c)
            {
                ex += t / m;
                t *= x;
                m *= i;
                i++;
            }       
            Console.WriteLine("e^" + x + " = " + ex);
            Console.ReadLine();
        }
    }
}
