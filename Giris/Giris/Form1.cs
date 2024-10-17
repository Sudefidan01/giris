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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Projemizin başlayacağı Form u seçmek için
        //Program.cs in içerisine gidip
        //Application.Run(new Form1()) kodunun parantez içerisinde yazan Form ismini değiştirmek yeterli
        //Parantez içerisinde yeni oluşturduğumuz yada daha önceden var olan Form elementinin ismini yazacağız 
        //Örnek
        //Application.Run(new Form2()) 

        private void button1_Click(object sender, EventArgs e)
        {
            //Windows form uygulamaları içerisinde mesaj kutusu gösterimi için MessageBox class ' ı  içerisindeki Show() metodunu kullanırız

            //MessageBox.Show("Butona Tıklandı");
            MessageBox.Show("Butona Tıklandı"," !!!!! Uyarı !!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
            button3.ForeColor= Color.Blue;
            button3.Text = "Buton 2 ye tıklandı";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor= Color.Black;
            button2.Text = "Buton 3 e tıklandı";
        }
    }
}
