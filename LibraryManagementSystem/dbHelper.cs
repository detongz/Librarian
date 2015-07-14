using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/*
  数据访问层dbHelper
 * 
 * 数据库分三个表，user表，books表，borrowRecord表
 * 
 * user表记录用户基本信息
 * books表记录书籍基本信息
 * borrowRecords表记录书籍借出信息
 */

namespace LibraryManagementSystem
{
    public static class dbHelper
    {
        public static SqlConnection conn;
        public static SqlConnection Conn
        {
            get
            {
                string strConn = ConfigurationManager.AppSettings["conn"];
                //configurationManager不存在上下文终极解决方案：引用中添加system.configuratioin
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                    conn.Open();
                }
                else if (conn.State==ConnectionState.Broken)
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
        }
    }
}
