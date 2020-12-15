using System;

namespace ConsoleAppShop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Меню: 1.address 2.show 3.exit ");
            while (true)
            {
                Console.Write("Введите команду: ");
                string team = Console.ReadLine();
                switch (team)
                {
                    case "address":
                        Address();
                        break;
                    case "show":
                        Show();
                        break;
                    case "exit":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        continue;
                }
            }
        }
        static void Address()
        {
            Shop address = new Shop();
            address.GetInfoShop();
        }
        static void Show()
        {
            Product product = new Product();
            product.Notebook();
            product.Tablett();
        }
        static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
