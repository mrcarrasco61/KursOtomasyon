using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursOtomasyonu
{
   public class Baglanti
    {
        public SqlConnection connection = new SqlConnection("Data source=MRCARRASCO\\MRCARRASCO;initial catalog=kursdb;integrated Security=True;");
        public SqlCommand command;
        public SqlDataReader reader;

        public void girisyap(string ad, string sifre,Form frm )
        {
            command = new SqlCommand("Select *From Admin where KullaniciAdi='" + ad + "' and Sifre='" + sifre + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                
            }
            
            else
            {
                MessageBox.Show("HATALI GİRİŞ!");
            }

            connection.Close();
            command.Dispose();
        }

    }


}
