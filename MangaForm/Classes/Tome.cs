using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaForm.Classes
{
    class Tome
    {
        private int idTome;
        private int numeroTome;
        private string titreTome;
        private string resumerTome;
        private DateTime dateAchatTome;

        //constructeur
        public Tome() { }

#region getter setter
        public int IdTome { get => idTome; set => idTome = value; }
        public int NumeroTome { get => numeroTome; set => numeroTome = value; }
        public string TitreTome { get => titreTome; set => titreTome = value; }
        public string ResumerTome { get => resumerTome; set => resumerTome = value; }
        public DateTime DateAchatTome { get => dateAchatTome; set => dateAchatTome = value; }
        //image à ajouter
#endregion

    }
}
