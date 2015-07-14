using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BorrowBook : Form
    {
        /// <summary>
        /// 获取选中的书籍信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isbn"></param>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="press"></param>
        /// <param name="pressDate"></param>
        /// <param name="price"></param>
        /// <param name="content"></param>
        public void GetBookInfo(string id, string isbn, string name, string author, string press, string pressDate, string price, string content)
        {
            this.lblID.Text = id;
            this.txtISBN.Text = isbn;
            this.txtName.Text = name;
            this.txtAuthor.Text = author;
            this.txtPress.Text = press;
            this.txtPressDate.Text = pressDate;
            this.txtPrice.Text = price;
            this.txtContent.Text = content;
            //获取封面
            //this.pbCover.ImageLocation = 
            //获取读者可借书籍数目以及已经借了的书数目
            //lblKept.Text = ;
            //lblAvailable.Text = ;

        }
       
        public BorrowBook()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// 借书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            //连接数据库

            //判断所借书籍数目书否达到上限
            if (1 != 1)
            {
                MessageBox.Show("已借满5本书！不能再借。");
            }
            else
            {
                //更新数据库中图书租借信息

                //更新数据库中读者借书信息
                MessageBox.Show("借书成功");
                this.Close();


            }
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            
           
           
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
