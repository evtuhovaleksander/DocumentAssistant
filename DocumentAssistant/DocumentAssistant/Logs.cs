using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAssistant
{
    public static class Logs
    {
        public static void add_upload_log(int itemId,string param, string from, string to)
        {
            string zap = "insert into logs (ItemID,Log,Date,Who) values (" + itemId + ",'Изменение параметра " + param +
                         " c " + from + " на " + to + "',NOW(),'" + Environment.UserName + "')";
            SQL_Class.Execute(zap);
        }

        public static void add_upload_log(int itemId, string param,string table_name, int from, int to)
        {
            string fr = SQL_Class.ReadValueString("select " + param + " from " + table_name + " where ID=" + from);
            string too = SQL_Class.ReadValueString("select " + param + " from " + table_name + " where ID=" + from);
            string zap = "insert into logs (ItemID,Log,Date,Who) values (" + itemId + ",'Изменение параметра " + param +
                         " c " + fr + " на " + too + "',NOW(),'" + Environment.UserName + "')";
            SQL_Class.Execute(zap);
        }
        public static void add_upload_log(int itemId, string param, string table_name, int from, string to)
        {
            string fr = SQL_Class.ReadValueString("select " + param + " from " + table_name + " where ID=" + from);
            
            string zap = "insert into logs (ItemID,Log,Date,Who) values (" + itemId + ",'Изменение параметра " + param +
                         " c " + fr + " на " + to + "',NOW(),'" + Environment.UserName + "')";
            SQL_Class.Execute(zap);
        }
        
    }
}
