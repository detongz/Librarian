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
    public partial class AddBook : Form
    {
        private string coverFilePath;//保存封面图片的路径
        Manager manager;
        private DataGridViewRow dataGridViewRow;
        /// <summary>
        /// 添加图书界面
        /// </summary>
        /// <param name="manager"></param>
        public AddBook(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\AddBook.png");
        }
        /// <summary>
        /// 重载addbook初始化函数，作为修改图书信息界面使用
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="dataGridViewRow"></param>
        public AddBook(Manager manager, DataGridViewRow dataGridViewRow)
        {
            // TODO: Complete member initialization
            this.manager = manager;
            this.dataGridViewRow = dataGridViewRow;
            InitializeComponent();

            txtISBN.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtName.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtAuthor.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtPressDate.Text = dataGridViewRow.Cells[4].Value.ToString();
            txtPress.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtPrice.Text = dataGridViewRow.Cells[5].Value.ToString();
            txtContent.Text = dataGridViewRow.Cells[6].Value.ToString();
            txtStock.Text = dataGridViewRow.Cells[7].Value.ToString();
            pbCover.Image = booksInfo.getBookCover(txtISBN.Text,(byte[])dataGridViewRow.Cells[8].Value);

            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\AddBook.png");
            this.btnQuit.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_quit.png");
            this.btnSave.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login_submit.png");

        }
        /// <summary>
        /// 初始化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBook_Load(object sender, EventArgs e)
        {
       }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.manager.Show();
            this.Close();
        }
        /// <summary>
        /// 保存图书信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string pat3 = @"^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$";//浮点数
            bool m3 = Regex.IsMatch(txtPrice.Text.Trim(), pat3);
            string pat2 = @"\d{4}-\d{2}-\d{2}";
            bool m2 = Regex.IsMatch(txtPressDate.Text.Trim(), pat2);

            if (txtISBN.Text == "") MessageBox.Show("ISBN号不能为空！", "提示");
            else if (txtName.Text == "") MessageBox.Show("书名不能为空！", "提示");
            else if (txtAuthor.Text == "") MessageBox.Show("作者不能为空！", "提示");
            else if (txtStock.Text == "") MessageBox.Show("库存不能为空！", "提示");
            else if (!m3) MessageBox.Show("图书价格应为XX.XX元！", "提示！");
            else if (!m2) MessageBox.Show("时间格式错误！", "提示！");
            else
            {
                ///查询是否已经有记录存在
                int intcont = booksInfo.findBookByIsbn(txtISBN.Text, txtName.Text);
                if (intcont != 0)//判断是否添加了相同的记录 
                {
                    try
                    {

                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.pbCover.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);//将当期pic
                        int rows = booksInfo.adminModifyBook(txtISBN.Text,
                             txtName.Text, txtAuthor.Text,
                             txtPress.Text, txtPressDate.Text,
                             txtPrice.Text, txtContent.Text,
                             txtStock.Text, ms.ToArray());
                        MessageBox.Show("修改成功!");
                    }
                    catch
                    {
                        MessageBox.Show("未进行修改");
                    }
                }
                if (intcont == 0)
                {
                    try
                    {   
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.pbCover.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        int rows = booksInfo.adminAddBook(txtISBN.Text,
                             txtName.Text, txtAuthor.Text,
                             txtPress.Text, txtPressDate.Text,
                             txtPrice.Text, txtContent.Text,
                             txtStock.Text, ms.ToArray());
                        MessageBox.Show("添加成功!");
                       
                    }
                    catch
                    {
                        MessageBox.Show("未进行修改");
                    }
                }
            }
            this.Close();
            manager.Show();
            manager.Manager_Load(manager, null);//刷新datagridview
        }
        /// <summary>
        /// 添加图书封面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            ofdViewPic.InitialDirectory = Application.StartupPath;//设置打开时的默认目录
            ofdViewPic.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";//控件打开的文件类型
            ofdViewPic.RestoreDirectory = true;
            ofdViewPic.CheckFileExists = true;
            ofdViewPic.CheckPathExists = true;
            ofdViewPic.Multiselect = false;
            ofdViewPic.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofdViewPic.ShowDialog() == DialogResult.OK)
            {
                //向PictureBox中装入图片
                coverFilePath = ofdViewPic.FileName;
                pbCover.ImageLocation = ofdViewPic.FileName;
               
            }
            else
            {
                MessageBox.Show("你没有选择图片!", "信息提示");
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
    }
}
