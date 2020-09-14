using System;

namespace CW_7
{
    class Program
    {
        static void fractionalPart(ref double number)
        {
            // Формула Неотъемлемой Частью И Дробная Часть
            int intPart = (int)number;
            double fracPart = number - intPart;
            Console.WriteLine($"The Integral Part is Неотъемлемой Частью является:: {intPart} \nThe Fractional Part is Дробная Часть:: {fracPart}");
        }

        static void squarePart(ref double number)
        {
            // Формула Квадрат и Квадратный Корень
            double square = (number * number);
            double sqroot = Math.Sqrt(number);
            Console.WriteLine($"The Square is Квадрат: {square} \nThe Square root is Квадратный Корень: {sqroot}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number Введите ваше число: ");
            double number = double.Parse(Console.ReadLine());              // Наш Номер
            
            // Метод Неотъемлемой Частью И Дробная Часть
            
            fractionalPart(ref number);
            Console.WriteLine("\n");

            // Метод Квадрат и Квадратный Корень
            
            squarePart(ref number);
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
