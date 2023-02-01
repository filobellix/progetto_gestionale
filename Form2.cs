using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_crm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonArchivio_Click(object sender, EventArgs e)
        {
            FormArchivio formArchivio = new FormArchivio();
            formArchivio.ShowDialog();
        }

        private void buttonCategorie_Click(object sender, EventArgs e)
        {
            FormCategorie formCategorie = new FormCategorie();
            formCategorie.ShowDialog();
        }
    }
}
