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
    class DaoGenre : Dao
    {
        public static void create(Genre unGenre)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO type(idType, libelle_Type) VALUES (@idType, @libelle_Type)";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idType", unGenre.IdType);
                cmd.Parameters.AddWithValue("@libelle_Type", unGenre.Libelle_Type);



                cmd.ExecuteNonQuery();

                unGenre.IdType = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }

        }

        public static Genre ReadOneId(int id)
        {
            Genre unGenre = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM type WHERE idType=" + id;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                unGenre = new Genre();
                unGenre.IdType = (int)res["idType"];
                unGenre.Libelle_Type = (string)res["Libelle_Type"];
                close();

                return unGenre;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return unGenre;
            }
        }
        public static Genre ReadOneName(string libelle_Type)
        {
            Genre unGenre = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM categorie WHERE libelle_Type=" + libelle_Type;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                unGenre = new Genre();
                unGenre.IdType = (int)res["idType"];
                unGenre.Libelle_Type = (string)res["Libelle_Type"];
                close();

                return unGenre;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return unGenre;
            }
        }
    }
}
