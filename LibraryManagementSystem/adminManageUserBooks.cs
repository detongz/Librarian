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
    public partial class adminManageUserBooks : Form
    {
        UserManagement mangement;
        string id;
        /// <summary>
        /// 初始化界面
        /// </summary>
        /// <param name="un"></param>
        /// <param name="Id"></param>
        public adminManageUserBooks(UserManagement un, string Id)
        {
            mangement = un;
            InitializeComponent();
            this.id = lblId.Text = Id;
            DataSet ds = booksInfo.getBorrowedInfo(Id);
            dgvRecord.DataSource = ds.Tables[0].DefaultView;
        }
        private void adminManageUserBooks_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\userBackground.png");
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            mangement.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lblBook.Text == "") MessageBox.Show("请选择要还书籍！");
            else
            {
                //根据用户ID和书籍的ISBN号连接数据库
                //更新数据库信息
                //连接数据库
                int success = 0;
                success = booksInfo.readerReturnBook(id, dgvRecord.CurrentRow.Cells[7].Value.ToString());
                if (success > 1)
                {
                    this.Close();
                    mangement.Show();
                    if (userInfo.userKeptRecord(id, lblBook.Text) == -1)
                    {

                        MessageBox.Show(lblId+": 还书成功！");
                    }
                }
            }
        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblBook.Text = dgvRecord.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
