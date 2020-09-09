using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value of voltage V: ");
            string su = Console.ReadLine();
            Console.WriteLine("Enter the Value of resistance R: ");
            string sr = Console.ReadLine();
            int u = int.Parse(su);
            int r = int.Parse(sr);
            int i = u / r;
            Console.WriteLine("The Current is: " + i);
            int p = (u * u) / r;
            Console.WriteLine("And the power consumption is: " + p);
        }
    }
}
