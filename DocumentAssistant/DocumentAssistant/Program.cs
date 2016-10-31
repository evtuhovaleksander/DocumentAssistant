using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAssistant
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //List<string> ms=new List<string>();
            //ms.Add("0");
            //ms.Add("1");
            //ms.Add("2");
            //ms.Add("3");

            //int i = ms.IndexOf("2");
            //i = ms.IndexOf("65655");




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
