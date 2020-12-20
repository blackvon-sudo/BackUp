using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BackUp.Winform.Class
{
    public static class Json
    {
        /// <summary>
        /// 保存设置
        /// </summary>
        /// <param name="model"></param>
        public static void SaveSetting(Models.Setting model)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            SaveJson("Setting", json);
        }

        /// <summary>
        /// 保存运行状态
        /// </summary>
        /// <param name="model"></param>
        public static void SaveStatus(Models.Status model)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            SaveJson("Status", json);
        }

        /// <summary>
        /// 保存记录
        /// </summary>
        /// <param name="model"></param>
        public static void SaveRecord(Models.Record model)
        {
            var lstModel = GetRecord();
            lstModel.Add(model);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(lstModel);
            SaveJson("Record", json);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="database"></param>
        /// <param name="username"></param>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        public static void DelRecord(string database, string username, DateTime starttime, DateTime endtime)
        {
            var lstModel = GetRecord();
            var index = lstModel.FindIndex(x => x.DataBase == database && x.Username == username && x.StartTime.ToString("yyyyMMddHHmmss") == starttime.ToString("yyyyMMddHHmmss") && x.EndTime.ToString("yyyyMMddHHmmss") == endtime.ToString("yyyyMMddHHmmss"));
            if (index > -1)
            {
                lstModel.RemoveAt(index);
            }
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(lstModel);
            SaveJson("Record", json);
        }

        /// <summary>
        /// 保存备份配置
        /// </summary>
        /// <param name="model"></param>
        public static void SaveBackUp(Models.BackUp model)
        {
            var lstModel = GetBackUp();
            lstModel.Add(model);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(lstModel);
            SaveJson("BackUp", json);
        }

        /// <summary>
        /// 修改备份配置
        /// </summary>
        /// <param name="model"></param>
        public static void EditBackUp(Models.BackUp model)
        {
            var lstModel = GetBackUp();
            var index = lstModel.FindIndex(x => x.UuId == model.UuId);
            lstModel.RemoveAt(index);
            lstModel.Add(model);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(lstModel);
            SaveJson("BackUp", json);
        }

        /// <summary>
        /// 删除备份配置
        /// </summary>
        /// <param name="uuId"></param>
        public static void DelBackUp(string uuId)
        {
            var lstModel = GetBackUp();
            var index = lstModel.FindIndex(x => x.UuId == uuId);
            if (index > -1)
            {
                lstModel.RemoveAt(index);
            }
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(lstModel);
            SaveJson("BackUp", json);
        }

        /// <summary>
        /// 获取设置
        /// </summary>
        /// <returns></returns>
        public static Models.Setting GetSetting()
        {
            var json = GetJson("Setting");
            return string.IsNullOrEmpty(json)
                ? new Models.Setting() : Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Setting>(json);
        }

        /// <summary>
        /// 获取运行状态
        /// </summary>
        /// <returns></returns>
        public static Models.Status GetStatus()
        {
            var json = GetJson("Status");
            return string.IsNullOrEmpty(json)
                ? new Models.Status() : Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Status>(json);
        }

        /// <summary>
        /// 获取记录
        /// </summary>
        /// <returns></returns>
        public static List<Models.Record> GetRecord()
        {
            var json = GetJson("Record");
            return string.IsNullOrEmpty(json)
                ? new List<Models.Record>() : Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.Record>>(json).OrderByDescending(p=>p.EndTime).ToList();
        }

        /// <summary>
        /// 获取备份配置
        /// </summary>
        /// <returns></returns>
        public static List<Models.BackUp> GetBackUp()
        {
            var json = GetJson("BackUp");
            return string.IsNullOrEmpty(json)
                ? new List<Models.BackUp>() : Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.BackUp>>(json).OrderByDescending(p => p.PostTime).ToList();
        }

        /// <summary>
        /// 保存JSON数据
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="json"></param>
        private static void SaveJson(string filename, string json)
        {
            try
            {
                var exeFolder = System.Windows.Forms.Application.StartupPath + "\\";
                var directory = exeFolder + "Json\\";
                var filepath = directory + "\\" + filename + ".json";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                File.WriteAllText(filepath, json);
            }
            catch (Exception e)
            {
                WriteTxt("保存JSON", $"{filename}.json 保存出错:\r\n{e.Message}");
            }
        }

        /// <summary>
        /// 获取JSON数据
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private static string GetJson(string filename)
        {
            var res = "";
            try
            {
                var exeFolder = System.Windows.Forms.Application.StartupPath + "\\";
                var directory = exeFolder + "Json\\";
                var filepath = directory + "\\" + filename + ".json";
                // 创建一个 StreamReader 的实例来读取文件 
                // using 语句也能关闭 StreamReader
                using (var sr = new StreamReader(filepath))
                {
                    string line;

                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        res += line;
                    }
                }
            }
            catch (Exception e)
            {
                WriteTxt("获取JSON", $"{filename}.json 读取出错:\r\n{e.Message}");
            }
            return res;
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="folder">该日志所在文件夹名字</param>
        /// <param name="content"></param>
        public static void WriteTxt(string folder, string content)
        {
            try
            {
                var exeFolder = System.Windows.Forms.Application.StartupPath + "\\";
                var directory = exeFolder + "logs\\" + folder;
                var filepath = directory + "\\日志(" + DateTime.Now.ToString("yyyy-MM-dd") + ").txt";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
                var sw = new StreamWriter(filepath, true, Encoding.UTF8);
                sw.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]:");
                sw.WriteLine("***************************分隔符【开始】***********************************");
                sw.WriteLine(content);
                sw.WriteLine("***************************分隔符【结束】***********************************\r\n");
                sw.Close();
            }
            catch
            {
                // ignored
            }
        }
    }
}
