using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursOtomasyonu.Models
{
    public class Kurs
    {
        public int Id { get; set; }

        public string Adı { get; set; }

        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }

        public DateTime EklenmeTarihi { get; set; }



    }
}
