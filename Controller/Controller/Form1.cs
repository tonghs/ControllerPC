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
        int rowCount = 5;
        int leftPadding = 20;
        SockectUtil su = new SockectUtil();
        XmlUtil xu = new XmlUtil();
        public Main()
        {
            InitializeComponent();
            this.panelController.MouseWheel += new MouseEventHandler(panelController_MouseWheel);
            //绑定数据源
            this.BindData();
        }
        
        private void BindData()
        {
            try
            {
                DataTable dt = xu.GetArea();
                if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Button btn = new Button();
                        string name = dt.Rows[i]["name"].ToString();
                        btn.Name = name;
                        btn.Text = name;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.TextAlign = ContentAlignment.MiddleLeft;
                        btn.Width = 125;
                        btn.Click += new EventHandler(btn_Click);
                        btn.Location = new Point(0, i * 25 + 5);
                        this.panelMenu.Controls.Add(btn);
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动错误，请检查配置文件");
            }            
        }

        
        private void switch_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string name = btn.Name;
            int moduleIndex = 0;
            int switchIndex = 0;
            if (!string.IsNullOrEmpty(name))
            {
                String[] index = name.Split('_');
                switchIndex = int.Parse(index[1]);
                moduleIndex = int.Parse(index[2]);
            }

            int state = int.Parse(btn.Tag.ToString());//开关状态            
            //接收端ip
            string ip = GetControllerByName("lblIp" + moduleIndex, btn.Parent).Text;
            int port = int.Parse(GetControllerByName("lblPort" + moduleIndex, btn.Parent).Text);
            //发送
            su.Send(ip, port, switchIndex, state);
        }
        
       
        /// <summary>
        /// 选定区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.panelMenu.Controls)
            {
                Button btn = (Button)control;
                btn.BackColor = Control.DefaultBackColor;
                btn.Font = new Font("宋体", 9F, FontStyle.Regular);
                btn.ForeColor = Color.Black;
            }

            Button objBtn = (Button)sender;
            objBtn.BackColor = Color.Green;
            objBtn.Font = new Font("宋体", 9F, FontStyle.Bold);
            objBtn.ForeColor = Color.White;

            DataTable dt = xu.GetXmlTable(objBtn.Name);
            if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
            {
                this.RenderController(dt);
            }
            else
            {
                panelController.Controls.Clear();
            }
        }

        public void RenderController(DataTable dt)
        {
            panelController.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(180, 230);
                panel.Location = new Point(190 * (i % rowCount), (i / rowCount) * 240);

                DataRow dr = dt.Rows[i];
                Label lblName = new Label();
                lblName.Text = dr["name"].ToString();
                lblName.Font = new Font("宋体", 11F, FontStyle.Bold);
                lblName.Location = new Point(leftPadding, 10);
                panel.Controls.Add(lblName);

                Label lblIp = new Label();
                lblIp.Text = dr["ip"].ToString();
                lblIp.Name = "lblIp" + i;
                lblIp.Location = new Point(leftPadding, 35);
                panel.Controls.Add(lblIp);

                Label lblPort = new Label();
                lblPort.Text = dr["port"].ToString();
                lblPort.Name = "lblPort" + i;
                lblPort.Location = new Point(100 + leftPadding, 35);
                panel.Controls.Add(lblPort);

                for (int j = 0; j < 6; j++)
                {
                    Label lblSwitch = new Label();
                    lblSwitch.Width = 40;
                    lblSwitch.Location = new Point(leftPadding, j * 25 + 63);
                    lblSwitch.Text = dr["switch" + (j + 1)].ToString();
                    panel.Controls.Add(lblSwitch);

                    Button btn = new Button();
                    btn.Text = "开";
                    btn.Tag = 1;
                    btn.Location = new Point(60 + leftPadding, j * 25 + 60);
                    btn.Name = "btn_" + j + "_" + i;//btn_开关索引_模块索引
                    btn.Click += new EventHandler(switch_Click);
                    panel.Controls.Add(btn);
                }

                panelController.Controls.Add(panel);
            }
            this.panelController.Focus();
        }

        /// <summary>
        /// 根据控件名查找控件
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public Control GetControllerByName(String name, Control parent)
        {
            Control obj = new Control();
            foreach (Control con in parent.Controls)
            {
                if (con.Name == name)
                {
                    obj = con;
                    break;
                }
            }

            return obj;
        }


        /// <summary>
        /// 鼠标滚动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void panelController_MouseWheel(object sender, MouseEventArgs e)
        {
            //获取光标位置
            Point mousePoint = new Point(e.X, e.Y);
            //换算成相对本窗体的位置
            mousePoint.Offset(this.Location.X, this.Location.Y);
            //判断是否在panel内
            if (panelController.RectangleToScreen(panelController.DisplayRectangle).Contains(mousePoint))
            {
                //滚动
                panelController.AutoScrollPosition = new Point(0, panelController.VerticalScroll.Value - e.Delta);
            }
        }


        #region 菜单
        private void file_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void file_newArea_Click(object sender, EventArgs e)
        {
            NewArea area = new NewArea();
            area.ShowDialog();
            BindData();
        }
        
        #endregion

        
    }
}
