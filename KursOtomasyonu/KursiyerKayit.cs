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
    public partial class KursiyerKayit : Form
    {
        Baglanti db = new Baglanti();

        Kursiyer _kursiyer = new Kursiyer();
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
            btnKursiyer.Text = "Kursiyer Ekle";
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
            if (btnKursiyer.Text == "Kursiyer Ekle")
            {
                _kursiyer.KursiyerNo = txtKursiyerNo.Text;
                _kursiyer.TcNo = txtTcNo.Text;
                _kursiyer.AdSoyad = txtAdSoyad.Text;
                _kursiyer.TelNo = txtTelNo.Text;
                _kursiyer.KayitTarihi = dtpKayitTarihi.Value;
                _kursiyer.Adres = rtbAdres.Text;

                db.connection.Open();
                db.command = new SqlCommand("Insert Into Kursiyer values(@KursiyerNo,@TcNo,@AdSoyad,@TelNo, @KayitTarihi, @Adres)", db.connection);

                db.command.Parameters.AddWithValue("KursiyerNo", _kursiyer.KursiyerNo);
                db.command.Parameters.AddWithValue("TcNo", _kursiyer.TcNo);
                db.command.Parameters.AddWithValue("AdSoyad", _kursiyer.AdSoyad);
                db.command.Parameters.AddWithValue("TelNo", _kursiyer.TelNo);
                db.command.Parameters.AddWithValue("KayitTarihi", _kursiyer.KayitTarihi);
                db.command.Parameters.AddWithValue("Adres", _kursiyer.Adres);
                
                db.command.ExecuteNonQuery();
                
                db.connection.Close();
                MessageBox.Show("Kayıt Eklendi");
                dtgKursiyerList.DataSource = KursiyerListele();



            }
            else if (btnKursiyer.Text == "Kursiyer Güncelle")
            {

                _kursiyer.Id = Convert.ToInt32(dtgKursiyerList.CurrentRow.Cells[0].Value);
                _kursiyer.KursiyerNo = txtKursiyerNo.Text;
                _kursiyer.TcNo = txtTcNo.Text;
                _kursiyer.AdSoyad = txtAdSoyad.Text;
                _kursiyer.TelNo = txtTelNo.Text;
                _kursiyer.KayitTarihi = dtpKayitTarihi.Value;
                _kursiyer.Adres = rtbAdres.Text;

                db.connection.Open();
                db.command = new SqlCommand("Update Kursiyer set KursiyerNo=@KursiyerNo,TcNo=@TcNo,AdSoyad=@AdSoyad,TelNo=@TelNo, KayitTarihi=@KayitTarihi, Adres=@Adres where Id=@Id", db.connection);
                db.command.Parameters.AddWithValue("Id", _kursiyer.Id);
                db.command.Parameters.AddWithValue("KursiyerNo", _kursiyer.KursiyerNo);
                db.command.Parameters.AddWithValue("TcNo", _kursiyer.TcNo);
                db.command.Parameters.AddWithValue("AdSoyad", _kursiyer.AdSoyad);
                db.command.Parameters.AddWithValue("TelNo", _kursiyer.TelNo);
                db.command.Parameters.AddWithValue("KayitTarihi", _kursiyer.KayitTarihi);
                db.command.Parameters.AddWithValue("Adres", _kursiyer.Adres);

                db.command.ExecuteNonQuery();
                db.connection.Close();
                MessageBox.Show("Kayıt Güncellendi");
                dtgKursiyerList.DataSource = KursiyerListele();

            }
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

        private void Temizle()
        {
            txtKursiyerNo.Text = txtTcNo.Text = txtAdSoyad.Text = txtTelNo.Text =rtbAdres.Text="";
            dtpKayitTarihi.Value = DateTime.Now;
           btnKursiyer.Text = "Kursiyer Ekle";
            dtgKursiyerList.ClearSelection();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

       

        private void KurisiyerSil(int id)
        {
            MessageBox.Show(id.ToString());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _kursiyer.Id = Convert.ToInt32(dtgKursiyerList.CurrentRow.Cells[0].Value);
            _kursiyer.AdSoyad = dtgKursiyerList.CurrentRow.Cells[3].Value.ToString();


            db.connection.Open();

                SqlCommand command = new SqlCommand("Delete from Kursiyer where Id=@Id", db.connection);
                command.Parameters.AddWithValue("@Id", _kursiyer.Id);

                command.ExecuteNonQuery();
                
                db.connection.Close();
                MessageBox.Show(_kursiyer.AdSoyad + "isimli kursiyer Silindi");
                dtgKursiyerList.DataSource = KursiyerListele();

            db.connection.Close();

        }
    }
}
