using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidox
{
    public partial class QueryAppResponseOfOutboxDocument : Form
    {



        string documentUUID;
        string withXML;




        public QueryAppResponseOfOutboxDocument()
        {
            InitializeComponent();
        }

        private void QueryAppResponseOfOutboxDocument_Load(object sender, EventArgs e)
        {
            textBox1.Text = "e221fa2c-ef66-482d-b18d-ea27dd8e9ae9";
            textBox2.Text = "YES";

            documentUUID = textBox1.Text;
            withXML = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unidox.baslik.BaslikYardimci.queryAppResponseOfOutboxDocument(documentUUID, withXML);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FonkFormE_Fatura_Sorgu form = new FonkFormE_Fatura_Sorgu();
            form.Show();
        }
    }
}
