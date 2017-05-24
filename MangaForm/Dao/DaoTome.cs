using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Librairie MySQL
using MySql.Data.MySqlClient;
using System.Data;

// Classes du projets
using MangaForm.Classes;
namespace MangaForm.Dao
{
    class DaoTome : Dao
    {
        public static void create(Tome leTome)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO tome(idTome, numeroTome, titreTome, resumerTome, dateAchatTome) VALUES (@idTome, @numeroTome, @titreTome, @resumerTome, @statutManga, @dateAchatTome)";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idTome", leTome.IdTome);
                cmd.Parameters.AddWithValue("@numeroTome", leTome.NumeroTome);
                cmd.Parameters.AddWithValue("@titreTome", leTome.TitreTome);
                cmd.Parameters.AddWithValue("@resumerTome", leTome.ResumerTome);
                cmd.Parameters.AddWithValue("@dateAchatTome", leTome.DateAchatTome);


                cmd.ExecuteNonQuery();

                leTome.IdTome = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }

        }


        public static Tome ReadOneId(int id)
        {
            Tome leTome = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM tome WHERE idTome=" + id;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                leTome = new Tome();
                leTome.IdTome= (int)res["idTome"];
                leTome.NumeroTome = (int)res["numeroTome"];
                leTome.TitreTome = (string)res["titreTome"];
                leTome.ResumerTome = (string)res["resumerTome"];
                leTome.DateAchatTome = (DateTime)res["dateAchatTome"];
                close();

                return leTome;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return leTome;

            }
        }


        public static Tome ReadOneName(string titreTome)
        {
            Tome leTome = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM manga WHERE nomManga=" + titreTome;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                leTome = new Tome();
                leTome.IdTome = (int)res["idTome"];
                leTome.NumeroTome = (int)res["numeroTome"];
                leTome.TitreTome = (string)res["titreTome"];
                leTome.ResumerTome = (string)res["resumerTome"];
                leTome.DateAchatTome = (DateTime)res["dateAchatTome"];
                close();

                return leTome;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return leTome;
            }
        }

        public static DataTable ReadAllTome()
        {
            DataTable dtRes = new DataTable();
            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM tome where 1";
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

        public static Boolean editTome(Tome leTome)
        {
            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE tome SET idTome=@idTome,numeroTome=@numeroTome, titreTome=@titreTome, resumerTome=@resumerTome, dateAchatTome=@dateAchatTome WHERE idTome=" + leTome.IdTome;

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idTome", leTome.IdTome);
                cmd.Parameters.AddWithValue("@numeroTome", leTome.NumeroTome);
                cmd.Parameters.AddWithValue("@titreTome", leTome.TitreTome);
                cmd.Parameters.AddWithValue("@resumerTome", leTome.ResumerTome);
                cmd.Parameters.AddWithValue("@dateAchatTome", leTome.DateAchatTome);

                cmd.ExecuteNonQuery();

                close();

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return false;
            }
        }
    }
}


        
    

