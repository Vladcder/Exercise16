using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;

namespace Task1
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            for (int i=0; i<products.Length; i++)
            {
                int number = i + 1;
               
                bool isValid;
                int code = 0; ;
                string name="";
                int price=0;
                do
                {
                    isValid = false;
                    Console.WriteLine("Введите характеристики товара " + number + ":");
                    try
                    {
                        Console.Write("Введите код товара ");
                        code = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите название товара ");
                        name = Console.ReadLine();
                        Console.Write("Введите цену товара ");
                        price = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        isValid = true;
                    }
                }while (isValid);
                products[i] = new Product(code, name, price);


            }

            string jsonString=JsonSerializer.Serialize(products, JsonOptions.options);
            File.WriteAllText(JsonOptions.fullname, jsonString);





        }
    }

    public static class JsonOptions
    { 
        public  static string fullname = new FileInfo(@"Products.json").FullName;
        public static JsonSerializerOptions options = new JsonSerializerOptions()
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true,

        };
    }

}
