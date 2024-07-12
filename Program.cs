using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;

            Console.Write(a + " " + b + " ");

            for(int i=2; i<=n; i++)
            {
                int c = a + b;
                Console.Write(c + " ");

                a = b; b = c;
            }
            Console.ReadLine();
        }
    }
}
