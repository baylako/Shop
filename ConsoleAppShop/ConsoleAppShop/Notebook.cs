using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppShop
{
    class Notebook : Product
    {
        public int Price { get; set; }
        public Notebook(string name, int price) 
           
        {
            Name = name;
            Price = price;
        }
    }
}
