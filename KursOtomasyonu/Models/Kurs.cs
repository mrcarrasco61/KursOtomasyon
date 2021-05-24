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

        public string Adi { get; set; }

        public DateTime BaslangicSaati { get; set; }

        public DateTime BitisSaati { get; set; }

        public int EgitmenId { get; set; }

        public decimal Fiyat { get; set; }


    }
}
