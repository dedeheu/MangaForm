using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Librairie MySQL
using MySql.Data.MySqlClient;
using System.Data;

namespace MangaForm.Dao
{

    class Dao
    {
        //Attributs
        protected static MySqlConnection conn = null;

        //Méthodes
        protected static void open()
        {
            string cs = @"server=localhost;userid=root;password=;database=bibliomanga";
            string dd = "test";
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }
        protected static void close()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
        public static DataTable ReadAll(string table){
            DataTable dtRes = new DataTable();
            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM "+table+";";
                MySqlDataReader res = cmd.ExecuteReader();
                dtRes.Load(res);
                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return dtRes;
            }
            return dtRes;
        }
        public static void RemoveId(int id, string col, string table)
        {
            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM " + table + " WHERE " + col +"="+id;
                cmd.ExecuteNonQuery();
                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }
    }
}

