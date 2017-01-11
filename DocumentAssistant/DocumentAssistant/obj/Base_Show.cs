using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

using System.Windows.Forms;


using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace DocumentAssistant
{
    public partial class Base_Show : Form
    {
        private List<Search_Element> search_list;
       
        public int[] asms;
     //   private Browser Cur_Browser;
       



        private DataTable tbl;//= new DataTable();

        public Base_Show()
        {
          
            InitializeComponent();
           
            prepare_variats();
            
        }

        public void prepare_variats()
        {
            search_list = new List<Search_Element>();

            string zapros =
                "SELECT COLUMN_NAME,DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS where table_name = 'itemtable' and table_schema = 'documentassistant'";
            SQL_Class sqlcl = SQL_Class.Create_class();
            sqlcl.ReadValues(zapros);
            while (sqlcl.SQL_DataReader.Read())
            {
                if (sqlcl.SQL_DataReader.GetString(0) != "ID")
                    search_list.Add(new Search_Element(sqlcl.SQL_DataReader.GetString(0), sqlcl.SQL_DataReader.GetString(1)));
            }

            Refresh();
        }

     

      

        public void color_row(int i, Color cl)
        {
            for (int k = 0; k < dgv.ColumnCount; k++)
            {
                dgv.Rows[i].Cells[k].Style.BackColor = cl;
            }

        }




  

      

        private void Base_Show_Load(object sender, EventArgs e)
        {
           
        }




      

      

        private void D_One_RBut_CheckedChanged(object sender, EventArgs e)
        {
            if (D_One_RBut.Checked)
            {
                Date_Filter2.Visible = false;
            }
            else
            {
                Date_Filter2.Visible = true;
            }
        }



       

        private void Main_Load_But_Click(object sender, EventArgs e)
        {          
          
            Test_Load();
        }



        public DataTable get_Table(List<string> mas_eng,string str )
        {
            string[] or_like = new string[0];
            if (All_Search_chBox.Checked)
            {
                string[] sv = All_Search_TBox.Text.Split('|');
                or_like = new string[sv.Length];
                for (int i = 0; i < sv.Length; i++)
                {
                    string cur = "";
                    for (int j = 1; j < mas_eng.Count; j++)
                    {
                        if (!"Data_StartIngest_StartIngest_EndTime_Of_Registration".Contains(mas_eng[j]))
                        {
                            if (sv[i][0] == '@')
                            {
                                cur += "  or  " + mas_eng[j] + " like '" + sv[i].Replace("#", "").Replace("!", "") + "' ";
                            }
                            else
                            {
                                cur += "  or  " + mas_eng[j] + " like '%" + sv[i].Replace("#", "").Replace("!", "") + "%' ";
                            }
                            //cur += "  or  " + mas_eng[j] + " like "+ sv[i].Replace("#","").Replace("@","") + " ";
                           
                        }
                        
                    }

                    or_like[i] = " and ( false " + cur + " )";
                    if (sv[i][0] == '#')
                    {
                        or_like[i] = or_like[i].Replace(" and ("," and NOT (");
                    }

                    
                }
            }


            string agregate = str;

            string pre_zapros = "";


            if (agregate.Contains("PrID"))
            {
                pre_zapros = "SELECT MDA.ID,PrID,MDA.ID  " + agregate.Replace("PrID", "St.Name") + " FROM     MetaDataArchive as MDA   left join ingestassistantsettingsbase.settings as St  on St.ID=PrID  where( Deleted=0  ";
            }
            else
            {
                pre_zapros = "SELECT MDA.ID,PrID,MDA.ID  " + agregate + " FROM     MetaDataArchive as MDA   where (Deleted=0  ";
            }

            if (ViPlanner_ChBOX.Checked)
            {
                pre_zapros += "AND ViPlanner='" + Viplanner_TBox.Text + "'  ";
            }

            if (Reel_ID_ChBox.Checked)
            {
                pre_zapros += "AND Reel_ID='" + Reel_Id_TBox + "'  ";
            }


            if (Pr_Filter_ChBox.Checked)
            {
                pre_zapros += "AND PrID=" +
                              SQL_Class.ReadValueInt32(
                                  "select ID from settings where Name='" + Pr_Filter_CmBox.SelectedItem + "'",
                                  Properties.Settings.Default.Setting_Base_Path) + "  ";
            }

            if (D_Date_ChBox.Checked)
            {
                DateTime d1;
                DateTime d2;
                if (D_One_RBut.Checked)
                {
                    d1 = Date_Filter1.Value.Date;
                    d2 = d1.AddDays(1).Date;
                }
                else
                {
                    d1 = Date_Filter1.Value.Date;
                    d2 = Date_Filter2.Value.AddDays(1).Date;
                }
                pre_zapros += "AND (Time_Of_Registration between '" + d1.ToString("yyyy.MM.dd HH:mm:ss") + "' and  '" +
                              d2.ToString("yyyy.MM.dd HH:mm:ss") + "'  )";
            }

            if (All_Search_chBox.Checked)
            {
                string zapr = "";
                pre_zapros += "  ";
                for (int i = 0; i < or_like.Length; i++)
                {

                    zapr += pre_zapros + or_like[i] + ") union ";
                }
                if (or_like.Length != 0) zapr = zapr.Substring(0, zapr.Length - 7);
                else zapr = pre_zapros + " false)";

                pre_zapros = zapr;
            }
            else
            {
                pre_zapros += ")";
            }




            if (pre_zapros.Contains("UserID"))
            {
                pre_zapros = pre_zapros.Replace("UserID", "L.L_FullName");
                pre_zapros = pre_zapros.Replace("where",
                    "left join ingestassistantsettingsbase.login as L  on L.L_ID=UserID  where");
            }
            if (pre_zapros.Contains("RegisterID"))
            {
                pre_zapros = pre_zapros.Replace("RegisterID", "LL.L_FullName");
               // if (!pre_zapros.Contains("left join ingestassistantsettingsbase.login as L  on L_ID=UserId")) 
                { pre_zapros = pre_zapros.Replace("where",
                     "left join ingestassistantsettingsbase.login as LL  on LL.L_ID=RegisterID  where"); }
            }




            pre_zapros = pre_zapros.Replace(" ID", "MDA.ID");

            var sqlcon = SQL_Class.Create_class(Ingest_Assistant.Properties.Settings.Default.MetaBase_Way);
            int rows_count = 0;


            //vk
            MySqlDataAdapter mad = new MySqlDataAdapter(pre_zapros, sqlcon.SQL_Connection);
            //DataSet set = new DataSet();
            DataTable tb = new DataTable();
            mad.Fill(tb);
            return tb;
        }

        public void Test_Load()
        {


             string zapros = "select Count(*) from settings";
           
            
         
        
            string str = "";
            List<string> mas_eng = new List<string>();
            List<string> mas_rus = new List<string>();
            //mas.Enqueue("ID");
            mas_eng.Add("ID") ;
            mas_rus.Add("ID");

            for (int i = 0; i < search_list.Count; i++)
            {
                if (search_list[i].marked)
                {
                    mas_eng.Add(search_list[i].name);
                    mas_rus.Add(search_list[i].rusname);
                    str += "," + search_list[i].name;

                }

            }



           
            
            dgv.DataSource = get_Table(mas_eng,str);
            

            for (int i = 0; i < mas_rus.Count; i++)
            {
                //tb.Columns[i].ColumnName = mas_rus[i];
                dgv.Columns[i+2].HeaderText = mas_rus[i];
            }
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].Visible = false;

           
            
            Refresh();
          
        }


 //private void Export_To_Excell_But_Click(object sender, EventArgs e)
        //{

        //    string filters = "";


        //    if (ViPlanner_ChBOX.Checked)
        //    {
        //        filters += "ID_ViPlanner=" + Viplanner_TBox.Text + "  |  ";
        //    }

        //    if (D_Date_ChBox.Checked)
        //    {
        //        if (D_Duraation_RBut.Checked)
        //        {
        //            filters += "Промежуток времени между " + Date_Filter1.Value.ToString("G") + " и " +
        //                       Date_Filter2.Value.ToString("G") + "  |  ";
        //        }
        //        else
        //        {
        //            filters += "За один день " + Date_Filter1.Value.ToString("G") + "  |  ";
        //        }
        //        filters += "ID_ViPlanner=" + Viplanner_TBox.Text + "  |  ";
        //    }



        //    if (Reel_ID_ChBox.Checked)
        //    {
        //        filters += "Reel_ID=" + Reel_Id_TBox.Text + "  |  ";
        //    }

        //    if (All_Search_chBox.Checked)
        //    {
        //        filters += "Сквозной поиск по значениям:" + All_Search_TBox.Text.Replace("|", " , ") + "  |  ";
        //    }







        //    string old_file = Ingest_Assistant.Properties.Settings.Default.Shablon_Path + "\\ExportXLS.xls";
        //    string new_file = Ingest_Assistant.Properties.Settings.Default.Temp_Files_Directory + "\\Export_File__" +
        //                      DateTime.Now.ToString("HH-MM-SS   dd-mm-yyyy") + " .xls";
        //    if (!Directory.Exists(Ingest_Assistant.Properties.Settings.Default.Temp_Files_Directory))
        //    {
        //        DirectoryM.CreateDirectory(Ingest_Assistant.Properties.Settings.Default.Temp_Files_Directory);
        //    }

        //    FileM.Copy(old_file, new_file);




        //    Application xlApp = null;
        //    Workbook xlWorkBook = null;
        //    Worksheet xlWorkSheet = null;
        //    var old_excels = Process.GetProcessesByName("EXCEL");
        //    var old_excels_id = new Queue<string>();
        //    foreach (var Pr in old_excels)
        //    {
        //        old_excels_id.Enqueue(Pr.Id.ToString());
        //    }
        //    try
        //    {
        //        xlApp = new Application();

        //        xlApp.Workbooks.Open(new_file);
        //        xlWorkBook = xlApp.ActiveWorkbook;

        //        xlWorkSheet = xlWorkBook.Worksheets.get_Item(1);
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //    var m_workSheet = xlWorkSheet;

        //    xlWorkSheet.Cells[2, 2] = filters;
           

        //    int bas = 5;
        //    int k = 1;
           
                   
               

        //     string str = "";
        //    List<string> mas_eng = new List<string>();
        //    List<string> mas_rus = new List<string>();
        //    //mas.Enqueue("ID");
        //    mas_eng.Add("ID") ;
        //    mas_rus.Add("ID");

        //    for (int i = 0; i < search_list.Count; i++)
        //    {
        //        if (search_list[i].marked)
        //        {
        //            mas_eng.Add(search_list[i].name);
        //            mas_rus.Add(search_list[i].rusname);
        //            str += "," + search_list[i].name;
        //            m_workSheet.Cells[bas - 1, k] = search_list[i].rusname;
        //            k++;
        //        }

        //    }

        //    DataTable tbl = get_Table(mas_eng, str);

        //    Export_prbar.Maximum = tbl.Rows.Count + 1;
        //    Export_prbar.Value = 0;
        //    Refresh();

        //    for (int i = 0; i < tbl.Rows.Count; i++)
        //    {
        //        for (int q = 0; q < k; q++)
        //        {
        //            m_workSheet.Cells[i + bas, q+1] = tbl.Rows[i][q+2].ToString();
        //        }
        //        draw_line(i + bas, m_workSheet, k);
        //        if (i%10 == 0)
        //        {
        //            Export_prbar.Value = i;
        //            Refresh();
        //        }
        //    }


        //    Export_prbar.Value = Export_prbar.Maximum;
        //    Refresh();





                    
                
                
            
        //    draw_line(bas - 1, m_workSheet, k);
        //xlWorkBook.Save();
        //    xlWorkBook.Close(true);
        //    xlApp.Quit();
        //    var new_excels = Process.GetProcessesByName("EXCEL");
        //    foreach (var Pr in new_excels)
        //    {
        //        if (!old_excels_id.Contains(Pr.Id.ToString()))
        //            Pr.Kill();
        //    }



        //    Process.Start(new_file);




        //}
        
        //public string get_excel_code(int i)
        //{
        //    string[] mas =
        //    {
        //        "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
        //        "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK",
        //        "AL", "AM", "AN", "AO", "AP", "AQ"
        //    };
        //    return mas[i];
        //}

        //public void draw_line(int id, Worksheet Sheet,int len)
        //{
        //    Sheet.get_Range("A" + id, get_excel_code(len) + id).Borders.ColorIndex = 0;
        //    Sheet.get_Range("A" + id, get_excel_code(len) + id).Borders.LineStyle = XlLineStyle.xlContinuous;
        //    Sheet.get_Range("A" + id, get_excel_code(len) + id).Borders.Weight = XlBorderWeight.xlThin;
        //}


        private string last_clicked;
        private int row;
        private int column;





        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("open" + "row=" + row + "   col=" + column);
            //int id = Convert.ToInt32(dgv.Rows[row].Cells[0].Value);
            //string viplanner = SQL_Class.ReadValueString("select ViPlanner from metadataarchive where id=" + id,
            //    Settings.Default.MetaBase_Way);
            //string path = Settings.Default.Work_Path + "\\" + viplanner;
            //if (Directory.Exists(path)) Process.Start(path);
            //else MessageBox.Show("no such a directory :" + path);
        }

        private void ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Drawing.Point pCell = dgv.GetCellDisplayRectangle(column, row, true).Location;
            System.Drawing.Point pGrid = dgv.Location;
            ContextMenuStrip.Location = new System.Drawing.Point(pCell.X + pGrid.X,
                pCell.Y + pGrid.Y + dgv.CurrentRow.Height);
        }

   




      
      

        
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            column = e.ColumnIndex;
        }

       


        public class Search_Element
        {
            public string name;
            public string rusname;
            public Boolean marked;
            public string type;
            

            public Search_Element(string name,string type)
            {
                this.type = type;
                this.name = name;
                marked = true;
                object reader = null;
                this.rusname = name;
               
                if (name == "Work_Status") rusname = "Статус работы";
               

            }
        }

        private void отобразитьMediaInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void отправитьНаРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (column > 2)
            {
                //List<Search_Element> mas = new List<Search_Element>();
                //for (int i = 0; i < search_list.Count; i++)
                //{
                //    if (search_list[i].marked) mas.Add(search_list[i]);
                //}
                //string vp =
                //    SQL_Class.ReadValueString(
                //        "Select ViPlanner from metadataarchive where ID=" + dgv.Rows[row].Cells[0].Value,
                //        Settings.Default.MetaBase_Way);
                //Correction_Form.Correction_Lauch(Convert.ToInt64(dgv.Rows[row].Cells[0].Value), vp, mas[column - 3].name,
                //    mas[column - 3].rusname, mas[column - 3].type, dgv.Rows[row].Cells[column].Value.ToString());
            }
        }

        private void R_Help_But_Click(object sender, EventArgs e)
        {
            if (R_Help_But.Size.Width == 25)
            {
                for (int i = 0; i < 400; i++)
                {
                    if (R_Help_But.Size.Height == 100)
                    {
                        R_Help_But.Size = new Size(R_Help_But.Size.Width + 1, R_Help_But.Size.Height);
                    }
                    else
                    {
                        R_Help_But.Size = new Size(R_Help_But.Size.Width + 1, R_Help_But.Size.Height + 1);
                    }
                   
                    R_Help_But.Refresh();
                }
                R_Help_But.Text =
                    "Для разделения слов при поиске используется символ '|' \n Для поиска по условию 'все кроме' перед словом ставим '#' \n Для поиска по условию 'строгое вхождение' перед словом ставим '@'";
            }
            else
            {
                for (int i = 0; i < 400; i++)
                {
                    if (R_Help_But.Size.Height == 25)
                    {
                        R_Help_But.Size = new Size(R_Help_But.Size.Width - 1, R_Help_But.Size.Height);
                    }
                    else
                    {
                        R_Help_But.Size = new Size(R_Help_But.Size.Width - 1, R_Help_But.Size.Height - 1);
                    }
                    R_Help_But.Refresh();
                }
                R_Help_But.Text ="?";
            }
        }



        private void загрузитьВРабочуюФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
        }

        private void Date_Filter1_ValueChanged(object sender, EventArgs e)
        {
            if (Date_Filter1.Value > Date_Filter2.Value)
            {
                Date_Filter2.Value = Date_Filter1.Value;
            }
        }

        private void Date_Filter2_ValueChanged(object sender, EventArgs e)
        {
            if (Date_Filter1.Value > Date_Filter2.Value)
            {
                Date_Filter1.Value = Date_Filter2.Value;
            }
        }

      




    }
}



