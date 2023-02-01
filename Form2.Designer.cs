namespace prog_crm
{
    partial class Form2
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
            this.buttonArchivio = new System.Windows.Forms.Button();
            this.buttonCategorie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArchivio
            // 
            this.buttonArchivio.Location = new System.Drawing.Point(93, 145);
            this.buttonArchivio.Name = "buttonArchivio";
            this.buttonArchivio.Size = new System.Drawing.Size(127, 80);
            this.buttonArchivio.TabIndex = 0;
            this.buttonArchivio.Text = "Archivio";
            this.buttonArchivio.UseVisualStyleBackColor = true;
            this.buttonArchivio.Click += new System.EventHandler(this.buttonArchivio_Click);
            // 
            // buttonCategorie
            // 
            this.buttonCategorie.Location = new System.Drawing.Point(93, 36);
            this.buttonCategorie.Name = "buttonCategorie";
            this.buttonCategorie.Size = new System.Drawing.Size(127, 80);
            this.buttonCategorie.TabIndex = 1;
            this.buttonCategorie.Text = "Categorie";
            this.buttonCategorie.UseVisualStyleBackColor = true;
            this.buttonCategorie.Click += new System.EventHandler(this.buttonCategorie_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 283);
            this.Controls.Add(this.buttonCategorie);
            this.Controls.Add(this.buttonArchivio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Anagrafica Articoli";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonArchivio;
        private Button buttonCategorie;
    }
}