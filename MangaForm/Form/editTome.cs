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
    public partial class editTome : MetroFramework.Forms.MetroForm
    {
        Tome leTome;
        public editTome(int idTome)
        {
            InitializeComponent();

            leTome = DaoTome.ReadOneId(idTome);

            refreshForm();
        }

        private void editMangaBtn_Click(object sender, EventArgs e)
        {
            Tome monTome = new Tome();
            monTome.IdTome = leTome.IdTome;
            monTome.NumeroTome = Convert.ToUInt16(MtxNumTome.Text);
            monTome.TitreTome = MtxTitreTome.Text;
            monTome.ResumerTome = MtxSysnopsisTome.Text;
            //monTome.ImageTome = AddImageBtn.Text;
            monTome.DateAchatTome = DateAchatDt.Value;
            DaoTome.editTome(monTome);
            readAllTome AccueilForm = new readAllTome();
            AccueilForm.Show();
            this.Close();
        }

        private void refreshForm()
        {
            MtxNumTome.Text = leTome.NumeroTome;
            MtxTitreTome.Text = leTome.TitreTome;
            MtxSysnopsisTome.Text = leTome.ResumerTome;
            DateAchatDt.Value = leTome.DateAchatTome;

        }

    }
}
