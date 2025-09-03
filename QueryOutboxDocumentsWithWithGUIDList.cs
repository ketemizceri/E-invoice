using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unidox
{
    public partial class QueryOutboxDocumentsWithWithGUIDList : Form
    {


        string documentType = "1";


        List<string> guidList = new List<string>
            {

              "62f59934-1a6f-439b-a1e0-e31f0dd43914",
              "b88346fc-aabc-4bb7-96cf-6ece839b4929",
              "ce65f0aa-0e53-4755-926a-3edb185440c4"


            };


        private void QueryOutboxDocumentsWithWithGUIDList_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (var guid in guidList)
            {
                checkedListBox1.Items.Add(guid);
            }
        }



        public QueryOutboxDocumentsWithWithGUIDList()
        {
            InitializeComponent();
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FonkFormE_Fatura_Sorgu form = new FonkFormE_Fatura_Sorgu();
            form.Show();
        }
    }
}
