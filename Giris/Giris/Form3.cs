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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0;
            if (string.IsNullOrEmpty(txtSayi1.Text))
            {
                lblSonuc.ForeColor = Color.Red;
                lblSonuc.Text = "1. Sayı Alanını Doldurunuz";
                txtSayi1.Focus();
                //Texbox ın seçili hale gelmesini sağlıyor
            }
            else if (string.IsNullOrEmpty(txtSayi2.Text))
            {
                lblSonuc.ForeColor = Color.Red;
                lblSonuc.Text = "2. Sayı Alanını Doldurunuz";
                txtSayi2.Focus();
            }

            else
            {
                try
                {
                    sayi1 = double.Parse(txtSayi1.Text);
                }
                catch 
                {
                    lblSonuc.ForeColor= Color.Red;
                    lblSonuc.Text = "1. Sayı Alanına Doğru Bir Değer Giriniz";
                    txtSayi1.Focus();
                    txtSayi1.Clear();
                   
                }
                try
                {
                    sayi2=double.Parse(txtSayi2.Text);
                }
                catch 
                {
                    lblSonuc.ForeColor = Color.Red;
                    lblSonuc.Text = "2. Sayı Alanına Doğru Bir Değer Giriniz";
                    txtSayi2.Focus();
                    txtSayi2.Clear();
                    
                    
                }
                if (sayi1!=0 && sayi2 !=0)
                {
                    lblSonuc.Text = "Sonuç = " + (sayi1 + sayi2);
                    lblSonuc.ForeColor = Color.Green;
                }

            }
        }
    }
}
