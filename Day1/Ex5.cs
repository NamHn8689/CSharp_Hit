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
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = n > 1;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    isPrime = false;
            Console.WriteLine(n + (isPrime ? " is prime" : " is not prime"));
            Console.ReadLine();
        }
    }
}
