using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackUp.Winform.Models
{
    public class BackUp
    {
        /// <summary>
        /// 标识
        /// </summary>
        public string UuId { get; set; }

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
        /// 执行周期
        /// </summary>
        public ExcTimes Times { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsUse { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public BackType Type { get; set; }

        /// <summary>
        /// 添加、修改时间
        /// </summary>
        public DateTime PostTime { get; set; }

        /// <summary>
        /// 上一次执行时间
        /// </summary>
        public DateTime LastExecuteTime { get; set; }

        /// <summary>
        /// 下一次执行时间
        /// </summary>
        public DateTime NextExecuteTime { get; set; }
    }
}
