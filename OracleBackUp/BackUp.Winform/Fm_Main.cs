using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BackUp.Winform.Class;
using BackUp.Winform.Models;

namespace BackUp.Winform
{
    public partial class Fm_Main : Form
    {
        private DateTime StartTime;
        private int AllRunTime;
        private static Models.Status Status;
        private static Models.Setting Setting;
        private static List<Models.BackUp> BackUps;
        private bool IsExceing = false;//是否正在执行操作
        private string Cmd;
        private string FilePath;
        private string LogsFolder;
        private string EmailTitle;
        private string EmailBody;
        private Models.BackUp BackUp;
        private DataTable DtBackUp;
        private Fm_Loading fm_Loading;

        public Fm_Main()
        {
            InitializeComponent();
            fm_Loading = new Fm_Loading();
            Status = Class.Json.GetStatus();
            AllRunTime = Status.AllRunTime;
            StartTime = DateTime.Now;
            timer.Start();
            timerBackUp.Start();
        }

        #region BackUp 方法
        /// <summary>
        /// 运行cmd
        /// </summary>
        private void RunCmd()
        {
            try
            {
                Class.Execute exec = new Class.Execute(Cmd, BackUp, LogsFolder);
                exec.RunCmd();
                while (true)
                {
                    if (exec.IsFinish)
                    {
                        break;
                    }
                }
                fm_Loading.DialogResult = exec.IsOk ? DialogResult.OK : DialogResult.Cancel;
            }
            catch
            {
                fm_Loading.DialogResult = DialogResult.Cancel;
            }
        }
        /// <summary>
        /// 线程里运行
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="filePath"></param>
        /// <param name="backUp"></param>
        /// <param name="logsfolder"></param>
        private void ThreadRun(string cmd, string filePath, Models.BackUp backUp, string logsfolder)
        {
            FilePath = filePath;
            Cmd = cmd;
            LogsFolder = logsfolder;
            BackUp = backUp;
            bool isSuccess = false;

            fm_Loading = new Fm_Loading();
            IsExceing = true;
            tsslStatus.Text = $@"状态：正在{logsfolder}...";
            tsslStatus.ForeColor = Color.Black;

            fm_Loading = new Fm_Loading();
            Thread th = new Thread(new ThreadStart(RunCmd));
            th.Start();

            IsExceing = false;
            isSuccess = fm_Loading.ShowDialog() == DialogResult.OK;
            tsslStatus.Text = isSuccess ? $@"状态：{logsfolder}成功" : $@"状态：{logsfolder}失败";
            tsslStatus.ForeColor = isSuccess ? Color.Green : Color.Red;
            if (isSuccess && BackUp.Type != Models.BackType.导入)
            {
                EmailTitle = $"Oracle数据库{logsfolder}:{BackUp.Username}";
                EmailBody = Newtonsoft.Json.JsonConvert.SerializeObject(BackUp);
                Thread thA = new Thread(new ThreadStart(SendMail));
                thA.Start();
            }
        }

        /// <summary>
        /// 设置DataGridView表头
        /// </summary>
        private void SetDgvStyle()
        {
            DataGridViewCellStyle head_style = new DataGridViewCellStyle();
            head_style.Alignment = DataGridViewContentAlignment.MiddleCenter; //设置dgdv中的选择居中
            foreach (DataGridViewColumn dc in dgvData.Columns)
            {
                dc.Visible = false;
            }

            dgvData.AutoGenerateColumns = false;
            dgvData.Columns["DataBase"].HeaderText = "数据库";
            dgvData.Columns["DataBase"].Visible = true;
            dgvData.Columns["DataBase"].DisplayIndex = 0;
            dgvData.Columns["DataBase"].ReadOnly = true;
            dgvData.Columns["DataBase"].Width = 100;

            dgvData.Columns["Username"].HeaderText = "用户名";
            dgvData.Columns["Username"].Visible = true;
            dgvData.Columns["Username"].DisplayIndex = 1;
            dgvData.Columns["Username"].ReadOnly = true;
            dgvData.Columns["Username"].Width = 100;

            dgvData.Columns["Password"].HeaderText = "密码";
            dgvData.Columns["Password"].Visible = true;
            dgvData.Columns["Password"].DisplayIndex = 2;
            dgvData.Columns["Password"].ReadOnly = true;
            dgvData.Columns["Password"].Width = 100;

            dgvData.Columns["Path"].HeaderText = "存储路径";
            dgvData.Columns["Path"].Visible = true;
            dgvData.Columns["Path"].DisplayIndex = 3;
            dgvData.Columns["Path"].ReadOnly = true;
            dgvData.Columns["Path"].Width = 150;


            dgvData.Columns["IsLogs"].HeaderText = "是否保存日志";
            dgvData.Columns["IsLogs"].Visible = true;
            dgvData.Columns["IsLogs"].DisplayIndex = 4;
            dgvData.Columns["IsLogs"].ReadOnly = true;
            dgvData.Columns["IsLogs"].Width = 100;

            dgvData.Columns["LogPath"].HeaderText = "日志保存路径";
            dgvData.Columns["LogPath"].Visible = true;
            dgvData.Columns["LogPath"].DisplayIndex = 5;
            dgvData.Columns["LogPath"].ReadOnly = true;
            dgvData.Columns["LogPath"].Width = 150;

            dgvData.Columns["Times"].HeaderText = "执行周期";
            dgvData.Columns["Times"].Visible = true;
            dgvData.Columns["Times"].DisplayIndex = 6;
            dgvData.Columns["Times"].ReadOnly = true;
            dgvData.Columns["Times"].Width = 100;

            dgvData.Columns["IsUse"].HeaderText = "是否启用";
            dgvData.Columns["IsUse"].Visible = true;
            dgvData.Columns["IsUse"].DisplayIndex = 7;
            dgvData.Columns["IsUse"].ReadOnly = true;
            dgvData.Columns["IsUse"].Width = 100;

            dgvData.Columns["PostTime"].HeaderText = "修改时间";
            dgvData.Columns["PostTime"].Visible = true;
            dgvData.Columns["PostTime"].DisplayIndex = 8;
            dgvData.Columns["PostTime"].ReadOnly = true;
            dgvData.Columns["PostTime"].Width = 150;
            dgvData.Columns["PostTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            dgvData.Columns["LastExecuteTime"].HeaderText = "上一次执行时间";
            dgvData.Columns["LastExecuteTime"].Visible = true;
            dgvData.Columns["LastExecuteTime"].DisplayIndex = 9;
            dgvData.Columns["LastExecuteTime"].ReadOnly = true;
            dgvData.Columns["LastExecuteTime"].Width = 150;
            dgvData.Columns["LastExecuteTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            dgvData.Columns["NextExecuteTime"].HeaderText = "下一次执行时间";
            dgvData.Columns["NextExecuteTime"].Visible = true;
            dgvData.Columns["NextExecuteTime"].DisplayIndex = 10;
            dgvData.Columns["NextExecuteTime"].ReadOnly = true;
            dgvData.Columns["NextExecuteTime"].Width = 150;
            dgvData.Columns["NextExecuteTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            dgvData.Columns["UuId"].HeaderText = "标识";
            dgvData.Columns["UuId"].Visible = false;
            dgvData.Columns["UuId"].DisplayIndex = 11;
            dgvData.Columns["UuId"].ReadOnly = true;
            dgvData.Columns["UuId"].Width = 50;

            DataGridViewButtonColumn column_Use = new DataGridViewButtonColumn
            {
                Name = "Use",
                UseColumnTextForButtonValue = true,
                Text = "启用/停用",
                DisplayIndex = 12,
                FlatStyle = FlatStyle.System,
                HeaderText = "启用/停用"
            };
            dgvData.Columns.Add(column_Use);

            DataGridViewButtonColumn column_Execute = new DataGridViewButtonColumn
            {
                Name = "Execute",
                UseColumnTextForButtonValue = true,
                Text = "执行一次",
                DisplayIndex = 13,
                FlatStyle = FlatStyle.System,
                HeaderText = "执行一次"
            };
            dgvData.Columns.Add(column_Execute);

            DataGridViewButtonColumn column_Del = new DataGridViewButtonColumn
            {
                Name = "Del",
                UseColumnTextForButtonValue = true,
                Text = "删除",
                DisplayIndex = 14,
                FlatStyle = FlatStyle.System,
                HeaderText = "删除"
            };
            dgvData.Columns.Add(column_Del);


            dgvData.Focus();
        }

        /// <summary>
        /// 加载备份列表
        /// </summary>
        private void LoadBackUpList()
        {
            BackUps = Class.Json.GetBackUp();
            DtBackUp = Class.Unit.ToDataTable(BackUps);
            dgvData.DataSource = DtBackUp.DefaultView;
            if (dgvData.DataSource != null && DtBackUp != null && DtBackUp.Rows.Count > 0)
            {
                SetDgvStyle();
            }
        }

        /// <summary>
        /// 自动备份
        /// </summary>
        private void BackUpAuto()
        {
            lock (BackUp.Username)
            {
                if (IsExceing) return;
                if (BackUp == null) return;
                string now = DateTime.Now.ToString("yyyyMMddHHms");
                string cmd = $"exp {BackUp.Username}/{BackUp.Password}@{BackUp.DataBase} file={BackUp.Path}\\Backup_{BackUp.Username}_{now}.dmp";
                if (BackUp.IsLogs)
                {
                    cmd += $" log={BackUp.LogPath}\\Backup_{BackUp.Username}_{now}.log";
                }
                ThreadRun(cmd, $"{BackUp.Path}\\Backup_{BackUp.Username}_{now}.dmp", BackUp, "自动备份");
            }
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="header"></param>
        /// <param name="body"></param>
        /// <param name="attachmentArr"></param>
        private void SendMail()
        {
            try
            {
                if (Setting != null)
                {
                    if (!Setting.IsMail) return;
                    if (Setting.EmailType == Models.EmailType.通知)
                    {
                        Class.Mail.sendMail(int.Parse(Setting.EmailPort), Setting.EmailHost, Setting.SendEmail,
                            Setting.ReceivedEmail, Setting.Password, EmailTitle, EmailBody);
                    }
                    else
                    {
                        if (!Class.Mail.sendMailWithAttachfile(int.Parse(Setting.EmailPort), Setting.EmailHost,
                            Setting.SendEmail, Setting.ReceivedEmail, Setting.Password, EmailTitle, EmailBody,
                            new string[] { FilePath })) return;
                        if (Setting.IsDel)
                        {
                            Thread th = new Thread(new ThreadStart(DeleteFile));
                            th.Start();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Class.Json.WriteTxt("发送邮件", $"header:{EmailTitle}\r\nbody:{EmailBody}\r\nattachmentArr:{FilePath}\r\nError:{ex.Message.ToString()}");
            }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        private void DeleteFile()
        {
            try
            {
                if (File.Exists(FilePath))
                    File.Delete(FilePath);
            }
            catch (Exception ex)
            {
                Class.Json.WriteTxt("自动删除备份", $"删除出错，等待一分钟后再次尝试，备份文件:{FilePath}\r\nError:{ex.ToString()}");
                //删除出错，等待一分钟后再次尝试删除
                Thread.Sleep(60 * 1000);
                try
                {
                    if (File.Exists(FilePath))
                        File.Delete(FilePath);
                    Class.Json.WriteTxt("自动删除备份", $"再次尝试删除成功，备份文件:{FilePath}");
                }
                catch (Exception e)
                {
                    Class.Json.WriteTxt("自动删除备份", $"再次尝试删除依旧出错，备份文件:{FilePath}\r\nError:{e.ToString()}");
                }
            }

        }

        #endregion

        #region Record方法

        private void BindCbxType()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value", typeof(int));
            dt.Columns.Add("text", typeof(string));
            DataRow drAll = dt.NewRow();
            drAll["value"] = 0;
            drAll["text"] = "全部";
            dt.Rows.Add(drAll);
            foreach (Models.BackType excTimes in Enum.GetValues(typeof(Models.BackType)))
            {
                DataRow dr = dt.NewRow();
                dr["value"] = (int)excTimes;
                dr["text"] = excTimes;
                dt.Rows.Add(dr);
            }
            cbxType.DisplayMember = "text";
            cbxType.ValueMember = "value";
            cbxType.DataSource = dt.DefaultView;
            cbxType.SelectedIndex = 0;
        }

        /// <summary>
        /// 设置DataGridView表头
        /// </summary>
        private void SetDgvRecordStyle()
        {
            DataGridViewCellStyle head_style = new DataGridViewCellStyle();
            head_style.Alignment = DataGridViewContentAlignment.MiddleCenter; //设置dgdv中的选择居中
            foreach (DataGridViewColumn dc in dgvRecord.Columns)
            {
                dc.Visible = false;
            }

            dgvRecord.AutoGenerateColumns = false;
            dgvRecord.Columns["DataBase"].HeaderText = "数据库";
            dgvRecord.Columns["DataBase"].Visible = true;
            dgvRecord.Columns["DataBase"].DisplayIndex = 0;
            dgvRecord.Columns["DataBase"].ReadOnly = true;
            dgvRecord.Columns["DataBase"].Width = 100;

            dgvRecord.Columns["Username"].HeaderText = "用户名";
            dgvRecord.Columns["Username"].Visible = true;
            dgvRecord.Columns["Username"].DisplayIndex = 1;
            dgvRecord.Columns["Username"].ReadOnly = true;
            dgvRecord.Columns["Username"].Width = 100;

            dgvRecord.Columns["Password"].HeaderText = "密码";
            dgvRecord.Columns["Password"].Visible = true;
            dgvRecord.Columns["Password"].DisplayIndex = 2;
            dgvRecord.Columns["Password"].ReadOnly = true;
            dgvRecord.Columns["Password"].Width = 100;

            dgvRecord.Columns["Path"].HeaderText = "路径";
            dgvRecord.Columns["Path"].Visible = true;
            dgvRecord.Columns["Path"].DisplayIndex = 3;
            dgvRecord.Columns["Path"].ReadOnly = true;
            dgvRecord.Columns["Path"].Width = 150;

            dgvRecord.Columns["IsLogs"].HeaderText = "是否保存日志";
            dgvRecord.Columns["IsLogs"].Visible = true;
            dgvRecord.Columns["IsLogs"].DisplayIndex = 4;
            dgvRecord.Columns["IsLogs"].ReadOnly = true;
            dgvRecord.Columns["IsLogs"].Width = 100;

            dgvRecord.Columns["LogPath"].HeaderText = "日志保存路径";
            dgvRecord.Columns["LogPath"].Visible = true;
            dgvRecord.Columns["LogPath"].DisplayIndex = 5;
            dgvRecord.Columns["LogPath"].ReadOnly = true;
            dgvRecord.Columns["LogPath"].Width = 150;

            dgvRecord.Columns["Type"].HeaderText = "类型";
            dgvRecord.Columns["Type"].Visible = true;
            dgvRecord.Columns["Type"].DisplayIndex = 6;
            dgvRecord.Columns["Type"].ReadOnly = true;
            dgvRecord.Columns["Type"].Width = 100;

            dgvRecord.Columns["IsOk"].HeaderText = "是否成功";
            dgvRecord.Columns["IsOk"].Visible = true;
            dgvRecord.Columns["IsOk"].DisplayIndex = 7;
            dgvRecord.Columns["IsOk"].ReadOnly = true;
            dgvRecord.Columns["IsOk"].Width = 100;

            dgvRecord.Columns["StartTime"].HeaderText = "开始时间";
            dgvRecord.Columns["StartTime"].Visible = true;
            dgvRecord.Columns["StartTime"].DisplayIndex = 8;
            dgvRecord.Columns["StartTime"].ReadOnly = true;
            dgvRecord.Columns["StartTime"].Width = 150;
            dgvRecord.Columns["StartTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            dgvRecord.Columns["EndTime"].HeaderText = "结束时间";
            dgvRecord.Columns["EndTime"].Visible = true;
            dgvRecord.Columns["EndTime"].DisplayIndex = 9;
            dgvRecord.Columns["EndTime"].ReadOnly = true;
            dgvRecord.Columns["EndTime"].Width = 150;
            dgvRecord.Columns["EndTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            dgvRecord.Columns["Remark"].HeaderText = "备注";
            dgvRecord.Columns["Remark"].Visible = true;
            dgvRecord.Columns["Remark"].DisplayIndex = 10;
            dgvRecord.Columns["Remark"].ReadOnly = true;
            dgvRecord.Columns["Remark"].Width = 250;


            DataGridViewButtonColumn column_Del = new DataGridViewButtonColumn
            {
                Name = "Del",
                UseColumnTextForButtonValue = true,
                Text = "删除",
                DisplayIndex = 11,
                FlatStyle = FlatStyle.System,
                HeaderText = "删除"
            };
            dgvRecord.Columns.Add(column_Del);


            dgvRecord.Focus();
        }

        private void LoadRecordList()
        {
            List<Models.Record> list = new List<Models.Record>();
            int type = int.Parse(cbxType.SelectedValue.ToString());
            var lstModel = Class.Json.GetRecord();
            if (type > 0)
            {
                list.AddRange(lstModel.FindAll(x => x.Type == (Models.BackType)type));
            }
            else
            {
                list = lstModel;
            }
            DataTable dtRrcord = Class.Unit.ToDataTable(list);
            dgvRecord.DataSource = dtRrcord.DefaultView;
            if (dgvRecord.DataSource != null && dtRrcord.Rows.Count > 0)
            {
                SetDgvRecordStyle();
            }
        }

        #endregion

        #region 初始化值

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            BindCbxType();
            LoadSetting();
            LoadStatusStrip();
            LoadBackUpList();
            LoadRecordList();
        }

        /// <summary>
        /// 加载设置
        /// </summary>
        private void LoadSetting()
        {
            Setting = Class.Json.GetSetting();
        }

        /// <summary>
        /// 加载页面底部的数据
        /// </summary>
        private void LoadStatusStrip()
        {
            tsslVersion.Text = @"版本：" + Models.Assemblys.AssemblyVersion;
            tsslLastStopTime.Text = @"上次停止时间：" + Status.StopTime.ToString("yyyy-MM-dd HH:mm:ss");
            tsslLastRunTimeCount.Text = @"上次运行时长：" + Unit.TimeFormat(Unit.TimeSpan(Status.StartTime, Status.StopTime));
            tsslAllRunTimeCount.Text = @"运行总时长：" + Unit.TimeFormat(AllRunTime);
        }

        #endregion

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fm_Main_Load(object sender, EventArgs e)
        {
            Init();
        }

        /// <summary>
        /// 新建备份点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_NewBackUp_Click(object sender, EventArgs e)
        {
            Fm_AddBackUp fm = new Fm_AddBackUp();
            fm.ShowDialog();
            if (fm.DialogResult == DialogResult.OK)
            {
                LoadBackUpList();
            }
        }

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_Setting_Click(object sender, EventArgs e)
        {
            Fm_Setting fm = new Fm_Setting();
            fm.ShowDialog();
            if (fm.DialogResult == DialogResult.OK)
            {
                Setting = Class.Json.GetSetting();
            }
        }

        /// <summary>
        /// 新建导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_Export_Click(object sender, EventArgs e)
        {
            if (IsExceing == false)
            {
                Fm_Export fm = new Fm_Export();
                fm.ShowDialog();
                if (fm.DialogResult == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(fm.Cmd))
                    {
                        ThreadRun(fm.Cmd, fm.FilePath, fm.BackUp, "导出");
                    }
                }
            }
            else
            {
                MessageBox.Show(@"当前正在执行导出数据库操作，请稍后尝试！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 新建导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_Import_Click(object sender, EventArgs e)
        {
            if (IsExceing == false)
            {
                Fm_Import fm = new Fm_Import();
                fm.ShowDialog();
                if (fm.DialogResult == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(fm.Cmd))
                    {
                        ThreadRun(fm.Cmd, fm.FilePath, fm.BackUp, "导入");
                    }
                }
            }
            else
            {
                MessageBox.Show(@"当前正在执行数据库操作，请稍后尝试！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, new SolidBrush(e.InheritedRowStyle.ForeColor), e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView view = (DataView)this.dgvData.DataSource;
            DataRow dr = (DataRow)view[this.dgvData.CurrentCell.RowIndex].Row;
            Models.BackUp backUp = new Models.BackUp()
            {
                UuId = dr["UuId"].ToString(),
                DataBase = dr["DataBase"].ToString(),
                Username = dr["Username"].ToString(),
                Password = dr["Password"].ToString(),
                Path = dr["Path"].ToString(),
                IsLogs = bool.Parse(dr["IsLogs"].ToString()),
                LogPath = dr["LogPath"].ToString(),
                Type = Models.BackType.备份,
                Times = (Models.ExcTimes)int.Parse(dr["Times"].ToString()),
                IsUse = bool.Parse(dr["IsUse"].ToString()),
                PostTime = DateTime.Parse(dr["PostTime"].ToString()),
                LastExecuteTime = DateTime.Parse(dr["LastExecuteTime"].ToString()),
                NextExecuteTime = DateTime.Parse(dr["NextExecuteTime"].ToString())
            };
            if (dgvData.Columns[e.ColumnIndex].Name == "Use")
            {
                backUp.IsUse = !backUp.IsUse;
                Class.Json.EditBackUp(backUp);
                LoadBackUpList();
            }
            if (dgvData.Columns[e.ColumnIndex].Name == "Del")
            {
                if (MessageBox.Show(@"确认是否删除？", @"删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Class.Json.DelBackUp(backUp.UuId);
                    LoadBackUpList();
                }
            }
            if (dgvData.Columns[e.ColumnIndex].Name == "Execute")
            {
                string now = DateTime.Now.ToString("yyyyMMddHHms");
                string cmd = $"exp {backUp.Username}/{backUp.Password}@{backUp.DataBase} file={backUp.Path}\\Backup_{backUp.Username}_{now}.dmp";
                if (backUp.IsLogs)
                {
                    cmd += $" log={backUp.LogPath}\\Backup_{backUp.Username}_{now}.log";
                }
                ThreadRun(cmd, $"{backUp.Path}\\Backup_{backUp.Username}_{now}.dmp", backUp, "手动备份");
                LoadBackUpList();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            AllRunTime++;
            tsslAllRunTimeCount.Text = @"运行总时长：" + Unit.TimeFormat(AllRunTime);
        }

        private void timerBackUp_Tick(object sender, EventArgs e)
        {
            DateTime thisTime = DateTime.Now;
            var backUp = BackUps.Find(x =>
                x.NextExecuteTime < thisTime.AddSeconds(2) && x.NextExecuteTime > thisTime.AddSeconds(-2));
            if (backUp != null && backUp.IsUse)
            {
                if (IsExceing) return;
                BackUp = backUp;
                BackUpAuto();
                LoadBackUpList();
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"是否确认退出程序？", @"退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
        }

        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_About_Click(object sender, EventArgs e)
        {
            Fm_About fm = new Fm_About();
            fm.ShowDialog();
        }

        /// <summary>
        /// 检查更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMI_UpdateCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"暂无更新");
        }

        /// <summary>
        /// 托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon.Visible = false;
            }
        }

        /// <summary>
        /// 窗口改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fm_Main_SizeChanged(object sender, EventArgs e)
        {
            //判断是否选择的是最小化按钮
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon.Visible = true;
            }
        }

        /// <summary>
        /// 窗口退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(@"是否确认退出程序？", @"退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //保存运行状态
                Json.SaveStatus(new Status() { AllRunTime = AllRunTime, StartTime = StartTime, StopTime = DateTime.Now });
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 托盘退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CTSMI_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"是否确认退出程序？", @"退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
        }

        /// <summary>
        /// 托盘显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CTSMI_Show_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// 查询备份配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectBackUp_Click(object sender, EventArgs e)
        {
            LoadBackUpList();
        }

        /// <summary>
        /// 查询记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnselectRrcord_Click(object sender, EventArgs e)
        {
            LoadRecordList();
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView view = (DataView)this.dgvRecord.DataSource;
            DataRow dr = (DataRow)view[this.dgvRecord.CurrentCell.RowIndex].Row;
            Models.Record record = new Models.Record()
            {
                DataBase = dr["DataBase"].ToString(),
                Username = dr["Username"].ToString(),
                Password = dr["Password"].ToString(),
                Path = dr["Path"].ToString(),
                IsLogs = bool.Parse(dr["IsLogs"].ToString()),
                LogPath = dr["LogPath"].ToString(),
                Type = Models.BackType.备份,
                IsOk = bool.Parse(dr["IsOk"].ToString()),
                StartTime = DateTime.Parse(dr["StartTime"].ToString()),
                EndTime = DateTime.Parse(dr["EndTime"].ToString()),
                Remark = dr["Remark"].ToString()
            };
            if (dgvRecord.Columns[e.ColumnIndex].Name == "Del")
            {
                if (MessageBox.Show(@"确认是否删除？", @"删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Class.Json.DelRecord(record.DataBase, record.Username, record.StartTime, record.EndTime);
                    LoadRecordList();
                }
            }
        }
    }
}
