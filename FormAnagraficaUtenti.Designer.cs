namespace prog_crm
{
    partial class FormAnagraficaUtenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnagraficaUtenti));
            this.labelRagsociale = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTipUtente = new System.Windows.Forms.Label();
            this.labelCognome = new System.Windows.Forms.Label();
            this.comboBoxTipoUtente = new System.Windows.Forms.ComboBox();
            this.textBoxRagSoc = new System.Windows.Forms.TextBox();
            this.labelVia = new System.Windows.Forms.Label();
            this.labelCap = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelCittà = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelPiva = new System.Windows.Forms.Label();
            this.labelStato = new System.Windows.Forms.Label();
            this.labelCodFIscale = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.textBoxVia = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxCap = new System.Windows.Forms.TextBox();
            this.textBoxCittà = new System.Windows.Forms.TextBox();
            this.textBoxStato = new System.Windows.Forms.TextBox();
            this.textBoxProvincia = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCodFisc = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxPIVA = new System.Windows.Forms.TextBox();
            this.buttonCerca = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonElim = new System.Windows.Forms.Button();
            this.buttonModi = new System.Windows.Forms.Button();
            this.buttonInse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRagsociale
            // 
            this.labelRagsociale.AutoSize = true;
            this.labelRagsociale.Location = new System.Drawing.Point(267, 96);
            this.labelRagsociale.Name = "labelRagsociale";
            this.labelRagsociale.Size = new System.Drawing.Size(90, 15);
            this.labelRagsociale.TabIndex = 1;
            this.labelRagsociale.Text = "Ragione Sociale";
            this.labelRagsociale.Visible = false;
            this.labelRagsociale.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(15, 138);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome";
            // 
            // labelTipUtente
            // 
            this.labelTipUtente.AutoSize = true;
            this.labelTipUtente.Location = new System.Drawing.Point(12, 93);
            this.labelTipUtente.Name = "labelTipUtente";
            this.labelTipUtente.Size = new System.Drawing.Size(94, 15);
            this.labelTipUtente.TabIndex = 4;
            this.labelTipUtente.Text = "Tipologia Utente";
            // 
            // labelCognome
            // 
            this.labelCognome.AutoSize = true;
            this.labelCognome.Location = new System.Drawing.Point(284, 135);
            this.labelCognome.Name = "labelCognome";
            this.labelCognome.Size = new System.Drawing.Size(60, 15);
            this.labelCognome.TabIndex = 5;
            this.labelCognome.Text = "Cognome";
            // 
            // comboBoxTipoUtente
            // 
            this.comboBoxTipoUtente.FormattingEnabled = true;
            this.comboBoxTipoUtente.Items.AddRange(new object[] {
            "Amministratore",
            "Operatore",
            "Cliente",
            "Fornitore"});
            this.comboBoxTipoUtente.Location = new System.Drawing.Point(125, 93);
            this.comboBoxTipoUtente.Name = "comboBoxTipoUtente";
            this.comboBoxTipoUtente.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTipoUtente.TabIndex = 6;
            this.comboBoxTipoUtente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxRagSoc
            // 
            this.textBoxRagSoc.Location = new System.Drawing.Point(363, 93);
            this.textBoxRagSoc.Name = "textBoxRagSoc";
            this.textBoxRagSoc.Size = new System.Drawing.Size(169, 23);
            this.textBoxRagSoc.TabIndex = 7;
            this.textBoxRagSoc.Visible = false;
            this.textBoxRagSoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelVia
            // 
            this.labelVia.AutoSize = true;
            this.labelVia.Location = new System.Drawing.Point(15, 180);
            this.labelVia.Name = "labelVia";
            this.labelVia.Size = new System.Drawing.Size(23, 15);
            this.labelVia.TabIndex = 8;
            this.labelVia.Text = "Via";
            // 
            // labelCap
            // 
            this.labelCap.AutoSize = true;
            this.labelCap.Location = new System.Drawing.Point(280, 261);
            this.labelCap.Name = "labelCap";
            this.labelCap.Size = new System.Drawing.Size(28, 15);
            this.labelCap.TabIndex = 9;
            this.labelCap.Text = "Cap";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(323, 183);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(21, 15);
            this.labelNumero.TabIndex = 10;
            this.labelNumero.Text = "N°";
            // 
            // labelCittà
            // 
            this.labelCittà.AutoSize = true;
            this.labelCittà.Location = new System.Drawing.Point(15, 223);
            this.labelCittà.Name = "labelCittà";
            this.labelCittà.Size = new System.Drawing.Size(32, 15);
            this.labelCittà.TabIndex = 11;
            this.labelCittà.Text = "Città";
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Location = new System.Drawing.Point(280, 223);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(56, 15);
            this.labelProvincia.TabIndex = 12;
            this.labelProvincia.Text = "Provincia";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(15, 302);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 15);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(280, 302);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(52, 15);
            this.labelTel.TabIndex = 14;
            this.labelTel.Text = "Telefono";
            // 
            // labelPiva
            // 
            this.labelPiva.AutoSize = true;
            this.labelPiva.Location = new System.Drawing.Point(284, 348);
            this.labelPiva.Name = "labelPiva";
            this.labelPiva.Size = new System.Drawing.Size(34, 15);
            this.labelPiva.TabIndex = 15;
            this.labelPiva.Text = "P.IVA";
            // 
            // labelStato
            // 
            this.labelStato.AutoSize = true;
            this.labelStato.Location = new System.Drawing.Point(15, 261);
            this.labelStato.Name = "labelStato";
            this.labelStato.Size = new System.Drawing.Size(34, 15);
            this.labelStato.TabIndex = 17;
            this.labelStato.Text = "Stato";
            // 
            // labelCodFIscale
            // 
            this.labelCodFIscale.AutoSize = true;
            this.labelCodFIscale.Location = new System.Drawing.Point(15, 345);
            this.labelCodFIscale.Name = "labelCodFIscale";
            this.labelCodFIscale.Size = new System.Drawing.Size(82, 15);
            this.labelCodFIscale.TabIndex = 16;
            this.labelCodFIscale.Text = "Codice Fiscale";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(73, 135);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(167, 23);
            this.textBoxNome.TabIndex = 18;
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.Location = new System.Drawing.Point(365, 130);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.Size = new System.Drawing.Size(167, 23);
            this.textBoxCognome.TabIndex = 19;
            // 
            // textBoxVia
            // 
            this.textBoxVia.Location = new System.Drawing.Point(57, 177);
            this.textBoxVia.Name = "textBoxVia";
            this.textBoxVia.Size = new System.Drawing.Size(167, 23);
            this.textBoxVia.TabIndex = 20;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(372, 180);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(41, 23);
            this.textBoxN.TabIndex = 21;
            this.textBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCap
            // 
            this.textBoxCap.Location = new System.Drawing.Point(353, 258);
            this.textBoxCap.Name = "textBoxCap";
            this.textBoxCap.Size = new System.Drawing.Size(73, 23);
            this.textBoxCap.TabIndex = 22;
            this.textBoxCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCittà
            // 
            this.textBoxCittà.Location = new System.Drawing.Point(57, 220);
            this.textBoxCittà.Name = "textBoxCittà";
            this.textBoxCittà.Size = new System.Drawing.Size(167, 23);
            this.textBoxCittà.TabIndex = 23;
            // 
            // textBoxStato
            // 
            this.textBoxStato.Location = new System.Drawing.Point(57, 258);
            this.textBoxStato.Name = "textBoxStato";
            this.textBoxStato.Size = new System.Drawing.Size(167, 23);
            this.textBoxStato.TabIndex = 24;
            // 
            // textBoxProvincia
            // 
            this.textBoxProvincia.Location = new System.Drawing.Point(353, 220);
            this.textBoxProvincia.Name = "textBoxProvincia";
            this.textBoxProvincia.Size = new System.Drawing.Size(167, 23);
            this.textBoxProvincia.TabIndex = 25;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(57, 299);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(167, 23);
            this.textBoxEmail.TabIndex = 26;
            // 
            // textBoxCodFisc
            // 
            this.textBoxCodFisc.Location = new System.Drawing.Point(103, 342);
            this.textBoxCodFisc.Name = "textBoxCodFisc";
            this.textBoxCodFisc.Size = new System.Drawing.Size(133, 23);
            this.textBoxCodFisc.TabIndex = 27;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(353, 299);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(167, 23);
            this.textBoxTel.TabIndex = 28;
            // 
            // textBoxPIVA
            // 
            this.textBoxPIVA.Location = new System.Drawing.Point(353, 345);
            this.textBoxPIVA.Name = "textBoxPIVA";
            this.textBoxPIVA.Size = new System.Drawing.Size(167, 23);
            this.textBoxPIVA.TabIndex = 29;
            // 
            // buttonCerca
            // 
            this.buttonCerca.Location = new System.Drawing.Point(387, 27);
            this.buttonCerca.Name = "buttonCerca";
            this.buttonCerca.Size = new System.Drawing.Size(75, 23);
            this.buttonCerca.TabIndex = 30;
            this.buttonCerca.Text = "Cerca";
            this.buttonCerca.UseVisualStyleBackColor = true;
            this.buttonCerca.Click += new System.EventHandler(this.buttonCerca_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(73, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 15);
            this.labelID.TabIndex = 31;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(127, 27);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(217, 23);
            this.textBoxID.TabIndex = 32;
            // 
            // buttonElim
            // 
            this.buttonElim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonElim.Location = new System.Drawing.Point(463, 390);
            this.buttonElim.Name = "buttonElim";
            this.buttonElim.Size = new System.Drawing.Size(75, 23);
            this.buttonElim.TabIndex = 33;
            this.buttonElim.Text = "Elimina";
            this.buttonElim.UseVisualStyleBackColor = true;
            this.buttonElim.Click += new System.EventHandler(this.buttonElim_Click);
            // 
            // buttonModi
            // 
            this.buttonModi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModi.Location = new System.Drawing.Point(280, 390);
            this.buttonModi.Name = "buttonModi";
            this.buttonModi.Size = new System.Drawing.Size(75, 23);
            this.buttonModi.TabIndex = 34;
            this.buttonModi.Text = "Modifica";
            this.buttonModi.UseVisualStyleBackColor = true;
            this.buttonModi.Click += new System.EventHandler(this.buttonModi_Click);
            // 
            // buttonInse
            // 
            this.buttonInse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInse.Location = new System.Drawing.Point(372, 390);
            this.buttonInse.Name = "buttonInse";
            this.buttonInse.Size = new System.Drawing.Size(75, 23);
            this.buttonInse.TabIndex = 35;
            this.buttonInse.Text = "Inserisci";
            this.buttonInse.UseVisualStyleBackColor = true;
            this.buttonInse.Click += new System.EventHandler(this.buttonInse_Click);
            // 
            // FormAnagraficaUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 425);
            this.Controls.Add(this.buttonInse);
            this.Controls.Add(this.buttonModi);
            this.Controls.Add(this.buttonElim);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonCerca);
            this.Controls.Add(this.textBoxPIVA);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxCodFisc);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxProvincia);
            this.Controls.Add(this.textBoxStato);
            this.Controls.Add(this.textBoxCittà);
            this.Controls.Add(this.textBoxCap);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxVia);
            this.Controls.Add(this.textBoxCognome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelStato);
            this.Controls.Add(this.labelCodFIscale);
            this.Controls.Add(this.labelPiva);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.labelCittà);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelCap);
            this.Controls.Add(this.labelVia);
            this.Controls.Add(this.textBoxRagSoc);
            this.Controls.Add(this.comboBoxTipoUtente);
            this.Controls.Add(this.labelCognome);
            this.Controls.Add(this.labelTipUtente);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelRagsociale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnagraficaUtenti";
            this.Text = "Anagrafica Utenti";
            this.Load += new System.EventHandler(this.FormAnagraficaUtenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelRagsociale;
        private Label labelNome;
        private Label labelTipUtente;
        private Label labelCognome;
        private ComboBox comboBoxTipoUtente;
        private TextBox textBoxRagSoc;
        private Label labelVia;
        private Label labelCap;
        private Label labelNumero;
        private Label labelCittà;
        private Label labelProvincia;
        private Label labelEmail;
        private Label labelTel;
        private Label labelPiva;
        private Label labelStato;
        private Label labelCodFIscale;
        private TextBox textBoxNome;
        private TextBox textBoxCognome;
        private TextBox textBoxVia;
        private TextBox textBoxN;
        private TextBox textBoxCap;
        private TextBox textBoxCittà;
        private TextBox textBoxStato;
        private TextBox textBoxProvincia;
        private TextBox textBoxEmail;
        private TextBox textBoxCodFisc;
        private TextBox textBoxTel;
        private TextBox textBoxPIVA;
        private Button buttonCerca;
        private Label labelID;
        private TextBox textBoxID;
        private Button buttonElim;
        private Button buttonModi;
        private Button buttonInse;
    }
}