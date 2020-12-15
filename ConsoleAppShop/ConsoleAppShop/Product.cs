using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppShop
{
    class Product
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public static void Show()
        {
           
        }
        public static void Exit()
        {
            Environment.Exit(0);
        }

        public string Notebook()
        {
            Name = "hp";
            Model = "X-100";
            Price = 25000;
            return $"Ноутбук {Name}, модель {Model} Цена {Price}";
        }

        public static string Tablett()
        {
            string name = "samsung";
            string model = "Y-500";
            int price = 35000;
            return $"Планшет {name}, модель {model} Цена {price}";
        }
    }
}
