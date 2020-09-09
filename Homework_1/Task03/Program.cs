using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add an Integer from 32 to 127:");
            string inpStr = Console.ReadLine();
            int n = Convert.ToInt32(inpStr);
            Console.WriteLine((char)(n));
        }
    }
}
