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
    public partial class ModuleMgr : Form
    {
        XmlUtil xu = new XmlUtil();
        public ModuleMgr()
        {
            InitializeComponent();
            dgvModules.AutoGenerateColumns = false;
            this.BindArea();            
        }

        /// <summary>
        /// 
        /// 绑定区域
        /// </summary>
        public void BindArea()
        {
            this.cmbArea.DisplayMember = "name";
            this.cmbArea.ValueMember = "name";
            DataTable dtArea = xu.GetArea();
            this.cmbArea.DataSource = dtArea;            
        }

        /// <summary>
        /// 绑定列表数据
        /// </summary>
        public void BindData()
        {
            string areaName = this.cmbArea.SelectedValue.ToString();
            DataTable dt = xu.GetXmlTable(areaName);
            dgvModules.DataSource = dt;

            for (int i = 0; i < dgvModules.Columns.Count; i++ )
            {
                DataGridViewColumn col = dgvModules.Columns[i];
                if (col.GetType() == typeof(DataGridViewLinkColumn))
                {
                    dgvModules.Columns.RemoveAt(i--);                    
                }
            }

            //为每行数据增加编辑列。
            //创建一个DataGridViewLinkColumn列
            DataGridViewLinkColumn dlink = new DataGridViewLinkColumn();
            dlink.Text = "修改";//添加的这列的显示文字，即每行最后一列显示的文字。
            dlink.Width = 50;
            dlink.Name = "linkEdit";
            dlink.HeaderText = "修改";//列的标题
            dlink.UseColumnTextForLinkValue = true;//上面设置的dlink.Text文字在列中显示
            dgvModules.Columns.Add(dlink);//将创建的列添加到UserdataGridView中

            //同上方法为每条记录创建&ldquo;删除&rdquo;超链接
            DataGridViewLinkColumn dlink2 = new DataGridViewLinkColumn();
            dlink2.Text = "删除";
            dlink2.Width = 50;
            dlink2.Name = "linkDelete";
            dlink2.HeaderText = "删除";
            dlink2.UseColumnTextForLinkValue = true;
            dgvModules.Columns.Add(dlink2);

            //同上方法为每条记录创建&ldquo;查看&rdquo;超链接
            DataGridViewLinkColumn dlink3 = new DataGridViewLinkColumn();
            dlink3.Text = "查看";
            dlink3.Width = 50;
            dlink3.Name = "linkView";
            dlink3.HeaderText = "查看";
            dlink3.UseColumnTextForLinkValue = true;
            dgvModules.Columns.Add(dlink3);
        }

        private void dgvModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string areaName = this.cmbArea.SelectedValue.ToString();
            int colIndex = e.ColumnIndex;
            string ip = this.dgvModules.SelectedRows[0].Cells[1].Value.ToString();
            DataTable dt = new DataTable();
            switch (colIndex)
            {
                case 3:
                    UpdateModule(ip, areaName);
                    dt = xu.GetXmlTable(areaName);
                    dgvModules.DataSource = dt;
                    break;
                case 4:
                    DelModule(ip, areaName);
                    dt = xu.GetXmlTable(areaName);
                    dgvModules.DataSource = dt;
                    break;
                case 5:
                    ViewModule(ip, areaName);
                    break;
            }
        }

        private void ViewModule(string ip, string areaName)
        {
            NewModule nmFrom = new NewModule(ip, "view", areaName);
            nmFrom.ShowDialog();
        }

        private void DelModule(string ip, string areaName)
        {
            if (MessageBox.Show("确认删除？", "此删除不可恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new XmlUtil().DelModule(ip, areaName);
            }
        }

        private void UpdateModule(string ip, string areaName)
        {
            NewModule nmFrom = new NewModule(ip, "mod", areaName);
            nmFrom.ShowDialog();
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindData();
        }
    }
}
