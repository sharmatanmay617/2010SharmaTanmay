using System;

namespace Task04
{
    /*
       Метод получает параметр типа uint, в дальнейших операциях преобразует его в тип char, 
       затем делает проверку на принадлежность данного аргумента к коду цифры или буквы кириллицы 
       и выводит необходимые сообщения по условию задачи.
     */
    class Program
    {
        public static string myMethod(uint code)
        {
            // Метод получает uint и затем делает проверку на принадлежность данного аргумента к коду цифры или буквы кириллицы //
            string check;
            return check = code <= '9' && code >= '0' ? "It is a letter Это цифра: " + (char)code
            : code <= 'Я' && code >= 'А' ? "It is a Capital letter Это прописная буква: " + (char)code
            : code <= 'я' && code >= 'а' ? "It is a small letter Это строчная буква: " + (char)code
            : "Not a symbol Неизвестный символ!";
            Console.WriteLine(check);
        }

        static void Main(string[] args)
        {
            uint code;
            string str;
            string check;
            uint код_А = (uint)'А',
                 код_а = (uint)'а',
                 код_я = (uint)'я',
                 код_Я = (uint)'Я',
                 код_0 = (uint)'0';
            Console.WriteLine("Boundry Character Codes Коды граничных символов:");
            Console.WriteLine("Code A Код А = " + код_А + "; Code Я Код Я = " + код_Я +
                        "; Code a Код а = " + код_а + "; Code я Код я = " + код_я +
                        "; Code zero Код нуля = " + код_0);
            Console.Write("Enter value of code Введите значение Кода: ");
            str = Console.ReadLine();
            uint.TryParse(str, out code);
            Console.WriteLine($"{myMethod(code)}");
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();

        }
    }
}
