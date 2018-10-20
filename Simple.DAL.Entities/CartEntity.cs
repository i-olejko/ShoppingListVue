using System;
using System.Collections.Generic;

namespace Simple.DAL.Entities
{
    public class CartEntity
    {
        public int Id { get; set; }
        List<Product> products { get; set; }
    }
}
