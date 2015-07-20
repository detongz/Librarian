using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace LibraryManagementSystem
{
    public partial class BorrowBook : Form
    {
        public string correctID;
        public string isbn;
        Reader reader;
        public BorrowBook()
        {
            InitializeComponent();
        }
        public BorrowBook(Reader reader,string ISBN ,string id, string name, string author, string press, string date, string price,string content, string stock)
        {
            InitializeComponent();
            this.correctID = id;
            this.txtISBN.Text = ISBN;
            this.txtName.Text = name;
            this.txtAuthor.Text = author;
            this.txtPress.Text = press;
            this.txtPressDate.Text = date;
            this.txtPrice.Text = price;
            this.txtContent.Text = content;
            this.lblStock.Text = stock;
            this.reader = reader;
            this.isbn = ISBN;
            try
            {
                //把封面显示到PictureBox中
                this.pbCover.Image = booksInfo.getBookCover(ISBN);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                          
        }

        
        /// <summary>
        /// 借书
        /// ！！！！！有问题！！！！！！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            int i = userInfo.userKeptRecord(correctID);//获取用户已借所有书目数量
            int s = 5 - i;

            int count = -1;
            count = userInfo.userKeptRecord(correctID, this.isbn);//判断用户是否已借过同一本书
            if(count > 0)
            {
                MessageBox.Show("同一本书不能同时借一本以上！");
            }
            else if (i > 4)
            {
                MessageBox.Show("已借满5本书！不能再借。");
            }
            else
            {
                int rows = booksInfo.readerBorrowBook(correctID, txtISBN.Text.Trim(), txtName.Text.Trim(), txtAuthor.Text.Trim(), txtPress.Text.Trim(), Convert.ToInt32(this.lblStock.Text));
                if (rows == 2)
                {
                    this.Close();
                    this.reader.Show();
                    MessageBox.Show("借书成功");
                }
            }
            quit();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\BorrowBackground.png");
            this.btnBorrow.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_submit.png");
            this.btnQuit.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_quit.png");         
            this.lblKept.Text = 0.ToString();
            this.lblAvailable.Text = 5.ToString();
            this.lblID.Text = correctID;
            int read = 0;
            read = userInfo.userLogin(correctID);
            if (read > 0)
            {
                int i = userInfo.userKeptRecord(correctID);
                lblKept.Text = i.ToString();
                int s = 5 - i;
                if (s <= 0)
                {
                    lblAvailable.Text = 0.ToString();
                }
                else
                {
                    lblAvailable.Text = s.ToString();
                }              
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            quit();
        }
        private void quit()
        {
            this.Close();
            this.reader.Show();
            reader.Reader_Load(reader, null);
        }
    }
}
