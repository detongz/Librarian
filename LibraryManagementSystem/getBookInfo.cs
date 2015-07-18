using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibraryManagementSystem
{
    class getBookInfo
    {
        public static DataSet bookByName(string name)
        {
            string sql = "select * from books where name = '" + name + "'";
            return dbHelper.GetDataSet(sql);
        }  
        public static DataTable bookByAuthor(string author)
        {
            string sql = "select * from books where author = '" + author + "'";
            return dbHelper.GetDataSet(sql).Tables["name"];
        }  
        public static DataTable bookByPress(string press)
        {
            string sql = "select * from books where press = '" + press + "'";
            return dbHelper.GetDataSet(sql).Tables["name"];
        }  
    }
}
