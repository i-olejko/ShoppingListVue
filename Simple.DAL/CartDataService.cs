using Simple.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Simple.DAL
{
    public class CartDataService : ICartDataService
    {
        private static readonly log4net.ILog s_logger = log4net.LogManager.GetLogger(typeof(CartDataService));

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
    }
}
