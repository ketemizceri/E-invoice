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
    public partial class UserAliases : Form
    {
        public UserAliases()
        {
            InitializeComponent();
        }

        private void UserAliases_Load(object sender, EventArgs e)
        {
            textBox1.Text = "6621610117";
        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string[] text = new string[] { textBox1.Text };
            var adresler = Unidox.baslik.BaslikYardimci.Alias(text);


            foreach (var adres in adresler)
            {
                string sonuc =
                    "VKN/TCKN: " + adres.vkn_tckn + Environment.NewLine +
                    "GB List : " + string.Join(", ", adres.gbList) + Environment.NewLine +
                    "PK List : " + string.Join(", ", adres.pkList);

                MessageBox.Show(sonuc);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FonkForm form = new FonkForm();
            form.Show();
        }
    }
}
