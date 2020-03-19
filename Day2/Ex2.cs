using System;

namespace CSharp
{
    class Day2
    {
        static void Main(string[] args)
        {
            float A, x;
            int n;
            input(out A, out x, out n);
            Console.WriteLine("S = " + S(A, x, n));
        }
        static void input(out float A, out float x, out int n)
        {
            Console.Write("Input A: ");
            A = float.Parse(Console.ReadLine());
            do
            {
                Console.Write("Input x(x >0): ");
                x = float.Parse(Console.ReadLine());
            } while (x <= 0);
            do
            {
                Console.Write("Input n(5<= n <=20): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 5 || n > 20);
        }
        static float SS(float x, int k)
        {
            return (float)Math.Sqrt(Math.Pow(x, k));
        }
        static double S(float A, float x, int n)
        {
            double S = A;
            for (int i = 1; i <= n; i++)
                S += (float)Math.Pow(-1, i) * SS(x, i) / (n + 1 - i);
            return S;
        }
    }
}
