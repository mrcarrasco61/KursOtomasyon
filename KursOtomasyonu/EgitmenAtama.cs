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
    public partial class EgitmenAtama : Form
    {
        Baglanti db = new Baglanti();
        public EgitmenAtama()
        {
            InitializeComponent();
        }

        private void dtgEgitmen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEgitmenId.Text = dtgEgitmen.CurrentRow.Cells[0].Value.ToString();
        }

        private void EgitmenAtama_Load(object sender, EventArgs e)
        {
            dtgEgitmen.DataSource = EgitmenListele();
            dtgKurs.DataSource = KursListele();
            AtanmaListele();
        }

        public List<Egitmen> EgitmenListele()
        {
            db.connection.Open();

            db.command = new SqlCommand("Select *From Egitmen", db.connection);
            SqlDataReader dataReader = db.command.ExecuteReader();


            List<Egitmen> egitmenler = new List<Egitmen>();

            while (dataReader.Read())
            {
                Egitmen egitmen = new Egitmen();

                egitmen.Id = Convert.ToInt32(dataReader["Id"]);
                egitmen.AdSoyad = dataReader["AdSoyad"].ToString();
                egitmen.Brans = dataReader["Brans"].ToString();
                egitmen.Maas = Convert.ToDecimal(dataReader["Maas"].ToString());
                egitmen.TcNo = dataReader["TcNo"].ToString();
                egitmen.MaasOdendi = Convert.ToBoolean(dataReader["MaasOdendi"]);

                egitmenler.Add(egitmen);
            }

            db.connection.Close();
            return egitmenler;

        }

        public List<Kurs> KursListele()
        {
            db.connection.Open();

            db.command = new SqlCommand("Select *From Kurs where EgitmenId = 0", db.connection);
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

        private void AtanmaListele()
        {

            db.connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select k.Id,k.Adi,e.AdSoyad from Kurs k left join Egitmen e on k.EgitmenId=e.Id where k.EgitmenId <> 0", db.connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dtgAtanan.DataSource = dataTable;
            db.connection.Close();
        }

        private void dtgKurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKursId.Text = dtgKurs.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAtamaYap_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            db.command = new SqlCommand("Update Kurs set EgitmenId=@EgitmenId where Id=@Id", db.connection);
            db.command.Parameters.AddWithValue("Id", txtKursId.Text);
            db.command.Parameters.AddWithValue("EgitmenId", txtEgitmenId.Text);
            db.command.ExecuteNonQuery();
            db.connection.Close();
            MessageBox.Show("Kayıt Güncellendi");
            dtgEgitmen.DataSource = EgitmenListele();
            dtgKurs.DataSource = KursListele();
            AtanmaListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        int kursId;
        private void dtgAtanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAtananKursId.Text = dtgAtanan.CurrentRow.Cells[0].Value.ToString();
            kursId = Convert.ToInt32(dtgAtanan.CurrentRow.Cells[0].Value);
            txtEgitmenAdi.Text = dtgAtanan.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            db.command = new SqlCommand("Update Kurs set EgitmenId = @EgitmenId where Id=@Id", db.connection);
            db.command.Parameters.AddWithValue("Id", kursId);

            db.command.Parameters.Add(new SqlParameter("@EgitmenId", SqlDbType.Int) { Value = 0 });
            db.command.ExecuteNonQuery();
            db.connection.Close();
            MessageBox.Show("Atanma Kaldırıldı");
            dtgEgitmen.DataSource = EgitmenListele();
            dtgKurs.DataSource = KursListele();
            AtanmaListele();
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
