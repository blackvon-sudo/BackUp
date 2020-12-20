
namespace BackUp.Winform
{
    partial class Fm_Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_NewBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UpdateCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAllRunTimeCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastStopTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastRunTimeCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectRrcord = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectBackUp = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerBackUp = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTSMI_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.CTSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel4.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1203, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_NewBackUp,
            this.TSMI_Export,
            this.TSMI_Import,
            this.toolStripSeparator1,
            this.TSMI_Exit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // TSMI_NewBackUp
            // 
            this.TSMI_NewBackUp.Name = "TSMI_NewBackUp";
            this.TSMI_NewBackUp.Size = new System.Drawing.Size(124, 22);
            this.TSMI_NewBackUp.Text = "新建备份";
            this.TSMI_NewBackUp.Click += new System.EventHandler(this.TSMI_NewBackUp_Click);
            // 
            // TSMI_Export
            // 
            this.TSMI_Export.Name = "TSMI_Export";
            this.TSMI_Export.Size = new System.Drawing.Size(124, 22);
            this.TSMI_Export.Text = "新建导出";
            this.TSMI_Export.Click += new System.EventHandler(this.TSMI_Export_Click);
            // 
            // TSMI_Import
            // 
            this.TSMI_Import.Name = "TSMI_Import";
            this.TSMI_Import.Size = new System.Drawing.Size(124, 22);
            this.TSMI_Import.Text = "新建导入";
            this.TSMI_Import.Click += new System.EventHandler(this.TSMI_Import_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(124, 22);
            this.TSMI_Exit.Text = "退出";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Setting});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // TSMI_Setting
            // 
            this.TSMI_Setting.Name = "TSMI_Setting";
            this.TSMI_Setting.Size = new System.Drawing.Size(100, 22);
            this.TSMI_Setting.Text = "设置";
            this.TSMI_Setting.Click += new System.EventHandler(this.TSMI_Setting_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UpdateCheck,
            this.toolStripSeparator2,
            this.TSMI_About});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // TSMI_UpdateCheck
            // 
            this.TSMI_UpdateCheck.Name = "TSMI_UpdateCheck";
            this.TSMI_UpdateCheck.Size = new System.Drawing.Size(124, 22);
            this.TSMI_UpdateCheck.Text = "检查更新";
            this.TSMI_UpdateCheck.Click += new System.EventHandler(this.TSMI_UpdateCheck_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(124, 22);
            this.TSMI_About.Text = "关于";
            this.TSMI_About.Click += new System.EventHandler(this.TSMI_About_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslTime,
            this.tsslStatus,
            this.tsslLastStopTime,
            this.tsslLastRunTimeCount,
            this.tsslAllRunTimeCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1203, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.TabStop = true;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(81, 17);
            this.tsslVersion.Text = "版本：1.0.0.0";
            // 
            // tsslTime
            // 
            this.tsslTime.ForeColor = System.Drawing.Color.SeaGreen;
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(126, 17);
            this.tsslTime.Text = "2020-11-18 15:03:00";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(68, 17);
            this.tsslStatus.Text = "状态：正常";
            // 
            // tsslAllRunTimeCount
            // 
            this.tsslAllRunTimeCount.ForeColor = System.Drawing.Color.Green;
            this.tsslAllRunTimeCount.Name = "tsslAllRunTimeCount";
            this.tsslAllRunTimeCount.Size = new System.Drawing.Size(125, 17);
            this.tsslAllRunTimeCount.Text = "tsslAllRunTimeCount";
            this.tsslAllRunTimeCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslLastStopTime
            // 
            this.tsslLastStopTime.ForeColor = System.Drawing.Color.Red;
            this.tsslLastStopTime.Name = "tsslLastStopTime";
            this.tsslLastStopTime.Size = new System.Drawing.Size(621, 17);
            this.tsslLastStopTime.Spring = true;
            this.tsslLastStopTime.Text = "tsslLastStopTime";
            this.tsslLastStopTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslLastRunTimeCount
            // 
            this.tsslLastRunTimeCount.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tsslLastRunTimeCount.Name = "tsslLastRunTimeCount";
            this.tsslLastRunTimeCount.Size = new System.Drawing.Size(134, 17);
            this.tsslLastRunTimeCount.Text = "tsslLastRunTimeCount";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 575);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvRecord);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 346);
            this.panel3.TabIndex = 5;
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.Location = new System.Drawing.Point(0, 35);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowTemplate.Height = 23;
            this.dgvRecord.Size = new System.Drawing.Size(1203, 311);
            this.dgvRecord.TabIndex = 2;
            this.dgvRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellContentClick);
            this.dgvRecord.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvData_RowPostPaint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.cbxType);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnSelectRrcord);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1203, 35);
            this.panel6.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(913, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "选择类型:";
            // 
            // cbxType
            // 
            this.cbxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(989, 6);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 22);
            this.cbxType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "记录";
            // 
            // btnSelectRrcord
            // 
            this.btnSelectRrcord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectRrcord.Location = new System.Drawing.Point(1116, 6);
            this.btnSelectRrcord.Name = "btnSelectRrcord";
            this.btnSelectRrcord.Size = new System.Drawing.Size(75, 23);
            this.btnSelectRrcord.TabIndex = 1;
            this.btnSelectRrcord.Text = "查询";
            this.btnSelectRrcord.UseVisualStyleBackColor = true;
            this.btnSelectRrcord.Click += new System.EventHandler(this.btnselectRrcord_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvData);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1203, 229);
            this.panel8.TabIndex = 4;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 35);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(1203, 194);
            this.dgvData.TabIndex = 2;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvData_RowPostPaint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnSelectBackUp);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1203, 35);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库备份";
            // 
            // btnSelectBackUp
            // 
            this.btnSelectBackUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectBackUp.Location = new System.Drawing.Point(1116, 6);
            this.btnSelectBackUp.Name = "btnSelectBackUp";
            this.btnSelectBackUp.Size = new System.Drawing.Size(75, 23);
            this.btnSelectBackUp.TabIndex = 0;
            this.btnSelectBackUp.Text = "查询";
            this.btnSelectBackUp.UseVisualStyleBackColor = true;
            this.btnSelectBackUp.Click += new System.EventHandler(this.btnSelectBackUp_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerBackUp
            // 
            this.timerBackUp.Interval = 4000;
            this.timerBackUp.Tick += new System.EventHandler(this.timerBackUp_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Oracle数据库备份托盘";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTSMI_Show,
            this.CTSMI_Exit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // CTSMI_Show
            // 
            this.CTSMI_Show.Name = "CTSMI_Show";
            this.CTSMI_Show.Size = new System.Drawing.Size(100, 22);
            this.CTSMI_Show.Text = "显示";
            this.CTSMI_Show.Click += new System.EventHandler(this.CTSMI_Show_Click);
            // 
            // CTSMI_Exit
            // 
            this.CTSMI_Exit.Name = "CTSMI_Exit";
            this.CTSMI_Exit.Size = new System.Drawing.Size(100, 22);
            this.CTSMI_Exit.Text = "退出";
            this.CTSMI_Exit.Click += new System.EventHandler(this.CTSMI_Exit_Click);
            // 
            // Fm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Fm_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle 数据库备份";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Fm_Main_Load);
            this.SizeChanged += new System.EventHandler(this.Fm_Main_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_NewBackUp;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Import;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Setting;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdateCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Export;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerBackUp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CTSMI_Show;
        private System.Windows.Forms.ToolStripMenuItem CTSMI_Exit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectBackUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectRrcord;
        private System.Windows.Forms.ToolStripStatusLabel tsslAllRunTimeCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslLastStopTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslLastRunTimeCount;
    }
}

