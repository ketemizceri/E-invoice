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
    public partial class KrediForm2 : Form
    {
        public KrediForm2()
        {
            InitializeComponent();
        }

        private void KrediForm2_Load(object sender, EventArgs e)
        {


            textBox1.Text = "0370368198";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

      
        
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;



            var kredi = Unidox.baslik.BaslikYardimci.CreditSpace(text);

            string mesaj = "Açıklama:" + kredi.explanation + Environment.NewLine +
                "kalan:" + kredi.remainCredit + Environment.NewLine +
                "toplam" + kredi.totalCredit + Environment.NewLine +
                "hata kodu:" + kredi.code + Environment.NewLine;

            MessageBox.Show(mesaj, "Kredi Sorgu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FonkForm form = new FonkForm();
            form.Show();
        }
    }
}
