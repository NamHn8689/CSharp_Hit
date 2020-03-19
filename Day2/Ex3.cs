using System;

namespace CSharp
{
    class Day2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            String s = Console.ReadLine();
            String[] a = split(s);
            show(a);
            Console.WriteLine("Age: " + getAge(a[a.Length - 1]));
            Console.ReadLine();
        }
        static String[] split(String s)
        {
            return s.Split(' ');
        }
        static void show(String[] a)
        {
            Console.WriteLine("First name: " + a[0]);
            Console.Write("Middle name: ");
            for (int i = 1; i <= a.Length - 3; i++)
                Console.Write(a[i] + " ");

            Console.WriteLine();
            Console.WriteLine("Last name: " + a[a.Length - 2]);
            Console.WriteLine("Year of birth: " + a[a.Length - 1]);
        }
        static int getAge(String x)
        {
            DateTime now = DateTime.Now;
            int now_Year = now.Year;
            return now_Year - int.Parse(x);
        }
    }
}
