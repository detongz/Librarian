using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace LibraryManagementSystem
{
    public partial class Manager : Form
    {
        public string coverFilePath;//保存封面图片的路径
        public Boolean changePic = false;
        Login login;
        string preISBN;
        string preName;
        public Manager(Login login)
        {
            this.login = login;
            InitializeComponent();
        }

        public void Manager_Load(object sender, EventArgs e)
        {

            this.lblKeyWord.BackColor = Color.Transparent;
            this.lblSearchWay.BackColor = Color.Transparent;
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Mbackground.png");
            this.btnSearch.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_submit.png");
            this.btnChange.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_submit.png");
            this.btnDelete.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_quit.png");
            //打开数据库           
            this.dgvBook.AllowUserToDeleteRows = false; ///不允许删除数据

            DataSet ds = booksInfo.loadBooksInfo();
            dgvBook.DataSource = ds.Tables[0].DefaultView;
           
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

                string searchType;
                switch (cmbSearch.Text)
                {
                    case ("出版社"):
                        searchType = "Press"; break;
                    case ("作者"):
                        searchType = "Author"; break;
                    default:
                        searchType = "Name"; break;
                }
                DataSet ds = booksInfo.searchBooksByMethod(searchType, txtKeyWord.Text.Trim());
                dgvBook.DataSource = ds.Tables[0].DefaultView;
                
            }
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Manager_Load(this, null);
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
        /// 显示全部数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnALL_Click(object sender, EventArgs e)
        {
            Manager_Load(this, null);
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
                preISBN = txtISBN.Text;
                preName = txtName.Text;
                pbCover.Image = booksInfo.getBookCover(txtISBN.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                    
        }
        /// <summary>
        /// 新增图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(this);
            this.Hide();
            addBook.Show();
        }
        /// <summary>
        /// 修改图书信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //打开数据库
            //询问是否确定删除
            if(txtISBN.Text.Equals(""))
            {
                MessageBox.Show("请选择要删除的书籍！");
                return;
            }
            
            DialogResult ret = MessageBox.Show("确定要删除 书名为：'" + txtName.Text + "'，ISBN号为：'" + txtISBN.Text + "'的记录吗？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel) return;
            int success = booksInfo.deleteBooks(txtISBN.Text);
            if (success > 0)
            {
                foreach (DataGridViewRow r in dgvBook.SelectedRows)
                {
                    dgvBook.Rows.Remove(r);
                }
                MessageBox.Show("删除成功！");
            }
            
        }
        /// <summary>
        /// 控制库存只能为数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;//判断为数字
            }
        }
        /// <summary>
        /// 退出当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要注销？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
                this.login.Show();
            }
            
        }

        /// <summary>
        /// 点击modify按钮，对图书数据进行修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(this,dgvBook.CurrentRow);
            this.Hide();
            addBook.Show();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            UserManagement user = new UserManagement(this);
            this.Hide();
            user.Show();
        }
    }
}
