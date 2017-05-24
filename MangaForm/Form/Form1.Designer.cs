namespace MangaForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mGridManga = new MetroFramework.Controls.MetroGrid();
            this.idManga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomManga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutManga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbTome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.GandTBtn = new MetroFramework.Controls.MetroTile();
            this.ReadAllTomeBtn = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGridManga)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // mGridManga
            // 
            this.mGridManga.AllowUserToAddRows = false;
            this.mGridManga.AllowUserToResizeRows = false;
            this.mGridManga.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridManga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridManga.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridManga.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridManga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridManga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridManga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idManga,
            this.nomManga,
            this.statutManga,
            this.nbTome,
            this.Modifier,
            this.Supprimer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridManga.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridManga.EnableHeadersVisualStyles = false;
            this.mGridManga.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridManga.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridManga.Location = new System.Drawing.Point(341, 116);
            this.mGridManga.Name = "mGridManga";
            this.mGridManga.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridManga.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridManga.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridManga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridManga.Size = new System.Drawing.Size(431, 249);
            this.mGridManga.TabIndex = 0;
            this.mGridManga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mGridManga_CellContentClick);
            // 
            // idManga
            // 
            this.idManga.HeaderText = "idManga";
            this.idManga.Name = "idManga";
            this.idManga.Visible = false;
            this.idManga.Width = 50;
            // 
            // nomManga
            // 
            this.nomManga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomManga.HeaderText = "Nom";
            this.nomManga.Name = "nomManga";
            this.nomManga.ReadOnly = true;
            // 
            // statutManga
            // 
            this.statutManga.HeaderText = "Statut";
            this.statutManga.Name = "statutManga";
            this.statutManga.ReadOnly = true;
            this.statutManga.Width = 75;
            // 
            // nbTome
            // 
            this.nbTome.HeaderText = "Nombre de tomes";
            this.nbTome.Name = "nbTome";
            this.nbTome.ReadOnly = true;
            this.nbTome.Width = 80;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Image = global::MangaForm.Properties.Resources.tab_modifier;
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modifier.Width = 55;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Image = global::MangaForm.Properties.Resources.tab_supprimer;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.Width = 60;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(341, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(431, 47);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Ajouter un manga";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modifier";
            this.dataGridViewImageColumn1.Image = global::MangaForm.Properties.Resources.tab_modifier;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 55;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Supprimer";
            this.dataGridViewImageColumn2.Image = global::MangaForm.Properties.Resources.tab_supprimer;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GandTBtn
            // 
            this.GandTBtn.ActiveControl = null;
            this.GandTBtn.Location = new System.Drawing.Point(341, 13);
            this.GandTBtn.Name = "GandTBtn";
            this.GandTBtn.Size = new System.Drawing.Size(134, 44);
            this.GandTBtn.TabIndex = 3;
            this.GandTBtn.Text = "Genre et type";
            this.GandTBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GandTBtn.UseSelectable = true;
            // 
            // ReadAllTomeBtn
            // 
            this.ReadAllTomeBtn.ActiveControl = null;
            this.ReadAllTomeBtn.Location = new System.Drawing.Point(497, 13);
            this.ReadAllTomeBtn.Name = "ReadAllTomeBtn";
            this.ReadAllTomeBtn.Size = new System.Drawing.Size(104, 44);
            this.ReadAllTomeBtn.TabIndex = 4;
            this.ReadAllTomeBtn.Text = "Les tomes";
            this.ReadAllTomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReadAllTomeBtn.UseSelectable = true;
            this.ReadAllTomeBtn.Click += new System.EventHandler(this.ReadAllTomeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 388);
            this.Controls.Add(this.ReadAllTomeBtn);
            this.Controls.Add(this.GandTBtn);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mGridManga);
            this.Name = "Form1";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGridManga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroGrid mGridManga;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idManga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomManga;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutManga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbTome;
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MetroFramework.Controls.MetroTile ReadAllTomeBtn;
        private MetroFramework.Controls.MetroTile GandTBtn;
    }
}

