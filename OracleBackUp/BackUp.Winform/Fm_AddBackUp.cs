using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackUp.Winform
{
    public partial class Fm_AddBackUp : Form
    {
        public Fm_AddBackUp()
        {
            InitializeComponent();
        }

        private void Fm_AddBackUp_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value", typeof(int));
            dt.Columns.Add("text", typeof(string));
            foreach (Models.ExcTimes excTimes in Enum.GetValues(typeof(Models.ExcTimes)))
            {
                DataRow dr = dt.NewRow();
                dr["value"] = (int) excTimes;
                dr["text"] = excTimes;
                dt.Rows.Add(dr);
            }
            cbxTimes.DisplayMember = "text";
            cbxTimes.ValueMember = "value";
            cbxTimes.DataSource = dt.DefaultView;
            cbxTimes.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Checked())
            {
                Models.Setting setting = Class.Json.GetSetting();
                Models.BackUp BackUp = new Models.BackUp()
                {
                    UuId = System.Guid.NewGuid().ToString("N"),
                    DataBase = tbxDataBase.Text.Trim(),
                    Username = tbxUsername.Text.Trim(),
                    Password = tbxPassword.Text.Trim(),
                    Path = $"{tbxPath.Text.Trim()}\\",
                    IsLogs = setting.IsLogs,
                    LogPath = setting.IsLogs ? $"{setting.LogsPath}\\" : "",
                    Type = Models.BackType.备份,
                    Times = (Models.ExcTimes)int.Parse(cbxTimes.SelectedValue.ToString()),
                    IsUse = rbtnYes.Checked,
                    PostTime = DateTime.Now,
                    LastExecuteTime = DateTime.MinValue,
                    NextExecuteTime = DateTime.Now.AddMinutes(5)
                };
                Class.Json.SaveBackUp(BackUp);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Checked()
        {
            if (string.IsNullOrEmpty(tbxDataBase.Text.Trim()))
            {
                MessageBox.Show(@"数据库不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(tbxUsername.Text.Trim()))
            {
                MessageBox.Show(@"用户名不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(tbxPassword.Text.Trim()))
            {
                MessageBox.Show(@"密码不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(tbxPath.Text.Trim()))
            {
                MessageBox.Show(@"文件不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cbxTimes.Text.Trim()))
            {
                MessageBox.Show(@"执行周期不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbxPath.Text = dialog.SelectedPath;
            }
        }
    }
}
