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
    public partial class UserManagement : Form
    {
        Manager manager;
        public UserManagement(Manager manager)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\userBackground.png");
            this.txtID.ReadOnly = true;
            this.manager = manager;
        }
        public void UserManagement_Load(object sender, EventArgs e)
        {

            //向datagridview中载入数据
            DataSet ds = userInfo.getAllUser("reader");
            dgvReader.DataSource = ds.Tables[0].DefaultView;
            DataSet ds2 = userInfo.getAllUser("admin");
            dgvAdmin.DataSource = ds2.Tables[0].DefaultView;
        }

        private void btuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            manager.Show();
            manager.Manager_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("请选择要删除的用户！");
                return;
            }

            DialogResult ret = MessageBox.Show("确定要删除用户名为：'"+txtID.Text.Trim()+"'的记录吗？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel) return;
            int success = -2;
            if (radAdmin.Checked == true)
            {
                success = userInfo.deleteUser(txtID.Text.Trim(),"admin");

            }
            else
            {
                success = userInfo.deleteUser(txtID.Text.Trim(), "reader");
            }
            if (success > 0)
            {
                MessageBox.Show("删除成功！");
                UserManagement_Load(this,null);
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            //管理员用户
            if(this.tabControl1.SelectedTab == this.tabPage1)
            {
                SignUp su = new SignUp(this,dgvAdmin.CurrentRow,1);
                su.Show();
                this.Hide();
            }
            //普通用户
            else
            {
                SignUp su = new SignUp(this, dgvReader.CurrentRow,0);
                su.Show();
                this.Hide();
            }
        }


        private void dgvAdmin_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvAdmin.SelectedCells[0].Value.ToString();
            this.radAdmin.Checked = true;
            this.radReader.Checked = false;
        }

        private void dgvReader_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvReader.SelectedCells[0].Value.ToString();
            this.radAdmin.Checked = false;
            this.radReader.Checked = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("请选中一个用户");
            }
            else
            {
                if (this.radReader.Checked == true)
                {
                    adminManageUserBooks ub = new adminManageUserBooks(this, txtID.Text.Trim());
                    this.Hide();
                    ub.Show();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UserManagement_Load(this, null);
        }

        private void dgvReader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
