using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaForm.Classes
{
    class Manga
    {
        private int idManga;
        private string nomManga;
        private string synopsis;
        //a faire ajout d'une image
        private bool statutManga;
        private DateTime dateParutionManga;
        public Manga() { }

        public int IdManga { get => idManga; set => idManga = value; }
        public string NomManga { get => nomManga; set => nomManga = value; }
        public string Synopsis { get => synopsis; set => synopsis = value; }
        public bool StatutManga { get => statutManga; set => statutManga = value; }
        public DateTime DateParutionManga { get => dateParutionManga; set => dateParutionManga = value; }
    }
}
