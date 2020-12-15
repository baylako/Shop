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

        //string[] array = new string[4];
        //string name = array[0];

        public void Notebook()
        {
            string name = "hp";
            string model = "X-500";
            int price = 25000;
            Console.WriteLine($"Ноутбук {name}\t модель {model}\t Цена {price}");
        }

        public void Tablett()
        {
            string name = "samsung";
            string model = "Y-500";
            int price = 35000;
            Console.WriteLine($"Планшет {name}\t модель {model}\t Цена {price}");
        }
    }
}
