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
    public partial class createCategorie : MetroFramework.Forms.MetroForm
    {
        public createCategorie()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            Categorie maCategorie = new Categorie();
            maCategorie.Libelle_Cat = MbxCatégorie.Text;
            DaoCategorie.create(maCategorie);
            Form1 AccueilForm = new Form1();
            AccueilForm.Show();
            this.Close();
        }
    }
}
