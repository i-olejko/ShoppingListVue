using App.Logic.Interfaces;
using Simple.DAL.Interfaces;
using System;

namespace App.Logic
{
    public class CartService : ICartService
    {
        private static readonly log4net.ILog s_logger = log4net.LogManager.GetLogger(typeof(CartService));
        private readonly ICartDataService m_CartDataService = null;

        public CartService(ICartDataService cartDataService)
        {
            m_CartDataService = cartDataService;
        }

        public int GenerateCartId()
        {
            try
            {
                return m_CartDataService.GenerateNewCartID();
            }
            catch (Exception ex)
            {
                s_logger.Error(ex);
                throw;
            }
        }
    }
}
