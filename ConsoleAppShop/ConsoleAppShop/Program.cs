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
            MyShop.Addresses = GetAddress();

            Console.WriteLine("Доступные команды: 1.address 2.show 3.show first 4.show last 5.show visible 6.show invisible 7.exit ");

            while (true)
            {
                Console.Write("Введите команду: ");

                string command = Console.ReadLine();

                switch (command)
                {
                    case "address":
                        Address(MyShop.Addresses);
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
        static List<Address> GetAddress()
        {
            List<Address> addresses = new List<Address>();

            Address legal_address = new Address
            {
                Type = "Юридический адрес",
                Sity = "Иркутск",
                Street = "Маяковского",
                Home = 2,
                Index = 664005,
                Phone_number = 88002003000,
                Email = "irkutsk@dns.ru"
            };

            Address actual_address = new Address
            {
                Type = "Фактический адрес",
                Sity = "Кызыл",
                Street = "Дружбы",
                Home = 137,
                Index = 667000,
                Phone_number = 88002001000,
                Email = "kyzyl@dns.ru"
            };

            Address postal_address = new Address
            {
                Type = "Почтовый адрес",
                Sity = "Иркутск",
                Street = "Маяковского",
                Home = 2,
                Index = 664005
            };

            addresses.Add(legal_address);
            addresses.Add(actual_address);
            addresses.Add(postal_address);

                return addresses;
        }
        static void Address(List<Address> addresses)
        {
            foreach (Address item in addresses)
            {
                Console.WriteLine($"{item.Type}: индекс {item.Index}, г. {item.Sity}, ул. {item.Street}, д. {item.Home}, {item.Phone_number}, {item.Email}");
            }
           
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
