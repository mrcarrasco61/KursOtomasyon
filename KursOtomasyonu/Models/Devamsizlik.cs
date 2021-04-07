using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursOtomasyonu.Models
{
     public class Devamsizlik
    {
        public int Id { get; set; }

        public int KursiyerId { get; set; }

        public string KursiyerAd { get; set; }
        public DateTime DevamsizlikTarihi { get; set; }

    }
}
