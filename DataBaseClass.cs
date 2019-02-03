using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Marwa_DeskTop
{
  public  class DataBaseClass
    {
        public SqlConnection connect;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        SqlDataReader Reader;

        string dbName;
        string ServerName;
        public string ConnectionString;

        public DataBaseClass()
        {
            connect = new SqlConnection(ConnectionString);
            ServerName = "(local)";
            dbName = "MarwaDB";
         
            ConnectionString = string.Format("server={0}; database={1};trusted_connection=yes", ServerName, dbName);
            connect = new SqlConnection(ConnectionString);
            OpenConnection();
        }

        public void OpenConnection()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public DataTable ExecuteQuery(string sqlStmt)
        {
            connect = new SqlConnection(ConnectionString);
            cmd = new SqlCommand(sqlStmt, connect);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            cmd.CommandTimeout = 600;
            try
            {
                OpenConnection();

                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex; 
            }
            finally
            {
                CloseConnection();
            }
            return ds.Tables[0];
        }

        public int ExecuteNonQuery(string sql)
        {
            connect = new SqlConnection(ConnectionString);
            int recordsAffected;
            try
            {
                cmd = new SqlCommand(sql, connect);
                cmd.CommandTimeout = 600;
                OpenConnection();

                recordsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex; // new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return recordsAffected;
        }


        public Object ExecuteScalar(string sql)
        {
            connect = new SqlConnection(ConnectionString);

            Object returnValue;

            try
            {
                cmd = new SqlCommand(sql, connect);
                cmd.CommandTimeout = 600;

                OpenConnection();

                returnValue = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex; // new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            if (returnValue == null)
                return 0;
            else
                return returnValue;
        }

    }
}
