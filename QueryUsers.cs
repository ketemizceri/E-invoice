using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidox
{
    public partial class QueryUsers : Form
    {



        string vknTckn;
        DateTime startDate;
        DateTime finishDate;


        public QueryUsers()
        {
            InitializeComponent();
        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             startDate = dateTimePicker1.Value;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

             finishDate = dateTimePicker2.Value;


        }

        public void QueryUsers_Load(object sender, EventArgs e)
        {
            textBox1.Text = "51304154104";

             vknTckn = textBox1.Text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Unidox.baslik.BaslikYardimci.QueryUsers(startDate, finishDate, vknTckn);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
