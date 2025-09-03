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
    public partial class QueryInboxDocument : Form
    {

        string paramType;
        string parameter;
        string withXML;


        public QueryInboxDocument()
        {
            InitializeComponent();
        }


        private void QueryInboxDocument_Load(object sender, EventArgs e)
        {

            textBox1.Text = "Envelope_UUID";
            textBox2.Text = "f0b8dd50-5384-41fa-8e43-47b417fc883d";
            textBox3.Text = "NONE";

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

        private void button1_Click(object sender, EventArgs e)
        {

            paramType = textBox1.Text;
            parameter = textBox2.Text;
            withXML = textBox3.Text;

            Unidox.baslik.BaslikYardimci.InboxDocument(paramType, parameter, withXML);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            FonkFormE_Fatura_Sorgu form = new FonkFormE_Fatura_Sorgu();
            form.Show();


        }

        
    }
}
