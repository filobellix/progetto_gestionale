namespace prog_crm
{
    partial class Utenti
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAnagraficaUtenti = new System.Windows.Forms.Button();
            this.buttonAnagraficaArticoli = new System.Windows.Forms.Button();
            this.buttonMovimentiArticoli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAnagraficaUtenti
            // 
            this.buttonAnagraficaUtenti.Location = new System.Drawing.Point(84, 12);
            this.buttonAnagraficaUtenti.Name = "buttonAnagraficaUtenti";
            this.buttonAnagraficaUtenti.Size = new System.Drawing.Size(100, 83);
            this.buttonAnagraficaUtenti.TabIndex = 2;
            this.buttonAnagraficaUtenti.Text = "Anagrafica Utenti";
            this.buttonAnagraficaUtenti.UseVisualStyleBackColor = true;
            this.buttonAnagraficaUtenti.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAnagraficaArticoli
            // 
            this.buttonAnagraficaArticoli.Location = new System.Drawing.Point(84, 112);
            this.buttonAnagraficaArticoli.Name = "buttonAnagraficaArticoli";
            this.buttonAnagraficaArticoli.Size = new System.Drawing.Size(100, 83);
            this.buttonAnagraficaArticoli.TabIndex = 3;
            this.buttonAnagraficaArticoli.Text = "Anagrafica Articoli";
            this.buttonAnagraficaArticoli.UseVisualStyleBackColor = true;
            this.buttonAnagraficaArticoli.Click += new System.EventHandler(this.buttonAnagraficaArticoli_Click);
            // 
            // buttonMovimentiArticoli
            // 
            this.buttonMovimentiArticoli.Location = new System.Drawing.Point(84, 222);
            this.buttonMovimentiArticoli.Name = "buttonMovimentiArticoli";
            this.buttonMovimentiArticoli.Size = new System.Drawing.Size(100, 83);
            this.buttonMovimentiArticoli.TabIndex = 4;
            this.buttonMovimentiArticoli.Text = "Movimenti Articoli";
            this.buttonMovimentiArticoli.UseVisualStyleBackColor = true;
            this.buttonMovimentiArticoli.Click += new System.EventHandler(this.buttonMovimentiArticoli_Click);
            // 
            // Utenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 358);
            this.Controls.Add(this.buttonMovimentiArticoli);
            this.Controls.Add(this.buttonAnagraficaArticoli);
            this.Controls.Add(this.buttonAnagraficaUtenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Utenti";
            this.Text = "Utenti";
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonAnagraficaUtenti;
        private Button buttonAnagraficaArticoli;
        private Button buttonMovimentiArticoli;
    }
}