using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BackUp.Winform.Class
{
    public static class Unit
    {
        /// <summary>    
        /// 将集合类转换成DataTable    
        /// </summary>    
        /// <param name="list">集合</param>    
        /// <returns></returns>    
        public static DataTable ToDataTable(IList list)
        {
            DataTable result = new DataTable();
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();


                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name, pi.PropertyType);
                }
                foreach (object t in list)
                {
                    ArrayList tempList = new ArrayList();

                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(t, null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;


        }

        #region 时间转换

        /// <summary>
        /// 秒转时间
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string TimeFormat(int time)
        {
            var ts = new TimeSpan(0, 0, time);
            return $"{ts.Days}天{ts.Hours}小时{ts.Minutes}分钟{ts.Seconds}秒";
        }

        /// <summary>
        /// 时间差值获取秒数
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public static int TimeSpan(DateTime startTime, DateTime endTime)
        {
            var ts = endTime.Subtract(startTime);
            var sec = (int)ts.TotalSeconds;
            return sec;
        }

        #endregion
    }
}
