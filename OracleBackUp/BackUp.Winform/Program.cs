using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BackUp.Winform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //测试vscode网页版代码编辑
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Fm_Main());
        }
    }
}
