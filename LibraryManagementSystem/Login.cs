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
    public partial class Login : Form
    {
 
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            radManager.Checked = false;
            radReader.Checked = true;
            txtID.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //三层架构——数据连接层，获取用户登录信息
            int success = getUserInfo.userLogin(txtID.Text.Trim(), txtPwd.Text.Trim());

                if (radManager.Checked == true)
                {

                    if (success==2)//判断密码用户是否正确
                    {//登录成功
                        this.Hide();
                        Reader reader = new Reader(txtID.Text.Trim());
                        reader.Show();

                    }
                    else
                    {
                        MessageBox.Show("登录失败！");
                    }

                }
                if (radReader.Checked == true)
                {

                    if (success==1)//判断密码用户是否正确
                    {//登录成功
                        this.Hide();
                        Reader reader = new Reader(txtID.Text.Trim());
                        reader.Show();

                    }
                    else
                    {
                        MessageBox.Show("登录失败！");
                    }

                }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
