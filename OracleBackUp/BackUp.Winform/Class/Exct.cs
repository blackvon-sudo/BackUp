using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BackUp.Winform.Class
{
    public class Execute
    {
        private string _logsContent;//日志内容
        private readonly string _logFolder;//日志保存目录
        private readonly string _cmd;//待执行的cmd命令
        private Models.BackUp _backUp;//备份配置
        private bool _isloading = true;//是否正在执行命令
        private bool _isok = false;//是否成功
        private DateTime _startTime;//开始时间
        private DateTime _endTime;//执行结束时间
        public Execute(string cmd, Models.BackUp backUp, string logfolder)
        {
            _cmd = cmd;
            _backUp = backUp;
            _logFolder = logfolder;
        }

        public bool IsFinish => !_isloading;
        public bool IsOk => _isok;

        /// <summary>
        /// 执行cmd命令
        /// </summary>
        public void RunCmd()
        {
            lock (_cmd)
            {
                try
                {
                    //string strInput = Console.ReadLine();
                    Process p = new Process();
                    //设置要启动的应用程序
                    p.StartInfo.FileName = "cmd.exe";
                    //是否使用操作系统shell启动
                    p.StartInfo.UseShellExecute = false;
                    // 接受来自调用程序的输入信息
                    p.StartInfo.RedirectStandardInput = true;
                    //输出信息
                    p.StartInfo.RedirectStandardOutput = true;
                    // 输出错误
                    p.StartInfo.RedirectStandardError = true;
                    //不显示程序窗口
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

                    p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
                    p.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);
                    //启用Exited事件
                    p.EnableRaisingEvents = true;
                    p.Exited += new EventHandler(Process_Exited);

                    //启动程序
                    p.Start();
                    p.BeginOutputReadLine();
                    p.BeginErrorReadLine();
                    p.StandardInput.AutoFlush = true;

                    //输入命令

                    _startTime = DateTime.Now;

                    p.StandardInput.WriteLine(_cmd);
                    p.StandardInput.WriteLine("exit");

                }
                catch (Exception ex)
                {
                    Class.Json.WriteTxt("CMD", $"执行cmd命令出错：\r\ncmd:{_cmd}\r\n{ex.Message}");
                }
            }
        }


        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                SetLogContent(e.Data);
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                SetLogContent(e.Data);
            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            //备份的时候要更新配置中的下次执行时间
            if (_backUp.Type == Models.BackType.备份)
            {
                _backUp.LastExecuteTime = _startTime;
                _backUp.NextExecuteTime = GetNextExecuteTime(_startTime, _backUp.Times); 
                Class.Json.EditBackUp(_backUp);
            }

            SetLogContent("命令执行完毕");
            WriteTxt(_logFolder);
            _isok = _logsContent.Contains("成功")&& !_logsContent.Contains("未成功");
            _isloading = false;
            _endTime = DateTime.Now;

            SaveRecord();

        }

        /// <summary>
        /// 设置日志内容
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public string SetLogContent(string log)
        {
            _logsContent += log + "\r\n";
            return _logsContent;
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="folder">该日志所在文件夹名字</param>
        public void WriteTxt(string folder)
        {
            Class.Json.WriteTxt(folder, _logsContent);
        }

        /// <summary>
        /// 保存记录
        /// </summary>
        private void SaveRecord()
        {
            Class.Json.SaveRecord(new Models.Record()
            {
                DataBase = _backUp.DataBase,
                Username = _backUp.Username,
                Password = _backUp.Password,
                Path = _backUp.Path,
                IsLogs = _backUp.IsLogs,
                LogPath = _backUp.LogPath,
                Type = _backUp.Type,
                StartTime = _startTime,
                EndTime = _endTime,
                IsOk = _isok,
                Remark = _cmd
            });
        }

        /// <summary>
        /// 获取下一次执行的时间
        /// </summary>
        /// <param name="time"></param>
        /// <param name="excTimes"></param>
        /// <returns></returns>
        private DateTime GetNextExecuteTime(DateTime time,Models.ExcTimes excTimes)
        {
            switch (excTimes)
            {
                case Models.ExcTimes.一天 :
                    return time.AddDays(1);
                case Models.ExcTimes.三天:
                    return time.AddDays(3);
                case Models.ExcTimes.一周:
                    return time.AddDays(7);
                case Models.ExcTimes.半个月:
                    return time.AddDays(15);
                case Models.ExcTimes.一个月:
                    return time.AddMonths(1);
                case Models.ExcTimes.三个月:
                    return time.AddMonths(3);
                case Models.ExcTimes.半年:
                    return time.AddMonths(6);
                case Models.ExcTimes.一年:
                    return time.AddYears(1);
                default:
                    return time.AddDays(7);
            }
        }

    }
}
