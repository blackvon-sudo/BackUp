namespace BackUp.Winform
{
    partial class Fm_Import
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
            this.tbxFromuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(513, 35);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(441, 219);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 30);
            this.btnChoose.TabIndex = 29;
            this.btnChoose.Text = "选择文件";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "选择文件：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 31;
            this.label4.Text = "数据库：";
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(192, 222);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(243, 23);
            this.tbxPath.TabIndex = 30;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(192, 134);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(349, 23);
            this.tbxPassword.TabIndex = 27;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(192, 91);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(349, 23);
            this.tbxUsername.TabIndex = 26;
            // 
            // tbxDataBase
            // 
            this.tbxDataBase.Location = new System.Drawing.Point(192, 48);
            this.tbxDataBase.Name = "tbxDataBase";
            this.tbxDataBase.Size = new System.Drawing.Size(349, 23);
            this.tbxDataBase.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "数据库密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "数据库用户名(touser)：";
            // 
            // tbxFromuser
            // 
            this.tbxFromuser.Location = new System.Drawing.Point(192, 178);
            this.tbxFromuser.Name = "tbxFromuser";
            this.tbxFromuser.Size = new System.Drawing.Size(349, 23);
            this.tbxFromuser.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 14);
            this.label5.TabIndex = 33;
            this.label5.Text = "原用户名(fromuser)：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "*说明：需要提前在数据库中建好用户！";
            // 
            // Fm_Import
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 338);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxFromuser);
            this.Controls.Add(this.label5);
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
            this.Name = "Fm_Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建导入";
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
        private System.Windows.Forms.TextBox tbxFromuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}