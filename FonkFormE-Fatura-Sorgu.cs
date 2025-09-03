using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Unidox
{
    public partial class FonkFormE_Fatura_Sorgu : Form
    {
        public FonkFormE_Fatura_Sorgu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 


            this.Hide();
            QueryUsers form = new QueryUsers();
            form.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] text = new string[] { "ABC2025"};



            string vkn = "51304154104";

            Unidox.baslik.BaslikYardimci.GetLastInvoiceIdAndDate(vkn, text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
   


            this.Hide();
            QueryOutboxDocument form = new  QueryOutboxDocument();
            form.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {

          

            this.Hide();
            QueryOutboxDocumentWithDocumentDate form = new QueryOutboxDocumentWithDocumentDate();
            form.Show();




        }

        private void button5_Click(object sender, EventArgs e)
        {



            this.Hide();
            QueryEnvelope form = new QueryEnvelope();
            form.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {


            this.Hide();
            QueryOutboxDocumentWithReceivedDate form = new QueryOutboxDocumentWithReceivedDate();
            form.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {


            this.Hide();
            QueryOutboxDocumentWithLocalID form = new QueryOutboxDocumentWithLocalID();
            form.Show();



        }

        private void button8_Click(object sender, EventArgs e)
        {



            this.Hide();
            QueryOutboxDocumentsWithWithGUIDList form = new QueryOutboxDocumentsWithWithGUIDList();
            form.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {



            this.Hide();
            QueryInboxDocument form = new QueryInboxDocument();
            form.Show();


        }

        private void button10_Click(object sender, EventArgs e)
        {



            this.Hide();
            QueryInboxDocumentsWithDocumentDate form = new QueryInboxDocumentsWithDocumentDate();
            form.Show();



        }

        private void button11_Click(object sender, EventArgs e)
        {







           

            this.Hide();
            QueryInboxDocumentsWithReceivedDate form = new QueryInboxDocumentsWithReceivedDate();
            form.Show();


        }





        private void button12_Click(object sender, EventArgs e)
        {


            this.Hide();
            QueryInboxDocumentsWithGUIDList form = new QueryInboxDocumentsWithGUIDList();
            form.Show();

        }




        private void button13_Click(object sender, EventArgs e)
        {

            Unidox.baslik.BaslikYardimci.getUserGBList();
        }




        private void button14_Click(object sender, EventArgs e)
        {
            Unidox.baslik.BaslikYardimci.getUserPKList();
       
        
        }

        private void button15_Click(object sender, EventArgs e)
        {


            string[] documentUUID = { "09c9f178-7c75-4c6d-9e0d-227a22a1a740", "e421fa2c-ef66-482d-b18d-ea27dd8e9ae9" };


            Unidox.baslik.BaslikYardimci.setTakenFromEntegrator(documentUUID);

        }

        private void button16_Click(object sender, EventArgs e)
        {

       

            this.Hide();
            QueryAppResponseOfOutboxDocument form = new QueryAppResponseOfOutboxDocument();
            form.Show();




        }

        private void button17_Click(object sender, EventArgs e)
        {


            //string docmentUUID = "09c9f178-7c75-4c6d-9e0d-227a22a1a740";
            //string withXML = "YES";

            //Unidox.baslik.BaslikYardimci.queryAppResponseOfInboxDocument(docmentUUID, withXML);


            this.Hide();
            QueryAppResponseOfInboxDocument form = new QueryAppResponseOfInboxDocument();
            form.Show();


        }

        private void button18_Click(object sender, EventArgs e)
        {

            this.Hide();
            ServiceForm form = new ServiceForm();
            form.Show();

        }

        private void FonkFormE_Fatura_Sorgu_Load(object sender, EventArgs e)
        {

        }
    }
}
