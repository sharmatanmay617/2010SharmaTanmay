using System;

namespace CW_3
{
    class Program
    {
        static void Solver(ref double a, ref double b, ref double c)
        {
            double d = ((b * b) - (4 * a * c));
            string roots = (d >= 0) ? "Roots are Real Корни реальны." : "Roots are Imaginary Корны нереальны";
            // Формула Дискриминанта
            double root1 = ((-b + Math.Sqrt(d)) / (2 * a)); // Корень 1
            double root2 = ((-b - Math.Sqrt(d)) / (2 * a)); // Корень 2
            Console.WriteLine("Корень 1 Root 1 is: " + root1);
            Console.WriteLine("Корень 2 Root 2 is: " + root2);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Self Work 3 Самостоятельная работа 3");
            Console.WriteLine("Введите значение A Enter the Value for A: ");
            double a = double.Parse(Console.ReadLine()); // Значение A
            Console.WriteLine("Введите значение B Enter the Value for B: ");
            double b = double.Parse(Console.ReadLine()); // Значение B
            Console.WriteLine("Введите значение C Enter the Value for C: ");
            double c = double.Parse(Console.ReadLine()); // Значение C
            // Наш Метод
            Solver(ref a, ref b, ref c);
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
