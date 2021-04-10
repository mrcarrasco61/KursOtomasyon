﻿using System;
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
    }
}
