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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取读者信息
        /// </summary>
        /// <param name="id"></param>
        public void GetReaderInfo(string id)
        {
            this.lblID.Text = id;      
            //获取读者可借书籍数目以及已经借了的书数目
            //lblKept.Text = ;
            //lblAvailable.Text = ;

        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 初始化dgv控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            //链接数据库，根据当前用户的correctID获取相关信息并绑定到dgv控件中

        }
        /// <summary>
        /// 单机dgv控件的单元格显示图书信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvKeptBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtISBN.Text = dgvKeptBooks.SelectedCells[0].Value.ToString();
            txtName.Text = dgvKeptBooks.SelectedCells[1].Value.ToString();          
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
                MessageBox.Show("还书成功！");
                this.Close();

            }
        }
    }
}
