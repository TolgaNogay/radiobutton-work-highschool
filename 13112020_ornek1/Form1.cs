using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13112020_ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, cinsiyet;
            ad = textBoxAd.Text;
            soyad = textBoxSoyad.Text;
            cinsiyet = "";

            if (radioButton1.Checked==true)
            {
                cinsiyet = "Erkek";
            }
            else if (radioButton2.Checked==true)
            {
                cinsiyet = "Kadın";
            }
            else
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz.");
            }
            string kisi = String.Format("Ad : {0} Soyad : {1} Cinsiyet {2}", ad, soyad, cinsiyet);
            MessageBox.Show(kisi);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
