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
    public partial class editManga : MetroFramework.Forms.MetroForm
    {
        Manga leManga;
        public editManga(int idManga)
        {
            InitializeComponent();

            leManga = DaoManga.ReadOneId(idManga);

            refreshForm();
        }

        private void editMangaBtn_Click(object sender, EventArgs e)
        {
            Manga monManga = new Manga();
            monManga.IdManga = leManga.IdManga;
            monManga.NomManga = MtxNomManga.Text;
            monManga.Synopsis = MtxSynopsis.Text;
            monManga.DateParutionManga = DateParutionDt.Value;
            monManga.ImageManga = AddImageBtn.Text;
            monManga.StatutManga = statutDuManga();
            DaoManga.editManga(monManga);
            Form1 AccueilForm = new Form1();
            AccueilForm.Show();
            this.Close();
        }

        private bool statutDuManga()
        {
            if (RbtnStatutEnCours.Checked == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void refreshForm()
        {
            MtxNomManga.Text = leManga.NomManga;
            MtxSynopsis.Text = leManga.Synopsis;
            DateParutionDt.Value = leManga.DateParutionManga;

            if(leManga.StatutManga)
            {
                RbtnStatutTerminer.Select();
            }
            else
            {
                RbtnStatutEnCours.Select();
            }
        }
    }
}
