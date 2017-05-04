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
    class DaoCategorie : Dao
    {

        public static void create(Categorie uneCategorie)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO categorie(idCat, libelle_cat) VALUES (@idCat, @libelle_cat)";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idCat", uneCategorie.IdCat);
                cmd.Parameters.AddWithValue("@libelle_cat", uneCategorie.Libelle_Cat);
                


                cmd.ExecuteNonQuery();

                uneCategorie.IdCat = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }

        }

        public static Categorie ReadOneId(int idCat)
            {
                Categorie uneCategorie = null;

                try
                {
                    open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM categorie WHERE idCat =" + idCat;

                    MySqlDataReader res = cmd.ExecuteReader();

                    res.Read();
                    uneCategorie = new Categorie();
                    uneCategorie.IdCat = (int)res["IdCat"];
                    uneCategorie.Libelle_Cat = (string)res["Libelle_Cat"];
                    close();

                    return uneCategorie;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());

                    return uneCategorie;
                }
            }
        public static Categorie ReadOneName(string libelle_cat)
        {
            Categorie uneCategorie = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM categorie WHERE libelle_cat=" + libelle_cat;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                uneCategorie = new Categorie();
                uneCategorie.IdCat = (int)res["IdCat"];
                uneCategorie.Libelle_Cat = (string)res["Libelle_Cat"];
                close();

                return uneCategorie;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return uneCategorie;
            }
        }
        public static Boolean editCategorie(Categorie uneCategorie)
        {
            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE categorie SET idCat=@idCat, libelle_cat=@libelle_cat WHERE idCat =" + uneCategorie.IdCat;

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idCat", uneCategorie.IdCat);
                cmd.Parameters.AddWithValue("@libelle_cat", uneCategorie.Libelle_Cat);
               
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
