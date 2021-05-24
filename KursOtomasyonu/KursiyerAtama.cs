using System;
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
    public partial class KursiyerAtama : Form
    {
        Baglanti db = new Baglanti();
        public KursiyerAtama()
        {
            InitializeComponent();
        }

        private void KursiyerAtama_Load(object sender, EventArgs e)
        {
            dtgKursiyer.DataSource = KursiyerListele();
            dtgKursList.DataSource = KursListele();
            AtananOgrenciListesi();
        }

        public List<Kursiyer> KursiyerListele()
        {

            //veritabanı bağlantısı açarız.
            db.connection.Open();
            //veritabanında hangi Kursiyer Tablosuna ulaşılır.
            db.command = new SqlCommand("Select *From Kursiyer k where k.KursId = 0", db.connection);
            // gelen veriyi okur
            SqlDataReader dataReader = db.command.ExecuteReader();
            //verileri listede tutmak için yeni bir liste nesnesi oluşturdum.
            List<Kursiyer> kursiyerler = new List<Kursiyer>();

            // veri geldikce verileri belirtilen yerlere aktar.
            while (dataReader.Read())
            {

                Kursiyer kursiyer = new Kursiyer();
                //Eğitmen classın dan gelen nesneleri verilere aktardık.
                kursiyer.Id = Convert.ToInt32(dataReader["Id"]);
                kursiyer.KursiyerNo = dataReader["KursiyerNo"].ToString();
                kursiyer.TcNo = dataReader["TcNo"].ToString();
                kursiyer.AdSoyad = dataReader["AdSoyad"].ToString();
                kursiyer.TelNo = dataReader["TelNo"].ToString();
                kursiyer.KayitTarihi = Convert.ToDateTime(dataReader["KayitTarihi"]);
                kursiyer.Adres = dataReader["Adres"].ToString();

                //verileri Listeye ekleme işlemini gerçekleştirir.
                kursiyerler.Add(kursiyer);
            }

            db.connection.Close();
            // return ile kursiyerler listesine geri döndürürüz.
            return kursiyerler;

        }
        public List<Kurs> KursListele()
        {
            db.connection.Open();

            db.command = new SqlCommand("Select *From Kurs", db.connection);
            SqlDataReader dataReader = db.command.ExecuteReader();


            List<Kurs> kurslar = new List<Kurs>();

            while (dataReader.Read())
            {
                Kurs kurs = new Kurs();

                kurs.Id = Convert.ToInt32(dataReader["Id"]);
                kurs.Adi = dataReader["Adi"].ToString();
                kurs.BaslangicSaati = Convert.ToDateTime(dataReader["BaslangicSaati"]);
                kurs.BitisSaati = Convert.ToDateTime(dataReader["BitisSaati"]);
                kurs.Fiyat = Convert.ToDecimal(dataReader["Fiyat"]);
                kurs.EgitmenId = Convert.ToInt32(dataReader["EgitmenId"]);

                kurslar.Add(kurs);
            }

            db.connection.Close();
            return kurslar;

        }

        private void AtananOgrenciListesi()
        {
            db.connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select kr.Id,kr.AdSoyad,ku.Adi from Kursiyer kr left join Kurs ku on kr.KursId=ku.Id where kr.KursId <> 0", db.connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dtgAtanan.DataSource = dataTable;
            db.connection.Close();
        }

        private void dtgKursiyer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKursiyerId.Text = dtgKursiyer.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            //Id ile güncelleme yapacağımız Id belirtiyoruz.
            //güncelleme yapacağımız tabloyu belirtiyoruz Update ile güncelleme yapacağımızı belirtiyoruz.
            db.command = new SqlCommand("Update Kursiyer set KursId=@KursId where Id=@Id", db.connection);
            db.command.Parameters.AddWithValue("Id", txtKursiyerId.Text);
            db.command.Parameters.AddWithValue("KursId", txtKursId.Text);
            db.command.ExecuteNonQuery();
            db.connection.Close();
            MessageBox.Show("Kayıt Güncellendi");
            dtgKursiyer.DataSource = KursiyerListele();
            dtgKursList.DataSource = KursListele();
            AtananOgrenciListesi();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dtgKursList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKursId.Text = dtgKursList.CurrentRow.Cells[0].Value.ToString();
        }
        int kursiyerId;
        private void dtgAtanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtArananKursiyerId.Text = dtgAtanan.CurrentRow.Cells[0].Value.ToString();
            kursiyerId = Convert.ToInt32(dtgAtanan.CurrentRow.Cells[0].Value);
            txtKursAdi.Text = dtgAtanan.CurrentRow.Cells[2].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            db.connection.Open();
            //Id ile güncelleme yapacağımız Id belirtiyoruz.
            //güncelleme yapacağımız tabloyu belirtiyoruz Update ile güncelleme yapacağımızı belirtiyoruz.
            db.command = new SqlCommand("Update Kursiyer set KursId = @KursId where Id=@Id", db.connection);
            db.command.Parameters.AddWithValue("Id",kursiyerId);

            db.command.Parameters.Add(new SqlParameter("@KursId", SqlDbType.Int) { Value = 0 });
            db.command.ExecuteNonQuery();
            db.connection.Close();
            MessageBox.Show("Atanma Kaldırıldı");
            dtgKursiyer.DataSource = KursiyerListele();
            dtgKursList.DataSource = KursListele();
            AtananOgrenciListesi();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
