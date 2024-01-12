using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Файл для десериализации должен находиться по адресу  "+ JsonOptions.fullname);
            var jsonString = File.ReadAllText(JsonOptions.fullname);
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString, Task1.JsonOptions.options);
            Product productWithMaxPrice=products[0];
            foreach (var product in products)
            {
                if (product.Price > productWithMaxPrice.Price)
                {
                    productWithMaxPrice= product;
                }
            }
            Console.WriteLine("Наибольшей ценой обладает продукт с названием "+productWithMaxPrice.Name);
            Console.ReadKey();
        }
    }
}
