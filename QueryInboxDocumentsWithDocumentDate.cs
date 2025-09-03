using System;

using System.Windows.Forms;


namespace Unidox
{
    public partial class QueryInboxDocumentsWithDocumentDate : Form
    {


        DateTime startDate;
        DateTime endDate;
        string documentType;
        string queried;
        string withXML;
        string takenFromEntegrator;
        string minRecordId;



        public QueryInboxDocumentsWithDocumentDate()
        {
            InitializeComponent();
        }


        private void QueryInboxDocumentsWithDocumentDate_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "ALL";
            textBox3.Text = "NONE";
            textBox4.Text = "ALL";
            textBox5.Text = "1";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            startDate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            endDate = dateTimePicker2.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            documentType = textBox1.Text;
            queried = textBox2.Text;
            withXML = textBox3.Text;
            takenFromEntegrator = textBox4.Text;
            minRecordId = textBox5.Text;


            Unidox.baslik.BaslikYardimci.InboxDocumentWithDocumentDate(startDate, endDate, documentType, queried, withXML, takenFromEntegrator, minRecordId);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FonkFormE_Fatura_Sorgu form = new FonkFormE_Fatura_Sorgu();
            form.Show();
        }
    }
}
