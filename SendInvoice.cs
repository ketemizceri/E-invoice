using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidox.baslik;

namespace Unidox
{
    public partial class SendInvoice : Form
    {

        string adet;




        public SendInvoice()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendInvoice_Load(object sender, EventArgs e)
        {
            
            adet= textBox1.Text;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text.Trim(), out int adet) || adet <= 0)
            {
                MessageBox.Show("Lütfen 1 veya daha büyük bir tam sayı girin.");
                return;
            }

            using (var ofd = new OpenFileDialog { Filter = "XML Dosyaları (*.xml)|*.xml" })
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                string xmlIcerik = File.ReadAllText(ofd.FileName);

               
                System.Net.ServicePointManager.DefaultConnectionLimit = Math.Max(100, adet);

                int started = 0, completed = 0, success = 0, fail = 0;
                var errors = new System.Collections.Concurrent.ConcurrentBag<string>();
                var tasks = new List<Task>(adet);
                var sw = System.Diagnostics.Stopwatch.StartNew();

                for (int i = 0; i < adet; i++)
                {
                    started++;
                    tasks.Add(Task.Run(() =>
                    {
                        var res = Unidox.baslik.BaslikYardimci.GonderXML(xmlIcerik, showUi: false);
                        System.Threading.Interlocked.Increment(ref completed);
                        if (res.Success) System.Threading.Interlocked.Increment(ref success);
                        else { System.Threading.Interlocked.Increment(ref fail); errors.Add($"{res.Code} - {res.Explanation} - {res.Error}"); }
                    }));
                }

                await Task.WhenAll(tasks);
                sw.Stop();

                var firstErrors = string.Join(Environment.NewLine, errors.Take(5));
                if (!string.IsNullOrEmpty(firstErrors))
                    firstErrors = Environment.NewLine + Environment.NewLine + "Yanıt:" + Environment.NewLine + firstErrors;

                MessageBox.Show(
                    $"Başlatılan: {started}\nTamamlanan: {completed}\nBaşarılı: {success}\nBaşarısız: {fail}\n" +
                    $"Geçen süre: {sw.Elapsed.TotalSeconds:F2} sn{firstErrors}",
                    "Gönderim Özeti");
            }
        }

    }




}

