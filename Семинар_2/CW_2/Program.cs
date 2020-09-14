using System;

namespace CW_2
{
    /* 
     * Введите натуральное трехзначное число "hundred". 
     * Найдите наибольшее целое число, которое можно получить, переставив цифры числа "hundred".
    */
    class Program
    {
        static void ValuesSort(ref int x, ref int y, ref int z)
        {
            // Вспомогательные переменные
            int minValue = 0, middleValue = 0, maxValue = 0;
            minValue = x < y ? (z < x ? z : x) : (y < z ? y : z);
            maxValue = x > y ? (z > x ? z : x) : (y > z ? y : z);
            middleValue = x == minValue ? (z == maxValue ? y : z) : (z == minValue ? (x > y ? y : x) : z);
            Console.WriteLine("The number will be: " + ((maxValue * 100) + (middleValue * 10) + (minValue)));
        }
        static void Main(string[] args)
        {
            int hundred;
            string number;
            Console.WriteLine("Self Work 2 Самостоятельная работа 2");
            Console.WriteLine("Enter a number from 100 to 999 Введите целое от 100 до 999: ");
            number = Console.ReadLine();
            int.TryParse(number, out hundred);
            int x;
            int y;
            x = (hundred / 100);                // первая цифра
            int ten = hundred - (x * 100);
            y = (ten / 10);                     // вторая цифра
            int z = ten - y * 10;               // третья цифра
            // Наш Метод
            ValuesSort(ref x, ref y, ref z);
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();

        }
    }
}
