using System;

namespace CW_4
{
    class Program
    {
        static void Reverser(ref uint hundred)
        {
            uint digit1;
            uint ten;
            digit1 = hundred / 100;                // первая цифра
            ten = hundred - digit1 * 100;
            uint digit2 = ten / 10;                 // вторая цифра
            uint digit3 = ten - (digit2 * 10);      // третья цифра 
            uint revNumber = (digit3 * 100) + (digit2 * 10) + digit1;
            Console.WriteLine("Reverse of the number given will be Обратная сторона приведенного числа будет:: " + revNumber);
        }

        static void Main(string[] args)
        {
            uint hundred,       // Введенное число
                 one,           // Очередная цифра
                 ten;           // рабочая переменная
            string number;
            Console.WriteLine("Self Work 4 Самостоятельная работа 4");
            Console.Write("Enter a number from 100 to 999 Введите целое от 100 до 999: ");
            number = Console.ReadLine();
            uint.TryParse(number, out hundred);
            // Наш Метод
            Reverser(ref hundred);
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
