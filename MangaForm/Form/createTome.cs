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
    public partial class createTome : MetroFramework.Forms.MetroForm
    {
        public createTome()
        {
            InitializeComponent();
        }

        private void createTomeBtn_Click(object sender, EventArgs e)
        {
            Tome leTome = new Tome();
            leTome.NumeroTome = Convert.ToUInt16(MtxnumTome.Text);
            leTome.TitreTome = MtxTitreTome.Text;
            leTome.ResumerTome = mtxSysnopsisTome.Text;
            leTome.DateAchatTome = DateAcahtDt.Value;
            //leTome.ImageManga = AddImageBtn.Text;
            //leTome.SelectionManga = SelectionManga(); TODO lié a un manga
            DaoTome.create(leTome);
            Form1 AccueilForm = new Form1();
            AccueilForm.Show();
            this.Close();
        }
    }
}
