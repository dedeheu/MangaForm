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
    }
}
