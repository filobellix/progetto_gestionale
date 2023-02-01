using MySql.Data.MySqlClient;
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

namespace prog_crm
{
    public partial class FormAnagraficaUtenti : Form
    {
        public FormAnagraficaUtenti()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTipoUtente.Text == "Amministratore" || comboBoxTipoUtente.Text == "Operatore" ||  comboBoxTipoUtente.Text == "Cliente")
            {
                textBoxRagSoc.Hide();
                labelRagsociale.Hide(); 
                textBoxNome.Show();
                textBoxCognome.Show();
                labelNome.Show();
                labelCognome.Show();
            }
            else
            {
                textBoxRagSoc.Show();
                labelRagsociale.Show();
                textBoxNome.Hide();
                textBoxCognome.Hide();
                labelNome.Hide();
                labelCognome.Hide();
            }
        }

        private void FormAnagraficaUtenti_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void buttonInse_Click(object sender, EventArgs e)
        {
            string StringaDiConnesione = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
            MySqlConnection connessione;
            connessione = new MySqlConnection(StringaDiConnesione);


            try
            {
                connessione.Open();
                MySqlCommand cmd = new MySqlCommand();


                cmd.Connection = connessione;
                cmd.CommandText = "INSERT INTO gestioneutenti" +
                    " (Nome,Cognome,TipologiaUtente,RagioneSociale,Via,NumeroCivico,Città,Provincia,Stato,Cap,Email,Telefono,CodiceFiscale,PIVA)" +
                    " VALUES ('" + textBoxNome.Text + "', '" + 
                    textBoxCognome.Text + "', '" +
                    comboBoxTipoUtente.Text + "', '" + 
                    textBoxRagSoc.Text + "', '" + 
                    textBoxVia.Text + "','"+
                    textBoxN.Text +"', '" +
                    textBoxCittà.Text+ "', '" +
                    textBoxProvincia.Text+ "','" + 
                    textBoxStato.Text+"', '"+
                    textBoxCap.Text+"', '"+
                    textBoxEmail.Text +"', '"+ 
                    textBoxTel.Text+"', '"+ 
                    textBoxCodFisc.Text+"', '"+
                    textBoxPIVA.Text+"')";

                MySqlDataReader dr = cmd.ExecuteReader();

                connessione.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCerca_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            try
            {

                Connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "SELECT * FROM gestioneutenti WHERE IDutente LIKE '" + textBoxID.Text + "'";

                var cerca = cmd.ExecuteReader();

                while (cerca.Read())
                {
                    textBoxNome.Text = cerca.GetString(1);
                    textBoxCognome.Text = cerca.GetString(2);
                    comboBoxTipoUtente.Text = cerca.GetString(3);  
                    textBoxRagSoc.Text = cerca.GetString(4);    
                    textBoxVia.Text = cerca.GetString(5);
                    textBoxN.Text = cerca.GetString(6);
                    textBoxCittà.Text = cerca.GetString(7); 
                    textBoxProvincia.Text = cerca.GetString(8);  
                    textBoxStato.Text= cerca.GetString(9);
                    textBoxCap.Text = cerca.GetString(10);
                    textBoxEmail.Text = cerca.GetString(11);    
                    textBoxTel.Text = cerca.GetString(12);
                    textBoxCodFisc.Text = cerca.GetString(13);
                    textBoxPIVA.Text = cerca.GetString(14);

                }


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonModi_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            try
            {

                Connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;

                cmd.CommandText = "UPDATE gestioneutenti SET  Nome = '" + textBoxNome.Text + "', Cognome = '" + textBoxCognome.Text + "', TipologiaUtente = ' " + comboBoxTipoUtente.Text + "', RagioneSociale = ' " +textBoxRagSoc.Text+ "', Via = '" +textBoxVia.Text + "', NumeroCivico = '" + textBoxN.Text + "', Città = '" + textBoxCittà.Text + "', Provincia = '"+textBoxProvincia.Text +"', Stato = '"+textBoxStato.Text +"', Cap = '" +textBoxCap.Text +"', Email = '"+ textBoxEmail.Text + "', Telefono = '" +textBoxTel.Text + "', CodiceFiscale = '" +textBoxCodFisc.Text +"', PIVA = '"+textBoxPIVA.Text + "';";
                cmd.ExecuteNonQuery();

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void buttonElim_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            try
            {

                Connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;

                cmd.CommandText = "DELETE FROM gestioneutenti WHERE IDutente LIKE '" + textBoxID.Text + "'";
                cmd.ExecuteNonQuery();

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();

        }
    }
}
