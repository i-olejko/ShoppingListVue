using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Logic.Interfaces;
using App.WebAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly log4net.ILog s_logger = log4net.LogManager.GetLogger(typeof(ProductsController));
        private readonly ICartService m_CartService = null;

        public ProductsController(ICartService cartService)
        {
            m_CartService = cartService;
            log4net.LogicalThreadContext.Properties["context"] = Guid.NewGuid().ToString("N");
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> Get()
        {
            var retVal = new List<ProductDTO>();
            s_logger.Debug("Request for all available items");
            try
            {
                retVal = m_CartService.GetAllProducts()
                    .Select(p => new ProductDTO()
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        Category = (int)p.Category,
                        Image = p.Image
                    }).ToList<ProductDTO>();
            }
            catch (Exception ex)
            {
                s_logger.Error(ex);
                throw;
            }
            return retVal;
        }
    }
}