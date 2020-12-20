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
    public partial class Fm_Import : Form
    {
        public string Cmd { get; set; }
        public string FilePath { get; set; }
        public Models.BackUp BackUp { get; set; }
        public Fm_Import()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Checked())
            {
                string now = DateTime.Now.ToString("yyyyMMddHHms");
                string cmd = $@"imp {tbxUsername.Text.Trim()}/{tbxPassword.Text.Trim()}@{tbxDataBase.Text.Trim()} file={tbxPath.Text.Trim()} fromuser={tbxFromuser.Text.Trim()} touser={tbxUsername.Text.Trim()}";
                Models.Setting setting = Class.Json.GetSetting();
                if (setting.IsLogs)
                {
                    cmd += $" log={setting.LogsPath}\\Imp_{tbxUsername.Text.Trim()}_{now}.log";
                }
                Cmd = cmd;
                FilePath = tbxPath.Text.Trim();
                BackUp = new Models.BackUp()
                {
                    DataBase = tbxDataBase.Text.Trim(),
                    Username = tbxUsername.Text.Trim(),
                    Password = tbxPassword.Text.Trim(),
                    Path = $"{tbxPath.Text.Trim()}\\{tbxUsername.Text.Trim()}_{now}.dmp",
                    IsLogs = setting.IsLogs,
                    LogPath = setting.IsLogs ? $"{setting.LogsPath}\\{tbxUsername.Text.Trim()}_{now}.log" : "",
                    Type = Models.BackType.导入
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*dmp*)|*.dmp*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxPath.Text = fileDialog.FileName;//返回文件的完整路径                
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
            if (string.IsNullOrEmpty(tbxFromuser.Text.Trim()))
            {
                MessageBox.Show(@"原用户名不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
