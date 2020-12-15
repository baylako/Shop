using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppShop
{
    class Shop
    {
        public static string Name { get; } = "DNS";
        public static string Address { get; } = "г. Кызыл, ул. Дружба 137";
        public void GetInfoShop()
        {
            Console.WriteLine($"Магазин \"{Name}\" находится по адресу {Address}");
        }
    }
}
