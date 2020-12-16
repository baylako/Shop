using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppShop
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }

        public void GetInfoShop()
        {
            Console.WriteLine($"Магазин \"{Name}\" находится по адресу {Address}");
        }
    }
}
