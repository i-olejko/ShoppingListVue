using Simple.DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public eCategory Category { get; set; }
    }
}
