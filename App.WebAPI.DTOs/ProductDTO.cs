using System;
using System.Collections.Generic;
using System.Text;

namespace App.WebAPI.DTOs
{
    public class ProductDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Category { get; set; }
    }
}
