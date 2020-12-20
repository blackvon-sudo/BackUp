using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackUp.Winform.Models
{
    /// <summary>
    /// 状态
    /// </summary>
    public class Status
    {
        /// <summary>
        /// 总运行时间
        /// </summary>
        public int AllRunTime { get; set; }

        /// <summary>
        /// 开始执行时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 停止时间
        /// </summary>
        public DateTime StopTime { get; set; }
    }
}
