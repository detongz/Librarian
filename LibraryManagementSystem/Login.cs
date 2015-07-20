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
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\Login.png");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radManager.Checked == true)
            {
                int read = userInfo.adminLogin(txtID.Text, txtPwd.Text);
                if (read > 0)//判断密码用户是否正确
                {
                    //登录成功
                    Manager manager = new Manager(this);
                    this.Hide();
                    manager.Show();
                }

                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
            if (radReader.Checked == true)
            {

                //连接数据库,判断是否存在用户
                int read = 0 ;
                read = userInfo.userLogin(txtID.Text.Trim(), txtPwd.Text.Trim());
                if (read > 0)//判断密码用户是否正确
                {//登录成功
                    this.Hide();
                    Reader reader = new Reader(txtID.Text,this);
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
            System.Environment.Exit(0);
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(this);
            this.Hide();
            signUp.Show();
        }

    }
}
