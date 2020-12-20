using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackUp.Winform.Models
{
    public class Record
    { 
        /// <summary>
        /// 数据库
        /// </summary>
        public string DataBase { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 是否保存日志
        /// </summary>
        public bool IsLogs { get; set; }

        /// <summary>
        /// 日志保存路径
        /// </summary>
        public string LogPath { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public BackType Type { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsOk { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
