using System;

namespace Task06
{
    /* Установите окружность с центром в начале координат и радиусом R=10. 
       Введите координаты точки и выведите на экран сообщение: "точка внутри круга!"или" точка вне круга!". 
       Обеспечьте проверку входных данных и цикл повторения решений.  
    */
    class Program
    {
        static void Checker(ref double x, ref double y)
        {
            string check;
            // Проверка с помощью уравнения x^2 + y^2 = R^2
            check = (x * x) + (y * y) > 100 ? "It is not in the circle не в круга" : "It is in the circle в круге";
            Console.WriteLine(check);
        }

        static void Main(string[] args)
        {
            const double R = 10;
            double x, y;
            Console.Write("X Co-ordinate X Кординат = ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("X Co-ordinate Y Кординат = ");
            double.TryParse(Console.ReadLine(), out y);
            // Наш Метод
            Checker(ref x, ref y);
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();

        }
    }
}
