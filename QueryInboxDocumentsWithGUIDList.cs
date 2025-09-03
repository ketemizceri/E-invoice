using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unidox
{
    public partial class QueryInboxDocumentsWithGUIDList : Form
    {

        string documentType = "1";



        List<string> guidList = new List<string>
            {

              "a64eb118-ff1c-493e-a8cd-442032840856",
              "533815e3-2a94-4455-b614-edea7a7f249f",
              "5c00efce-c3fc-453b-8ac4-4e7df5cd6a80"


            };



        public QueryInboxDocumentsWithGUIDList()
        {
            InitializeComponent();
        }



        private void QueryInboxDocumentsWithGUIDList_Load(object sender, EventArgs e)
        {

            checkedListBox1.Items.Clear();
            foreach (var guid in guidList)
            {
                checkedListBox1.Items.Add(guid);
            }


        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> selectedGuids = new List<string>();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedGuids.Add(item.ToString());
            }

            if (selectedGuids.Count > 0)
            {
                Unidox.baslik.BaslikYardimci.InboxDocumentsWithGUIDList(selectedGuids, documentType);
            }
            else
            {
                MessageBox.Show("Lütfen en az bir GUID seçiniz.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            FonkFormE_Fatura_Sorgu form = new FonkFormE_Fatura_Sorgu();
            form.Show();


        }

       
    }
}
