using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaForm.Classes
{
    class Categorie
    {

        private int idCat;
        private string libelle_Cat;

        //constructeur a vide pour passer unquement pas le setter et getter
        public Categorie() { }

        //getter setter
#region getter setter
        public int IdCat { get => idCat; set => idCat = value; }
        public string Libelle_Cat { get => libelle_Cat; set => libelle_Cat = value; }
#endregion
    }
}
