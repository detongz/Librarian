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
            if (radManager.Checked == true)
            {
               
                //连接数据库

                if (1==1)//判断密码用户是否正确
                {//登录成功


                    Manager manager = new Manager();
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
               
                //连接数据库
                if (1 == 1)//判断密码用户是否正确
                {//登录成功
                    this.Hide();
                    Reader reader = new Reader();
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
