using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursOtomasyonu
{
    
    public partial class Form1 : Form
    {
        Baglanti db = new Baglanti();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtkadi.Text;
            string Sifre = txtsifre.Text;
            Baglanti islemim = new Baglanti();
            islemim.girisyap(KullaniciAdi,Sifre,this);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtsifre.PasswordChar = '*';
        }
    }
}
