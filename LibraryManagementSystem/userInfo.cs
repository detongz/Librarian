using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public class userInfo
    {
        /// <summary>
        /// 读者登录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static int userLogin(string id, string pwd)
        {
            string sql = "select count(*) from reader where Password = '" + pwd + "' and id ='" + id + "'";
            return  Convert.ToInt32(dbHelper.GetScalar(sql));
        }
        /// <summary>
        /// 根据用户名 判断用户是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int userLogin(string id)
        {
            string sql = "select count(*) from reader where id ='" + id + "'";
            return  Convert.ToInt32(dbHelper.GetScalar(sql));
        }
        /// <summary>
        /// 获取用户借书总数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int userKeptRecord(string id)
        {
            string sql = "select count(*) from kept where ID='" + id + "'";
            return  Convert.ToInt32(dbHelper.GetScalar(sql));
        }
        /// <summary>
        /// 判断用户是否借过某一册书
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public static int userKeptRecord(string id, string isbn)
        {
            string sql = "select count(*) from kept where id='" + id + "' and isbn ='"+isbn+"'";
            return Convert.ToInt32(dbHelper.GetScalar(sql));
        }
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static int adminLogin(string id, string pwd)
        {
            string sql = "select count(*) from admin where password = '" + pwd + "' and id = '" + id + "'";
            return Convert.ToInt32(dbHelper.GetScalar(sql));
        }
        /// <summary>
        /// 添加普通用户
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static int addUser(string id, string pwd)
        {
            string sql = "select count(*) from reader where id = '" + id + "'";
            if (Convert.ToInt32(dbHelper.GetScalar(sql)) > 0)
            {
                return -2;
            }
            sql = "insert into reader values ('" + id + "','" + pwd + "','" + 0 + "')";
            return dbHelper.ExecuteCommand(sql);
        }
        /// <summary>
        /// 加载所有用户信息
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static DataSet getAllUser(string type)
        {
            string sql = "select * from " + type;
            return dbHelper.GetDataSet(sql);
        }
        public static int addAdmin(string id, string pwd)
        {
            string sql = "select count(*) from admin where id = '" + id + "'";
            if (Convert.ToInt32(dbHelper.GetScalar(sql)) > 0)
            {
                return -2;
            }
            sql = "insert into admin values ('" + id + "','" + pwd + "','" + 0 + "')";
            return dbHelper.ExecuteCommand(sql);
        }
        /// <summary>
        /// 管理员更改用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <param name="type"></param>
        public static void updateUser(string id, string pwd, string type)
        {
            string sql = "update " + type + " set password = '" + pwd + "'，id = '" + id + "' where id = '" + id + "'";
        }
        /// <summary>
        /// 删除用户，同时要将改用户所借的书返回到原库存中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static int deleteUser(string id, string type)
        {
            string sql ="delete from "+type+" where id = '"+id+"'";
            return dbHelper.ExecuteCommand(sql);
        }
    }
}
