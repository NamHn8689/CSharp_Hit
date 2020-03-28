using System;

namespace CSharp
{
    class Day1
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                if (n % i == 0) 
                    Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
