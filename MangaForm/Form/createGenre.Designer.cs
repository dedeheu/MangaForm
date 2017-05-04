namespace MangaForm
{
    partial class createGenre
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
            this.MtxLibelleGenre = new MetroFramework.Controls.MetroTextBox();
            this.BtnAddGenre = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // MtxLibelleGenre
            // 
            // 
            // 
            // 
            this.MtxLibelleGenre.CustomButton.Image = null;
            this.MtxLibelleGenre.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.MtxLibelleGenre.CustomButton.Name = "";
            this.MtxLibelleGenre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MtxLibelleGenre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MtxLibelleGenre.CustomButton.TabIndex = 1;
            this.MtxLibelleGenre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MtxLibelleGenre.CustomButton.UseSelectable = true;
            this.MtxLibelleGenre.CustomButton.Visible = false;
            this.MtxLibelleGenre.Lines = new string[] {
        "Libelle"};
            this.MtxLibelleGenre.Location = new System.Drawing.Point(392, 49);
            this.MtxLibelleGenre.MaxLength = 32767;
            this.MtxLibelleGenre.Name = "MtxLibelleGenre";
            this.MtxLibelleGenre.PasswordChar = '\0';
            this.MtxLibelleGenre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MtxLibelleGenre.SelectedText = "";
            this.MtxLibelleGenre.SelectionLength = 0;
            this.MtxLibelleGenre.SelectionStart = 0;
            this.MtxLibelleGenre.ShortcutsEnabled = true;
            this.MtxLibelleGenre.Size = new System.Drawing.Size(266, 23);
            this.MtxLibelleGenre.TabIndex = 0;
            this.MtxLibelleGenre.Text = "Libelle";
            this.MtxLibelleGenre.UseSelectable = true;
            this.MtxLibelleGenre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MtxLibelleGenre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnAddGenre
            // 
            this.BtnAddGenre.ActiveControl = null;
            this.BtnAddGenre.Location = new System.Drawing.Point(392, 93);
            this.BtnAddGenre.Name = "BtnAddGenre";
            this.BtnAddGenre.Size = new System.Drawing.Size(266, 44);
            this.BtnAddGenre.TabIndex = 1;
            this.BtnAddGenre.Text = "Ajouter un genre";
            this.BtnAddGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddGenre.UseSelectable = true;
            this.BtnAddGenre.Click += new System.EventHandler(this.BtnAddGenre_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(316, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "un genre";
            // 
            // createGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 198);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnAddGenre);
            this.Controls.Add(this.MtxLibelleGenre);
            this.Name = "createGenre";
            this.Text = "createGenre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox MtxLibelleGenre;
        private MetroFramework.Controls.MetroTile BtnAddGenre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}