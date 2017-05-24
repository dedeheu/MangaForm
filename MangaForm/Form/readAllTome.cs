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
    public partial class readAllTome : MetroFramework.Forms.MetroForm
    {
        DataTable dtTome = Dao.DaoTome.ReadAllTome();
        public readAllTome()
        {
            InitializeComponent();

            refreshDtTome();
            refreshGrid(dtTome);
        }

        private void refreshGrid(DataTable DataTableForFill)
        {
            //Chargement de la liste des mangas
            mGridTome.RowTemplate.MinimumHeight = 35;
            mGridTome.AutoGenerateColumns = false;
            mGridTome.Columns[0].DataPropertyName = "idTome";
            mGridTome.Columns[1].DataPropertyName = "numeroTome";
            mGridTome.Columns[2].DataPropertyName = "titreTome";
            mGridTome.DataSource = DataTableForFill;
        }
        private void refreshDtTome()
        {
            dtTome = Dao.DaoTome.ReadAllTome();
        }

        private void btnAddTome_Click(object sender, EventArgs e)
        {
            createTome formtagueule = new createTome();
            formtagueule.Show();
            this.Close();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            Form1 accueil = new Form1();
            accueil.Show();
            this.Close();
        }

        private void mGridTome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == mGridTome.Columns["Modifier"].Index && e.RowIndex >= 0)
            {
                editTome editTomeForm = new editTome(Convert.ToUInt16(mGridTome.Rows[e.RowIndex].Cells[0].Value.ToString()));
                editTomeForm.Show();
                this.Close();
            }
            else if (e.ColumnIndex == mGridTome.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MetroMessageBox.Show(this, "Voulez vous vraiment supprimer le tome ?", "Confirmer la suppréssion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Dao.Dao.RemoveId(Convert.ToInt16(mGridTome.Rows[e.RowIndex].Cells[0].Value.ToString()), "idTome", "tome");
                    refreshDtTome();
                    refreshGrid(dtTome);
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
