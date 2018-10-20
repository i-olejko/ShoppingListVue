using Simple.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Logic.Interfaces
{
    public interface ICartService
    {
        int GenerateCartId();
        List<Product> GetAllProducts();
    }
}
