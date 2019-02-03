using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwa_DeskTop
{
   public class clsPosition
    {
        DataBaseClass db = new DataBaseClass();
        public DataTable GetPosition()
        {
            try
            {
                string sqlSelect = "select * from Position";
                return db.ExecuteQuery(sqlSelect);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
