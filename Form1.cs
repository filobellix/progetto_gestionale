namespace prog_crm
{
    public partial class Utenti : Form
    {
        public Utenti()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAnagraficaUtenti f2 = new FormAnagraficaUtenti();
            f2.ShowDialog();
        }

        private void buttonAnagraficaArticoli_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void buttonMovimentiArticoli_Click(object sender, EventArgs e)
        {
            FormMovimenti form3 = new FormMovimenti();
            form3.ShowDialog();
        }
    }
}