using System;
using System.Collections.Generic;
using System.Text;

namespace App.WebAPI.DTOs
{
    public class CartToSaveDTO
    {
        public int CartID { get; set; }
        public List<ProductDTO> products { get; set; }
    }
}
