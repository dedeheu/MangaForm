namespace MangaForm
{
    partial class createManga
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
            this.components = new System.ComponentModel.Container();
            this.MtxNomManga = new MetroFramework.Controls.MetroTextBox();
            this.createMangaBtn = new MetroFramework.Controls.MetroTile();
            this.MtxSynopsis = new MetroFramework.Controls.MetroTextBox();
            this.DateParutionDt = new MetroFramework.Controls.MetroDateTime();
            this.AddImageBtn = new MetroFramework.Controls.MetroTile();
            this.titreMangaLbl = new MetroFramework.Controls.MetroLabel();
            this.SynopsisLbl = new MetroFramework.Controls.MetroLabel();
            this.DateParutionLbl = new MetroFramework.Controls.MetroLabel();
            this.RbtnStatutTerminer = new MetroFramework.Controls.MetroRadioButton();
            this.RbtnStatutEnCours = new MetroFramework.Controls.MetroRadioButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ImageDefault = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // MtxNomManga
            // 
            // 
            // 
            // 
            this.MtxNomManga.CustomButton.Image = null;
            this.MtxNomManga.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.MtxNomManga.CustomButton.Name = "";
            this.MtxNomManga.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MtxNomManga.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MtxNomManga.CustomButton.TabIndex = 1;
            this.MtxNomManga.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MtxNomManga.CustomButton.UseSelectable = true;
            this.MtxNomManga.CustomButton.Visible = false;
            this.MtxNomManga.Lines = new string[] {
        "titre"};
            this.MtxNomManga.Location = new System.Drawing.Point(235, 63);
            this.MtxNomManga.MaxLength = 32767;
            this.MtxNomManga.Name = "MtxNomManga";
            this.MtxNomManga.PasswordChar = '\0';
            this.MtxNomManga.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MtxNomManga.SelectedText = "";
            this.MtxNomManga.SelectionLength = 0;
            this.MtxNomManga.SelectionStart = 0;
            this.MtxNomManga.ShortcutsEnabled = true;
            this.MtxNomManga.Size = new System.Drawing.Size(423, 23);
            this.MtxNomManga.TabIndex = 1;
            this.MtxNomManga.Text = "titre";
            this.MtxNomManga.UseSelectable = true;
            this.MtxNomManga.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MtxNomManga.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createMangaBtn
            // 
            this.createMangaBtn.ActiveControl = null;
            this.createMangaBtn.Location = new System.Drawing.Point(197, 357);
            this.createMangaBtn.Name = "createMangaBtn";
            this.createMangaBtn.Size = new System.Drawing.Size(245, 51);
            this.createMangaBtn.TabIndex = 2;
            this.createMangaBtn.Text = "créer un manga";
            this.createMangaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createMangaBtn.UseSelectable = true;
            this.createMangaBtn.Click += new System.EventHandler(this.createMangaBtn_Click);
            // 
            // MtxSynopsis
            // 
            // 
            // 
            // 
            this.MtxSynopsis.CustomButton.Image = null;
            this.MtxSynopsis.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.MtxSynopsis.CustomButton.Name = "";
            this.MtxSynopsis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MtxSynopsis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MtxSynopsis.CustomButton.TabIndex = 1;
            this.MtxSynopsis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MtxSynopsis.CustomButton.UseSelectable = true;
            this.MtxSynopsis.CustomButton.Visible = false;
            this.MtxSynopsis.Lines = new string[] {
        "Synopsis du manga"};
            this.MtxSynopsis.Location = new System.Drawing.Point(235, 92);
            this.MtxSynopsis.MaxLength = 32767;
            this.MtxSynopsis.Name = "MtxSynopsis";
            this.MtxSynopsis.PasswordChar = '\0';
            this.MtxSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MtxSynopsis.SelectedText = "";
            this.MtxSynopsis.SelectionLength = 0;
            this.MtxSynopsis.SelectionStart = 0;
            this.MtxSynopsis.ShortcutsEnabled = true;
            this.MtxSynopsis.Size = new System.Drawing.Size(423, 23);
            this.MtxSynopsis.TabIndex = 3;
            this.MtxSynopsis.Text = "Synopsis du manga";
            this.MtxSynopsis.UseSelectable = true;
            this.MtxSynopsis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MtxSynopsis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DateParutionDt
            // 
            this.DateParutionDt.Location = new System.Drawing.Point(235, 121);
            this.DateParutionDt.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateParutionDt.Name = "DateParutionDt";
            this.DateParutionDt.Size = new System.Drawing.Size(207, 29);
            this.DateParutionDt.TabIndex = 4;
            // 
            // AddImageBtn
            // 
            this.AddImageBtn.ActiveControl = null;
            this.AddImageBtn.Location = new System.Drawing.Point(478, 121);
            this.AddImageBtn.Name = "AddImageBtn";
            this.AddImageBtn.Size = new System.Drawing.Size(180, 43);
            this.AddImageBtn.TabIndex = 5;
            this.AddImageBtn.Text = "Ajouter une image";
            this.AddImageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddImageBtn.UseSelectable = true;
            // 
            // titreMangaLbl
            // 
            this.titreMangaLbl.AutoSize = true;
            this.titreMangaLbl.Location = new System.Drawing.Point(121, 63);
            this.titreMangaLbl.Name = "titreMangaLbl";
            this.titreMangaLbl.Size = new System.Drawing.Size(99, 19);
            this.titreMangaLbl.TabIndex = 6;
            this.titreMangaLbl.Text = "Titre du manga";
            // 
            // SynopsisLbl
            // 
            this.SynopsisLbl.AutoSize = true;
            this.SynopsisLbl.Location = new System.Drawing.Point(105, 96);
            this.SynopsisLbl.Name = "SynopsisLbl";
            this.SynopsisLbl.Size = new System.Drawing.Size(124, 19);
            this.SynopsisLbl.TabIndex = 7;
            this.SynopsisLbl.Text = "Résumer du manga";
            // 
            // DateParutionLbl
            // 
            this.DateParutionLbl.AutoSize = true;
            this.DateParutionLbl.Location = new System.Drawing.Point(105, 131);
            this.DateParutionLbl.Name = "DateParutionLbl";
            this.DateParutionLbl.Size = new System.Drawing.Size(124, 19);
            this.DateParutionLbl.TabIndex = 8;
            this.DateParutionLbl.Text = "La date de parution";
            // 
            // RbtnStatutTerminer
            // 
            this.RbtnStatutTerminer.AutoSize = true;
            this.RbtnStatutTerminer.Location = new System.Drawing.Point(485, 215);
            this.RbtnStatutTerminer.Name = "RbtnStatutTerminer";
            this.RbtnStatutTerminer.Size = new System.Drawing.Size(70, 15);
            this.RbtnStatutTerminer.TabIndex = 9;
            this.RbtnStatutTerminer.Text = "Terminer";
            this.RbtnStatutTerminer.UseSelectable = true;
            // 
            // RbtnStatutEnCours
            // 
            this.RbtnStatutEnCours.AutoSize = true;
            this.RbtnStatutEnCours.Location = new System.Drawing.Point(485, 254);
            this.RbtnStatutEnCours.Name = "RbtnStatutEnCours";
            this.RbtnStatutEnCours.Size = new System.Drawing.Size(68, 15);
            this.RbtnStatutEnCours.TabIndex = 10;
            this.RbtnStatutEnCours.Text = "En cours";
            this.RbtnStatutEnCours.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // ImageDefault
            // 
            this.ImageDefault.Location = new System.Drawing.Point(136, 219);
            this.ImageDefault.Name = "ImageDefault";
            this.ImageDefault.Size = new System.Drawing.Size(100, 50);
            this.ImageDefault.TabIndex = 11;
            this.ImageDefault.TabStop = false;
            // 
            // createManga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 431);
            this.Controls.Add(this.ImageDefault);
            this.Controls.Add(this.RbtnStatutEnCours);
            this.Controls.Add(this.RbtnStatutTerminer);
            this.Controls.Add(this.DateParutionLbl);
            this.Controls.Add(this.SynopsisLbl);
            this.Controls.Add(this.titreMangaLbl);
            this.Controls.Add(this.AddImageBtn);
            this.Controls.Add(this.DateParutionDt);
            this.Controls.Add(this.MtxSynopsis);
            this.Controls.Add(this.createMangaBtn);
            this.Controls.Add(this.MtxNomManga);
            this.Name = "createManga";
            this.Text = "createManga";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDefault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox MtxNomManga;
        private MetroFramework.Controls.MetroTile createMangaBtn;
        private MetroFramework.Controls.MetroTextBox MtxSynopsis;
        private MetroFramework.Controls.MetroDateTime DateParutionDt;
        private MetroFramework.Controls.MetroTile AddImageBtn;
        private MetroFramework.Controls.MetroLabel titreMangaLbl;
        private MetroFramework.Controls.MetroLabel SynopsisLbl;
        private MetroFramework.Controls.MetroLabel DateParutionLbl;
        private MetroFramework.Controls.MetroRadioButton RbtnStatutTerminer;
        private MetroFramework.Controls.MetroRadioButton RbtnStatutEnCours;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.PictureBox ImageDefault;
    }
}