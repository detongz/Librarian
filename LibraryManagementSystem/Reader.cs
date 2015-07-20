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
    public partial class Reader : Form
    {
        public string correctID;//用来传递登录名
        Login login;
        public Reader()
        {
            InitializeComponent();
        }
        public Reader(string id, Login login)
        {
            InitializeComponent();
            this.correctID = id;
            this.login = login;
        }

        public void Reader_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Rbackground.png");
            this.btnSearch.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_submit.png");
            //打开数据库           
            this.dgvBook.AllowUserToDeleteRows = false; ///不允许删除数据
           
            DataSet ds = booksInfo.loadBooksInfo();
            dgvBook.DataSource = ds.Tables[0].DefaultView;
        }

        
        /// <summary>
        /// 关闭窗口时提示信息，关闭整个进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        /// <summary>
        /// 按关键字和分类查找书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyWord.Text == "")
            {
                MessageBox.Show("请输入搜索关键字！", "提示");
            }
            else if (cmbSearch.Text == "")
            {
                MessageBox.Show("请选择查询项！");
            }
            else
            {
                string searchType;
                switch (cmbSearch.Text)
                {
                    case("出版社"):
                        searchType = "Press";break;
                    case("作者"):
                        searchType = "Author";break;
                    default:
                        searchType = "Name";break;
                }
                DataSet ds = booksInfo.searchBooksByMethod(searchType, txtKeyWord.Text.Trim());
                dgvBook.DataSource = ds.Tables[0].DefaultView;
                
            }
        }


        /// <summary>
        /// 显示全部数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnALL_Click(object sender, EventArgs e)
        {
            Reader_Load(this, null);
        }


        /// <summary>
        /// 单击dgv控件显示详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtISBN.Text = dgvBook.SelectedCells[0].Value.ToString();
                txtName.Text = dgvBook.SelectedCells[1].Value.ToString();
                txtAuthor.Text = dgvBook.SelectedCells[2].Value.ToString();
                txtPress.Text = dgvBook.SelectedCells[3].Value.ToString();
                txtPressDate.Text = dgvBook.SelectedCells[4].Value.ToString();
                txtPrice.Text = dgvBook.SelectedCells[5].Value.ToString();
                txtContent.Text = dgvBook.SelectedCells[6].Value.ToString();
                txtStock.Text = dgvBook.SelectedCells[7].Value.ToString();
                this.pbCover.Image = booksInfo.getBookCover(txtISBN.Text.Trim());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                                                            
        }


        /// <summary>
        /// 刷新，重新加载信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reader_Load(this, null);
            txtISBN.Text = "";
            txtName.Text = "";
            txtAuthor.Text = "";
            txtPress.Text = "";
            txtPressDate.Text = "";
            txtPrice.Text = "";
            txtContent.Text = "";
            txtStock.Text = "";
            pbCover.Image = null;
        }



        /// <summary>
        /// 进入借书界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            
            if(this.dgvBook.SelectedRows.Count != 0)
            {
                this.Hide();
                BorrowBook borrowBook = new BorrowBook(this,
                                                       dgvBook.SelectedCells[0].Value.ToString() , correctID,
                                                       dgvBook.SelectedCells[1].Value.ToString(),
                                                       dgvBook.SelectedCells[2].Value.ToString(),
                                                       dgvBook.SelectedCells[3].Value.ToString(),
                                                       dgvBook.SelectedCells[4].Value.ToString(),
                                                       dgvBook.SelectedCells[5].Value.ToString(),
                                                       dgvBook.SelectedCells[6].Value.ToString(),
                                                       dgvBook.SelectedCells[7].Value.ToString());
                
                borrowBook.Show();
            }
            else
            {
                MessageBox.Show("请选择要借阅的图书！");
            }
        }


        /// <summary>
        /// 进入还书界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            int stock = 0;
            if(!txtStock.Text.Equals(""))
            {
                 stock = Convert.ToInt32(txtStock.Text.ToString());
            }            
            ReturnBook returnBook = new ReturnBook(correctID, stock,this);
            returnBook.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要注销？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
                this.login.Show();                   
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

    }
}
