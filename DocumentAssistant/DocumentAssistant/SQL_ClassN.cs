using System;
using System.Collections.Generic;
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
            
            Create_Connection();
           Open_Connection();
            if (SQL_Connection.State != ConnectionState.Open) MessageBox.Show("eror during con open");

        }

     

        public static void Manualy_Close_Connection()
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

       
        public static void Create_Connection()
        {
            SQL_Connection = new MySqlConnection(Properties.Settings.Default.BasePath);
        }
      
        public void Create_Connection2()
        {
            SQL_Connection2 = new MySqlConnection(Properties.Settings.Default.BasePath);
        }


        public static Boolean Open_Connection()
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

        public Boolean Open_Connection2()
        {
            try
            {
                if (SQL_Connection2.State == ConnectionState.Closed)
                {

                    SQL_Connection2.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;

            }
            return true;
        }




      
      

        public static object ReadValue(string s)
        {

            
            Create_Connection();
            Open_Connection();
            MySqlCommand comand = new MySqlCommand(s, SQL_Connection);
            object obj = comand.ExecuteScalar();
            Manualy_Close_Connection();
            return obj;

        }

     


        public static int ReadValueInt32(string s)
        {

            return Convert.ToInt32(ReadValue(s));
        }

        public static Boolean ReadValueBoolean(string s)
        {
            return Convert.ToBoolean(ReadValue(s));
        }

        public static string ReadValueString(string s)
        {
            return Convert.ToString(ReadValue(s));
        }

      

      

        public  void ReadValues(string s)
        {
            Create_Connection2();
            if (SQL_Connection2.State == ConnectionState.Open) SQL_Connection2.Close();
            Open_Connection2();
            try
            {
                if (SQL_DataReader != null)
                {

                    if (!SQL_DataReader.IsClosed)SQL_DataReader.Close();
                }
                MySqlCommand temp = new MySqlCommand(s,SQL_Connection2);
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

   

        public static bool Execute(string s)
        {
            s = s.Replace("'True'", "1");
            s = s.Replace("'False'", "0");
            
            Create_Connection();
            Open_Connection();

            var temp = new MySqlCommand(s, SQL_Connection);

            try
            {
                temp.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
                Manualy_Close_Connection();
                return false;
            }


            Manualy_Close_Connection();
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

        public static List<string> get_data_Source(string queue)
        {
            List<string> lst= new List<string>();
            SQL_Class cl=new SQL_Class();
            cl.ReadValues(queue);
            while (cl.SQL_DataReader.Read())
            {
                lst.Add(cl.get_string(0));
            }
            return lst;
        }

        

    }
}