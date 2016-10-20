using System;
using System.Data;

using System.Data.SqlTypes;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql;


using MySql.Data.MySqlClient;

namespace DocumentAssistant
{
    //Properties.Settings.Default.BasePath
    internal class SQL_Class
    {
        
        public MySqlConnection SQL_Connection;
        public MySqlDataReader SQL_DataReader;

      public   SQL_Class()
        {
            
            Create_Connection(Properties.Settings.Default.BasePath);
           Open_Connection();
            if (SQL_Connection.State != ConnectionState.Open) MessageBox.Show("eror during con open");

        }

        public static Boolean check_connection(string con_string)
        {
            try
            {
                var conString = @"" + con_string;
                MySqlConnection Test_SQL_Connection = new MySqlConnection(conString);
                Test_SQL_Connection.Open();
                Test_SQL_Connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static Boolean check_connection()
        {
            try
            {
                var conString = @"" + Properties.Settings.Default.BasePath;
                MySqlConnection Test_SQL_Connection = new MySqlConnection(conString);
                Test_SQL_Connection.Open();
                Test_SQL_Connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        public void Manualy_Close_Connection()
        {
            if (SQL_Connection.State == ConnectionState.Open)
            {
                SQL_Connection.Close();
            }
        }

        public void Create_Connection(string base_path)
        {
           SQL_Connection=new MySqlConnection(base_path); 
        }
        public void Create_Connection()
        {
            SQL_Connection = new MySqlConnection(Properties.Settings.Default.BasePath);
        }
        private Boolean Open_Connection()
        {
            try
            {
                if (SQL_Connection.State == ConnectionState.Closed)
                {

                    SQL_Connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;

            }
            return true;
        }






        public static int ReadValueInt32(string s, string base_path)
        {
           
            return Convert.ToInt32(ReadValue(s, base_path));
        }

        public static Boolean ReadValueBoolean(string s, string base_path)
        {
            return Convert.ToBoolean(ReadValue(s, base_path));
        }

        public static string ReadValueString(string s, string base_path)
        {
            return Convert.ToString(ReadValue(s, base_path));
        }

        public static object ReadValue(string s, string base_path)
        {
            
            SQL_Class sql = new SQL_Class();
            sql.Create_Connection(base_path);
            sql.Open_Connection();
            MySqlCommand comand = new MySqlCommand(s, sql.SQL_Connection);
            object obj = comand.ExecuteScalar();
            sql.Manualy_Close_Connection();
            return obj;
           
        }

        public static SQL_Class Create_class(string base_path)
        {
           
            SQL_Class sql_class = new SQL_Class();
            sql_class.Create_Connection(base_path);
            sql_class.Open_Connection();
            if (sql_class.SQL_Connection.State != ConnectionState.Open) return null;
            return sql_class;
         
        }


        public static int ReadValueInt32(string s)
        {

            return Convert.ToInt32(ReadValue(s, Properties.Settings.Default.BasePath));
        }

        public static Boolean ReadValueBoolean(string s)
        {
            return Convert.ToBoolean(ReadValue(s, Properties.Settings.Default.BasePath));
        }

        public static string ReadValueString(string s)
        {
            return Convert.ToString(ReadValue(s, Properties.Settings.Default.BasePath));
        }

        public static object ReadValue(string s)
        {

            SQL_Class sql = new SQL_Class();
            sql.Create_Connection(Properties.Settings.Default.BasePath);
            sql.Open_Connection();
            MySqlCommand comand = new MySqlCommand(s, sql.SQL_Connection);
            object obj = comand.ExecuteScalar();
            sql.Manualy_Close_Connection();
            return obj;

        }

        public static SQL_Class Create_class()
        {

            SQL_Class sql_class = new SQL_Class();
            sql_class.Create_Connection(Properties.Settings.Default.BasePath);
            sql_class.Open_Connection();
            if (sql_class.SQL_Connection.State != ConnectionState.Open) return null;
            return sql_class;

        }

        public  void ReadValues(string s)
        {

            try
            {
                if (SQL_DataReader != null)
                {

                    if (!SQL_DataReader.IsClosed)SQL_DataReader.Close();
                }
                MySqlCommand temp = new MySqlCommand(s,SQL_Connection);
                MySqlDataReader ret = temp.ExecuteReader();
                SQL_DataReader = ret;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        public  Boolean getBoolean(int i)
        {
            if (SQL_DataReader.GetInt32(i) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Execute(string s, string base_path)
        {
            s = s.Replace("'True'", "1");
            s = s.Replace("'False'", "0");
            SQL_Class sql_c = new SQL_Class();
            sql_c.Create_Connection(base_path);
            sql_c.Open_Connection();

            var temp = new MySqlCommand(s, sql_c.SQL_Connection);

            try
            {
                temp.ExecuteNonQuery();
            }
            catch (Exception)
            {
                sql_c.Manualy_Close_Connection();
                return false;
            }

            
            sql_c.Manualy_Close_Connection();
            return true;
        }

        public static bool Execute(string s)
        {
            s = s.Replace("'True'", "1");
            s = s.Replace("'False'", "0");
            SQL_Class sql_c = new SQL_Class();
            sql_c.Create_Connection(Properties.Settings.Default.BasePath);
            sql_c.Open_Connection();

            var temp = new MySqlCommand(s, sql_c.SQL_Connection);

            try
            {
                temp.ExecuteNonQuery();
            }
            catch (Exception)
            {
                sql_c.Manualy_Close_Connection();
                return false;
            }


            sql_c.Manualy_Close_Connection();
            return true;
        }

        public static string get_Data_asString(SQL_Class sqlcl, int index)
        {
        
            if (sqlcl.SQL_DataReader.GetValue(index).ToString() == "")
            {
                return "";
            }
            else
            {
                return sqlcl.SQL_DataReader.GetDateTime(index).ToString("g");
            }
        }

        public static string wr_data(string str)
        {
            if (str != "")
            {
                return "'" + str + "'";
            }
            else
            {
                return "NULL";
            }
        }

        public static string wr_data(object obj)
        {
            if (obj != null)
            {
                return wr_data(obj.ToString());
            }
            else
            {
                return "NULL";
            }

        }

        //public DataTable get_Table(List<string> mas_eng, string str)
        //{
        //    string[] or_like = new string[0];
        //    if (All_Search_chBox.Checked)
        //    {
        //        string[] sv = All_Search_TBox.Text.Split('|');
        //        or_like = new string[sv.Length];
        //        for (int i = 0; i < sv.Length; i++)
        //        {
        //            string cur = "";
        //            for (int j = 1; j < mas_eng.Count; j++)
        //            {
        //                if (!"Data_StartIngest_StartIngest_EndTime_Of_Registration".Contains(mas_eng[j]))
        //                {
        //                    if (sv[i][0] == '@')
        //                    {
        //                        cur += "  or  " + mas_eng[j] + " like '" + sv[i].Replace("#", "").Replace("!", "") + "' ";
        //                    }
        //                    else
        //                    {
        //                        cur += "  or  " + mas_eng[j] + " like '%" + sv[i].Replace("#", "").Replace("!", "") + "%' ";
        //                    }
        //                    //cur += "  or  " + mas_eng[j] + " like "+ sv[i].Replace("#","").Replace("@","") + " ";

        //                }

        //            }

        //            or_like[i] = " and ( false " + cur + " )";
        //            if (sv[i][0] == '#')
        //            {
        //                or_like[i] = or_like[i].Replace(" and (", " and NOT (");
        //            }


        //        }
        //    }


        //    string agregate = str;

        //    string pre_zapros = "";


        //    if (agregate.Contains("PrID"))
        //    {
        //        pre_zapros = "SELECT MDA.ID,PrID,MDA.ID  " + agregate.Replace("PrID", "St.Name") + " FROM     MetaDataArchive as MDA   left join ingestassistantsettingsbase.settings as St  on St.ID=PrID  where( Deleted=0  ";
        //    }
        //    else
        //    {
        //        pre_zapros = "SELECT MDA.ID,PrID,MDA.ID  " + agregate + " FROM     MetaDataArchive as MDA   where (Deleted=0  ";
        //    }

        //    if (ViPlanner_ChBOX.Checked)
        //    {
        //        pre_zapros += "AND ViPlanner='" + Viplanner_TBox.Text + "'  ";
        //    }

        //    if (Reel_ID_ChBox.Checked)
        //    {
        //        pre_zapros += "AND Reel_ID='" + Reel_Id_TBox + "'  ";
        //    }


        //    if (Pr_Filter_ChBox.Checked)
        //    {
        //        pre_zapros += "AND PrID=" +
        //                      SQL_Class.ReadValueInt32(
        //                          "select ID from settings where Name='" + Pr_Filter_CmBox.SelectedItem + "'",
        //                          Properties.Settings.Default.Setting_Base_Path) + "  ";
        //    }

        //    if (D_Date_ChBox.Checked)
        //    {
        //        DateTime d1;
        //        DateTime d2;
        //        if (D_One_RBut.Checked)
        //        {
        //            d1 = Date_Filter1.Value.Date;
        //            d2 = d1.AddDays(1).Date;
        //        }
        //        else
        //        {
        //            d1 = Date_Filter1.Value.Date;
        //            d2 = Date_Filter2.Value.AddDays(1).Date;
        //        }
        //        pre_zapros += "AND (Time_Of_Registration between '" + d1.ToString("yyyy.MM.dd HH:mm:ss") + "' and  '" +
        //                      d2.ToString("yyyy.MM.dd HH:mm:ss") + "'  )";
        //    }

        //    if (All_Search_chBox.Checked)
        //    {
        //        string zapr = "";
        //        pre_zapros += "  ";
        //        for (int i = 0; i < or_like.Length; i++)
        //        {

        //            zapr += pre_zapros + or_like[i] + ") union ";
        //        }
        //        if (or_like.Length != 0) zapr = zapr.Substring(0, zapr.Length - 7);
        //        else zapr = pre_zapros + " false)";

        //        pre_zapros = zapr;
        //    }
        //    else
        //    {
        //        pre_zapros += ")";
        //    }




        //    if (pre_zapros.Contains("UserID"))
        //    {
        //        pre_zapros = pre_zapros.Replace("UserID", "L.L_FullName");
        //        pre_zapros = pre_zapros.Replace("where",
        //            "left join ingestassistantsettingsbase.login as L  on L.L_ID=UserID  where");
        //    }
        //    if (pre_zapros.Contains("RegisterID"))
        //    {
        //        pre_zapros = pre_zapros.Replace("RegisterID", "LL.L_FullName");
        //        // if (!pre_zapros.Contains("left join ingestassistantsettingsbase.login as L  on L_ID=UserId")) 
        //        {
        //            pre_zapros = pre_zapros.Replace("where",
        //               "left join ingestassistantsettingsbase.login as LL  on LL.L_ID=RegisterID  where");
        //        }
        //    }




        //    pre_zapros = pre_zapros.Replace(" ID", "MDA.ID");

        //    var sqlcon = SQL_Class.Create_class(Ingest_Assistant.Properties.Settings.Default.MetaBase_Way);
        //    int rows_count = 0;


        //    //vk
        //    MySqlDataAdapter mad = new MySqlDataAdapter(pre_zapros, sqlcon.SQL_Connection);
        //    //DataSet set = new DataSet();
        //    DataTable tb = new DataTable();
        //    mad.Fill(tb);
        //    return tb;
        //}

    }
}