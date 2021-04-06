﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursOtomasyonu.Models;

namespace KursOtomasyonu
{
    public partial class KursiyerKayit : Form
    {
        Baglanti db = new Baglanti();
        public KursiyerKayit()
        {
            InitializeComponent();
        }

        private void btnNoUret_Click(object sender, EventArgs e)
        {
            KursiyerNoUretici kursiyerNoUretici = new KursiyerNoUretici();
            txtKursiyerNo.Text = kursiyerNoUretici.KursiyerNo.ToString();
        }

        private void KursiyerKayit_Load(object sender, EventArgs e)
        {
            dtgKursiyerList.DataSource = KursiyerListele();
        }

        public List<Kursiyer> KursiyerListele()
        {

            //bağlantıyı  aç
            db.connection.Open();
            // 
            db.command = new SqlCommand("Select *From Kursiyer", db.connection);
            // gelen veriyi okur
            SqlDataReader dataReader = db.command.ExecuteReader();

            List<Kursiyer> kursiyerler = new List<Kursiyer>();

            // veri geldikce verileri belirtilen yerlere aktar.
            while (dataReader.Read())
            {
                Kursiyer kursiyer = new Kursiyer();

                kursiyer.Id = Convert.ToInt32(dataReader["Id"]);
                kursiyer.KursiyerNo = dataReader["KursiyerNo"].ToString();
                kursiyer.TcNo = dataReader["TcNo"].ToString();
                kursiyer.AdSoyad = dataReader["AdSoyad"].ToString();
                kursiyer.TelNo = dataReader["TelNo"].ToString();
                kursiyer.KayitTarihi = Convert.ToDateTime(dataReader["KayitTarihi"]);
                kursiyer.Adres = dataReader["Adres"].ToString();

                //Listeye ekleme işlemini gerçekleştirir.
                kursiyerler.Add(kursiyer);
            }

            db.connection.Close();
            return kursiyerler;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnKursiyer.Text = "Kursiyer Güncelle";
            txtKursiyerNo.Text = dtgKursiyerList.CurrentRow.Cells[1].Value.ToString();
            txtTcNo.Text = dtgKursiyerList.CurrentRow.Cells[2].Value.ToString();
            txtAdSoyad.Text = dtgKursiyerList.CurrentRow.Cells[3].Value.ToString();
            txtTelNo.Text = dtgKursiyerList.CurrentRow.Cells[4].Value.ToString();
            dtpKayitTarihi.Value = Convert.ToDateTime(dtgKursiyerList.CurrentRow.Cells[5].Value.ToString());
            rtbAdres.Text = dtgKursiyerList.CurrentRow.Cells[6].Value.ToString();
            




        }
    }
}
