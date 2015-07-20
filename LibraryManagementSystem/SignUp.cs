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
    public partial class SignUp : Form
    {
        int flag = 0;//判断是否更改用户权限
        Login login;
        UserManagement mangement;
        public SignUp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 管理员修改用户信息
        /// </summary>
        /// <param name="um"></param>
        /// <param name="dr"></param>
        public SignUp(UserManagement um, DataGridViewRow dr,int Flag)
        {
            this.mangement = um;
            InitializeComponent();
            this.txtID.ReadOnly = true;
            this.lblShade.Hide();
            this.txtID.Text = dr.Cells[0].Value.ToString();
            this.txtPwd.Text = dr.Cells[1].Value.ToString();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\signUp.png");
            this.flag = Flag;
        }
        /// <summary>
        /// 普通用户注册
        /// </summary>
        /// <param name="login"></param>
        public SignUp(Login login)
        {
            InitializeComponent();
            this.login = login;
        }
        /// <summary>
        /// 默认页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUp_Load(object sender, EventArgs e)
        {
            radManager.Checked = false;
            radReader.Checked = true;
            txtID.Focus();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Image\signUp.png");
            if (flag == 1)
            {

                radManager.Checked = true;
                radReader.Checked = false;
            }
        }
        /// <summary>
        /// 返回上层页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            exit();
        }
        /// <summary>
        /// 主体业务逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (login != null)
            {
                int result = userInfo.addUser(txtID.Text, txtPwd.Text);
                    if (result == -2)
                    {
                        MessageBox.Show("该用户已存在");
                        return;
                    }
                    MessageBox.Show("用户注册成功！");
            }
            else
            {
                if (flag == 1 && radReader.Checked == true)//如果用户类型被改变，且最终是读者类型
                {
                    int result = userInfo.addUser(txtID.Text, txtPwd.Text);
                    if (result == -2)
                    {
                        MessageBox.Show("该用户已存在");
                        return;
                    }
                }
                else if (flag == 0 && radManager.Checked == true)//如果用户类型被改变，且最终是管理员类型
                {
                    int result = userInfo.addAdmin(txtID.Text, txtPwd.Text);
                    if (result == -2)
                    {
                        MessageBox.Show("该管理员已存在");
                        return;
                    }
                    exit();
                }
                else//如果用户类型没有被改变，更新用户数据
                {
                    string type;
                    if (radReader.Checked == true)
                    {
                        type = "reader";
                    }
                    else
                    {
                        type = "admin";
                    }
                    userInfo.updateUser(txtID.Text, txtPwd.Text, type);
                }
            }
            exit();
        }
        private void exit()
        {
            this.Close();
            if (login != null)//普通注册
            {
                login.Show();
            }
            if (mangement != null)//管理员修改用户信息
            {
                mangement.Show();
                mangement.UserManagement_Load(mangement, null);//重新载入数据
            }
        }
    }
}
