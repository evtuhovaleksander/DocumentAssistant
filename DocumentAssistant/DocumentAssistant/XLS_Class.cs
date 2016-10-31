﻿using System;
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

        public object read_val(int i, int j)
        {
            return ObjWorkSheet.get_Range("A"+j,"A"+j).Text; ;
            return null;
        }
        ~XLS_Class()  // destructor
        {
            ObjWorkBook.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
            ObjWorkExcel.Quit(); // выйти из экселя
            GC.Collect(); // убрать за собой
        }
       
           
    }
}
