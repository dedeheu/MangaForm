namespace MangaForm
{
    partial class createTome
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.titreTomeLbl = new MetroFramework.Controls.MetroLabel();
            this.SynopsisTomeLbl = new MetroFramework.Controls.MetroLabel();
            this.numTomeLbl = new MetroFramework.Controls.MetroLabel();
            this.MtxTitreTome = new MetroFramework.Controls.MetroTextBox();
            this.createTomeBtn = new MetroFramework.Controls.MetroTile();
            this.MtxnumTome = new MetroFramework.Controls.MetroTextBox();
            this.AddImageBtn = new MetroFramework.Controls.MetroTile();
            this.mtxSysnopsisTome = new MetroFramework.Controls.MetroTextBox();
            this.ImageDefault = new System.Windows.Forms.PictureBox();
            this.DateAcahtDt = new MetroFramework.Controls.MetroDateTime();
            this.DateAchatLb = new MetroFramework.Controls.MetroLabel();
            this.CbMangaSelection = new MetroFramework.Controls.MetroComboBox();
            this.SelectionMangaLb = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // titreTomeLbl
            // 
            this.titreTomeLbl.AutoSize = true;
            this.titreTomeLbl.Location = new System.Drawing.Point(80, 111);
            this.titreTomeLbl.Name = "titreTomeLbl";
            this.titreTomeLbl.Size = new System.Drawing.Size(89, 19);
            this.titreTomeLbl.TabIndex = 19;
            this.titreTomeLbl.Text = "Titre du tome";
            // 
            // SynopsisTomeLbl
            // 
            this.SynopsisTomeLbl.AutoSize = true;
            this.SynopsisTomeLbl.Location = new System.Drawing.Point(80, 146);
            this.SynopsisTomeLbl.Name = "SynopsisTomeLbl";
            this.SynopsisTomeLbl.Size = new System.Drawing.Size(114, 19);
            this.SynopsisTomeLbl.TabIndex = 18;
            this.SynopsisTomeLbl.Text = "Résumer du tome";
            // 
            // numTomeLbl
            // 
            this.numTomeLbl.AutoSize = true;
            this.numTomeLbl.Location = new System.Drawing.Point(82, 82);
            this.numTomeLbl.Name = "numTomeLbl";
            this.numTomeLbl.Size = new System.Drawing.Size(112, 19);
            this.numTomeLbl.TabIndex = 17;
            this.numTomeLbl.Text = "Numero du tome";
            // 
            // MtxTitreTome
            // 
            this.MtxTitreTome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.MtxTitreTome.CustomButton.Image = null;
            this.MtxTitreTome.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.MtxTitreTome.CustomButton.Name = "";
            this.MtxTitreTome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MtxTitreTome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MtxTitreTome.CustomButton.TabIndex = 1;
            this.MtxTitreTome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MtxTitreTome.CustomButton.UseSelectable = true;
            this.MtxTitreTome.CustomButton.Visible = false;
            this.MtxTitreTome.Lines = new string[] {
        "Titre"};
            this.MtxTitreTome.Location = new System.Drawing.Point(200, 111);
            this.MtxTitreTome.MaxLength = 32767;
            this.MtxTitreTome.Name = "MtxTitreTome";
            this.MtxTitreTome.PasswordChar = '\0';
            this.MtxTitreTome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MtxTitreTome.SelectedText = "";
            this.MtxTitreTome.SelectionLength = 0;
            this.MtxTitreTome.SelectionStart = 0;
            this.MtxTitreTome.ShortcutsEnabled = true;
            this.MtxTitreTome.Size = new System.Drawing.Size(423, 23);
            this.MtxTitreTome.TabIndex = 14;
            this.MtxTitreTome.Text = "Titre";
            this.MtxTitreTome.UseSelectable = true;
            this.MtxTitreTome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MtxTitreTome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createTomeBtn
            // 
            this.createTomeBtn.ActiveControl = null;
            this.createTomeBtn.Location = new System.Drawing.Point(230, 328);
            this.createTomeBtn.Name = "createTomeBtn";
            this.createTomeBtn.Size = new System.Drawing.Size(207, 51);
            this.createTomeBtn.TabIndex = 13;
            this.createTomeBtn.Text = "créer un tome";
            this.createTomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createTomeBtn.UseSelectable = true;
            this.createTomeBtn.Click += new System.EventHandler(this.createTomeBtn_Click);
            // 
            // MtxnumTome
            // 
            this.MtxnumTome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.MtxnumTome.CustomButton.Image = null;
            this.MtxnumTome.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.MtxnumTome.CustomButton.Name = "";
            this.MtxnumTome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MtxnumTome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MtxnumTome.CustomButton.TabIndex = 1;
            this.MtxnumTome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MtxnumTome.CustomButton.UseSelectable = true;
            this.MtxnumTome.CustomButton.Visible = false;
            this.MtxnumTome.Lines = new string[] {
        "num"};
            this.MtxnumTome.Location = new System.Drawing.Point(200, 78);
            this.MtxnumTome.MaxLength = 32767;
            this.MtxnumTome.Name = "MtxnumTome";
            this.MtxnumTome.PasswordChar = '\0';
            this.MtxnumTome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MtxnumTome.SelectedText = "";
            this.MtxnumTome.SelectionLength = 0;
            this.MtxnumTome.SelectionStart = 0;
            this.MtxnumTome.ShortcutsEnabled = true;
            this.MtxnumTome.Size = new System.Drawing.Size(423, 23);
            this.MtxnumTome.TabIndex = 12;
            this.MtxnumTome.Text = "num";
            this.MtxnumTome.UseSelectable = true;
            this.MtxnumTome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MtxnumTome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddImageBtn
            // 
            this.AddImageBtn.ActiveControl = null;
            this.AddImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImageBtn.BackColor = System.Drawing.Color.Gray;
            this.AddImageBtn.Location = new System.Drawing.Point(443, 194);
            this.AddImageBtn.Name = "AddImageBtn";
            this.AddImageBtn.Size = new System.Drawing.Size(180, 43);
            this.AddImageBtn.TabIndex = 16;
            this.AddImageBtn.Text = "Ajouter une image";
            this.AddImageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddImageBtn.UseSelectable = true;
            // 
            // mtxSysnopsisTome
            // 
            this.mtxSysnopsisTome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxSysnopsisTome.CustomButton.Image = null;
            this.mtxSysnopsisTome.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.mtxSysnopsisTome.CustomButton.Name = "";
            this.mtxSysnopsisTome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxSysnopsisTome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxSysnopsisTome.CustomButton.TabIndex = 1;
            this.mtxSysnopsisTome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxSysnopsisTome.CustomButton.UseSelectable = true;
            this.mtxSysnopsisTome.CustomButton.Visible = false;
            this.mtxSysnopsisTome.Lines = new string[] {
        "Synopsis du tome"};
            this.mtxSysnopsisTome.Location = new System.Drawing.Point(200, 146);
            this.mtxSysnopsisTome.MaxLength = 32767;
            this.mtxSysnopsisTome.Name = "mtxSysnopsisTome";
            this.mtxSysnopsisTome.PasswordChar = '\0';
            this.mtxSysnopsisTome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxSysnopsisTome.SelectedText = "";
            this.mtxSysnopsisTome.SelectionLength = 0;
            this.mtxSysnopsisTome.SelectionStart = 0;
            this.mtxSysnopsisTome.ShortcutsEnabled = true;
            this.mtxSysnopsisTome.Size = new System.Drawing.Size(423, 23);
            this.mtxSysnopsisTome.TabIndex = 23;
            this.mtxSysnopsisTome.Text = "Synopsis du tome";
            this.mtxSysnopsisTome.UseSelectable = true;
            this.mtxSysnopsisTome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxSysnopsisTome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ImageDefault
            // 
            this.ImageDefault.Image = global::MangaForm.Properties.Resources.mangaDefaut;
            this.ImageDefault.Location = new System.Drawing.Point(443, 243);
            this.ImageDefault.Name = "ImageDefault";
            this.ImageDefault.Size = new System.Drawing.Size(180, 136);
            this.ImageDefault.TabIndex = 22;
            this.ImageDefault.TabStop = false;
            // 
            // DateAcahtDt
            // 
            this.DateAcahtDt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateAcahtDt.Location = new System.Drawing.Point(200, 194);
            this.DateAcahtDt.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateAcahtDt.Name = "DateAcahtDt";
            this.DateAcahtDt.Size = new System.Drawing.Size(207, 29);
            this.DateAcahtDt.TabIndex = 24;
            // 
            // DateAchatLb
            // 
            this.DateAchatLb.AutoSize = true;
            this.DateAchatLb.Location = new System.Drawing.Point(111, 204);
            this.DateAchatLb.Name = "DateAchatLb";
            this.DateAchatLb.Size = new System.Drawing.Size(83, 19);
            this.DateAchatLb.TabIndex = 25;
            this.DateAchatLb.Text = "Date D\'achat";
            // 
            // CbMangaSelection
            // 
            this.CbMangaSelection.FormattingEnabled = true;
            this.CbMangaSelection.ItemHeight = 23;
            this.CbMangaSelection.Location = new System.Drawing.Point(200, 243);
            this.CbMangaSelection.Name = "CbMangaSelection";
            this.CbMangaSelection.Size = new System.Drawing.Size(121, 29);
            this.CbMangaSelection.TabIndex = 26;
            this.CbMangaSelection.UseSelectable = true;
            // 
            // SelectionMangaLb
            // 
            this.SelectionMangaLb.AutoSize = true;
            this.SelectionMangaLb.Location = new System.Drawing.Point(60, 253);
            this.SelectionMangaLb.Name = "SelectionMangaLb";
            this.SelectionMangaLb.Size = new System.Drawing.Size(134, 19);
            this.SelectionMangaLb.TabIndex = 27;
            this.SelectionMangaLb.Text = "Selectionné le manga";
            // 
            // createTome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 402);
            this.Controls.Add(this.SelectionMangaLb);
            this.Controls.Add(this.CbMangaSelection);
            this.Controls.Add(this.DateAchatLb);
            this.Controls.Add(this.DateAcahtDt);
            this.Controls.Add(this.mtxSysnopsisTome);
            this.Controls.Add(this.ImageDefault);
            this.Controls.Add(this.titreTomeLbl);
            this.Controls.Add(this.SynopsisTomeLbl);
            this.Controls.Add(this.numTomeLbl);
            this.Controls.Add(this.AddImageBtn);
            this.Controls.Add(this.MtxTitreTome);
            this.Controls.Add(this.createTomeBtn);
            this.Controls.Add(this.MtxnumTome);
            this.Name = "createTome";
            this.Text = "createTome";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDefault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel titreTomeLbl;
        private MetroFramework.Controls.MetroLabel SynopsisTomeLbl;
        private MetroFramework.Controls.MetroLabel numTomeLbl;
        private MetroFramework.Controls.MetroTextBox MtxTitreTome;
        private MetroFramework.Controls.MetroTile createTomeBtn;
        private MetroFramework.Controls.MetroTextBox MtxnumTome;
        private MetroFramework.Controls.MetroTile AddImageBtn;
        private System.Windows.Forms.PictureBox ImageDefault;
        private MetroFramework.Controls.MetroTextBox mtxSysnopsisTome;
        private MetroFramework.Controls.MetroDateTime DateAcahtDt;
        private MetroFramework.Controls.MetroLabel DateAchatLb;
        private MetroFramework.Controls.MetroComboBox CbMangaSelection;
        private MetroFramework.Controls.MetroLabel SelectionMangaLb;
    }
}