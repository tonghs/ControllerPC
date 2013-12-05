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
    public partial class AreaMgr : Form
    {
        XmlUtil xu = new XmlUtil();
        public AreaMgr()
        {
            InitializeComponent();
            dgvArea.AutoGenerateColumns = false;
            this.BindData();
        }

        public void BindData()
        {            
            DataTable dt = xu.GetArea();
            this.dgvArea.DataSource = dt;

            for (int i = 0; i < dgvArea.Columns.Count; i++)
            {
                DataGridViewColumn col = dgvArea.Columns[i];
                if (col.GetType() == typeof(DataGridViewLinkColumn))
                {
                    dgvArea.Columns.RemoveAt(i--);
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
            dgvArea.Columns.Add(dlink);//将创建的列添加到UserdataGridView中

            //同上方法为每条记录创建&ldquo;删除&rdquo;超链接
            DataGridViewLinkColumn dlink2 = new DataGridViewLinkColumn();
            dlink2.Text = "删除";
            dlink2.Width = 50;
            dlink2.Name = "linkDelete";
            dlink2.HeaderText = "删除";
            dlink2.UseColumnTextForLinkValue = true;
            dgvArea.Columns.Add(dlink2);
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            string areaName = this.dgvArea.SelectedRows[0].Cells[0].Value.ToString();
            DataTable dt = new DataTable();
            switch (colIndex)
            {
                case 1:
                    NewArea areaForm = new NewArea(areaName, "mod");
                    areaForm.ShowDialog();
                    this.BindData();
                    break;
                case 2:
                    xu.DelArea(areaName);
                    MessageBox.Show("删除成功！");
                    this.BindData();
                    break;
            }
        }
    }
}
