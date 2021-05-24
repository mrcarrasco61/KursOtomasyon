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
    public partial class Muhasebe : Form
    {
        Baglanti db = new Baglanti();
        public Muhasebe()
        {
            InitializeComponent();
        }

        private void dtgOgrenciOdeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            lblKursiyerId.Text = dtgOgrenciOdeme.CurrentRow.Cells[0].Value.ToString();
            lblKursiyerNo.Text = dtgOgrenciOdeme.CurrentRow.Cells[1].Value.ToString();
            lblKursiyerAdi.Text = dtgOgrenciOdeme.CurrentRow.Cells[3].Value.ToString();

        }

        private void Muhasebe_Load(object sender, EventArgs e)
        {
            dtgOgrenciOdeme.DataSource = KursiyerListele();
            dtgEgitmenOdeme.DataSource = EgitmenListele();

        }

        public List<Kursiyer> KursiyerListele()
        {


            db.connection.Open();

            db.command = new SqlCommand("Select *From Kursiyer", db.connection);

            SqlDataReader dataReader = db.command.ExecuteReader();

            List<Kursiyer> kursiyerler = new List<Kursiyer>();


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
                kursiyer.UcretOdendi = dataReader.GetBoolean(dataReader.GetOrdinal("UcretOdendi"));
                
                
       

                kursiyerler.Add(kursiyer);
            }

            db.connection.Close();

            return kursiyerler;

        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {

            db.connection.Open();
            db.command = new SqlCommand("Update Kursiyer set UcretOdendi=@UcretOdendi where Id=@Id", db.connection);
            db.command.Parameters.AddWithValue("Id", Convert.ToInt32(lblKursiyerId.Text));
            db.command.Parameters.Add(new SqlParameter("UcretOdendi", SqlDbType.Bit) { Value = 1 });
            db.command.ExecuteNonQuery();
            db.connection.Close();
            dtgOgrenciOdeme.DataSource = KursiyerListele();


        }


        private void dtgEgitmenOdeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEgitmenId.Text = dtgEgitmenOdeme.CurrentRow.Cells[0].Value.ToString();
            lblEgitmenNo.Text = dtgEgitmenOdeme.CurrentRow.Cells[1].Value.ToString();
            lblEgitmenAd.Text = dtgEgitmenOdeme.CurrentRow.Cells[3].Value.ToString();
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
                egitmen.MaasOdendi = dataReader.GetBoolean(dataReader.GetOrdinal("MaasOdendi"));



                egitmenler.Add(egitmen);
            }

            db.connection.Close();
            return egitmenler;

        }


        private void btnEgitmenOde_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            db.command = new SqlCommand("Update Egitmen set MaasOdendi=@MaasOdendi where Id=@Id", db.connection);
            db.command.Parameters.AddWithValue("Id", Convert.ToInt32(lblEgitmenId.Text));
            db.command.Parameters.Add(new SqlParameter("MaasOdendi", SqlDbType.Bit) { Value = 1 });
            db.command.ExecuteNonQuery();
            db.connection.Close();
            dtgEgitmenOdeme.DataSource = EgitmenListele();
        }

       
    }
}
