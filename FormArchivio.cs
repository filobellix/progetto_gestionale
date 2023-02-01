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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prog_crm
{
    public partial class FormArchivio : Form
    {
        public FormArchivio()
        {
            InitializeComponent();
        }

        private void FormArchivio_Load(object sender, EventArgs e)
        {

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
                cmd.CommandText = "SELECT * FROM gestionearticoli WHERE IDarticolo LIKE '" + textBoxID.Text + "'";

                var cerca = cmd.ExecuteReader();

                while (cerca.Read())
                {
                    textBoxDesProd.Text = cerca.GetString(1);
                    textBoxCatArt.Text = cerca.GetString(2);
                    textBoxCodFornitore.Text = cerca.GetString(4);
                    textBoxFornitore.Text = cerca.GetString(3);
                    textBoxValore.Text = cerca.GetString(5);
                }


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            string StringaDiConnesione = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
            MySqlConnection connessione;
            connessione = new MySqlConnection(StringaDiConnesione);


            try
            {
                connessione.Open();
                MySqlCommand cmd = new MySqlCommand();


                cmd.Connection = connessione;
                cmd.CommandText = "INSERT INTO gestionearticoli" +
                    " (DescrizioneProdotto,CategoriaArticolo,Fornitore,CodiceFornitore,Valore)" +
                    " VALUES ('"+ textBoxDesProd.Text +"', '" +
                    textBoxCatArt.Text+ "', '"+ 
                    textBoxFornitore.Text+ "', '" +
                    textBoxCodFornitore.Text + "', '" +
                    textBoxValore.Text+ "')";

                MySqlDataReader dr = cmd.ExecuteReader();

                connessione.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            try
            {

                Connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;

                cmd.CommandText = "DELETE FROM gestionearticoli WHERE IDarticolo LIKE '" + textBoxID.Text + "'";
                cmd.ExecuteNonQuery();

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void textBoxDesProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            try
            {

                Connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;

                cmd.CommandText = "UPDATE gestionearticoli SET  DescrizioneProdotto = '" + textBoxDesProd.Text + "', CategoriaArticolo = '"+ textBoxCatArt.Text+"', Fornitore = '" + textBoxFornitore.Text+ "', CodiceFornitore = '" +textBoxCodFornitore.Text + "', Valore = '" +textBoxValore.Text+ "';";
                cmd.ExecuteNonQuery();

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    
}
