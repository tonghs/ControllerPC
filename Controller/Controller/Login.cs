using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Controller
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;            

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("用户名密码不可为空！");
            }
            else
            {
                password = StringUtil.MD5(password);
                if (login(username, password))
                {
                    this.Hide();
                    new Main().Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重试！");
                }
            }
        }

        private bool login(string username, string password)
        {
            bool isOk = false;
            String sysU = ConfigurationSettings.AppSettings["username"];
            String sysP = ConfigurationSettings.AppSettings["password"];

            if (string.IsNullOrEmpty(sysU) || string.IsNullOrEmpty(sysP))
            {
                MessageBox.Show("用户配置错误！");
            }
            else
            {
                isOk = sysU.Equals(username) && sysP.Equals(password);
            }

            return isOk;
        }
    }
}
