using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwa_DeskTop
{
   public class clsUsers
    {
        DataBaseClass db = new DataBaseClass();
        public int Adduser(string FullName, string UserName,string Email,string Password ,int PositionNo)

        {
            try
            {
                String sql = String.Format("insert into UserData (FullName,UserName,Email ,Password,PositionNo) values ('{0}', '{1}', '{2}' , '{3}',{4})", FullName,  UserName, Email, Password, PositionNo);
                return db.ExecuteNonQuery(sql);
            }
            catch(Exception)
            {
                throw;
            }
        }
   public DataTable GetUsers(int UserId=0)
        {
            try
            {
                if (UserId == 0)
                    return db.ExecuteQuery("select * from VWusers");
                else
                    return db.ExecuteQuery("select * from UserData where Id = " +UserId);

            }
            catch(Exception)
            {
                throw;
            }

        }


        public int CheckUser(string username, string password)
        {
            try
            {
                string sql = "Select Id from UserData where UserName ='" + username + "' and Password ='" + password + "'";
                return Int32.Parse(db.ExecuteScalar(sql).ToString());
            }
            catch(Exception )
            {
                throw;

            }

        }
       
    }
}
