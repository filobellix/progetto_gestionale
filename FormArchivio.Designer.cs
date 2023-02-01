namespace prog_crm
{
    partial class FormArchivio
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
            this.buttonCerca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDesProd = new System.Windows.Forms.TextBox();
            this.textBoxCatArt = new System.Windows.Forms.TextBox();
            this.textBoxCodFornitore = new System.Windows.Forms.TextBox();
            this.textBoxValore = new System.Windows.Forms.TextBox();
            this.textBoxFornitore = new System.Windows.Forms.TextBox();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCerca
            // 
            this.buttonCerca.Location = new System.Drawing.Point(289, 38);
            this.buttonCerca.Name = "buttonCerca";
            this.buttonCerca.Size = new System.Drawing.Size(75, 23);
            this.buttonCerca.TabIndex = 0;
            this.buttonCerca.Text = "Cerca";
            this.buttonCerca.UseVisualStyleBackColor = true;
            this.buttonCerca.Click += new System.EventHandler(this.buttonCerca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cerca ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(95, 38);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(150, 23);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrizione del prodotto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria articolo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Codice fornitore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fornitore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Valore";
            // 
            // textBoxDesProd
            // 
            this.textBoxDesProd.Location = new System.Drawing.Point(168, 102);
            this.textBoxDesProd.Multiline = true;
            this.textBoxDesProd.Name = "textBoxDesProd";
            this.textBoxDesProd.Size = new System.Drawing.Size(323, 113);
            this.textBoxDesProd.TabIndex = 8;
            this.textBoxDesProd.TextChanged += new System.EventHandler(this.textBoxDesProd_TextChanged);
            // 
            // textBoxCatArt
            // 
            this.textBoxCatArt.Location = new System.Drawing.Point(168, 254);
            this.textBoxCatArt.Multiline = true;
            this.textBoxCatArt.Name = "textBoxCatArt";
            this.textBoxCatArt.Size = new System.Drawing.Size(323, 40);
            this.textBoxCatArt.TabIndex = 9;
            // 
            // textBoxCodFornitore
            // 
            this.textBoxCodFornitore.Location = new System.Drawing.Point(168, 317);
            this.textBoxCodFornitore.Name = "textBoxCodFornitore";
            this.textBoxCodFornitore.Size = new System.Drawing.Size(149, 23);
            this.textBoxCodFornitore.TabIndex = 10;
            // 
            // textBoxValore
            // 
            this.textBoxValore.Location = new System.Drawing.Point(168, 424);
            this.textBoxValore.Name = "textBoxValore";
            this.textBoxValore.Size = new System.Drawing.Size(149, 23);
            this.textBoxValore.TabIndex = 11;
            // 
            // textBoxFornitore
            // 
            this.textBoxFornitore.Location = new System.Drawing.Point(168, 365);
            this.textBoxFornitore.Name = "textBoxFornitore";
            this.textBoxFornitore.Size = new System.Drawing.Size(257, 23);
            this.textBoxFornitore.TabIndex = 12;
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalva.Location = new System.Drawing.Point(447, 481);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(75, 23);
            this.buttonSalva.TabIndex = 13;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonElimina.Location = new System.Drawing.Point(350, 481);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(75, 23);
            this.buttonElimina.TabIndex = 14;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifica.Location = new System.Drawing.Point(251, 481);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(75, 23);
            this.buttonModifica.TabIndex = 15;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // FormArchivio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 516);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.textBoxFornitore);
            this.Controls.Add(this.textBoxValore);
            this.Controls.Add(this.textBoxCodFornitore);
            this.Controls.Add(this.textBoxCatArt);
            this.Controls.Add(this.textBoxDesProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerca);
            this.Name = "FormArchivio";
            this.Text = "FormArchivio";
            this.Load += new System.EventHandler(this.FormArchivio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCerca;
        private Label label1;
        private TextBox textBoxID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxDesProd;
        private TextBox textBoxCatArt;
        private TextBox textBoxCodFornitore;
        private TextBox textBoxValore;
        private TextBox textBoxFornitore;
        private Button buttonSalva;
        private Button buttonElimina;
        private Button buttonModifica;
    }
}