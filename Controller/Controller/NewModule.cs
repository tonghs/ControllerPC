using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controller
{
    public partial class NewModule : Form
    {
        XmlUtil xu = new XmlUtil();
        private string ip_ = "";
        string action = "add";

        public NewModule()
        {
            InitializeComponent();
            this.BindData();
        }

        /// <summary>
        /// 绑定区域列表
        /// </summary>
        public void BindData()
        {
            DataTable dt = xu.GetArea();
            this.cmbArea.DataSource = dt;
            this.cmbArea.DisplayMember = "name";
            this.cmbArea.ValueMember = "name";
        }

        public NewModule(string ip, string action, string areaName)
        {
            InitializeComponent();
            this.cmbArea.Text = areaName;
            this.cmbArea.SelectedValue = areaName;
            this.ip_ = ip;
            this.action = action;
            if (!action.Equals("add"))
            {
                DataTable dt = xu.GetXmlTable(areaName);
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["ip"].ToString() == ip)
                        {
                            this.txtName.Text = dr["name"].ToString();
                            this.txtIP.Text = dr["ip"].ToString();
                            this.txtPort.Text = dr["port"].ToString();
                            this.txtSwitch1.Text = dr["switch1"].ToString();
                            this.txtSwitch2.Text = dr["switch2"].ToString();
                            this.txtSwitch3.Text = dr["switch3"].ToString();
                            this.txtSwitch4.Text = dr["switch4"].ToString();
                            this.txtSwitch5.Text = dr["switch5"].ToString();
                            this.txtSwitch6.Text = dr["switch6"].ToString();

                            this.txtEp1.Text = dr["ep1"].ToString();
                            this.txtEp2.Text = dr["ep2"].ToString();
                            this.txtEp3.Text = dr["ep3"].ToString();
                            this.txtEp4.Text = dr["ep4"].ToString();
                            this.txtEp5.Text = dr["ep5"].ToString();
                            this.txtEp6.Text = dr["ep6"].ToString();
                            break;
                        }
                    }
                }
            }
        }        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isExsist = false;
            string areaName = this.cmbArea.Text; ;
            string name = this.txtName.Text;
            string ip = this.txtIP.Text.Trim();
            string port = this.txtPort.Text;
            string[] switches = new String[6];
            switches[0] = this.txtSwitch1.Text;
            switches[1] = this.txtSwitch2.Text;
            switches[2] = this.txtSwitch3.Text;
            switches[3] = this.txtSwitch4.Text;
            switches[4] = this.txtSwitch5.Text;
            switches[5] = this.txtSwitch6.Text;

            string[] eps = new String[8];
            eps[0] = this.txtEp1.Text;
            eps[1] = this.txtEp2.Text;
            eps[2] = this.txtEp3.Text;
            eps[3] = this.txtEp4.Text;
            eps[4] = this.txtEp5.Text;
            eps[5] = this.txtEp6.Text;
            eps[6] = this.txtEp7.Text;
            eps[7] = this.txtEp8.Text;

            if (action.Equals("add"))
            {
                if (string.IsNullOrEmpty(ip))
                {
                    MessageBox.Show("IP不可为空");
                    return;
                }
                else
                {
                    DataTable dt = xu.GetXmlTable(areaName);
                    if (dt.Rows != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr["ip"].ToString() == ip)
                            {
                                isExsist = true;
                                MessageBox.Show("该IP已经存在");
                                break;
                            }
                        }
                    }

                    if (!isExsist)
                    {
                        xu.AddModule(name, ip, port, switches, eps, areaName);
                        MessageBox.Show("添加成功");
                        this.Close();
                    }
                }
            }
            else if (this.action.Equals("mod"))
            {
                if (string.IsNullOrEmpty(ip))
                {
                    MessageBox.Show("IP不可为空");
                    return;
                }
                else
                {
                    DataTable dt = xu.GetXmlTable(areaName);
                    if (dt.Rows != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (ip != this.ip_ && dr["ip"].ToString() == ip)
                            {
                                isExsist = true;
                                MessageBox.Show("该IP已经存在");
                                break;
                            }
                        }
                        if (!isExsist)
                        {
                            xu.UpdateModule(name, this.ip_, ip, port, switches, eps, areaName);
                            MessageBox.Show("修改成功");
                            this.Close();
                        }
                    }
                }
            }
            else 
            {
                this.Close();
            }
        }
    }
}
