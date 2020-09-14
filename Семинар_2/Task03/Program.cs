using System;

namespace Task03
{
    class Program
    {
        static void ValuesSort(ref int x, ref int y, ref int z)
        {
            // Вспомогательные переменные
            int minValue = 0, middleValue = 0, maxValue = 0;
            minValue = x < y ? (z < x ? z : x) : (y < z ? y : z);
            maxValue = x > y ? (z > x ? z : x) : (y > z ? y : z);
            middleValue = x == minValue ? (z == maxValue ? y : z) : (z == minValue ? (x > y ? y : x) : z);
            x = minValue; y = middleValue; z = maxValue;
        }

        static void Main(string[] args)
        {
            // Программа будет принимать значения отсюда!
            Console.WriteLine("Enter Please, First Number Введите пожалйуста, первое число: ");
            int x = int.Parse(Console.ReadLine()); // Преобразование строки В тип данных int! 
            Console.WriteLine("Enter Please, Second Number Введите пожалйуста, второе число: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Please, Third Number Введите пожалйуста, третые число: ");
            int z = int.Parse(Console.ReadLine());

            // Через метод вывожу ответ
            ValuesSort(ref x, ref y, ref z);
            Console.WriteLine("Biggest Number Самое болшое число: " + z);
            Console.WriteLine("Middle Number Среднее число: " + y);
            Console.WriteLine("Smallest Number Самое меншее число: " + x);

            // Код для выхода из программы.
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();

        }
    }
}
