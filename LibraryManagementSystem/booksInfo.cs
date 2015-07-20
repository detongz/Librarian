using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace LibraryManagementSystem
{
    public class booksInfo
    {
        /// <summary>
        /// 向datagridview中，加载所有书籍目录
        /// </summary>
        /// <returns></returns>
        public static DataSet loadBooksInfo()
        {
            string sql = "select ISBN,Name,Author,Press,Date,Price,Content,Stock,Cover from book";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 搜索书籍
        /// </summary>
        /// <param name="method"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static DataSet searchBooksByMethod(string method, string target)
        {
            string sql = "select ISBN,Name,Author,Press,Date,Price,Content,Stock from book where " + method + " like '%" + target + "%' ";
            return dbHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 获取书籍封面图片信息
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Image getBookCover(string isbn)
        {
            string sql = "select cover from book where ISBN='" + isbn + "'";
            return Image.FromStream(new MemoryStream((byte[])dbHelper.GetScalar(sql)));
        }
        public static Image getBookCover(string isbn,byte[] imageByte)
        {
            return Image.FromStream(new MemoryStream(imageByte));
        }
        /// <summary>
        /// 用户借书操作
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ISBN"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="publisher"></param>
        /// <param name="stock"></param>
        /// <returns></returns>
        public static int readerBorrowBook(string id, string ISBN, string title, string author, string publisher,int stock)
        {
            string insert = "insert into [kept] (ID,ISBN,Name,Author,Press) values ('" + id + "','" + ISBN + "','" + title + "','" + author + "','" + publisher + "')";
            string update_storage = "update book set stock = " + stock + "- 1 where ISBN = '" + ISBN + "'";
            string update_user = "update reader set keptbook = keptbook +1 where id = '" + id + "'";
            return (Convert.ToInt32(dbHelper.ExecuteCommand(insert)) + Convert.ToInt32(dbHelper.ExecuteCommand(update_storage))+Convert.ToInt32(dbHelper.ExecuteCommand(update_user)));
        }
        /// <summary>
        /// 获取已借到的书记信息
        /// 利用kept表中存储的用户所接书籍的isbn信息，获取该isbn在book表中的所有有关记录
        /// 数据库两张表级联查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet getBorrowedInfo(string id)
        {
            string sql_kept = "select isbn from [kept] where id = '" + id + "'";
            string sql_book = "select * from book where isbn in (" + sql_kept + ")";
            return dbHelper.GetDataSet(sql_book);
        }
        /// <summary>
        /// 用户还书
        /// 需要从kept表中删除数据，在readers中更新保存书籍书目，需要更新书籍库存
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isbn"></param>
        public static int readerReturnBook(string id, string isbn)
        {
            string sql = "delete from [kept] where isbn ='" + isbn + "' and id ='" + id + "'";
            int success = 0;
            success += Convert.ToInt32(dbHelper.ExecuteCommand(sql));
            sql = "update book set Stock = Stock + 1 where isbn = '" + isbn + "'";
            success += Convert.ToInt32(dbHelper.ExecuteCommand(sql));
            sql = "update reader set keptbook = keptbook - 1 where id = '"+ id +"'";
            success += Convert.ToInt32(dbHelper.ExecuteCommand(sql));
            return success;
        }
        /// <summary>
        /// 管理员删除书记录
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public static int deleteBooks(string isbn)
        {
            string sql = "delete  from book where ISBN = '" + isbn + "'";
            return dbHelper.ExecuteCommand(sql);
        }
        public static int findBookByIsbn(string isbn,string title)
        {
            string sql = "select count(*) from [book] where Name = '" + title + "'or ISBN='" + isbn + "'";
            return Convert.ToInt32(dbHelper.GetScalar(sql));
        }
        /// <summary>
        /// 管理员添加图书
        /// </summary>
        /// <param name="ISBN"></param>
        /// <param name="Name"></param>
        /// <param name="Author"></param>
        /// <param name="Press"></param>
        /// <param name="Date"></param>
        /// <param name="Price"></param>
        /// <param name="Content"></param>
        /// <param name="Stock"></param>
        /// <param name="Cover"></param>
        /// <returns></returns>
        public static int adminAddBook
            (string ISBN,string Name,string Author,
            string Press,string Date,string Price,
            string Content, string Stock, byte[] Cover)
        {
            string sql = "insert into book (ISBN,Name,Author,Press,Date,Price,Content,Stock,Cover) values ('" +ISBN+"', '"+Name+"' ,'"+Author+"','"+Press + "' ,'" + Date + "' ," + Price + " ,'" +Content+"','"+Stock+"', @cover)";
            SqlCommand comm = new SqlCommand(sql,dbHelper.Conn());
            comm.Parameters.AddWithValue("@cover",Cover);
            return dbHelper.ExecuteCommand(comm);
        }
        /// <summary>
        /// 管理员修改图书信息
        /// </summary>
        /// <param name="ISBN"></param>
        /// <param name="Name"></param>
        /// <param name="Author"></param>
        /// <param name="Press"></param>
        /// <param name="Date"></param>
        /// <param name="Price"></param>
        /// <param name="Content"></param>
        /// <param name="Stock"></param>
        /// <param name="Cover"></param>
        /// <returns></returns>
        public static int adminModifyBook
             (string ISBN, string Name, string Author,
              string Press, string Date, string Price,
              string Content, string Stock, byte[] Cover)
        {
            string sql = "update book set ISBN = '" + ISBN + "',Name = '" + Name + "' ,Author = '" + Author + "',Press = '" + Press + "',Date = '" + Date + "',Price = " + Price + ",Content = '" + Content + "',Stock = '" + Stock + "',cover = @cover where ISBN = '" + ISBN + "'"; 
            SqlCommand comm = new SqlCommand(sql, dbHelper.Conn());
            comm.Parameters.AddWithValue("@cover", Cover);
            return dbHelper.ExecuteCommand(comm);
        }

    }
}
