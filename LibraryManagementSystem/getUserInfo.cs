using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public static class getUserInfo
    {
        public static int userLogin(string id, string pwd, int group)
        {
            string sql = "select userGroup from users where passwd = '" + pwd
                + "' and id ='" + id + "' and userGroup = '" + group+ "'";
            int success = Convert.ToInt32(dbHelper.GetScalar(sql));
            return success;
        }   
    }
}
