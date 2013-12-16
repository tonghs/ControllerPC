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
using System.Configuration;

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
        }

        #region 事件
        /// <summary>
        /// 开关事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            state = state == 1 ? 0 : 1;
            //接收端ip
            string ip = GetControllerByName("lblIp" + moduleIndex, btn.Parent).Text;
            int port = int.Parse(GetControllerByName("lblPort" + moduleIndex, btn.Parent).Text);
            byte[] msg = new Message().GetRequestMsg(ip, moduleIndex, switchIndex, state);
            //发送
            this.Send(ip, port,msg, moduleIndex);
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
            this.InitModule();
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
                this.panelMenu.Controls.Clear();
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
                if (this.panelMenu.Controls.Count > 0)
                {
                    this.btn_Click(this.panelMenu.Controls[0], null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动错误!");
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
                panel.Size = new Size(180, 265);
                panel.Location = new Point(190 * (i % rowCount), (i / rowCount) * 275);
                panel.Name = "panelController" + i;
                
                Label lblName = new Label();
                lblName.Text = name;
                lblName.Font = new Font("宋体", 10F, FontStyle.Bold);
                lblName.Height = 20;
                lblName.Location = new Point(leftPadding, 10);
                panel.Controls.Add(lblName);

                Label lblIp = new Label();
                lblIp.Text = ip;
                lblIp.Name = "lblIp" + i;
                lblIp.Height = 15;
                lblIp.Location = new Point(leftPadding, 30);
                panel.Controls.Add(lblIp);

                Label lblPort = new Label();
                lblPort.Text = port;
                lblPort.Height = 15;
                lblPort.Name = "lblPort" + i;
                lblPort.Location = new Point(100 + leftPadding, 30);
                panel.Controls.Add(lblPort);

                //设置电位显示
                for (int k = 0; k < 8; k++)
                {
                    Label lblEp1 = new Label();
                    lblEp1.Text = dr["ep" + (k + 1)].ToString();
                    lblEp1.Width = 66;
                    lblEp1.Height = 15;
                    lblEp1.BackColor = Color.Green;
                    lblEp1.ForeColor = Color.White;
                    lblEp1.Name = "lblEp_" + k + "_" + i;
                    lblEp1.Location = new Point((k % 2) * 68 + leftPadding, (k / 2) * 17 + 45);
                    lblEp1.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(lblEp1);
                }

                Message mUtil = new Message();
                for (int j = 0; j < 6; j++)
                {
                    Label lblSwitch = new Label();
                    lblSwitch.Width = 40;
                    lblSwitch.Location = new Point(leftPadding, j * 25 + 120);
                    lblSwitch.Text = dr["switch" + (j + 1)].ToString();
                    panel.Controls.Add(lblSwitch);

                    Button btn = new Button();
                    btn.Tag = i;
                    btn.Text = "获取中";
                    btn.FlatStyle = FlatStyle.Flat;                  
                    btn.Location = new Point(60 + leftPadding, j * 25 + 115);
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
            int tag = 0;
            switch(state)
            {
                case 0:
                    text = "关";
                    color = Control.DefaultBackColor;
                    tag = 0;
                    break;

                case 1:
                    text = "开";
                    color = Color.Yellow;
                    tag = 1;
                    break;

                case 2:
                    text = "超时";
                    color = Color.Red;
                    tag = 0;
                    break;
            }
            
            Button btn = (Button)GetControllerByName(name, this.panelController);
            if (btn != null)
            {
                btn.Text = text;
                btn.BackColor = color;
                btn.ForeColor = foreColor;
                btn.Tag = tag;
            }
        }

        public void SetEpState(string lblEpName, int state)
        {
            Color color = Color.Green;
            switch (state)
            {
                case 0:
                    color = Color.Green;
                    break;

                case 1:
                    color = Color.Red;
                    break;
            }

            Label lblEp = (Label)GetControllerByName(lblEpName, this.panelController);
            if (lblEp != null)
            {
                lblEp.BackColor = color;
            }
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
            if (msg != null)
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

                //8个电位指示
                uint[] status = mUtil.GetEPByMsg(msg);
                for (int i = 0; i < 8; i++)
                {
                    string lblName = "lblEp_" + i + "_" + moduleIndex;
                    if (status[i] == 1)
                    {
                        SetEpState(lblName, 1);
                    }
                    else if (status[i] == 0)
                    {
                        SetEpState(lblName, 0);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    string btnName = "btn_" + i + "_" + moduleIndex;
                    SetButtonText(btnName, 2);
                }
            }
        }
        #endregion

        #region 菜单
        private void file_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);                        
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void menuAddModule_Click(object sender, EventArgs e)
        {
            NewModule newModuleForm = new NewModule();
            newModuleForm.ShowDialog();
            BindData();
        }

        private void menuModuleMgr_Click(object sender, EventArgs e)
        {
            ModuleMgr mgrForm = new ModuleMgr();
            mgrForm.ShowDialog();
            BindData();
        }

        private void menuAddArea_Click(object sender, EventArgs e)
        {
            NewArea area = new NewArea();
            area.ShowDialog();
            this.BindData();
        }

        private void menuAreaMgr_Click(object sender, EventArgs e)
        {
            AreaMgr areaMgr = new AreaMgr();
            areaMgr.ShowDialog();
            this.BindData();
        }


        private void menuUpdatePwd_Click(object sender, EventArgs e)
        {
            UpdatePwdForm form = new UpdatePwdForm();
            form.ShowDialog();
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
            TcpClient client = new TcpClient();
            NetworkStream ns = null;
            try
            {
                int timeout = int.Parse(ConfigurationSettings.AppSettings["timeout"].ToString());
                client.SendTimeout = timeout;
                client.Connect(h.Ip, h.Port);
                ns = client.GetStream();
                ns.ReadTimeout = timeout;
                ns.Write(h.Msg, 0, h.Msg.Length);
                int len = ns.Read(msg, 0, msg.Length);
            }
            catch (Exception e)
            {
                msg = null;
            }
            finally
            {
                if (ns != null)
                {
                    ns.Close();
                }
                client.Close();
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
