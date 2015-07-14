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

namespace LibraryManagementSystem
{
    public partial class Manager : Form
    {
      
        public Manager()
        {
           
            InitializeComponent();
        }
        /// <summary>
        /// 关闭窗口时提示信息，关闭整个进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                Application.Exit();
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            //打开数据库
            //初始化DGV控件顺序显示全部数据
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
            txtISBN.Text = dgvBook.SelectedCells[0].Value.ToString();
            txtName.Text = dgvBook.SelectedCells[1].Value.ToString();
            txtAuthor.Text = dgvBook.SelectedCells[2].Value.ToString();
            txtPress.Text = dgvBook.SelectedCells[3].Value.ToString();
            txtPressDate.Text = dgvBook.SelectedCells[4].Value.ToString();
            txtPrice.Text = dgvBook.SelectedCells[5].Value.ToString();
            txtContent.Text = dgvBook.SelectedCells[6].Value.ToString();
            //将数据库中的图片插入PictureBox中
        }
        /// <summary>
        /// 新增图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }
        /// <summary>
        /// 修改图书信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            //控制输入格式
            string pat3 = @"^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$";//浮点数
            bool m3 = Regex.IsMatch(txtPrice.Text, pat3);
            string pat2 = @"\d{4}-\d{2}-\d{2}";
            bool m2 = Regex.IsMatch(txtPressDate.Text, pat2);


            if (txtISBN.Text == "") MessageBox.Show("ISBN号不能为空！", "提示");
            else if (txtName.Text == "") MessageBox.Show("书名不能为空！", "提示");
            else if (txtAuthor.Text == "") MessageBox.Show("作者不能为空！", "提示");
            else if (txtStock.Text == "") MessageBox.Show("作者不能为空！", "提示");
            else if (!m3) MessageBox.Show("图书价格应为XX.XX元！", "提示！");
            else if (!m2) MessageBox.Show("时间格式错误！", "提示！");
            else
            {               
                //连接数据库


                try
                {
                    //更新数据库信息
                    MessageBox.Show("修改成功!");

                }
                finally
                {
                    //关闭数据库
                }
            }
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
            DialogResult ret = MessageBox.Show("确定要删除 书名为：'" + txtName.Text + "'，ISBN号为：'" + txtISBN.Text + "'的记录吗？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel) return;
            //确定删除
            //删除数据库中的数据
            //string strDelect = "delete  from book where ISBN号 = '" + txtISBN.Text + "'";
            //SqlCommand conDelect = new SqlCommand(strDelect, connD);
            //connD.Open();
            ////更新dgv控件的数据
            //int rows = conDelect.ExecuteNonQuery();
            //if (rows > 0)
            //{
            //    foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            //    {

            //        dataGridView1.Rows.Remove(r);

            //    }
            //    MessageBox.Show("删除成功！");
            //}


            //connD.Close();
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
