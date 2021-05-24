using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursOtomasyonu.Models
{
    public class Kursiyer
    {
        public int Id { get; set; }

        public string KursiyerNo { get; set; }

        public string TcNo { get; set; }
        public string AdSoyad { get; set; }

        public string TelNo { get; set; }

        public DateTime KayitTarihi { get; set; }

        public string Adres { get; set; }

        public int KursId { get; set; }
        public bool UcretOdendi { get; set; }
    }
}
