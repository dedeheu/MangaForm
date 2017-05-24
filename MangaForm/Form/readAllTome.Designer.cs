namespace MangaForm
{
    partial class readAllTome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAccueil = new MetroFramework.Controls.MetroTile();
            this.GandTBtn = new MetroFramework.Controls.MetroTile();
            this.btnAddTome = new MetroFramework.Controls.MetroTile();
            this.mGridTome = new MetroFramework.Controls.MetroGrid();
            this.idTome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreTome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mGridTome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccueil
            // 
            this.btnAccueil.ActiveControl = null;
            this.btnAccueil.Location = new System.Drawing.Point(175, 63);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(104, 44);
            this.btnAccueil.TabIndex = 8;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccueil.UseSelectable = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // GandTBtn
            // 
            this.GandTBtn.ActiveControl = null;
            this.GandTBtn.Location = new System.Drawing.Point(19, 63);
            this.GandTBtn.Name = "GandTBtn";
            this.GandTBtn.Size = new System.Drawing.Size(134, 44);
            this.GandTBtn.TabIndex = 7;
            this.GandTBtn.Text = "Genre et type";
            this.GandTBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GandTBtn.UseSelectable = true;
            // 
            // btnAddTome
            // 
            this.btnAddTome.ActiveControl = null;
            this.btnAddTome.Location = new System.Drawing.Point(19, 113);
            this.btnAddTome.Name = "btnAddTome";
            this.btnAddTome.Size = new System.Drawing.Size(431, 47);
            this.btnAddTome.TabIndex = 6;
            this.btnAddTome.Text = "Ajouter un tome";
            this.btnAddTome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTome.UseSelectable = true;
            this.btnAddTome.Click += new System.EventHandler(this.btnAddTome_Click);
            // 
            // mGridTome
            // 
            this.mGridTome.AllowUserToAddRows = false;
            this.mGridTome.AllowUserToResizeRows = false;
            this.mGridTome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridTome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridTome.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridTome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridTome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridTome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridTome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTome,
            this.numeroTome,
            this.titreTome,
            this.Modifier,
            this.Supprimer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridTome.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridTome.EnableHeadersVisualStyles = false;
            this.mGridTome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridTome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridTome.Location = new System.Drawing.Point(19, 166);
            this.mGridTome.Name = "mGridTome";
            this.mGridTome.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridTome.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridTome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridTome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridTome.Size = new System.Drawing.Size(431, 249);
            this.mGridTome.TabIndex = 5;
            // 
            // idTome
            // 
            this.idTome.HeaderText = "idTome";
            this.idTome.Name = "idTome";
            this.idTome.Visible = false;
            this.idTome.Width = 50;
            // 
            // numeroTome
            // 
            this.numeroTome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroTome.HeaderText = "Numero";
            this.numeroTome.Name = "numeroTome";
            this.numeroTome.ReadOnly = true;
            // 
            // titreTome
            // 
            this.titreTome.HeaderText = "Titre";
            this.titreTome.Name = "titreTome";
            this.titreTome.ReadOnly = true;
            this.titreTome.Width = 125;
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
            // readAllTome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 471);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.GandTBtn);
            this.Controls.Add(this.btnAddTome);
            this.Controls.Add(this.mGridTome);
            this.Name = "readAllTome";
            this.Text = "readAllTome";
            ((System.ComponentModel.ISupportInitialize)(this.mGridTome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnAccueil;
        private MetroFramework.Controls.MetroTile GandTBtn;
        private MetroFramework.Controls.MetroTile btnAddTome;
        private MetroFramework.Controls.MetroGrid mGridTome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTome;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTome;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreTome;
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
    }
}