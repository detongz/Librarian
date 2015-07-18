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
    public partial class AddBook : Form
    {
        private string coverFilePath;//保存封面图片的路径
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
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
                
                //按ISBN号和书名查询是否已经有记录存在

                if (1!=2)//判断是否添加了相同的记录 
                {
                    MessageBox.Show("对不起!不允许填写相同记录(已有相同ISBN号书籍信息)！");
                }
                if (1==1)
                {
                    try
                    {
                        //向数据库中插入数据
                        //获取的图片路径保存在coverFilePath
                        MessageBox.Show("添加成功!");

                    }
                    finally
                    {
                        //关闭数据库
                    }
                }
            } 
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

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
