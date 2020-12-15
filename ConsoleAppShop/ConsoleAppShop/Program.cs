using System;

namespace ConsoleAppShop
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите команду: ");
                string team = Console.ReadLine();
                switch (team)
                {
                    case "show":
                        Show();
                        break;
                    case "exit":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
        }
        static void Show()
        {
            Product.Show();
        }
        static void Exit()
        {
            Product.Exit();
        }
    }
}
