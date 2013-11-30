using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Controller
{
    public partial class Main : Form
    {        
        SockectUtil su = new SockectUtil();
        XmlUtil xu = new XmlUtil();
        public Main()
        {
            InitializeComponent();
            //绑定数据源
            this.BindData();
        }

        private void BindData()
        {
            try
            {
                DataTable dt = xu.GetXmlTable();
                cmbModules.DataSource = dt;
                cmbModules.DisplayMember = "name";
                cmbModules.ValueMember = "ip";
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动错误，请检查配置文件");
            }
            setText(cmbModules.SelectedValue.ToString());
        }

        private void cmbModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ip = cmbModules.SelectedValue.ToString();
            setText(ip);
            
        }

        /// <summary>
        /// 设置显示文字
        /// </summary>
        /// <param name="ip"></param>
        public void setText(String ip)
        {
            DataTable dt = xu.GetXmlTable();
            if (dt.Rows != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["ip"].ToString() == ip)
                    {
                        this.lblSwitch1.Text = dr["switch1"].ToString();
                        this.lblSwitch2.Text = dr["switch2"].ToString();
                        this.lblSwitch3.Text = dr["switch3"].ToString();
                        this.lblSwitch4.Text = dr["switch4"].ToString();
                        this.lblSwitch5.Text = dr["switch5"].ToString();
                        this.lblSwitch6.Text = dr["switch6"].ToString();
                        this.lblIp.Text = ip;
                        this.lblPort.Text = dr["port"].ToString();
                        break;
                    }
                }
            }
        }

        private void file_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switch_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string name = btn.Name;            
            int state = 0;//开关状态
            if (name.Contains("On"))
            {
                state = 1;
            }
            else if (name.Contains("Off"))
            {
                state = 0;
            }
            //第几个开关
            int index = int.Parse(btn.Tag.ToString());
            //接收端ip
            string ip = cmbModules.SelectedValue.ToString();
            int port = int.Parse(lblPort.Text);
            //发送
            su.Send(ip, port, index, state);
        }

        private void file_NewModule_Click(object sender, EventArgs e)
        {
            NewModule newModuleForm = new NewModule();
            newModuleForm.ShowDialog();
            BindData();
        }

        private void file_ModuleMgr_Click(object sender, EventArgs e)
        {
            ModuleMgr mgrForm = new ModuleMgr();
            mgrForm.ShowDialog();
            BindData();
        }

    }
}
