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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTextBoxOku_Click(object sender, EventArgs e)
        {
            //string metin = textBox1.Text;
            //MessageBox.Show(metin);

            MessageBox.Show(textBox1.Text);
        }

        private void btnLabelOku_Click(object sender, EventArgs e)
        {
            string metin = lblYazi.Text;
            MessageBox.Show(metin);
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            if (string.IsNullOrEmpty(metin))
            {
                MessageBox.Show("Textbox alanını doldurmanız gerekmektedir"," !!!! UYARI !!!!");
            }
            else
            {
                lblYazi.Text = metin;
                textBox1.Clear();//Textbox içerisindeki tüm yazıları siler

            }
        }
    }
}
