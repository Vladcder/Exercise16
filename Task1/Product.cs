using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
    {
        [JsonPropertyName("Код")]
        public int Code { get; set; }

        [JsonPropertyName("Имя")]
        public string Name { get; set; }

        [JsonPropertyName("Цена")]
        public int Price { get; set; }


        public Product(int code, string name, int price)
        {
            Code=code;
            Name=name;
                Price=price;
        }
    }
}
