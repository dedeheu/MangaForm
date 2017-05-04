namespace MangaForm
{
    partial class createCategorie
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.MbxCatégorie = new MetroFramework.Controls.MetroTextBox();
            this.LblCategorie = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(314, 116);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(344, 42);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Ajouter la categorie";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // MbxCatégorie
            // 
            // 
            // 
            // 
            this.MbxCatégorie.CustomButton.Image = null;
            this.MbxCatégorie.CustomButton.Location = new System.Drawing.Point(322, 1);
            this.MbxCatégorie.CustomButton.Name = "";
            this.MbxCatégorie.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MbxCatégorie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MbxCatégorie.CustomButton.TabIndex = 1;
            this.MbxCatégorie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MbxCatégorie.CustomButton.UseSelectable = true;
            this.MbxCatégorie.CustomButton.Visible = false;
            this.MbxCatégorie.Lines = new string[] {
        "Nom..."};
            this.MbxCatégorie.Location = new System.Drawing.Point(314, 68);
            this.MbxCatégorie.MaxLength = 32767;
            this.MbxCatégorie.Name = "MbxCatégorie";
            this.MbxCatégorie.PasswordChar = '\0';
            this.MbxCatégorie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MbxCatégorie.SelectedText = "";
            this.MbxCatégorie.SelectionLength = 0;
            this.MbxCatégorie.SelectionStart = 0;
            this.MbxCatégorie.ShortcutsEnabled = true;
            this.MbxCatégorie.Size = new System.Drawing.Size(344, 23);
            this.MbxCatégorie.TabIndex = 1;
            this.MbxCatégorie.Text = "Nom...";
            this.MbxCatégorie.UseSelectable = true;
            this.MbxCatégorie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MbxCatégorie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(177, 68);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(131, 19);
            this.LblCategorie.TabIndex = 2;
            this.LblCategorie.Text = "Nom de la categorie";
            // 
            // createCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 198);
            this.Controls.Add(this.LblCategorie);
            this.Controls.Add(this.MbxCatégorie);
            this.Controls.Add(this.metroTile1);
            this.Name = "createCategorie";
            this.Text = "createCategorie";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox MbxCatégorie;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel LblCategorie;
    }
}