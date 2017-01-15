using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void open_document(int id)
        {
            try
            {
                Process.Start(SQL_Class.ReadValueString("select Path from documents where ID=" + id));
            }
            catch (Exception)
            {
                
               
            }
           
        }

        //public static void edit_document(int id)
        //{
        //    string path=SQL_Class.ReadValueString("select Path from documents where ID=" + id)
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.FileName = path;
        //    if (ofd.ShowDialog()==DialogResult.Yes)
        //    {
        //        path=
        //    }
            
        //}

        public static void delete_document(int id)
        {
            string path = (SQL_Class.ReadValueString("select Path from documents where ID=" + id));
            
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception)
            {
              
            }
            SQL_Class.Execute("delete * from documents where ID=" + id);
        }

        public static void add_document(int itemID)
        {
            string path;
            OpenFileDialog ofd = new OpenFileDialog();
                
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        path = ofd.FileName;
                        string dir = SQL_Class.ReadValueString("select Serial2 from itemtable where ID=" + itemID);
                        string dest_dir = Path + "\\" + dir;
                        if (!Directory.Exists(dest_dir))
                        {
                            Directory.CreateDirectory(dest_dir);
                        }
                        string dest_path = dest_dir + "\\" + System.IO.Path.GetFileName(path);
                        if (!File.Exists(dest_path))
                        {
                            File.Copy(path, dest_path);
                            string zap = "insert into documents (ItemID,Name,Path) values (" + itemID + ",'" +
                                         System.IO.Path.GetFileName(path) + "','" + dest_path.Replace("\\", "\\\\") + "')";
                            SQL_Class.Execute(zap);
                        }
                        else
                        {
                            if (MessageBox.Show("Заменить файл?", "Заменить файл?", MessageBoxButtons.YesNo) ==
                                DialogResult.Yes)
                            {
                                File.Delete(dest_path);
                                File.Copy(path, dest_path);
                                string zap = "insert into documents (ItemID,Name,Path) values (" + itemID + ",'" +
                                             System.IO.Path.GetFileName(path) + "','" + dest_path.Replace("\\","\\\\") + "')";
                                SQL_Class.Execute(zap);
                            }
                        }
                       
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                   
                }
        }
    }
}
