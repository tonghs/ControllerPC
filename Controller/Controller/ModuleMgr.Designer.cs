namespace Controller
{
    partial class ModuleMgr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.端口 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModules
            // 
            this.dgvModules.AllowUserToAddRows = false;
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名称,
            this.IP,
            this.端口});
            this.dgvModules.Location = new System.Drawing.Point(13, 49);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.RowTemplate.Height = 23;
            this.dgvModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModules.Size = new System.Drawing.Size(473, 437);
            this.dgvModules.TabIndex = 0;
            this.dgvModules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModules_CellContentClick);
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "name";
            this.名称.Frozen = true;
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            // 
            // IP
            // 
            this.IP.DataPropertyName = "ip";
            this.IP.Frozen = true;
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            // 
            // 端口
            // 
            this.端口.DataPropertyName = "port";
            this.端口.Frozen = true;
            this.端口.HeaderText = "端口";
            this.端口.Name = "端口";
            this.端口.Width = 60;
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(45, 12);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(100, 20);
            this.cmbArea.TabIndex = 16;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "区域";
            // 
            // ModuleMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 538);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModuleMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模块管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn 端口;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label4;

    }
}