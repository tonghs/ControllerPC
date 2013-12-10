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
    public partial class UpdatePwdForm : Form
    {
        public UpdatePwdForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String password = txtOldPwd.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入原密码！");
            }
            else 
            {
                password = StringUtil.MD5(password);
                String sysP = ConfigurationSettings.AppSettings["password"];

                if (sysP.Equals(password))
                {
                    string newPwd = txtNewPwd.Text;
                    string newPwdRe = txtNewPwdRe.Text;

                    if (string.IsNullOrEmpty(newPwd) || string.IsNullOrEmpty(newPwdRe))
                    {
                        MessageBox.Show("新密码不可为空");
                    }
                    else
                    {
                        if (newPwd == newPwdRe)
                        {
                            ConfigurationSettings.AppSettings["password"] = StringUtil.MD5(newPwd);
                            MessageBox.Show("修改成功！");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("两次新密码输入不一致！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("原密码错误！");
                }
            }
        }
    }
}
