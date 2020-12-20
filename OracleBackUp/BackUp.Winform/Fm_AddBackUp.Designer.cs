
namespace BackUp.Winform
{
    partial class Fm_AddBackUp
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxTimes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.btnChoose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxDataBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(409, 30);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxTimes
            // 
            this.cbxTimes.FormattingEnabled = true;
            this.cbxTimes.Location = new System.Drawing.Point(128, 172);
            this.cbxTimes.Name = "cbxTimes";
            this.cbxTimes.Size = new System.Drawing.Size(301, 22);
            this.cbxTimes.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 39;
            this.label6.Text = "执行周期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 38;
            this.label5.Text = "是否启用：";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(174, 211);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(39, 18);
            this.rbtnNo.TabIndex = 36;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "否";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Checked = true;
            this.rbtnYes.Location = new System.Drawing.Point(129, 211);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(39, 18);
            this.rbtnYes.TabIndex = 35;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "是";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(343, 133);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(86, 26);
            this.btnChoose.TabIndex = 30;
            this.btnChoose.Text = "选择文件夹";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 31;
            this.label3.Text = "存储路径：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 34;
            this.label4.Text = "数据库：";
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(128, 135);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(209, 23);
            this.tbxPath.TabIndex = 32;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(129, 98);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(300, 23);
            this.tbxPassword.TabIndex = 29;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(129, 61);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(300, 23);
            this.tbxUsername.TabIndex = 28;
            // 
            // tbxDataBase
            // 
            this.tbxDataBase.Location = new System.Drawing.Point(129, 24);
            this.tbxDataBase.Name = "tbxDataBase";
            this.tbxDataBase.Size = new System.Drawing.Size(300, 23);
            this.tbxDataBase.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "数据库密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 26;
            this.label1.Text = "数据库用户名：";
            // 
            // Fm_AddBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 309);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxTimes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.rbtnYes);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxDataBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Fm_AddBackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建备份";
            this.Load += new System.EventHandler(this.Fm_AddBackUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxTimes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxDataBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}