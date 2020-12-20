namespace BackUp.Winform
{
    partial class Fm_Export
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
            this.btnSave.Location = new System.Drawing.Point(22, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(477, 35);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(399, 156);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 30);
            this.btnChoose.TabIndex = 15;
            this.btnChoose.Text = "选择文件夹";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "存储路径：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "数据库：";
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(148, 159);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(243, 23);
            this.tbxPath.TabIndex = 17;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(149, 115);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(349, 23);
            this.tbxPassword.TabIndex = 14;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(149, 72);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(349, 23);
            this.tbxUsername.TabIndex = 13;
            // 
            // tbxDataBase
            // 
            this.tbxDataBase.Location = new System.Drawing.Point(149, 29);
            this.tbxDataBase.Name = "tbxDataBase";
            this.tbxDataBase.Size = new System.Drawing.Size(349, 23);
            this.tbxDataBase.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "数据库密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "数据库用户名：";
            // 
            // Fm_Export
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 268);
            this.Controls.Add(this.btnSave);
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
            this.Name = "Fm_Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建导出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
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