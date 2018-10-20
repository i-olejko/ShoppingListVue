using Simple.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.DAL.Interfaces
{
    public interface ICartDataService
    {
        int GenerateNewCartID();
        List<Product> GetAvailableProducts();
    }
}
