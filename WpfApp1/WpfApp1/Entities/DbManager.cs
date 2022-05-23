using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Entities;


namespace WpfApp1.Entities
{
    public class DbManager
    {
        public static KursEntities DBContext;
        public static KursEntities GetContext()
        {
                if (DBContext == null)
                    DBContext = new KursEntities();
                return DBContext;
            
        }
    }
}
