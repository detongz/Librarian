using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Reader : Form
    {
        public string correctID;
        public string userid;
       public void getID(string id)
        {
           this.correctID = id;
        }
       public Reader(string name)
        {
            userid = name;
            InitializeComponent();
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            lblUsername.Text = userid;
            //打开数据库
            //初始化DGV控件顺序显示全部数据


        }

        
        /// <summary>
        /// 关闭窗口时提示信息，关闭整个程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Dispose();
                System.Environment.Exit(0);
            }
            else
                e.Cancel = true;

        }
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

                if (cmbSearch.Text == "书名")
                {
                    //打开数据库按书名查找       

                    //将结果绑定到dgv控件中
                    //dgvBook.DataSource = 

                }
                if (cmbSearch.Text == "作者")
                {
                    //打开数据库按作者查找 

                    //将结果绑定到dgv控件中
                    //dgvBook.DataSource = 
                    
                }
                if (cmbSearch.Text == "出版社")
                {
                    //打开数据库按出版社查找 

                    //将结果绑定到dgv控件中
                    //dgvBook.DataSource = 
                }
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
            txtISBN.Text = dgvBook.SelectedCells[0].Value.ToString();
            txtName.Text = dgvBook.SelectedCells[1].Value.ToString();
            txtAuthor.Text = dgvBook.SelectedCells[2].Value.ToString();
            txtPress.Text = dgvBook.SelectedCells[3].Value.ToString();
            txtPressDate.Text = dgvBook.SelectedCells[4].Value.ToString();
            txtPrice.Text = dgvBook.SelectedCells[5].Value.ToString();
            txtContent.Text = dgvBook.SelectedCells[6].Value.ToString();
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
                BorrowBook borrowBook = new BorrowBook();
                borrowBook.GetBookInfo( correctID, 
                                       dgvBook.SelectedCells[0].Value.ToString(),
                                       dgvBook.SelectedCells[1].Value.ToString(),
                                       dgvBook.SelectedCells[2].Value.ToString(),
                                       dgvBook.SelectedCells[3].Value.ToString(),
                                       dgvBook.SelectedCells[4].Value.ToString(),
                                       dgvBook.SelectedCells[5].Value.ToString(),
                                       dgvBook.SelectedCells[6].Value.ToString());
                borrowBook.ShowDialog();
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
            ReturnBook returnBook = new ReturnBook();
            returnBook.GetReaderInfo(correctID);
            returnBook.ShowDialog();
        }
    }
}
