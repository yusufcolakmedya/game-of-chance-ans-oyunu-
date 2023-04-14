using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int rastgele;
        
        string[] dizi = { "1.at", "2.at", "3.at"};
        int[] puan = {0, 0, 0};
        const int bitis = 5;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rastgele = rnd.Next(1, 4);

            // karşılaştırma bölümü
            if (rastgele == 1)
            {
                puan[0] += 1;
                progressBar1.Value = puan[0];
            }

            else if (rastgele == 2)
            {
                puan[1] += 1;
                progressBar2.Value = puan[1];
            }

            else if (rastgele == 3)
            {
                puan[2] += 1;
                progressBar3.Value = puan[2];
            }

            else
            {
                MessageBox.Show("hata");
            }
            
            // kontrol bölümü
            for (int i = 0; i < dizi.Length; i++)
            {
                if (puan[i] == bitis)
                {
                    MessageBox.Show("kazanan : " + dizi[i]);
                    button1.Enabled = false;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = bitis; progressBar2.Maximum = bitis; progressBar3.Maximum = bitis;
        }
    }
}
