using System;

using System.Windows.Forms;

namespace Unidox
{
    public partial class QueryInboxDocumentsWithReceivedDate : Form
    {

        DateTime startDate;
        DateTime endDate ;
        string documentType;
        string queried;
        string withXML;
        string takenFromEntegrator;
        string minRecordId;



        public QueryInboxDocumentsWithReceivedDate()
        {
            InitializeComponent();
        }

        private void QueryInboxDocumentsWithReceivedDate_Load(object sender, EventArgs e)
        {

            textBox3.Text = "1";
            textBox4.Text = "ALL";
            textBox5.Text = "XML";
            textBox6.Text = "ALL";
            textBox7.Text = "1";

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            startDate = dateTimePicker1.Value;

        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            endDate = dateTimePicker2.Value;
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            documentType = textBox3.Text;
            queried = textBox4.Text;
            withXML = textBox5.Text;
            takenFromEntegrator = textBox6.Text;
            minRecordId = textBox7.Text;

            Unidox.baslik.BaslikYardimci.InboxDocumentWithReceivedDate(startDate, endDate, documentType, queried, withXML, takenFromEntegrator, minRecordId);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FonkFormE_Fatura_Sorgu form = new FonkFormE_Fatura_Sorgu();
            form.Show();
        }



    }
}
