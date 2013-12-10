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
            this.file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.模块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddModule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModuleMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.区域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddArea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAreaMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxArea = new System.Windows.Forms.GroupBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.gboxController = new System.Windows.Forms.GroupBox();
            this.panelController = new System.Windows.Forms.Panel();
            this.menuUpdatePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gboxArea.SuspendLayout();
            this.gboxController.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.模块ToolStripMenuItem,
            this.区域ToolStripMenuItem,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdatePwd,
            this.file_Exit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 21);
            this.fileMenu.Text = "文件";
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(152, 22);
            this.file_Exit.Text = "退出";
            this.file_Exit.Click += new System.EventHandler(this.file_Exit_Click);
            // 
            // 模块ToolStripMenuItem
            // 
            this.模块ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddModule,
            this.menuModuleMgr});
            this.模块ToolStripMenuItem.Name = "模块ToolStripMenuItem";
            this.模块ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.模块ToolStripMenuItem.Text = "模块";
            // 
            // menuAddModule
            // 
            this.menuAddModule.Name = "menuAddModule";
            this.menuAddModule.Size = new System.Drawing.Size(152, 22);
            this.menuAddModule.Text = "添加模块";
            this.menuAddModule.Click += new System.EventHandler(this.menuAddModule_Click);
            // 
            // menuModuleMgr
            // 
            this.menuModuleMgr.Name = "menuModuleMgr";
            this.menuModuleMgr.Size = new System.Drawing.Size(152, 22);
            this.menuModuleMgr.Text = "模块管理";
            this.menuModuleMgr.Click += new System.EventHandler(this.menuModuleMgr_Click);
            // 
            // 区域ToolStripMenuItem
            // 
            this.区域ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddArea,
            this.menuAreaMgr});
            this.区域ToolStripMenuItem.Name = "区域ToolStripMenuItem";
            this.区域ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.区域ToolStripMenuItem.Text = "区域";
            // 
            // menuAddArea
            // 
            this.menuAddArea.Name = "menuAddArea";
            this.menuAddArea.Size = new System.Drawing.Size(152, 22);
            this.menuAddArea.Text = "添加区域";
            this.menuAddArea.Click += new System.EventHandler(this.menuAddArea_Click);
            // 
            // menuAreaMgr
            // 
            this.menuAreaMgr.Name = "menuAreaMgr";
            this.menuAreaMgr.Size = new System.Drawing.Size(152, 22);
            this.menuAreaMgr.Text = "区域管理";
            this.menuAreaMgr.Click += new System.EventHandler(this.menuAreaMgr_Click);
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
            this.help_About.Size = new System.Drawing.Size(152, 22);
            this.help_About.Text = "关于";
            // 
            // gboxArea
            // 
            this.gboxArea.Controls.Add(this.panelMenu);
            this.gboxArea.Location = new System.Drawing.Point(13, 28);
            this.gboxArea.Name = "gboxArea";
            this.gboxArea.Size = new System.Drawing.Size(139, 681);
            this.gboxArea.TabIndex = 15;
            this.gboxArea.TabStop = false;
            this.gboxArea.Text = "区域";
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.Location = new System.Drawing.Point(7, 15);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(126, 660);
            this.panelMenu.TabIndex = 0;
            // 
            // gboxController
            // 
            this.gboxController.Controls.Add(this.panelController);
            this.gboxController.Location = new System.Drawing.Point(158, 28);
            this.gboxController.Name = "gboxController";
            this.gboxController.Size = new System.Drawing.Size(968, 681);
            this.gboxController.TabIndex = 15;
            this.gboxController.TabStop = false;
            this.gboxController.Text = "控制";
            // 
            // panelController
            // 
            this.panelController.AutoScroll = true;
            this.panelController.Location = new System.Drawing.Point(7, 15);
            this.panelController.Name = "panelController";
            this.panelController.Size = new System.Drawing.Size(960, 660);
            this.panelController.TabIndex = 0;
            // 
            // menuUpdatePwd
            // 
            this.menuUpdatePwd.Name = "menuUpdatePwd";
            this.menuUpdatePwd.Size = new System.Drawing.Size(152, 22);
            this.menuUpdatePwd.Text = "修改密码";
            this.menuUpdatePwd.Click += new System.EventHandler(this.menuUpdatePwd_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 722);
            this.Controls.Add(this.gboxController);
            this.Controls.Add(this.gboxArea);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC控制端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboxArea.ResumeLayout(false);
            this.gboxController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem help_About;
        private System.Windows.Forms.GroupBox gboxArea;
        private System.Windows.Forms.GroupBox gboxController;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelController;
        private System.Windows.Forms.ToolStripMenuItem 模块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 区域ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddModule;
        private System.Windows.Forms.ToolStripMenuItem menuModuleMgr;
        private System.Windows.Forms.ToolStripMenuItem menuAddArea;
        private System.Windows.Forms.ToolStripMenuItem menuAreaMgr;
        private System.Windows.Forms.ToolStripMenuItem menuUpdatePwd;
    }
}

