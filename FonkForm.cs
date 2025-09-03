using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Unidox
{



    public partial class FonkForm : Form
    {
        public FonkForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }






        private void btnXmlSec_Click(object sender, EventArgs e)
        {



            this.Hide();
            SendInvoice form = new SendInvoice();
            form.Show();



        }









        private void button2_Click(object sender, EventArgs e)
        {
            var donus = Unidox.baslik.BaslikYardimci.GbList();


            string doner = "VKN_TCKN: " + string.Join(", ", donus.users.Select(i => i.vkn_tckn)) +
                           Environment.NewLine +
                           "Etiket: " + string.Join(", ", donus.users.Select(i => i.etiket));

            MessageBox.Show(doner, "Donus Deger");

            


        }




        private void button3_Click(object sender, EventArgs e)
        {


            this.Hide();
            KrediForm form = new KrediForm();
            form.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {


            var donus = Unidox.baslik.BaslikYardimci.PkList();


            string doner = "VKN_TCKN: " + string.Join(", ", donus.users.Select(i => i.vkn_tckn)) +
                           Environment.NewLine +
                           "Etiket: " + string.Join(", ", donus.users.Select(i => i.etiket));

            MessageBox.Show(doner, "Donus Deger");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KrediForm2 form = new KrediForm2();
            form.Show();
        }

       
        
        private void button6_Click(object sender, EventArgs e)
        {



            var donus = Unidox.baslik.BaslikYardimci.GetPrefixList();



            string doner = "Query State: " + donus.queryState + Environment.NewLine +
                           "Açıklama: " + donus.stateExplanation + Environment.NewLine +
                           "Döküman Sayısı: " + donus.documentsCount + Environment.NewLine +
                           "Max Record: " + donus.maxRecordIdinList + Environment.NewLine +
                           "Documents:" + Environment.NewLine;

            foreach (var doc in donus.documents)
            {
                doner += "  - Email Sent: " + doc.emailSent + Environment.NewLine +
                         "    Reserved1: " + doc.reserved1 + Environment.NewLine +
                         "    Reserved2: " + doc.reserved2 + Environment.NewLine;
            }



            MessageBox.Show(doner, "Donus Deger");






            }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = "asdas";


            var donus = Unidox.baslik.BaslikYardimci.ControlInvoiceXML(text);

            string doner = "Kod: " + donus.code + Environment.NewLine +
                          "Açıklama: " + donus.explanation;


            MessageBox.Show(doner, "Donus Deger");


        }

        private void button8_Click(object sender, EventArgs e)
        {


            this.Hide();
            UserAliases form = new UserAliases();
            form.Show();


        }



        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceForm form = new ServiceForm();
            form.Show();
        }

    
    }
}
