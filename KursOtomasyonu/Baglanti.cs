using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursOtomasyonu
{
   public class Baglanti
    {
        public SqlConnection connection = new SqlConnection(@"Data source=MRCARRASCO\MRCARRASCO;initial catalog=kursdb;integrated Security=True;");
        public SqlCommand command;
        public SqlDataReader reader;
    }
}
