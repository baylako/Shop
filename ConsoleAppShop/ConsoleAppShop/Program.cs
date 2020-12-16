using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppShop
{
    class Program
    {
        static Shop MyShop;
        static void Main()
        {
            MyShop = new Shop();
            MyShop.Products = GetAllProducts();
            MyShop.Name = "DNS";
            MyShop.Address = "г. Кызыл, ул. Дружбы 137";

            Console.WriteLine("Доступные команды: 1.address 2.show 3.show first 4.show last 5.show visible 6.show invisible 7.exit ");

            while (true)
            {
                Console.Write("Введите команду: ");

                string command = Console.ReadLine();

                switch (command)
                {
                    case "address":
                        Address();
                        break;
                    case "show":
                        Show(MyShop.Products);
                        break;
                    case "show first":
                        ShowFirst(MyShop.Products);
                        break;
                    case "show last":
                        ShowLast(MyShop.Products);
                        break;
                    case "show visible":
                        ShowVisible(MyShop.Products);
                        break;
                    case "show invisible":
                        ShowInVisible(MyShop.Products);
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
        static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            Product NoteBook = new Product();
            NoteBook.Name = "Sony Waio";
            NoteBook.Model = "Sony Waio 256 Gb White";
            NoteBook.Price = 120;
            NoteBook.Visible = true;

            Product Tablet = new Product();
            Tablet.Name = "Apple Ipad";
            Tablet.Model = "Apple Ipad 32 Gb Grey";
            Tablet.Price = 50;
            Tablet.Visible = false;

            Product Phone = new Product();
            Phone.Name = "Samsung Galaxy S8";
            Phone.Model = "Samsung Galaxy S8 128 Gb Blue";
            Phone.Price = 80;
            Phone.Visible = true;

            Product UltraBook = new Product();
            UltraBook.Name = "Asus Laptop";
            UltraBook.Model = "Asus Laptop KA1 64 Gb Red";
            UltraBook.Price = 90;
            UltraBook.Visible = true;

            Product MacBook = new Product();
            MacBook.Name = "MacBook air";
            MacBook.Model = "MacBook air 13 128 Gb write";
            MacBook.Price = 150;
            MacBook.Visible = false;

            products.Add(NoteBook);
            products.Add(Tablet);
            products.Add(Phone);
            products.Add(UltraBook);
            products.Add(MacBook);

            return products;
        }
        static void Address()
        {
            Console.WriteLine(MyShop.Address);
        }
        static void Show(List<Product> products)
        {
            Console.WriteLine($"Всего в наличии {products.Count} товаров.");
            foreach (Product item in products)
            {
                Console.WriteLine(item.Model);
            }
        }
        static void ShowFirst(List<Product> products)
        {
            Console.WriteLine(products.First().Model);
        }
        static void ShowLast(List<Product> products)
        {
            Console.WriteLine(products.Last().Model);
        }
        static void ShowVisible(List<Product> products)
        {
            foreach (Product item in products)
            {
                if (item.Visible == true)
                Console.WriteLine(item.Model);
            }
        }
        static void ShowInVisible(List<Product> products)
        {
            foreach (Product item in products)
            {
                if (item.Visible == false)
                    Console.WriteLine(item.Model);
            }
        }
        static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
