using System;

namespace CW_6
{
    class Program
    {
        static void budgetCal(ref double budget, ref double PerComGame)
        {
            // Здесь PerCompGame процент Бюджета!!
            double budgetCompGame = (PerComGame / 100) * budget;
            Console.WriteLine("The budget for Computer Games will be Бюджет на компьютерные игры составит:: " + budgetCompGame + "₽");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the budget Введите бюджет:: ");
            double budget = double.Parse(Console.ReadLine()); // Значение Бюджета
            Console.WriteLine("Enter the percentage of budget for Computer Games Введите процент бюджета для компьютерных игр:: ");
            double PerCompGame = double.Parse(Console.ReadLine()); // Значение процент Бюджета
            // Наш Метод
            budgetCal(ref budget, ref PerCompGame);
            Console.WriteLine("For exit press Enter Для выхода нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
