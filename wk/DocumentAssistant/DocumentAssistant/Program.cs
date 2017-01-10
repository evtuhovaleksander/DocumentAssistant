using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Application = System.Windows.Forms.Application;

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
            try
            {
                MySqlConnection C=new MySqlConnection(Properties.Settings.Default.BasePathReserv_ACER);
                C.Open();
                C.Close();
                Properties.Settings.Default.BasePath = Properties.Settings.Default.BasePathReserv_ACER;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                Properties.Settings.Default.BasePath = Properties.Settings.Default.BasePathReserv;
                Properties.Settings.Default.Save();
                
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
