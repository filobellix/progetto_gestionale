namespace prog_crm
{
    partial class FormCategorie
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
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCerca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonElimina
            // 
            this.buttonElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonElimina.Location = new System.Drawing.Point(340, 478);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(75, 23);
            this.buttonElimina.TabIndex = 2;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalva.Location = new System.Drawing.Point(443, 478);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(75, 23);
            this.buttonSalva.TabIndex = 3;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Categoria articolo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 23);
            this.textBox1.TabIndex = 24;
            // 
            // buttonCerca
            // 
            this.buttonCerca.Location = new System.Drawing.Point(247, 18);
            this.buttonCerca.Name = "buttonCerca";
            this.buttonCerca.Size = new System.Drawing.Size(75, 23);
            this.buttonCerca.TabIndex = 25;
            this.buttonCerca.Text = "Cerca";
            this.buttonCerca.UseVisualStyleBackColor = true;
            this.buttonCerca.Click += new System.EventHandler(this.buttonCerca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cerca ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 47);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(399, 425);
            this.textBox3.TabIndex = 19;
            // 
            // FormCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.buttonElimina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonElimina;
        private Button buttonSalva;
        private Label label3;
        private TextBox textBox1;
        private Button buttonCerca;
        private Label label1;
        private TextBox textBox3;
    }
}