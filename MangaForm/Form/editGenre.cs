using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;

using MangaForm.Classes;
using MangaForm.Dao;

namespace MangaForm
{
    public partial class editGenre : MetroFramework.Forms.MetroForm
    {
        Genre leGenre;
        public editGenre(int idType)
        {
            InitializeComponent();
            leGenre = DaoGenre.ReadOneId(idType);

            refreshForm();
        }

        private void BtnEditGenre_Click(object sender, EventArgs e)
        {
            Genre monGenre = new Genre();
            monGenre.IdType = leGenre.IdType;
            monGenre.Libelle_Type = MtxEditGenre.Text;
            DaoGenre.editGenre(monGenre);
            Form1 AccueilForm = new Form1();
            AccueilForm.Show();
            this.Close();
        }

        private void refreshForm()
        {
            MtxEditGenre.Text = leGenre.Libelle_Type;

        }
    }
}
