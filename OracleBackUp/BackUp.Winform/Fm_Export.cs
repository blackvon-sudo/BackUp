using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackUp.Winform
{
    public partial class Fm_Export : Form
    {
        public string Cmd { get; set; }
        public string FilePath { get; set; }
        public Models.BackUp BackUp { get; set; }

        public Fm_Export()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Checked())
            {
                string now = DateTime.Now.ToString("yyyyMMddHHms");
                string cmd = $"exp {tbxUsername.Text.Trim()}/{tbxPassword.Text.Trim()}@{tbxDataBase.Text.Trim()} file={tbxPath.Text.Trim()}\\Exp_{tbxUsername.Text.Trim()}_{now}.dmp";
                Models.Setting setting = Class.Json.GetSetting();
                if (setting.IsLogs)
                {
                    cmd += $" log={setting.LogsPath}\\Exp_{tbxUsername.Text.Trim()}_{now}.log";
                }
                Cmd = cmd;
                FilePath = $"{tbxPath.Text.Trim()}\\Exp_{tbxUsername.Text.Trim()}_{now}.dmp";
                BackUp = new Models.BackUp()
                {
                    DataBase = tbxDataBase.Text.Trim(),
                    Username = tbxUsername.Text.Trim(),
                    Password = tbxPassword.Text.Trim(),
                    Path = $"{tbxPath.Text.Trim()}\\{tbxUsername.Text.Trim()}_{now}.dmp",
                    IsLogs = setting.IsLogs,
                    LogPath = setting.IsLogs ? $"{setting.LogsPath}\\{tbxUsername.Text.Trim()}_{now}.log" : "",
                    Type = Models.BackType.导出
                };
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
                MessageBox.Show(@"存储路径不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
