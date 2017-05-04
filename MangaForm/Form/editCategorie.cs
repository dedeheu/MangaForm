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
    public partial class editCategorie : MetroFramework.Forms.MetroForm
    {
        Categorie laCategorie;
        public editCategorie(int idCat)
        {
            InitializeComponent();

            laCategorie = DaoCategorie.ReadOneId(idCat);

            refreshForm();
        }

        private void BtnEditCategorie_Click(object sender, EventArgs e)
        {
            Categorie maCategorie = new Categorie();
            maCategorie.IdCat = laCategorie.IdCat;
            maCategorie.Libelle_Cat = MtxEditCategorie.Text;
            DaoCategorie.editCategorie(maCategorie);
            Form1 AccueilForm = new Form1();
            AccueilForm.Show();
            this.Close();
        }

        private void refreshForm()
        {
            MtxEditCategorie.Text = laCategorie.Libelle_Cat;
           
        }
    }
}
