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
    public partial class Fm_Setting : Form
    {
        public Fm_Setting()
        {
            InitializeComponent();
        }

        private void Fm_Setting_Load(object sender, EventArgs e)
        {
            SetSetting();
            gbxEmail.Enabled = rbtnEmailYes.Checked;
            gbxLog.Enabled = rbtnLogYes.Checked;
            cbxDel.Enabled = rbtnMessAndData.Checked;
            if (rbtnMess.Checked)
                cbxDel.Checked = false;
        }

        private void btnLogChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbxLogPath.Text = dialog.SelectedPath;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Checked())
            {
                Models.Setting setting = new Models.Setting()
                {
                    IsMail = rbtnEmailYes.Checked,
                    EmailHost = tbxEmailHost.Text.Trim(),
                    EmailPort = tbxEmailPort.Text.Trim(),
                    SendEmail = tbxSendEmail.Text.Trim(),
                    Password = tbxPassword.Text.Trim(),
                    ReceivedEmail = tbxReceivedEmail.Text.Trim(),
                    EmailType = rbtnMess.Checked ? Models.EmailType.通知 : Models.EmailType.通知和数据,
                    IsLogs = rbtnLogYes.Checked,
                    LogsPath = tbxLogPath.Text.Trim(),
                    IsDel = cbxDel.Checked
                };
                Class.Json.SaveSetting(setting);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Checked()
        {
            if (rbtnEmailYes.Checked)
            {
                if (string.IsNullOrEmpty(tbxEmailHost.Text.Trim()))
                {
                    MessageBox.Show(@"服务地址不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(tbxEmailPort.Text.Trim()))
                {
                    MessageBox.Show(@"端口不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(tbxSendEmail.Text.Trim()))
                {
                    MessageBox.Show(@"发送邮箱不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(tbxPassword.Text.Trim()))
                {
                    MessageBox.Show(@"密码不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(tbxReceivedEmail.Text.Trim()))
                {
                    MessageBox.Show(@"接收邮箱不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (rbtnLogYes.Checked)
            {
                if (string.IsNullOrEmpty(tbxLogPath.Text.Trim()))
                {
                    MessageBox.Show(@"存储路径不可为空", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void SetSetting()
        {
            Models.Setting setting = Class.Json.GetSetting();
            rbtnEmailYes.Checked = setting.IsMail;
            rbtnEmailNo.Checked = !setting.IsMail;
            tbxEmailHost.Text = setting.EmailHost;
            tbxEmailPort.Text = setting.EmailPort;
            tbxSendEmail.Text = setting.SendEmail;
            tbxPassword.Text = setting.Password;
            tbxReceivedEmail.Text = setting.ReceivedEmail;
            rbtnMess.Checked = setting.EmailType == Models.EmailType.通知;
            rbtnMessAndData.Checked = setting.EmailType != Models.EmailType.通知;
            rbtnLogYes.Checked = setting.IsLogs;
            rbtnLogNo.Checked = !setting.IsLogs;
            tbxLogPath.Text = setting.LogsPath;
            cbxDel.Checked = setting.IsDel;
        }

        private void rbtnEmailYes_CheckedChanged(object sender, EventArgs e)
        {
            gbxEmail.Enabled = rbtnEmailYes.Checked;
        }

        private void rbtnLogYes_CheckedChanged(object sender, EventArgs e)
        {
            gbxLog.Enabled = rbtnLogYes.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnMess_CheckedChanged(object sender, EventArgs e)
        {
            cbxDel.Enabled = !rbtnMess.Checked;
            if (rbtnMess.Checked)
                cbxDel.Checked = false;
        }
    }
}
