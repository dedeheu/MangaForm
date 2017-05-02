using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaForm.Classes
{
    class Genre
    {
        private int idType;
        private string libelle_Type;

        //constructeur
        public Genre() { }

        //getter stter
        #region getter setter
        public int IdType { get => idType; set => idType = value; }
        public string Libelle_Type { get => libelle_Type; set => libelle_Type = value; }
#endregion
    }
}
