using Simple.DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.DAL.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public eCategory Category { get; set; }

        public Product(string name, eCategory cat, string image = "")
        {
            Random rnd = new Random();
            Id = Guid.NewGuid().ToString("N");
            Price = rnd.Next(1,100);
            Name = name;
            Category = cat;
            Image = image;
        }
    }
}
