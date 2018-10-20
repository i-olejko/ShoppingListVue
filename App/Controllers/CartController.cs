using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Logic.Interfaces;
using App.WebAPI.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace App.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private static readonly log4net.ILog s_logger = log4net.LogManager.GetLogger(typeof(CartController));
        private readonly ICartService m_CartService = null;

        public CartController(ICartService cartService)
        {
            log4net.LogicalThreadContext.Properties["context"] = Guid.NewGuid().ToString("N");
            m_CartService = cartService;
        }
        // GET api/cart
        [HttpGet]
        public ActionResult<NewCartDTO> Get()
        {
            var retVal = new NewCartDTO();
            try
            {                
                retVal.NewCartID = m_CartService.GenerateCartId();
            }
            catch (Exception ex)
            {
                s_logger.Error(ex);
                throw;
            }
            return retVal;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
