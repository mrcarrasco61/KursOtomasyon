using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KursOtomasyonu.Models;

namespace KursOtomasyonu
{
    public partial class KursForm : Form
    {

        Baglanti db = new Baglanti();

        Kurs _kurs = new Kurs();


        public KursForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void KursForm_Load(object sender, EventArgs e)
        {
            dtgKursList.DataSource = KursListele();
            btnKursEkle.Text = "Kurs Ekle";

            ResizeRedraw = true;
            dtpFiyat.Minimum = 0;
            dtpFiyat.Maximum = 99999999;
            dtpFiyat.DecimalPlaces = 2;
            dtpFiyat.Increment = 0.01m;
        }


        List<Kurs> kurslar = new List<Kurs>();
        
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

        private void btnKursEkle_Click(object sender, EventArgs e)
        {
            
            {
                if (btnKursEkle.Text == "Kurs Ekle")
                {
                    _kurs.Adi = txtKursAdi.Text;
                    _kurs.BaslangicSaati = dtgbSaati.Value;
                    _kurs.BitisSaati = dtgbitisSaati.Value;
                    _kurs.Fiyat = Convert.ToDecimal(dtpFiyat.Value);


                    db.connection.Open();
                    db.command = new SqlCommand("Insert Into Kurs values(@Adi,@BaslangicSaati,@BitisSaati,@EgitmenId,@Fiyat)", db.connection);

                    db.command.Parameters.AddWithValue("Adi", _kurs.Adi);
                    db.command.Parameters.AddWithValue("BaslangicSaati", _kurs.BaslangicSaati);
                    db.command.Parameters.AddWithValue("BitisSaati", _kurs.BitisSaati);
                    db.command.Parameters.AddWithValue("Fiyat", _kurs.Fiyat);
                    db.command.Parameters.AddWithValue("EgitmenId", 0);

                    db.command.ExecuteNonQuery();

                    db.connection.Close();
                    MessageBox.Show("Kayıt Eklendi", "Başarıyla");
                    dtgKursList.DataSource = KursListele();

                }
                else if (btnKursEkle.Text == "Kurs Güncelle")
                {
                    _kurs.Id = Convert.ToInt32(dtgKursList.CurrentRow.Cells[0].Value);
                    _kurs.Adi = txtKursAdi.Text;
                    _kurs.BaslangicSaati = dtgbSaati.Value;
                    _kurs.BitisSaati = dtgbitisSaati.Value;
                    _kurs.Fiyat = Convert.ToDecimal(dtpFiyat.Value);
                    


                    db.connection.Open();

                    db.command = new SqlCommand("Update Kurs set Adi=@Adi,BaslangicSaati=@BaslangicSaati, BitisSaati=@BitisSaati,Fiyat=@Fiyat where Id=@Id", db.connection);

                    db.command.Parameters.AddWithValue("Id", _kurs.Id);
                    db.command.Parameters.AddWithValue("Adi", _kurs.Adi);
                    db.command.Parameters.AddWithValue("BaslangicSaati", _kurs.BaslangicSaati);
                    db.command.Parameters.AddWithValue("BitisSaati", _kurs.BitisSaati);
                    db.command.Parameters.AddWithValue("Fiyat", _kurs.Fiyat);




                    db.command.ExecuteNonQuery();
                    db.connection.Close();
                    MessageBox.Show("Kayıt Güncellendi");
                    dtgKursList.DataSource = KursListele();

                }
            }
        }

        private void dtgKursList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnKursEkle.Text = "Kurs Güncelle";

            txtKursAdi.Text = dtgKursList.CurrentRow.Cells[1].Value.ToString();
            dtgbitisSaati.Text = dtgKursList.CurrentRow.Cells[2].Value.ToString();
            dtgbitisSaati.Text = dtgKursList.CurrentRow.Cells[3].Value.ToString();
            dtpFiyat.Value= Convert.ToDecimal(dtgKursList.CurrentRow.Cells[5].Value);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            _kurs.Id = Convert.ToInt32(dtgKursList.CurrentRow.Cells[0].Value);
            _kurs.Adi = dtgKursList.CurrentRow.Cells[1].Value.ToString();


            db.connection.Open();

            SqlCommand command = new SqlCommand("Delete from Kurs where Id=@Id", db.connection);
            command.Parameters.AddWithValue("@Id", _kurs.Id);

            command.ExecuteNonQuery();

            db.connection.Close();
            MessageBox.Show(_kurs.Adi + "  İsimli Kurs Silindi  ");
            dtgKursList.DataSource = KursListele();

            db.connection.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            txtKursAdi.Text = "";
            dtgbitisSaati.Value = dtgbSaati.Value = DateTime.Now;
            dtpFiyat.Value = 0;
            btnKursEkle.Text = "Kurs Ekle";
            dtgKursList.ClearSelection();
        }
    }
}
