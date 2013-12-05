using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Controller
{
    public partial class NewArea : Form
    {
        private string action = "";
        private string areaName = "";
        public NewArea()
        {
            InitializeComponent();
        }

        public NewArea(string areaName, string action)
        {
            InitializeComponent();
            this.action = action;
            this.areaName = areaName;
            this.txtArea.Text = this.areaName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newAreaName = this.txtArea.Text;
            if (string.IsNullOrEmpty(newAreaName))
            {
                MessageBox.Show("区域名不可为空！");
            }
            else
            {
                if (this.action.Equals("mod"))
                {
                    new XmlUtil().UpdateArea(this.areaName, newAreaName);
                    MessageBox.Show("修改区域成功！");
                    this.Close();
                }
                else
                {
                    this.CreateAreaFile(newAreaName);
                }
            }
        }

        public void CreateAreaFile(string areaName)
        {
            try
            {                
                string xmlFilePath = areaName + ".xml";
                FileInfo file = new FileInfo(xmlFilePath);
                if (file.Exists)
                {
                    MessageBox.Show("改区域已存在！");
                }
                else
                {
                    XmlDocument myXmlDoc = new XmlDocument();
                    //创建xml的根节点
                    XmlElement rootElement = myXmlDoc.CreateElement("root");
                    //将根节点加入到xml文件中（AppendChild）
                    myXmlDoc.AppendChild(rootElement);
                    myXmlDoc.Save(xmlFilePath);
                    MessageBox.Show("区域添加成功！");
                    this.Close();
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show("创建区域失败！");
            }
        }
    }
}
