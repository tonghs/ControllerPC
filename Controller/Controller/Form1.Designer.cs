namespace Controller
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.file_NewModule = new System.Windows.Forms.ToolStripMenuItem();
            this.file_ModuleMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbModules = new System.Windows.Forms.ComboBox();
            this.lblSwitch1 = new System.Windows.Forms.Label();
            this.lblSwitch2 = new System.Windows.Forms.Label();
            this.lblSwitch3 = new System.Windows.Forms.Label();
            this.lblSwitch4 = new System.Windows.Forms.Label();
            this.lblSwitch5 = new System.Windows.Forms.Label();
            this.lblSwitch6 = new System.Windows.Forms.Label();
            this.switch1On = new System.Windows.Forms.Button();
            this.switch1Off = new System.Windows.Forms.Button();
            this.switch2On = new System.Windows.Forms.Button();
            this.switch2Off = new System.Windows.Forms.Button();
            this.switch3On = new System.Windows.Forms.Button();
            this.switch3Off = new System.Windows.Forms.Button();
            this.switch4On = new System.Windows.Forms.Button();
            this.switch4Off = new System.Windows.Forms.Button();
            this.switch5On = new System.Windows.Forms.Button();
            this.switch5Off = new System.Windows.Forms.Button();
            this.switch6On = new System.Windows.Forms.Button();
            this.switch6Off = new System.Windows.Forms.Button();
            this.lblSwitch1Status = new System.Windows.Forms.Label();
            this.lblSwitch2Status = new System.Windows.Forms.Label();
            this.lblSwitch3Status = new System.Windows.Forms.Label();
            this.lblSwitch4Status = new System.Windows.Forms.Label();
            this.lblSwitch5Status = new System.Windows.Forms.Label();
            this.lblSwitch6Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(325, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_NewModule,
            this.file_ModuleMgr,
            this.file_Exit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 21);
            this.fileMenu.Text = "文件";
            // 
            // file_NewModule
            // 
            this.file_NewModule.Name = "file_NewModule";
            this.file_NewModule.Size = new System.Drawing.Size(124, 22);
            this.file_NewModule.Text = "添加模块";
            this.file_NewModule.Click += new System.EventHandler(this.file_NewModule_Click);
            // 
            // file_ModuleMgr
            // 
            this.file_ModuleMgr.Name = "file_ModuleMgr";
            this.file_ModuleMgr.Size = new System.Drawing.Size(124, 22);
            this.file_ModuleMgr.Text = "模块管理";
            this.file_ModuleMgr.Click += new System.EventHandler(this.file_ModuleMgr_Click);
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(124, 22);
            this.file_Exit.Text = "退出";
            this.file_Exit.Click += new System.EventHandler(this.file_Exit_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_About});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 21);
            this.helpMenu.Text = "帮助";
            // 
            // help_About
            // 
            this.help_About.Name = "help_About";
            this.help_About.Size = new System.Drawing.Size(100, 22);
            this.help_About.Text = "关于";
            // 
            // cmbModules
            // 
            this.cmbModules.FormattingEnabled = true;
            this.cmbModules.Location = new System.Drawing.Point(82, 33);
            this.cmbModules.Name = "cmbModules";
            this.cmbModules.Size = new System.Drawing.Size(109, 20);
            this.cmbModules.TabIndex = 1;
            this.cmbModules.SelectedIndexChanged += new System.EventHandler(this.cmbModules_SelectedIndexChanged);
            // 
            // lblSwitch1
            // 
            this.lblSwitch1.AutoSize = true;
            this.lblSwitch1.Location = new System.Drawing.Point(13, 72);
            this.lblSwitch1.Name = "lblSwitch1";
            this.lblSwitch1.Size = new System.Drawing.Size(35, 12);
            this.lblSwitch1.TabIndex = 2;
            this.lblSwitch1.Text = "功能1";
            // 
            // lblSwitch2
            // 
            this.lblSwitch2.AutoSize = true;
            this.lblSwitch2.Location = new System.Drawing.Point(13, 107);
            this.lblSwitch2.Name = "lblSwitch2";
            this.lblSwitch2.Size = new System.Drawing.Size(35, 12);
            this.lblSwitch2.TabIndex = 2;
            this.lblSwitch2.Text = "功能2";
            // 
            // lblSwitch3
            // 
            this.lblSwitch3.AutoSize = true;
            this.lblSwitch3.Location = new System.Drawing.Point(13, 142);
            this.lblSwitch3.Name = "lblSwitch3";
            this.lblSwitch3.Size = new System.Drawing.Size(35, 12);
            this.lblSwitch3.TabIndex = 2;
            this.lblSwitch3.Text = "功能3";
            // 
            // lblSwitch4
            // 
            this.lblSwitch4.AutoSize = true;
            this.lblSwitch4.Location = new System.Drawing.Point(13, 177);
            this.lblSwitch4.Name = "lblSwitch4";
            this.lblSwitch4.Size = new System.Drawing.Size(35, 12);
            this.lblSwitch4.TabIndex = 2;
            this.lblSwitch4.Text = "功能4";
            // 
            // lblSwitch5
            // 
            this.lblSwitch5.AutoSize = true;
            this.lblSwitch5.Location = new System.Drawing.Point(13, 212);
            this.lblSwitch5.Name = "lblSwitch5";
            this.lblSwitch5.Size = new System.Drawing.Size(35, 12);
            this.lblSwitch5.TabIndex = 2;
            this.lblSwitch5.Text = "功能5";
            // 
            // lblSwitch6
            // 
            this.lblSwitch6.AutoSize = true;
            this.lblSwitch6.Location = new System.Drawing.Point(13, 247);
            this.lblSwitch6.Name = "lblSwitch6";
            this.lblSwitch6.Size = new System.Drawing.Size(35, 12);
            this.lblSwitch6.TabIndex = 2;
            this.lblSwitch6.Text = "功能6";
            // 
            // switch1On
            // 
            this.switch1On.Location = new System.Drawing.Point(83, 66);
            this.switch1On.Name = "switch1On";
            this.switch1On.Size = new System.Drawing.Size(52, 23);
            this.switch1On.TabIndex = 1;
            this.switch1On.Tag = "1";
            this.switch1On.Text = "开";
            this.switch1On.UseVisualStyleBackColor = true;
            this.switch1On.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch1Off
            // 
            this.switch1Off.Location = new System.Drawing.Point(141, 66);
            this.switch1Off.Name = "switch1Off";
            this.switch1Off.Size = new System.Drawing.Size(52, 23);
            this.switch1Off.TabIndex = 2;
            this.switch1Off.Tag = "1";
            this.switch1Off.Text = "关";
            this.switch1Off.UseVisualStyleBackColor = true;
            this.switch1Off.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch2On
            // 
            this.switch2On.Location = new System.Drawing.Point(83, 101);
            this.switch2On.Name = "switch2On";
            this.switch2On.Size = new System.Drawing.Size(52, 23);
            this.switch2On.TabIndex = 3;
            this.switch2On.Tag = "2";
            this.switch2On.Text = "开";
            this.switch2On.UseVisualStyleBackColor = true;
            this.switch2On.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch2Off
            // 
            this.switch2Off.Location = new System.Drawing.Point(141, 101);
            this.switch2Off.Name = "switch2Off";
            this.switch2Off.Size = new System.Drawing.Size(52, 23);
            this.switch2Off.TabIndex = 4;
            this.switch2Off.Tag = "2";
            this.switch2Off.Text = "关";
            this.switch2Off.UseVisualStyleBackColor = true;
            this.switch2Off.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch3On
            // 
            this.switch3On.Location = new System.Drawing.Point(83, 136);
            this.switch3On.Name = "switch3On";
            this.switch3On.Size = new System.Drawing.Size(52, 23);
            this.switch3On.TabIndex = 5;
            this.switch3On.Tag = "3";
            this.switch3On.Text = "开";
            this.switch3On.UseVisualStyleBackColor = true;
            this.switch3On.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch3Off
            // 
            this.switch3Off.Location = new System.Drawing.Point(141, 136);
            this.switch3Off.Name = "switch3Off";
            this.switch3Off.Size = new System.Drawing.Size(52, 23);
            this.switch3Off.TabIndex = 6;
            this.switch3Off.Tag = "3";
            this.switch3Off.Text = "关";
            this.switch3Off.UseVisualStyleBackColor = true;
            this.switch3Off.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch4On
            // 
            this.switch4On.Location = new System.Drawing.Point(83, 171);
            this.switch4On.Name = "switch4On";
            this.switch4On.Size = new System.Drawing.Size(52, 23);
            this.switch4On.TabIndex = 7;
            this.switch4On.Tag = "4";
            this.switch4On.Text = "开";
            this.switch4On.UseVisualStyleBackColor = true;
            this.switch4On.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch4Off
            // 
            this.switch4Off.Location = new System.Drawing.Point(141, 171);
            this.switch4Off.Name = "switch4Off";
            this.switch4Off.Size = new System.Drawing.Size(52, 23);
            this.switch4Off.TabIndex = 8;
            this.switch4Off.Tag = "4";
            this.switch4Off.Text = "关";
            this.switch4Off.UseVisualStyleBackColor = true;
            this.switch4Off.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch5On
            // 
            this.switch5On.Location = new System.Drawing.Point(83, 206);
            this.switch5On.Name = "switch5On";
            this.switch5On.Size = new System.Drawing.Size(52, 23);
            this.switch5On.TabIndex = 9;
            this.switch5On.Tag = "5";
            this.switch5On.Text = "开";
            this.switch5On.UseVisualStyleBackColor = true;
            this.switch5On.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch5Off
            // 
            this.switch5Off.Location = new System.Drawing.Point(141, 206);
            this.switch5Off.Name = "switch5Off";
            this.switch5Off.Size = new System.Drawing.Size(52, 23);
            this.switch5Off.TabIndex = 10;
            this.switch5Off.Tag = "5";
            this.switch5Off.Text = "关";
            this.switch5Off.UseVisualStyleBackColor = true;
            this.switch5Off.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch6On
            // 
            this.switch6On.Location = new System.Drawing.Point(83, 241);
            this.switch6On.Name = "switch6On";
            this.switch6On.Size = new System.Drawing.Size(52, 23);
            this.switch6On.TabIndex = 11;
            this.switch6On.Tag = "6";
            this.switch6On.Text = "开";
            this.switch6On.UseVisualStyleBackColor = true;
            this.switch6On.Click += new System.EventHandler(this.switch_Click);
            // 
            // switch6Off
            // 
            this.switch6Off.Location = new System.Drawing.Point(141, 241);
            this.switch6Off.Name = "switch6Off";
            this.switch6Off.Size = new System.Drawing.Size(52, 23);
            this.switch6Off.TabIndex = 12;
            this.switch6Off.Tag = "6";
            this.switch6Off.Text = "关";
            this.switch6Off.UseVisualStyleBackColor = true;
            this.switch6Off.Click += new System.EventHandler(this.switch_Click);
            // 
            // lblSwitch1Status
            // 
            this.lblSwitch1Status.AutoSize = true;
            this.lblSwitch1Status.Location = new System.Drawing.Point(223, 72);
            this.lblSwitch1Status.Name = "lblSwitch1Status";
            this.lblSwitch1Status.Size = new System.Drawing.Size(41, 12);
            this.lblSwitch1Status.TabIndex = 2;
            this.lblSwitch1Status.Text = "待执行";
            // 
            // lblSwitch2Status
            // 
            this.lblSwitch2Status.AutoSize = true;
            this.lblSwitch2Status.Location = new System.Drawing.Point(223, 107);
            this.lblSwitch2Status.Name = "lblSwitch2Status";
            this.lblSwitch2Status.Size = new System.Drawing.Size(41, 12);
            this.lblSwitch2Status.TabIndex = 2;
            this.lblSwitch2Status.Text = "待执行";
            // 
            // lblSwitch3Status
            // 
            this.lblSwitch3Status.AutoSize = true;
            this.lblSwitch3Status.Location = new System.Drawing.Point(223, 142);
            this.lblSwitch3Status.Name = "lblSwitch3Status";
            this.lblSwitch3Status.Size = new System.Drawing.Size(41, 12);
            this.lblSwitch3Status.TabIndex = 2;
            this.lblSwitch3Status.Text = "待执行";
            // 
            // lblSwitch4Status
            // 
            this.lblSwitch4Status.AutoSize = true;
            this.lblSwitch4Status.Location = new System.Drawing.Point(223, 177);
            this.lblSwitch4Status.Name = "lblSwitch4Status";
            this.lblSwitch4Status.Size = new System.Drawing.Size(41, 12);
            this.lblSwitch4Status.TabIndex = 2;
            this.lblSwitch4Status.Text = "待执行";
            // 
            // lblSwitch5Status
            // 
            this.lblSwitch5Status.AutoSize = true;
            this.lblSwitch5Status.Location = new System.Drawing.Point(223, 212);
            this.lblSwitch5Status.Name = "lblSwitch5Status";
            this.lblSwitch5Status.Size = new System.Drawing.Size(41, 12);
            this.lblSwitch5Status.TabIndex = 2;
            this.lblSwitch5Status.Text = "待执行";
            // 
            // lblSwitch6Status
            // 
            this.lblSwitch6Status.AutoSize = true;
            this.lblSwitch6Status.Location = new System.Drawing.Point(223, 247);
            this.lblSwitch6Status.Name = "lblSwitch6Status";
            this.lblSwitch6Status.Size = new System.Drawing.Size(41, 12);
            this.lblSwitch6Status.TabIndex = 2;
            this.lblSwitch6Status.Text = "待执行";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "模块选择";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(197, 37);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(95, 12);
            this.lblIp.TabIndex = 13;
            this.lblIp.Text = "000.000.000.000";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(292, 37);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 14;
            this.lblPort.Text = "0000";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 292);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.switch6Off);
            this.Controls.Add(this.switch6On);
            this.Controls.Add(this.switch5Off);
            this.Controls.Add(this.switch5On);
            this.Controls.Add(this.switch4Off);
            this.Controls.Add(this.switch4On);
            this.Controls.Add(this.switch3Off);
            this.Controls.Add(this.switch3On);
            this.Controls.Add(this.switch2Off);
            this.Controls.Add(this.switch2On);
            this.Controls.Add(this.switch1Off);
            this.Controls.Add(this.switch1On);
            this.Controls.Add(this.lblSwitch6Status);
            this.Controls.Add(this.lblSwitch6);
            this.Controls.Add(this.lblSwitch5Status);
            this.Controls.Add(this.lblSwitch5);
            this.Controls.Add(this.lblSwitch4Status);
            this.Controls.Add(this.lblSwitch4);
            this.Controls.Add(this.lblSwitch3Status);
            this.Controls.Add(this.lblSwitch3);
            this.Controls.Add(this.lblSwitch2Status);
            this.Controls.Add(this.lblSwitch2);
            this.Controls.Add(this.lblSwitch1Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSwitch1);
            this.Controls.Add(this.cmbModules);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC控制端";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem file_NewModule;
        private System.Windows.Forms.ToolStripMenuItem file_ModuleMgr;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem help_About;
        private System.Windows.Forms.ComboBox cmbModules;
        private System.Windows.Forms.Label lblSwitch1;
        private System.Windows.Forms.Label lblSwitch2;
        private System.Windows.Forms.Label lblSwitch3;
        private System.Windows.Forms.Label lblSwitch4;
        private System.Windows.Forms.Label lblSwitch5;
        private System.Windows.Forms.Label lblSwitch6;
        private System.Windows.Forms.Button switch1On;
        private System.Windows.Forms.Button switch1Off;
        private System.Windows.Forms.Button switch2On;
        private System.Windows.Forms.Button switch2Off;
        private System.Windows.Forms.Button switch3On;
        private System.Windows.Forms.Button switch3Off;
        private System.Windows.Forms.Button switch4On;
        private System.Windows.Forms.Button switch4Off;
        private System.Windows.Forms.Button switch5On;
        private System.Windows.Forms.Button switch5Off;
        private System.Windows.Forms.Button switch6On;
        private System.Windows.Forms.Button switch6Off;
        private System.Windows.Forms.Label lblSwitch1Status;
        private System.Windows.Forms.Label lblSwitch2Status;
        private System.Windows.Forms.Label lblSwitch3Status;
        private System.Windows.Forms.Label lblSwitch4Status;
        private System.Windows.Forms.Label lblSwitch5Status;
        private System.Windows.Forms.Label lblSwitch6Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblPort;
    }
}

