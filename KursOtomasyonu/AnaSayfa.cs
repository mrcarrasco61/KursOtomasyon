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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KursiyerKayit kursiyerKayit = new KursiyerKayit();
            kursiyerKayit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KursiyerDevamsizlik kursiyerDevamsizlik = new KursiyerDevamsizlik();
            kursiyerDevamsizlik.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EgitmenKayit egitmenler = new EgitmenKayit();
            egitmenler.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KursForm kursformu = new KursForm();
            kursformu.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KursiyerAtama kursiyerata = new KursiyerAtama();
            kursiyerata.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EgitmenAtama egitmenata = new EgitmenAtama();
            egitmenata.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sertifikafrm sertifikaata = new Sertifikafrm();
            sertifikaata.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Muhasebe muhasebeislemleri = new Muhasebe();
            muhasebeislemleri.Show();
        }
    }
}
