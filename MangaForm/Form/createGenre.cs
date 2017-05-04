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
    public partial class createGenre : MetroFramework.Forms.MetroForm
    {
        public createGenre()
        {
            InitializeComponent();
        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            Genre monGenre = new Genre();
            monGenre.Libelle_Type = MtxLibelleGenre.Text;
            DaoGenre.create(monGenre);
            Form1 AccueilForm = new Form1();
            AccueilForm.Show();
            this.Close();
        }
    }
}
