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
    internal class SQL_Class3
    {


        public int get_int(int i)
        {
            if (!SQL_DataReader.IsDBNull(i))
            {
                return SQL_DataReader.GetInt32(i);
            }
            else
            {
                return   RandomFull.get_rand_int(); ;
            }
        }

        public string get_string(int i)
        {
            
            if (!SQL_DataReader.IsDBNull(i))
            {
                return SQL_DataReader.GetString(i);
            }
            else
            {
                return "";
            }
        }

        public static MySqlConnection SQL_Connection;
        public static MySqlConnection SQL_Connection2;
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
        public void Manualy_Close_Connection2()
        {
            if (SQL_Connection2.State == ConnectionState.Open)
            {
                SQL_Connection2.Close();
            }
        }

       
        public void Create_Connection()
        {
            SQL_Connection = new MySqlConnection(Properties.Settings.Default.BasePath);
        }

        public void Create_Connection(string bp)
        {
            SQL_Connection = new MySqlConnection(bp);
        }

        public void Create_Connection2()
        {
            SQL_Connection2 = new MySqlConnection(Properties.Settings.Default.BasePath);
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

        private Boolean Open_Connection2()
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
            MySqlCommand comand = new MySqlCommand(s, SQL_Connection);
            object obj = comand.ExecuteScalar();
            sql.Manualy_Close_Connection();
            return obj;
           
        }

        public static SQL_Class Create_class(string base_path)
        {
           
            SQL_Class sql_class = new SQL_Class();
            sql_class.Create_Connection(base_path);
            sql_class.Open_Connection();
            if (SQL_Connection.State != ConnectionState.Open) return null;
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
            if(SQL_Connection.State==ConnectionState.Open) SQL_Connection.Close();
            sql.Open_Connection();
            MySqlCommand comand = new MySqlCommand(s, SQL_Connection);
            object obj = comand.ExecuteScalar();
            sql.Manualy_Close_Connection();
            return obj;

        }

        public static SQL_Class Create_class()
        {

            SQL_Class sql_class = new SQL_Class();
            sql_class.Create_Connection(Properties.Settings.Default.BasePath);
            sql_class.Open_Connection();
            if (SQL_Connection.State != ConnectionState.Open) return null;
            return sql_class;

        }

        public  void ReadValues(string s)
        {
            Create_Connection(Properties.Settings.Default.BasePath);
            if (SQL_Connection.State == ConnectionState.Open) SQL_Connection.Close();
            Open_Connection();
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

            var temp = new MySqlCommand(s, SQL_Connection);

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

            var temp = new MySqlCommand(s, SQL_Connection);

            try
            {
                temp.ExecuteNonQuery();
            }
            catch (Exception ex)
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

        

    }
}