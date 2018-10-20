using Simple.DAL.Entities;
using Simple.DAL.Entities.Enums;
using Simple.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Simple.DAL
{
    public class CartDataService : ICartDataService
    {
        private static readonly log4net.ILog s_logger = log4net.LogManager.GetLogger(typeof(CartDataService));

        private const int DEFAULT_PRODUCTS_AMMOUNT = 10;
        private List<int> s_CartIDsList = null;
        private int m_AutoIncrementedID = 0;

        public CartDataService()
        {
            s_CartIDsList = new List<int>();
        }

        public int GenerateNewCartID()
        {
            int retVal = 0;
            try
            {
                m_AutoIncrementedID = m_AutoIncrementedID + 1;
                s_logger.Debug($"new id is: {m_AutoIncrementedID}");
                s_CartIDsList.Add(m_AutoIncrementedID);
                retVal = m_AutoIncrementedID;
            }
            catch (Exception ex)
            {
                s_logger.Error(ex);
                throw;
            }
            return retVal;
        }

        public List<Product> GetAvailableProducts()
        {
            var retVal = new List<Product>();
            try
            {
                var categories = new eCategory[] 
                {
                    eCategory.Meat,
                    eCategory.Drink,
                    eCategory.Vegetables
                };
                foreach (var cat in categories)
                {
                    for (int i = 1; i < DEFAULT_PRODUCTS_AMMOUNT + 1; i++)
                    {
                        retVal.Add(new Product($"{cat.ToString()}_{i}",cat));
                    }
                }
                
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
