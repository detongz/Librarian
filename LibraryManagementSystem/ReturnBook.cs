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

namespace LibraryManagementSystem
{
    public partial class ReturnBook : Form
    {
        public string correctID;
        public int stock;
        Reader reader;
        public ReturnBook()
        {
            InitializeComponent();
        }
        public ReturnBook(string id,int stock, Reader reader)
        {
            InitializeComponent();
            this.correctID = id;
            this.stock = stock;
            this.reader = reader;
        }
 
        private void btnQuit_Click(object sender, EventArgs e)
        {
            quit();
        }
        /// <summary>
        /// 初始化dgv控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            //链接数据库，根据当前用户的correctID获取相关信息并绑定到dgv控件中
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\ReturnBackground.png");
            this.btnReturn.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_submit.png");
            this.btnQuit.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_quit.png");
            this.lblID.Text = correctID;
            this.lblAvailable.Text = 5.ToString();
            this.lblKept.Text = 0.ToString();
            int kept = 0;
            kept = Convert.ToInt32(userInfo.userKeptRecord(correctID));
            lblAvailable.Text =(5 - kept).ToString();
            lblKept.Text = kept.ToString();
            DataSet ds = booksInfo.getBorrowedInfo(correctID);
            dgvKeptBooks.DataSource = ds.Tables[0].DefaultView;

        }
        /// <summary>
        /// 单机dgv控件的单元格显示图书信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvKeptBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtISBN.Text = dgvKeptBooks.SelectedCells[7].Value.ToString();
            txtName.Text = dgvKeptBooks.SelectedCells[0].Value.ToString();          
        }
        /// <summary>
        /// 还书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") MessageBox.Show("请选择要还书籍！");
            else
            {             
                //根据用户ID和书籍的ISBN号连接数据库
                //更新数据库信息

                //连接数据库
                int success = 0;
                success = booksInfo.readerReturnBook(correctID, txtISBN.Text);
                if (success > 1)
                {
                        quit();
                        if (userInfo.userKeptRecord(correctID, txtISBN.Text) == -1)
                        {

                            MessageBox.Show("还书成功！");
                        }
                }
            }
        }
        /// <summary>
        /// 退出按钮引发的时间，还书成功后自动退出该页面
        /// </summary>
        private void quit()
        {
            this.Close();
            this.reader.Show();
            reader.Reader_Load(reader, null);
        }
    }
}
