using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using KursOtomasyonu.Models;

namespace KursOtomasyonu
{
    public partial class KursiyerDevamsizlik : Form
    {
        Baglanti db = new Baglanti();
        int _Id;
        public KursiyerDevamsizlik()
        {
            InitializeComponent();
        }

        private void KursiyerDevamsizlik_Load(object sender, EventArgs e)
        {
            db.connection.Open();

            db.command = new SqlCommand("Select *From Kursiyer",db.connection);
            db.reader = db.command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(db.reader);
            dt.Columns.Add("KursiyerNoVeName", typeof(string), "KursiyerNo + ' - ' + AdSoyad");
            db.connection.Close();

            

            cmbKursiyer.DataSource = dt.DefaultView;
            cmbKursiyer.DisplayMember = "KursiyerNoVeName";
            cmbKursiyer.ValueMember = "Id";
            int.TryParse(cmbKursiyer.SelectedValue.ToString(), out _Id);
        }



        private void cmbKursiyerAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbKursiyer.SelectedValue.ToString(), out _Id);
            KursiyerListele(_Id);
            //select COUNT(*) AS 'GUN' from Devamsizlik d left join Kursiyer k on d.KursiyerId = k.Id where d.KursiyerId = 1
            db.connection.Open();
            db.command = new SqlCommand("select COUNT(*) AS 'GUN' from Devamsizlik d left join Kursiyer k on d.KursiyerId = k.Id where d.KursiyerId = @kId", db.connection);
            db.command.Parameters.AddWithValue("kId", _Id);
            db.reader = db.command.ExecuteReader();
            while (db.reader.Read())
            {
                lblDevamsizlikSayisi.Text = db.reader["GUN"].ToString();
            }
       
            db.connection.Close();
        }


        private void btnDevamsizlikEkle_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            db.command = new SqlCommand("Insert Into Devamsizlik values (@KursiyerId,@DevamsizlikTarihi)",db.connection);

            db.command.Parameters.AddWithValue("KursiyerId", _Id);
            db.command.Parameters.AddWithValue("DevamsizlikTarihi", dateTimePicker1.Value);
            db.command.ExecuteNonQuery();
            db.connection.Close();
            dateTimePicker1.Value = DateTime.Now;
            KursiyerListele(_Id);
        }

        private void KursiyerListele(int kId)
        {
            kId = _Id;
            db.connection.Open();
            db.command = new SqlCommand("select d.Id,d.KursiyerId,k.AdSoyad,d.DevamsizlikTarihi from Devamsizlik d left join Kursiyer k on d.KursiyerId=k.Id where d.KursiyerId=@kId", db.connection);
            db.command.Parameters.AddWithValue("kId", kId);
            db.reader = db.command.ExecuteReader();

            List<Devamsizlik> devamsizlikList = new List<Devamsizlik>();

            while (db.reader.Read())
            {
                Devamsizlik devamsizlik = new Devamsizlik();

                devamsizlik.Id = Convert.ToInt32(db.reader["Id"]);
                devamsizlik.KursiyerId = Convert.ToInt32(db.reader["KursiyerId"]);
                devamsizlik.KursiyerAd = db.reader["AdSoyad"].ToString();
                devamsizlik.DevamsizlikTarihi = Convert.ToDateTime(db.reader["DevamsizlikTarihi"]);

                devamsizlikList.Add(devamsizlik);

            }
            dtgDevamsizlikList.DataSource = devamsizlikList;
            db.connection.Close();


           
            

        }
    }
}
