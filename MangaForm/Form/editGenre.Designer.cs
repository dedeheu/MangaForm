namespace MangaForm
{
    partial class editGenre
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
            this.BtnEditGenre = new MetroFramework.Controls.MetroTile();
            this.MtxEditGenre = new MetroFramework.Controls.MetroTextBox();
            this.LblEditGenre = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditGenre
            // 
            this.BtnEditGenre.ActiveControl = null;
            this.BtnEditGenre.Location = new System.Drawing.Point(335, 90);
            this.BtnEditGenre.Name = "BtnEditGenre";
            this.BtnEditGenre.Size = new System.Drawing.Size(242, 46);
            this.BtnEditGenre.TabIndex = 0;
            this.BtnEditGenre.Text = "Modifier le genre";
            this.BtnEditGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEditGenre.UseSelectable = true;
            this.BtnEditGenre.Click += new System.EventHandler(this.BtnEditGenre_Click);
            // 
            // MtxEditGenre
            // 
            // 
            // 
            // 
            this.MtxEditGenre.CustomButton.Image = null;
            this.MtxEditGenre.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.MtxEditGenre.CustomButton.Name = "";
            this.MtxEditGenre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MtxEditGenre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MtxEditGenre.CustomButton.TabIndex = 1;
            this.MtxEditGenre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MtxEditGenre.CustomButton.UseSelectable = true;
            this.MtxEditGenre.CustomButton.Visible = false;
            this.MtxEditGenre.Lines = new string[] {
        "texte"};
            this.MtxEditGenre.Location = new System.Drawing.Point(335, 48);
            this.MtxEditGenre.MaxLength = 32767;
            this.MtxEditGenre.Name = "MtxEditGenre";
            this.MtxEditGenre.PasswordChar = '\0';
            this.MtxEditGenre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MtxEditGenre.SelectedText = "";
            this.MtxEditGenre.SelectionLength = 0;
            this.MtxEditGenre.SelectionStart = 0;
            this.MtxEditGenre.ShortcutsEnabled = true;
            this.MtxEditGenre.Size = new System.Drawing.Size(242, 23);
            this.MtxEditGenre.TabIndex = 1;
            this.MtxEditGenre.Text = "texte";
            this.MtxEditGenre.UseSelectable = true;
            this.MtxEditGenre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MtxEditGenre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblEditGenre
            // 
            this.LblEditGenre.AutoSize = true;
            this.LblEditGenre.Location = new System.Drawing.Point(227, 48);
            this.LblEditGenre.Name = "LblEditGenre";
            this.LblEditGenre.Size = new System.Drawing.Size(96, 19);
            this.LblEditGenre.TabIndex = 2;
            this.LblEditGenre.Text = "nouveau libelle";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // editGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 188);
            this.Controls.Add(this.LblEditGenre);
            this.Controls.Add(this.MtxEditGenre);
            this.Controls.Add(this.BtnEditGenre);
            this.Name = "editGenre";
            this.Text = "editGenre";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile BtnEditGenre;
        private MetroFramework.Controls.MetroTextBox MtxEditGenre;
        private MetroFramework.Controls.MetroLabel LblEditGenre;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}