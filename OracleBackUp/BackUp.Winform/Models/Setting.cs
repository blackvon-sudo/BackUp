using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackUp.Winform.Models
{
    public class Setting
    {
        /// <summary>
        /// 是否发送邮件
        /// </summary>
        public bool IsMail { get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        public string EmailHost { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        public string EmailPort { get; set; }

        /// <summary>
        /// 发送的邮件
        /// </summary>
        public string SendEmail { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 接收的邮件
        /// </summary>
        public string ReceivedEmail { get; set; }

        /// <summary>
        /// 邮件发送类型
        /// </summary>
        public EmailType EmailType { get; set; }

        /// <summary>
        /// 是否记录日志
        /// </summary>
        public bool IsLogs { get; set; }

        /// <summary>
        /// 日志存放目录
        /// </summary>
        public string LogsPath { get; set; }


        /// <summary>
        /// 是否发送邮件后删除本地备份
        /// </summary>
        public bool IsDel { get; set; }
    }
}
