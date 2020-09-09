using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of Perpendicular: ");
            string sp = Console.ReadLine();
            Console.WriteLine("Enter the Length of Base: ");
            string sb = Console.ReadLine();
            double p = double.Parse(sp);
            double b = double.Parse(sb);
            double h = Math.Sqrt((p * p) + (b * b));
            Console.WriteLine("The Hypotenuse is: " + h);
        }
    }
}
