using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackUp.Winform.Models
{
    public enum EmailType
    {
        通知 = 1,
        通知和数据 = 2
    }

    public enum ExcTimes
    {
        一天 = 1,
        三天 = 3,
        一周 = 7,
        半个月 = 15,
        一个月 = 30,
        三个月 = 90,
        半年 = 180,
        一年 = 365
    }

    public enum BackType
    {
        导出 = 1,
        导入 = 2,
        备份 = 3
    }
}
