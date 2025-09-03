using System;

using System.Windows.Forms;

namespace Unidox
{
    public partial class QueryEnvelope : Form
    {

        string envelopeUUID ;



        public QueryEnvelope()
        {
            InitializeComponent();
        }

        private void QueryEnvelope_Load(object sender, EventArgs e)
        {

            textBox1.Text = "f0b8dd50-5384-41fa-8e43-47b417fc883d";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            envelopeUUID = textBox1.Text;

            Unidox.baslik.BaslikYardimci.SorguEnvelope(envelopeUUID);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FonkFormE_Fatura_Sorgu form = new FonkFormE_Fatura_Sorgu();
            form.Show();
        }
    }
}
