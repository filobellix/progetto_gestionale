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
    public partial class FormCategorie : Form
    {
        public FormCategorie()
        {
            InitializeComponent();
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
                cmd.CommandText = "SELECT * FROM gestionearticoli WHERE IDarticolo LIKE '" + textBox1.Text + "'";

                var cerca = cmd.ExecuteReader();

                while (cerca.Read())
                {
                    
                    textBox3.Text = cerca.GetString(2);
                 
                }


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=localhost;database=anagrafica;uid=vs;pwd=iot;";
            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            try
            {

                Connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;

                cmd.CommandText = "UPDATE gestionearticoli SET  CategoriaArticolo = '" + textBox3.Text + "';";
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
