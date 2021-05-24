using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static iTextSharp.text.Font;
using KursOtomasyonu.Models;
using System.Data.SqlClient;

namespace KursOtomasyonu
{
    public partial class Sertifikafrm : Form
    {
        Baglanti db = new Baglanti();
        public Sertifikafrm()
        {
            InitializeComponent();
        }
        string ogrenciIsmi = "";
        string kursAdi = "";

        string ogrno = "";
        private void button1_Click(object sender, EventArgs e)
        {
            BaseFont haveltica_turkish = BaseFont.CreateFont("Helvetica", "CP1254", BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontnormal8 = new iTextSharp.text.Font(haveltica_turkish, 8, iTextSharp.text.Font.NORMAL);

            string yazilacakText;
            yazilacakText = ogrenciIsmi + " isimli ogrenci, " + kursAdi + " isimli bunyemizde bulunan kurstan başarıyla mezun olmuştur.";

            PdfPTable pdfPTable = new PdfPTable(1);
            pdfPTable.DefaultCell.BorderWidth = 0;
            pdfPTable.WidthPercentage = 80;
            pdfPTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            Chunk c0 = new Chunk(yazilacakText, fontnormal8);
            Phrase p0 = new Phrase();
            p0.Add(c0);
            pdfPTable.AddCell(p0);

            string strFileName = ogrenciIsmi + kursAdi + ogrno+".pdf";
            string folderPath = @"C:\sertifika\" + strFileName;

            using (FileStream stream = new FileStream(folderPath,FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                #region PAGE-1
                pdfDoc.Add(pdfPTable);
                #endregion

                pdfDoc.Close();
                stream.Close();
            }
        }

        private void Sertifikafrm_Load(object sender, EventArgs e)
        {
            KursAtamaListele();
        }
        
        private void KursAtamaListele()
        {
            db.connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select kr.Id,kr.AdSoyad,ku.Adi,kr.KursiyerNo from Kursiyer kr left join Kurs ku on kr.KursId=ku.Id where kr.KursId <> 0", db.connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            db.connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            ogrenciIsmi = label1.Text;
            kursAdi = label2.Text;
            ogrno = label3.Text;
        }
    }
}
