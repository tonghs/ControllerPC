using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Sockets;
using System.Threading;

namespace Controller
{
    public partial class Main : Form
    {
        int rowCount = 5;
        int leftPadding = 20;
        SockectUtil su = new SockectUtil();
        XmlUtil xu = new XmlUtil();
        public delegate void MyInvoke(byte[] msg, int moduleIndex);

        public Main()
        {
            InitializeComponent();
            this.panelController.MouseWheel += new MouseEventHandler(panelController_MouseWheel);
            //绑定数据源
            this.BindData();
            this.InitModule();
        }

        #region 事件
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
            //this.Send(ip, port, moduleIndex, switchIndex, state);
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
        #endregion

        #region 函数
        /// <summary>
        /// 绑定左侧区域数据
        /// </summary>
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
                this.btn_Click(this.panelMenu.Controls[0], null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动错误，请检查配置文件");
            }
        }
        
        /// <summary>
        /// 加载控件
        /// </summary>
        /// <param name="dt"></param>
        public void RenderController(DataTable dt)
        {
            panelController.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                string ip = dr["ip"].ToString();
                string name = dr["name"].ToString();
                string port = dr["port"].ToString();                        

                Panel panel = new Panel();
                panel.Size = new Size(180, 230);
                panel.Location = new Point(190 * (i % rowCount), (i / rowCount) * 240);
                panel.Name = "panelController" + i;
                
                Label lblName = new Label();
                lblName.Text = name;
                lblName.Font = new Font("宋体", 11F, FontStyle.Bold);
                lblName.Location = new Point(leftPadding, 10);
                panel.Controls.Add(lblName);

                Label lblIp = new Label();
                lblIp.Text = ip;
                lblIp.Name = "lblIp" + i;
                lblIp.Location = new Point(leftPadding, 35);
                panel.Controls.Add(lblIp);

                Label lblPort = new Label();
                lblPort.Text = port;
                lblPort.Name = "lblPort" + i;
                lblPort.Location = new Point(100 + leftPadding, 35);
                panel.Controls.Add(lblPort);
                Message mUtil = new Message();
                for (int j = 0; j < 6; j++)
                {
                    Label lblSwitch = new Label();
                    lblSwitch.Width = 40;
                    lblSwitch.Location = new Point(leftPadding, j * 25 + 63);
                    lblSwitch.Text = dr["switch" + (j + 1)].ToString();
                    panel.Controls.Add(lblSwitch);

                    Button btn = new Button();
                    btn.Tag = i;
                    btn.Text = "获取中";
                    btn.FlatStyle = FlatStyle.Flat;                  
                    btn.Location = new Point(60 + leftPadding, j * 25 + 60);
                    btn.Name = "btn_" + j + "_" + i;//btn_开关索引_模块索引
                    btn.Click += new EventHandler(switch_Click);
                    ////获取继电器状态
                    //if (mUtil.GetStatus(msg, j) == 1)
                    //{
                    //    btn.Text = "开";
                    //    btn.BackColor = Color.Yellow;
                    //    btn.ForeColor = Color.Black;
                    //}
                    //else
                    //{
                    //    btn.Text = "关";
                    //    btn.BackColor = Control.DefaultBackColor;
                    //    btn.ForeColor = Color.Black;
                    //}
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
            Control obj = null;
            foreach (Control con in parent.Controls)
            {
                if (con.HasChildren)
                {
                    obj = GetControllerByName(name, con);
                    if (obj != null)
                    {
                        break;
                    }
                }
                else
                {
                    if (con.Name == name)
                    {
                        obj = con;
                        break;
                    }
                }
            }

            return obj;
        }

        /// <summary>
        /// 设置按钮显示
        /// </summary>
        public void SetButtonText(string name, int state)
        {
            string text = "";
            Color color = Control.DefaultBackColor;
            Color foreColor = Color.Black;
            switch(state)
            {
                case 0:
                    text = "关";
                    color = Control.DefaultBackColor;
                    foreColor = Color.Black;
                    break;

                case 1:
                    text = "开";
                    color = Color.Yellow;
                    foreColor = Color.Black;
                    break;

                case 2:
                    text = "超时";
                    color = Color.Red;
                    foreColor = Color.White;
                    break;
            }
            
            Button btn = (Button)GetControllerByName(name, this.panelController);
            btn.Text = text;
            btn.BackColor = color;
            btn.ForeColor = foreColor;
        }

        public void InitModule()
        {
            //初始化继电器标志
            //遍历控件
            for (int i = 0; i < panelController.Controls.Count; i++)
            {
                Control control = panelController.Controls[i];
                //如果是Panel容器
                if (control.GetType() == typeof(Panel))
                {
                    //接收端ip
                    string ip = GetControllerByName("lblIp" + i, control).Text;
                    int port = int.Parse(GetControllerByName("lblPort" + i, control).Text);
                    byte[] msg = new Message().RequestMsg;
                    this.Send(ip, port, msg, i);
                }
            }
        }

        /// <summary>
        /// 设置所有模块继电器状态
        /// </summary>
        public void SetStatus(byte[] msg, int moduleIndex)
        {
            Message mUtil = new Message();
            //6个继电器分别设置
            for (int i = 0; i < 6; i++)
            {
                string btnName = "btn_" + i + "_" + moduleIndex;
                uint state = mUtil.GetStatus(msg, i);
                if (state == 1)
                {
                    SetButtonText(btnName, 1);
                }
                else if (state == 0)
                {
                    SetButtonText(btnName, 0);
                }
                else
                {
                    SetButtonText(btnName, 2);
                }
            }
        }
        #endregion

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
        
        #region 线程相关
        public void Send(string ip, int port, byte[] msg, int moduleIndex)
        {                       
            Thread th = new Thread(new ParameterizedThreadStart(StartRequestAndReceive));
            th.Start(new Host(ip, port, msg, moduleIndex));
        }        

        public void StartRequestAndReceive(object host)
        {
            Host h = (Host)host;
            MyInvoke mi = new MyInvoke(SetStatus);
            byte[] msg = new byte[15];
            try
            {                
                TcpClient client = new TcpClient(h.Ip, h.Port);
                NetworkStream ns = client.GetStream();
                ns.ReadTimeout = 1000;
                ns.Write(h.Msg, 0, h.Msg.Length);
                //Thread.Sleep(1000);                
                int len = ns.Read(msg, 0, msg.Length);

                ns.Close();
                client.Close();
            }
            catch (Exception e)
            {
                msg = null;
            }
            //保存当前状态
            if (Message.CurrentState.Contains(h.Ip))
            {
                Message.CurrentState[h.Ip] = msg;
            }
            else
            {
                Message.CurrentState.Add(h.Ip, msg);
            }
            BeginInvoke(mi, new object[] { msg, h.ModuleIndex });  
        }

        #endregion
    }
}
