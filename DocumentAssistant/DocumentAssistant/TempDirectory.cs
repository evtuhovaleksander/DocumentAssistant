using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAssistant
{
    static class TempDirectory
    {
        public static bool AllowWork;
        public static bool ShablonsEnabled;
        public static string Path;
        public static string Shablon1Path;

        public static void InitTempDirectory()
        {
            AllowWork = true;
            ShablonsEnabled = true;

            Path = "D:\\DocumentAssistant";
            if (!Directory.Exists(Path))
            {
                try
                {
                    Directory.CreateDirectory(Path);
                }
                catch (Exception)
                {
                    AllowWork = false;
                }
            }

            Shablon1Path = "D:\\DocumentAssistant\\Shablon1.xlsx";
            checkFile(Shablon1Path);
        }

        public static void checkFile(string path)
        {
            if (!File.Exists(path)) ShablonsEnabled = false;
        }
    }
    static class DocumentDirectory
    {
        public static bool AllowWork;
        public static string Path;
        

        public static void InitDocumentDirectory()
        {
            AllowWork = true;
            

            Path = "D:\\DocumentAssistantArchive";
            if (!Directory.Exists(Path))
            {
                try
                {
                    Directory.CreateDirectory(Path);
                }
                catch (Exception)
                {
                    AllowWork = false;
                }
            }

           
        }

       
    }
}
