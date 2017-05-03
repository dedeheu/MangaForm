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
    public partial class createManga : MetroFramework.Forms.MetroForm
    {
        public createManga()
        {
            InitializeComponent();
            
        }

        private void createMangaBtn_Click(object sender, EventArgs e)
        {
            Manga monManga = new Manga();
            monManga.NomManga = MtxNomManga.Text;
            monManga.Synopsis = MtxSynopsis.Text;
            monManga.DateParutionManga = DateParutionDt.Value;
            monManga.ImageManga = AddImageBtn.Text;
            monManga.StatutManga = statutDuManga();
            DaoManga.create(monManga);
            Form1 AccueilForm = new Form1();
            AccueilForm.Show();
            this.Close();
        }

        private bool statutDuManga()
        {
            if(RbtnStatutEnCours.Checked == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
