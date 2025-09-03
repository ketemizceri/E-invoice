using System;

using System.Windows.Forms;

namespace Unidox
{
    public partial class QueryOutboxDocumentWithLocalID : Form
    {

        string localID;

        public QueryOutboxDocumentWithLocalID()
        {
            InitializeComponent();
        }

        private void QueryOutboxDocumentWithLocalID_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  

        }

        private void button1_Click(object sender, EventArgs e)
        {

            localID = textBox1.Text;

            Unidox.baslik.BaslikYardimci.OutboxDocumentWithLocalId(localID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FonkFormE_Fatura_Sorgu form = new FonkFormE_Fatura_Sorgu();
            form.Show();
        }
    }
}
