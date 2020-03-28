using System;

namespace CSharp
{
    class Day1
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            bool a = false;
            int t = 2;
            Console.Write( n + " = ");
            while (n > 1)
            {
                while (n > 1 && n % t == 0)
                {
                    if (!a)
                        a = true;
                    else
                        Console.Write("x");
                    Console.Write(t);
                    n /= t;
                }
                t++;
            }
            Console.ReadLine();
        }
    }
}
