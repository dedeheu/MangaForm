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

namespace MangaForm
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        DataTable dtManga = Dao.DaoManga.ReadAllManga();
        public Form1()
        {
            InitializeComponent();

            refreshDtManga();
            refreshGrid(dtManga);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void refreshGrid(DataTable DataTableForFill)
        {
            //Chargement de la liste des mangas
            mGridManga.RowTemplate.MinimumHeight = 35;
            mGridManga.AutoGenerateColumns = false;
            mGridManga.Columns[0].DataPropertyName = "idManga";
            mGridManga.Columns[1].DataPropertyName = "nomManga";
            mGridManga.Columns[2].DataPropertyName = "statutManga";
            mGridManga.Columns[3].DataPropertyName = "nombreTome";
            mGridManga.DataSource = DataTableForFill;
        }
        private void refreshDtManga()
        {
            dtManga = Dao.DaoManga.ReadAllManga();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            createManga formtagueule = new createManga();
            formtagueule.Show();
            this.Close();
        }

        private void mGridManga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == mGridManga.Columns["Modifier"].Index && e.RowIndex >= 0)
            {
                editManga editMangaForm = new editManga(Convert.ToUInt16(mGridManga.Rows[e.RowIndex].Cells[0].Value.ToString()));
                editMangaForm.Show();
                this.Close();
            }
            else if (e.ColumnIndex == mGridManga.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MetroMessageBox.Show(this, "Voulez vous vraiment supprimer le manga ?", "Confirmer la suppréssion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Dao.Dao.RemoveId(Convert.ToInt16(mGridManga.Rows[e.RowIndex].Cells[0].Value.ToString()), "idManga", "manga");
                    refreshDtManga();
                    refreshGrid(dtManga);
                }
                else if (result == DialogResult.No)
                {
                    // Ne rien faire
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
