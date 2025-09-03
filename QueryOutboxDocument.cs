using System;
using System.Windows.Forms;

namespace Unidox
{
    public partial class QueryOutboxDocument : Form
    {

        string paramType;
        string parameter;
        string withXML;


        public QueryOutboxDocument()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QueryOutboxDocument_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Envelope_UUID";
            textBox2.Text = "20a6ca00-636a-416a-82b7-be45a765e6f6";
            textBox3.Text = "NONE";

            



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            paramType = textBox1.Text;
            parameter = textBox2.Text;
            withXML = textBox3.Text;



            Unidox.baslik.BaslikYardimci.QueryOutboxDocument(paramType, parameter, withXML);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FonkFormE_Fatura_Sorgu form = new FonkFormE_Fatura_Sorgu();
            form.Show();
        }
    }
}
