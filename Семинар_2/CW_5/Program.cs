using System;

namespace CW_5
{
    class Program
    {
        static void Triangularity(ref double a, ref double b, ref double c)
        {
            // Уравнение за треугольностью: a + b > c
            string result = a + b >= c ? (a + c >= b ? (b + c >= a ? "It Follows the triangularity!! Это следует за треугольностью!!" : "Not a triangle! Это не треугольник!") : "Not a triangle! Это не треугольник!") : "Not a triangle! Это не треугольник!";
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Self Work 5 Самостоятельная работа 5");
            Console.WriteLine("Enter Side A Введите Сторону A: ");
            double a = double.Parse(Console.ReadLine());                // Сторона A
            Console.WriteLine("Enter Side A Введите Сторону B: ");
            double b = double.Parse(Console.ReadLine());               // Сторона B
            Console.WriteLine("Enter Side A Введите Сторону C: ");
            double c = double.Parse(Console.ReadLine());               // Сторона C
            // Наш Метод
            Triangularity(ref a, ref b, ref c);
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
