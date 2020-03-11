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
            Console.Write("Input a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            float c = float.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("This is triangle ");
                if (a == b && a == c)
                    Console.WriteLine("Equilateral triangle");
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Isosceles triangle");
                    if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)                  
                        Console.WriteLine("And right triangle");                    
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)              
                    Console.WriteLine("Right triangle");              
                else Console.WriteLine("Normal triangle");
            }
            else
                Console.WriteLine("Is not triangle");          
            Console.ReadLine();
        }
    }
}
