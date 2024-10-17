using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        bool bosMU=false;
        bool sayiMi1 = false , sayiMi2=false;
        double sayi1, sayi2;
        public void TexboxKontrol()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                lblSonuc.ForeColor = Color.Red;
                lblSonuc.Text = "1. Sayı Alanını Doldurunuz";
                textBox1.Focus();
                bosMU = false;
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                lblSonuc.ForeColor = Color.Red;
                lblSonuc.Text = "2. Sayı Alanını Doldurunuz";
                textBox2.Focus();
                bosMU = false;
            }
            else
            {
                bosMU = true;
            }

        }

        private void btnÇıkar_Click(object sender, EventArgs e)
        {
            TexboxKontrol();
            if (bosMU)
            {
                SayiKontrol();
                if (sayiMi1 && sayiMi2)
                {
                    lblSonuc.Text = "Sonuç = " + (sayi1 - sayi2);
                    lblSonuc.ForeColor = Color.Green;
                }
            }
        }

        private void btnÇarp_Click(object sender, EventArgs e)
        {
            TexboxKontrol();
            if (bosMU)
            {
                SayiKontrol();
                if (sayiMi1 && sayiMi2)
                {
                    lblSonuc.Text = "Sonuç = " + (sayi1 * sayi2);
                    lblSonuc.ForeColor = Color.Green;
                }
            }
        }

        private void btnBöl_Click(object sender, EventArgs e)
        {
            TexboxKontrol();
            if (bosMU)
            {
                SayiKontrol();
                if (sayiMi1 && sayiMi2)
                {
                    lblSonuc.Text = "Sonuç = " + (sayi1 / sayi2);
                    lblSonuc.ForeColor = Color.Green;
                }
            }
        }

        public void SayiKontrol()
        {
            try
            {
                sayi1 = double.Parse(textBox1.Text);
                sayiMi1 = true;
            }
            catch 
            {
                lblSonuc.ForeColor = Color.Red;
                lblSonuc.Text = "1. Sayı Alanına Doğru Bir Değer Giriniz";
                textBox1.Focus();
                textBox1.Clear();
                sayiMi1 = false;

            }

            try
            {
                sayi2 = double.Parse(textBox2.Text);
                sayiMi2= true;
            }
            catch 
            {
                lblSonuc.Text = "2. Sayı Alanına Doğru Bir Değer Giriniz";
                textBox2.Focus();
                textBox2.Clear();
                sayiMi2= false;

            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            TexboxKontrol();
            if (bosMU)
            {
                SayiKontrol();
                if (sayiMi1 &&sayiMi2)
                {
                    lblSonuc.Text = "Sonuç = " + (sayi1 + sayi2);
                    lblSonuc.ForeColor = Color.Green;
                }
            }
        }
    }
}
