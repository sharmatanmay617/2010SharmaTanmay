using System;

namespace Task05
{
    /* Выбор отдельных цифр натурального числа Задача: Введите трехзначное натуральное число и выведите его цифры. */
    class Program
    {
        static void Divider(ref uint hundred)
        {
            uint one;
            uint ten = 0;
            one = hundred / 100;                // первая цифра
            Console.WriteLine(one);
            ten = hundred - one * 100;
            one = ten / 10;                     // вторая цифра
            Console.WriteLine(one);
            one = ten - one * 10;               // третья цифра
            Console.WriteLine(one);
        }

        static void Main(string[] args)
        {
            uint hundred,       // Введенное число
                 one,           // Очередная цифра
                 ten;           // рабочая переменная
            string number;
            Console.Write("Enter a number from 100 to 999 Введите целое от 100 до 999: ");
            number = Console.ReadLine();
            uint.TryParse(number, out hundred);
            // Наш метод
            Divider(ref hundred);
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();

        }
    }
}
