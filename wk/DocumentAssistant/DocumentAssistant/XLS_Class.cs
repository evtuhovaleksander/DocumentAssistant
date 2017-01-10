using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DocumentAssistant
{
   public  class XLS_Class
    {

        public static XLS_Class get_xls()
        {
            //return new XLS_Class("E:\\GitRep\\DocumentAssistant\\NEW BASE.xlsx");
            FileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            if (File.Exists(dlg.FileName))
            {
                
                return new XLS_Class(dlg.FileName);
            }
            else
            {
                return null;
            }
        }



        Excel.Application ObjWorkExcel;// = new Excel.Application(); //открыть эксель
        Excel.Workbook ObjWorkBook;// = ObjWorkExcel.Workbooks.Open(@"C:\1.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
        Excel.Worksheet ObjWorkSheet;// = (Excel.Worksheet)ObjWorkBook.Sheets[1]; //получить 1 лист
        public XLS_Class(string path)
        {
            ObjWorkExcel = new Excel.Application(); //открыть эксель
            ObjWorkBook = ObjWorkExcel.Workbooks.Open(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1]; //получить 1 лист


        }


       public void set_val(int i, int j, string val)
       {
           i++;
           j++;
           ObjWorkSheet.Cells[j][i] = val;

       }

       public void save_as(string path)
       {
            ObjWorkBook.Save();
            //ObjWorkSheet.sa
       }


       public object read_val(int i, int j)
        {
            char k = 'A';
            char[] ms = {'0', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R'};



            return ObjWorkSheet.get_Range(ms[j].ToString()+i,ms[j].ToString()+i).Text; 
            return null;
        }
        ~XLS_Class()  // destructor
        {
            try
            {
                ObjWorkBook.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
                ObjWorkExcel.Quit(); // выйти из экселя
                GC.Collect(); // убрать за собой
            }
            catch (Exception)
            {
                
                
            }
           
        }
       
           
    }
}
