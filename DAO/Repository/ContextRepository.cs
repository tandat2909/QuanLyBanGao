using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Repository
{
    public class ContextRepository
    {
        //List<ManageContext> listIntanceContext = new List<ManageContext>();
        public ManageContext GetContext()
        {
            return new ManageContext();
        }
    }
}
