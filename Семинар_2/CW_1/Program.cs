using System;

namespace CW_1
{
    class Program
    {
        static void Calculator(ref double x)
        {
            // Это Метод выводит значение полинома
            double functionValue;
            // полнома
            functionValue = (12 * (x * x * x * x)) + (9 * (x * x * x)) - (3 * (x * x)) + (2 * x) - 4;
            Console.WriteLine(functionValue);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Self Work 1 Самостоятельная работа 1");
            Console.WriteLine("Enter the value of x for calculating f(x) Введите значение x для вычисления f(x)= 12x^4 + 9x^3 -3x^2 + 2x -4: ");
            double x = double.Parse(Console.ReadLine());
            // Наш Метод
            Calculator(ref x);
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
