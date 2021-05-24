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
    public partial class EgitmenKayit : Form
    {

        Baglanti db = new Baglanti();

        Egitmen _egitmen = new Egitmen();


        public EgitmenKayit()
        {
            InitializeComponent();
        }
        private void EgitmenKayit_Load(object sender, EventArgs e)
        {
            dtgEgitmenList.DataSource = EgitmenListele();
            btnEgitmenEkle.Text = "Egitmen Ekle";
        }

        private void dtgEgitmenList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgEgitmenList.DataSource = EgitmenListele();
        }

        List<Egitmen> egitmenler = new List<Egitmen>();

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


    
        private void btnEgitmenEkle_Click(object sender, EventArgs e)
        {
            if (btnEgitmenEkle.Text == "Egitmen Ekle")
            {
                _egitmen.AdSoyad = txtEgitmenAdi.Text;
                _egitmen.Brans = txtBrans.Text;
                _egitmen.Maas = Convert.ToDecimal(txtMaas.Text);
                _egitmen.TcNo = txtTcNo.Text;


                db.connection.Open();
                db.command = new SqlCommand("Insert Into Egitmen values(@AdSoyad,@Brans,@Maas,@TcNo,@MaasOdendi)", db.connection);

                db.command.Parameters.AddWithValue("AdSoyad", _egitmen.AdSoyad);
                db.command.Parameters.AddWithValue("Brans", _egitmen.Brans);
                db.command.Parameters.AddWithValue("Maas", _egitmen.Maas);
                db.command.Parameters.AddWithValue("TcNo", _egitmen.TcNo);
                db.command.Parameters.AddWithValue("MaasOdendi", false);

                db.command.ExecuteNonQuery();

                db.connection.Close();
                MessageBox.Show("Kayıt Eklendi","Başarıyla");
                dtgEgitmenList.DataSource = EgitmenListele();

            }
            else if (btnEgitmenEkle.Text == "Egitmen Güncelle")
            {
                _egitmen.Id = Convert.ToInt32(dtgEgitmenList.CurrentRow.Cells[0].Value);
                _egitmen.AdSoyad = txtEgitmenAdi.Text;
                _egitmen.Brans = txtBrans.Text;
                _egitmen.Maas = Convert.ToDecimal(txtMaas.Text);
                _egitmen.TcNo = txtTcNo.Text;


                db.connection.Open();
                
                db.command = new SqlCommand("Update Egitmen set AdSoyad=@AdSoyad,Brans=@Brans, Maas=@Maas,TcNo=@TcNo where Id=@Id", db.connection);

                db.command.Parameters.AddWithValue("Id", _egitmen.Id);
                db.command.Parameters.AddWithValue("AdSoyad", _egitmen.AdSoyad);
                db.command.Parameters.AddWithValue("Brans", _egitmen.Brans);
                db.command.Parameters.AddWithValue("Maas", _egitmen.Maas);
                db.command.Parameters.AddWithValue("TcNo", _egitmen.TcNo);
                
                


                db.command.ExecuteNonQuery();
                db.connection.Close();
                MessageBox.Show("Kayıt Güncellendi");
                dtgEgitmenList.DataSource = EgitmenListele();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        private void dtgEgitmenList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            btnEgitmenEkle.Text = "Egitmen Güncelle";
            
            txtEgitmenAdi.Text = dtgEgitmenList.CurrentRow.Cells[1].Value.ToString();
            txtBrans.Text = dtgEgitmenList.CurrentRow.Cells[2].Value.ToString();
            txtMaas.Text = dtgEgitmenList.CurrentRow.Cells[3].Value.ToString();
            txtTcNo.Text = dtgEgitmenList.CurrentRow.Cells[4].Value.ToString();

            
        }

        private void btnEgitmenSil_Click(object sender, EventArgs e)
        {
            _egitmen.Id = Convert.ToInt32(dtgEgitmenList.CurrentRow.Cells[0].Value);
            _egitmen.AdSoyad = dtgEgitmenList.CurrentRow.Cells[1].Value.ToString();


            db.connection.Open();

            SqlCommand command = new SqlCommand("Delete from Egitmen where Id=@Id", db.connection);
            command.Parameters.AddWithValue("@Id", _egitmen.Id);

            command.ExecuteNonQuery();

            db.connection.Close();
            MessageBox.Show(_egitmen.AdSoyad  +"  İsimli Eğitmen Silindi  ");
            dtgEgitmenList.DataSource = EgitmenListele();

            db.connection.Close();
        }

        private void btnEgitmenTemizle_Click(object sender, EventArgs e)
        {
            txtEgitmenAdi.Text = txtTcNo.Text = txtBrans.Text = txtMaas.Text = "";
            btnEgitmenEkle.Text = "Egitmen Ekle";
            dtgEgitmenList.ClearSelection();
        }
    }
}
