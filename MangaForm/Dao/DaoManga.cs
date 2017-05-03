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
    class DaoManga : Dao
    {
        public static void create(Manga unManga)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO manga(idManga, nomManga, synopsis, statutManga, dateParutionManga) VALUES (@idManga, @nomManga, @synopsis, @statutManga, @dateParutionManga)";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idManga", unManga.IdManga);
                cmd.Parameters.AddWithValue("@nomManga", unManga.NomManga);
                cmd.Parameters.AddWithValue("@synopsis", unManga.Synopsis);
                cmd.Parameters.AddWithValue("@statutManga", unManga.StatutManga);
                cmd.Parameters.AddWithValue("@dateParutionManga", unManga.DateParutionManga);


                cmd.ExecuteNonQuery();

                unManga.IdManga = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }

        public static Manga ReadOneId(int id)
        {
            Manga unManga = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM manga WHERE idManga=" + id;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                unManga = new Manga();
                unManga.IdManga = (int)res["idManga"];
                unManga.NomManga = (string)res["nomManga"];
                unManga.Synopsis = (string)res["synopsis"];
                unManga.StatutManga = (bool)res["statutManga"];
                unManga.DateParutionManga = (DateTime)res["dateParutionManga"];
                close();

                return unManga;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return unManga;
            }
        }

        public static Manga ReadOneName(string nom)
        {
            Manga unManga = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM manga WHERE nomManga=" + nom;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                unManga = new Manga();
                unManga.IdManga = (int)res["idManga"];
                unManga.NomManga = (string)res["nomManga"];
                unManga.Synopsis = (string)res["synopsis"];
                unManga.StatutManga = (bool)res["statutManga"];
                unManga.DateParutionManga = (DateTime)res["dateParutionManga"];
                close();

                return unManga;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return unManga;
            }
        }


        public static DataTable CountAllTome()
        {
            DataTable dtRes = new DataTable();
            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Manga.nomManga, COUNT(*) as nombreTome FROM manga inner join tome on manga.idManga = tome.idManga GROUP BY Manga.idManga";
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
        
    }
}

