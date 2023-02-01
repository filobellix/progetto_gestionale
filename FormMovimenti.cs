using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace prog_crm
{
    public partial class FormMovimenti : Form
    {
        public FormMovimenti()
        {
            InitializeComponent();
        }

        private void FormMovimenti_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Acquistare")
            {
                textBox3.Show();
                label5.Show();
                textBox4.Hide();
                label6.Hide();

            }
            else
            {
                textBox3.Hide();
                label5.Hide();
                textBox4.Show();
                label6.Show();

            }
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Vendere")
            {
                string StringaDiConnesione = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
                MySqlConnection connessione;
                connessione = new MySqlConnection(StringaDiConnesione);


                try
                {
                    connessione.Open();
                    MySqlCommand cmd = new MySqlCommand();


                    cmd.Connection = connessione;
                    cmd.CommandText = "INSERT INTO movimentoarticoli" +
                        " (CodiceArticolo,Data,Quantità)" +
                        " VALUES ('" + textBox1.Text + "', '" +
                        this.dateTimePicker1.Text + "', '" +
                        Convert.ToInt32(textBox2.Text) * (-1) + "')";

                    MySqlDataReader dr = cmd.ExecuteReader();

                    connessione.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string StringaDiConnesione = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
                MySqlConnection connessione;
                connessione = new MySqlConnection(StringaDiConnesione);


                try
                {
                    connessione.Open();
                    MySqlCommand cmd = new MySqlCommand();


                    cmd.Connection = connessione;
                    cmd.CommandText = "INSERT INTO movimentoarticoli" +
                        " (CodiceArticolo,Data,Quantità)" +
                        " VALUES ('" + textBox1.Text + "', '" +
                        dateTimePicker1.Text + "', '" +
                       textBox2.Text + "')";

                    MySqlDataReader dr = cmd.ExecuteReader();

                    connessione.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
