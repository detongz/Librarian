using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public class dbHelper
    {
        public static SqlConnection conn;
        public static SqlConnection Conn()
        {
                string strConn = "Data Source=.;Initial Catalog=MyLibraryDB;Integrated Security=True";//ConfigurationManager.AppSettings["conn"];
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                    conn.Open();
                }
                else if (conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }
                else if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
        }
        public static int ExecuteCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn());
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public static int ExecuteCommand(SqlCommand cmd)
        {
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public static object GetScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn());
            object o = cmd.ExecuteScalar();
            conn.Close();
            return o;
        }
        public static DataSet GetDataSet(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, Conn());
            DataSet ds = new DataSet();
            adp.Fill(ds);
            conn.Close();
            return ds;
        }

    }
}
