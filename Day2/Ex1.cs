using System;

namespace CSharp
{
    class Day2
    {
        static void Main(string[] args)
        {
            int n = input();
            int[] a = new int[n];
            inputArray(a, n);
            show(a, n);
            Console.ReadLine();
        }
        static int input()
        {
            int n;
            do
            {
                Console.Write("Input n(n>0): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            return n;
        }
        static void inputArray(int[] a, int n)
        {
            Console.WriteLine("Input array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static bool isPrime(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
        static void show(int[] a, int n)
        {
            Console.Write("Is prime: ");
            for (int i = 0; i < n; i++)
                if (isPrime(i + 1))
                    Console.Write(a[i] + " ");
        }
    }
}
