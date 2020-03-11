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
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Input d: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Input e: ");
            int e = int.Parse(Console.ReadLine());

            int[] arr = new int[5];
            arr[0] = a; arr[1] = b; arr[2] = c; arr[3] = d; arr[4] = e;
            Array.Sort<int>(arr);
            Console.WriteLine(arr[3]);
            Console.ReadLine();
        }
    }
}
