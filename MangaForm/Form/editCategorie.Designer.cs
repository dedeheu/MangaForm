namespace MangaForm
{
    partial class editCategorie
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
            this.MtxEditCategorie = new MetroFramework.Controls.MetroTextBox();
            this.LblEditCategorie = new MetroFramework.Controls.MetroLabel();
            this.BtnEditCategorie = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtxEditCategorie
            // 
            // 
            // 
            // 
            this.MtxEditCategorie.CustomButton.Image = null;
            this.MtxEditCategorie.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.MtxEditCategorie.CustomButton.Name = "";
            this.MtxEditCategorie.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MtxEditCategorie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MtxEditCategorie.CustomButton.TabIndex = 1;
            this.MtxEditCategorie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MtxEditCategorie.CustomButton.UseSelectable = true;
            this.MtxEditCategorie.CustomButton.Visible = false;
            this.MtxEditCategorie.Lines = new string[] {
        "nom"};
            this.MtxEditCategorie.Location = new System.Drawing.Point(298, 63);
            this.MtxEditCategorie.MaxLength = 32767;
            this.MtxEditCategorie.Name = "MtxEditCategorie";
            this.MtxEditCategorie.PasswordChar = '\0';
            this.MtxEditCategorie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MtxEditCategorie.SelectedText = "";
            this.MtxEditCategorie.SelectionLength = 0;
            this.MtxEditCategorie.SelectionStart = 0;
            this.MtxEditCategorie.ShortcutsEnabled = true;
            this.MtxEditCategorie.Size = new System.Drawing.Size(204, 23);
            this.MtxEditCategorie.TabIndex = 0;
            this.MtxEditCategorie.Text = "nom";
            this.MtxEditCategorie.UseSelectable = true;
            this.MtxEditCategorie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MtxEditCategorie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblEditCategorie
            // 
            this.LblEditCategorie.AutoSize = true;
            this.LblEditCategorie.Location = new System.Drawing.Point(155, 67);
            this.LblEditCategorie.Name = "LblEditCategorie";
            this.LblEditCategorie.Size = new System.Drawing.Size(137, 19);
            this.LblEditCategorie.TabIndex = 1;
            this.LblEditCategorie.Text = "Entré le nouveau nom";
            // 
            // BtnEditCategorie
            // 
            this.BtnEditCategorie.ActiveControl = null;
            this.BtnEditCategorie.Location = new System.Drawing.Point(298, 104);
            this.BtnEditCategorie.Name = "BtnEditCategorie";
            this.BtnEditCategorie.Size = new System.Drawing.Size(204, 40);
            this.BtnEditCategorie.TabIndex = 2;
            this.BtnEditCategorie.Text = "Modifier categorie";
            this.BtnEditCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEditCategorie.UseSelectable = true;
            this.BtnEditCategorie.Click += new System.EventHandler(this.BtnEditCategorie_Click);
            // 
            // editCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 181);
            this.Controls.Add(this.BtnEditCategorie);
            this.Controls.Add(this.LblEditCategorie);
            this.Controls.Add(this.MtxEditCategorie);
            this.Name = "editCategorie";
            this.Text = "editCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox MtxEditCategorie;
        private MetroFramework.Controls.MetroLabel LblEditCategorie;
        private MetroFramework.Controls.MetroTile BtnEditCategorie;
    }
}