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
            this.gboxArea = new System.Windows.Forms.GroupBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.gboxController = new System.Windows.Forms.GroupBox();
            this.panelController = new System.Windows.Forms.Panel();
            this.file_AreaMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gboxArea.SuspendLayout();
            this.gboxController.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
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
            this.file_NewModule,
            this.file_AreaMgr,
            this.file_ModuleMgr,
            this.file_Exit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 21);
            this.fileMenu.Text = "文件";
            // 
            // file_NewModule
            // 
            this.file_NewModule.Name = "file_NewModule";
            this.file_NewModule.Size = new System.Drawing.Size(152, 22);
            this.file_NewModule.Text = "添加模块";
            this.file_NewModule.Click += new System.EventHandler(this.file_NewModule_Click);
            // 
            // file_ModuleMgr
            // 
            this.file_ModuleMgr.Name = "file_ModuleMgr";
            this.file_ModuleMgr.Size = new System.Drawing.Size(152, 22);
            this.file_ModuleMgr.Text = "模块管理";
            this.file_ModuleMgr.Click += new System.EventHandler(this.file_ModuleMgr_Click);
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(152, 22);
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
            // file_AreaMgr
            // 
            this.file_AreaMgr.Name = "file_AreaMgr";
            this.file_AreaMgr.Size = new System.Drawing.Size(152, 22);
            this.file_AreaMgr.Text = "区域管理";
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
        private System.Windows.Forms.ToolStripMenuItem file_NewModule;
        private System.Windows.Forms.ToolStripMenuItem file_ModuleMgr;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem help_About;
        private System.Windows.Forms.GroupBox gboxArea;
        private System.Windows.Forms.GroupBox gboxController;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelController;
        private System.Windows.Forms.ToolStripMenuItem file_AreaMgr;
    }
}

