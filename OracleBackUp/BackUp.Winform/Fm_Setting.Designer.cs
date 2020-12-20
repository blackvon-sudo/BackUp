
namespace BackUp.Winform
{
    partial class Fm_Setting
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxEmail = new System.Windows.Forms.GroupBox();
            this.tbxEmailHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEmailPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnMessAndData = new System.Windows.Forms.RadioButton();
            this.rbtnMess = new System.Windows.Forms.RadioButton();
            this.tbxReceivedEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxSendEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnEmailNo = new System.Windows.Forms.RadioButton();
            this.rbtnEmailYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnLogNo = new System.Windows.Forms.RadioButton();
            this.rbtnLogYes = new System.Windows.Forms.RadioButton();
            this.gbxLog = new System.Windows.Forms.GroupBox();
            this.btnLogChoose = new System.Windows.Forms.Button();
            this.tbxLogPath = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDel = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbxEmail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(110, 460);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(140, 30);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "确定";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbxEmail);
            this.groupBox1.Controls.Add(this.rbtnEmailNo);
            this.groupBox1.Controls.Add(this.rbtnEmailYes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 326);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邮件";
            // 
            // gbxEmail
            // 
            this.gbxEmail.Controls.Add(this.cbxDel);
            this.gbxEmail.Controls.Add(this.tbxEmailHost);
            this.gbxEmail.Controls.Add(this.label3);
            this.gbxEmail.Controls.Add(this.tbxEmailPort);
            this.gbxEmail.Controls.Add(this.label1);
            this.gbxEmail.Controls.Add(this.rbtnMessAndData);
            this.gbxEmail.Controls.Add(this.rbtnMess);
            this.gbxEmail.Controls.Add(this.tbxReceivedEmail);
            this.gbxEmail.Controls.Add(this.tbxPassword);
            this.gbxEmail.Controls.Add(this.tbxSendEmail);
            this.gbxEmail.Controls.Add(this.label10);
            this.gbxEmail.Controls.Add(this.label7);
            this.gbxEmail.Controls.Add(this.label8);
            this.gbxEmail.Controls.Add(this.label9);
            this.gbxEmail.Location = new System.Drawing.Point(6, 36);
            this.gbxEmail.Name = "gbxEmail";
            this.gbxEmail.Size = new System.Drawing.Size(481, 273);
            this.gbxEmail.TabIndex = 13;
            this.gbxEmail.TabStop = false;
            // 
            // tbxEmailHost
            // 
            this.tbxEmailHost.Location = new System.Drawing.Point(85, 26);
            this.tbxEmailHost.Name = "tbxEmailHost";
            this.tbxEmailHost.Size = new System.Drawing.Size(384, 23);
            this.tbxEmailHost.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "服务地址：";
            // 
            // tbxEmailPort
            // 
            this.tbxEmailPort.Location = new System.Drawing.Point(83, 63);
            this.tbxEmailPort.Name = "tbxEmailPort";
            this.tbxEmailPort.Size = new System.Drawing.Size(384, 23);
            this.tbxEmailPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "端口：";
            // 
            // rbtnMessAndData
            // 
            this.rbtnMessAndData.AutoSize = true;
            this.rbtnMessAndData.Location = new System.Drawing.Point(153, 203);
            this.rbtnMessAndData.Name = "rbtnMessAndData";
            this.rbtnMessAndData.Size = new System.Drawing.Size(221, 18);
            this.rbtnMessAndData.TabIndex = 14;
            this.rbtnMessAndData.Text = "通知和数据(通过附件方式发送)";
            this.rbtnMessAndData.UseVisualStyleBackColor = true;
            // 
            // rbtnMess
            // 
            this.rbtnMess.AutoSize = true;
            this.rbtnMess.Checked = true;
            this.rbtnMess.Location = new System.Drawing.Point(94, 203);
            this.rbtnMess.Name = "rbtnMess";
            this.rbtnMess.Size = new System.Drawing.Size(53, 18);
            this.rbtnMess.TabIndex = 13;
            this.rbtnMess.TabStop = true;
            this.rbtnMess.Text = "通知";
            this.rbtnMess.UseVisualStyleBackColor = true;
            this.rbtnMess.CheckedChanged += new System.EventHandler(this.rbtnMess_CheckedChanged);
            // 
            // tbxReceivedEmail
            // 
            this.tbxReceivedEmail.Location = new System.Drawing.Point(83, 167);
            this.tbxReceivedEmail.Name = "tbxReceivedEmail";
            this.tbxReceivedEmail.Size = new System.Drawing.Size(384, 23);
            this.tbxReceivedEmail.TabIndex = 5;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(83, 134);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(384, 23);
            this.tbxPassword.TabIndex = 4;
            // 
            // tbxSendEmail
            // 
            this.tbxSendEmail.Location = new System.Drawing.Point(83, 101);
            this.tbxSendEmail.Name = "tbxSendEmail";
            this.tbxSendEmail.Size = new System.Drawing.Size(384, 23);
            this.tbxSendEmail.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "接收邮件：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "密码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "发送邮件：";
            // 
            // rbtnEmailNo
            // 
            this.rbtnEmailNo.AutoSize = true;
            this.rbtnEmailNo.Checked = true;
            this.rbtnEmailNo.Location = new System.Drawing.Point(154, 17);
            this.rbtnEmailNo.Name = "rbtnEmailNo";
            this.rbtnEmailNo.Size = new System.Drawing.Size(39, 18);
            this.rbtnEmailNo.TabIndex = 12;
            this.rbtnEmailNo.TabStop = true;
            this.rbtnEmailNo.Text = "否";
            this.rbtnEmailNo.UseVisualStyleBackColor = true;
            // 
            // rbtnEmailYes
            // 
            this.rbtnEmailYes.AutoSize = true;
            this.rbtnEmailYes.Location = new System.Drawing.Point(109, 17);
            this.rbtnEmailYes.Name = "rbtnEmailYes";
            this.rbtnEmailYes.Size = new System.Drawing.Size(39, 18);
            this.rbtnEmailYes.TabIndex = 11;
            this.rbtnEmailYes.Text = "是";
            this.rbtnEmailYes.UseVisualStyleBackColor = true;
            this.rbtnEmailYes.CheckedChanged += new System.EventHandler(this.rbtnEmailYes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "是否发送邮件：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnLogNo);
            this.groupBox2.Controls.Add(this.rbtnLogYes);
            this.groupBox2.Controls.Add(this.gbxLog);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(26, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // rbtnLogNo
            // 
            this.rbtnLogNo.AutoSize = true;
            this.rbtnLogNo.Checked = true;
            this.rbtnLogNo.Location = new System.Drawing.Point(153, 18);
            this.rbtnLogNo.Name = "rbtnLogNo";
            this.rbtnLogNo.Size = new System.Drawing.Size(39, 18);
            this.rbtnLogNo.TabIndex = 15;
            this.rbtnLogNo.TabStop = true;
            this.rbtnLogNo.Text = "否";
            this.rbtnLogNo.UseVisualStyleBackColor = true;
            // 
            // rbtnLogYes
            // 
            this.rbtnLogYes.AutoSize = true;
            this.rbtnLogYes.Location = new System.Drawing.Point(108, 18);
            this.rbtnLogYes.Name = "rbtnLogYes";
            this.rbtnLogYes.Size = new System.Drawing.Size(39, 18);
            this.rbtnLogYes.TabIndex = 14;
            this.rbtnLogYes.Text = "是";
            this.rbtnLogYes.UseVisualStyleBackColor = true;
            this.rbtnLogYes.CheckedChanged += new System.EventHandler(this.rbtnLogYes_CheckedChanged);
            // 
            // gbxLog
            // 
            this.gbxLog.Controls.Add(this.btnLogChoose);
            this.gbxLog.Controls.Add(this.tbxLogPath);
            this.gbxLog.Controls.Add(this.label16);
            this.gbxLog.Location = new System.Drawing.Point(8, 37);
            this.gbxLog.Name = "gbxLog";
            this.gbxLog.Size = new System.Drawing.Size(481, 45);
            this.gbxLog.TabIndex = 13;
            this.gbxLog.TabStop = false;
            // 
            // btnLogChoose
            // 
            this.btnLogChoose.Location = new System.Drawing.Point(399, 15);
            this.btnLogChoose.Name = "btnLogChoose";
            this.btnLogChoose.Size = new System.Drawing.Size(75, 23);
            this.btnLogChoose.TabIndex = 6;
            this.btnLogChoose.Text = "选择";
            this.btnLogChoose.UseVisualStyleBackColor = true;
            this.btnLogChoose.Click += new System.EventHandler(this.btnLogChoose_Click);
            // 
            // tbxLogPath
            // 
            this.tbxLogPath.Location = new System.Drawing.Point(78, 16);
            this.tbxLogPath.Name = "tbxLogPath";
            this.tbxLogPath.Size = new System.Drawing.Size(315, 23);
            this.tbxLogPath.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 14);
            this.label16.TabIndex = 2;
            this.label16.Text = "存储路径：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "是否记录日志：";
            // 
            // cbxDel
            // 
            this.cbxDel.AutoSize = true;
            this.cbxDel.Enabled = false;
            this.cbxDel.Location = new System.Drawing.Point(94, 237);
            this.cbxDel.Name = "cbxDel";
            this.cbxDel.Size = new System.Drawing.Size(222, 18);
            this.cbxDel.TabIndex = 19;
            this.cbxDel.Text = "发送到邮箱后自动删除本地备份";
            this.cbxDel.UseVisualStyleBackColor = true;
            // 
            // Fm_Setting
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnSave);
            this.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Fm_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Fm_Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxEmail.ResumeLayout(false);
            this.gbxEmail.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxLog.ResumeLayout(false);
            this.gbxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnEmailNo;
        private System.Windows.Forms.RadioButton rbtnEmailYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxEmail;
        private System.Windows.Forms.TextBox tbxReceivedEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxSendEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnLogNo;
        private System.Windows.Forms.RadioButton rbtnLogYes;
        private System.Windows.Forms.GroupBox gbxLog;
        private System.Windows.Forms.Button btnLogChoose;
        private System.Windows.Forms.TextBox tbxLogPath;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnMessAndData;
        private System.Windows.Forms.RadioButton rbtnMess;
        private System.Windows.Forms.TextBox tbxEmailHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEmailPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxDel;
    }
}