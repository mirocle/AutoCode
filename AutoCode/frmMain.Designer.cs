namespace AutoCode
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCreate = new System.Windows.Forms.Button();
            this.btnGetTable = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbDataBase = new System.Windows.Forms.ComboBox();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbTables = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbNameSpace = new System.Windows.Forms.TextBox();
            this.lblNameSpace = new System.Windows.Forms.Label();
            this.CMSRightButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAllSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAllNotSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectOther = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.CMSRightButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCreate);
            this.panel1.Controls.Add(this.btnGetTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(755, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 432);
            this.panel1.TabIndex = 6;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(36, 41);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(126, 23);
            this.btCreate.TabIndex = 9;
            this.btCreate.Text = "生成";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btnGetTable
            // 
            this.btnGetTable.Location = new System.Drawing.Point(36, 12);
            this.btnGetTable.Name = "btnGetTable";
            this.btnGetTable.Size = new System.Drawing.Size(126, 23);
            this.btnGetTable.TabIndex = 8;
            this.btnGetTable.Text = "获取数据表";
            this.btnGetTable.UseVisualStyleBackColor = true;
            this.btnGetTable.Click += new System.EventHandler(this.btnGetTable_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 432);
            this.panel3.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.cmbDataBase);
            this.groupBox1.Controls.Add(this.lblDataBase);
            this.groupBox1.Controls.Add(this.lblserver);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 175);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库配置";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 12);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "密码：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(76, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 31;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(17, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 30;
            this.lblUserName.Text = "用户名：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(76, 52);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 29;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // cmbDataBase
            // 
            this.cmbDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBase.FormattingEnabled = true;
            this.cmbDataBase.Location = new System.Drawing.Point(76, 114);
            this.cmbDataBase.Name = "cmbDataBase";
            this.cmbDataBase.Size = new System.Drawing.Size(121, 20);
            this.cmbDataBase.TabIndex = 28;
            this.cmbDataBase.SelectedIndexChanged += new System.EventHandler(this.cmbDataBase_SelectedIndexChanged);
            this.cmbDataBase.Enter += new System.EventHandler(this.cmbDataBase_Enter);
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Location = new System.Drawing.Point(14, 117);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(53, 12);
            this.lblDataBase.TabIndex = 26;
            this.lblDataBase.Text = "数据库：";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(17, 28);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(53, 12);
            this.lblserver.TabIndex = 27;
            this.lblserver.Text = "服务器：";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(76, 25);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(223, 21);
            this.txtServer.TabIndex = 25;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(203, 114);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(119, 21);
            this.btnTest.TabIndex = 24;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(371, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 432);
            this.panel2.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 374);
            this.panel5.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbTables);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据表";
            // 
            // clbTables
            // 
            this.clbTables.CheckOnClick = true;
            this.clbTables.ContextMenuStrip = this.CMSRightButton;
            this.clbTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbTables.FormattingEnabled = true;
            this.clbTables.Location = new System.Drawing.Point(3, 17);
            this.clbTables.Name = "clbTables";
            this.clbTables.Size = new System.Drawing.Size(378, 354);
            this.clbTables.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 58);
            this.panel4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNameSpace);
            this.groupBox3.Controls.Add(this.lblNameSpace);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 58);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "配置项";
            // 
            // tbNameSpace
            // 
            this.tbNameSpace.Location = new System.Drawing.Point(89, 20);
            this.tbNameSpace.Name = "tbNameSpace";
            this.tbNameSpace.Size = new System.Drawing.Size(141, 21);
            this.tbNameSpace.TabIndex = 1;
            // 
            // lblNameSpace
            // 
            this.lblNameSpace.AutoSize = true;
            this.lblNameSpace.Location = new System.Drawing.Point(18, 23);
            this.lblNameSpace.Name = "lblNameSpace";
            this.lblNameSpace.Size = new System.Drawing.Size(65, 12);
            this.lblNameSpace.TabIndex = 0;
            this.lblNameSpace.Text = "名称空间：";
            // 
            // CMSRightButton
            // 
            this.CMSRightButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAllSelect,
            this.tsmiAllNotSelect,
            this.tsmiSelectOther});
            this.CMSRightButton.Name = "CMSRightButton";
            this.CMSRightButton.Size = new System.Drawing.Size(153, 92);
            // 
            // tsmiAllSelect
            // 
            this.tsmiAllSelect.Name = "tsmiAllSelect";
            this.tsmiAllSelect.Size = new System.Drawing.Size(152, 22);
            this.tsmiAllSelect.Text = "全选";
            this.tsmiAllSelect.Click += new System.EventHandler(this.tsmiAllSelect_Click);
            // 
            // tsmiAllNotSelect
            // 
            this.tsmiAllNotSelect.Name = "tsmiAllNotSelect";
            this.tsmiAllNotSelect.Size = new System.Drawing.Size(152, 22);
            this.tsmiAllNotSelect.Text = "全不选";
            this.tsmiAllNotSelect.Click += new System.EventHandler(this.tsmiAllNotSelect_Click);
            // 
            // tsmiSelectOther
            // 
            this.tsmiSelectOther.Name = "tsmiSelectOther";
            this.tsmiSelectOther.Size = new System.Drawing.Size(152, 22);
            this.tsmiSelectOther.Text = "反选";
            this.tsmiSelectOther.Click += new System.EventHandler(this.tsmiSelectOther_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "自动代码生成";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.CMSRightButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbDataBase;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Label lblserver;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbTables;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNameSpace;
        private System.Windows.Forms.Label lblNameSpace;
        private System.Windows.Forms.ContextMenuStrip CMSRightButton;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllSelect;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllNotSelect;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectOther;

    }
}

