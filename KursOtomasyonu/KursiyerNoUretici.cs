using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursOtomasyonu
{
    
    public class KursiyerNoUretici
    {
        //public long KursiyerNo { get { return _KulakNoUret(); } set { KursiyerNo = value; } }
        public long KursiyerNo;

        
        /// Bu methodda ilk olarak Random sınıfının içindeki Next methodu içine 999999999 yazdım
        /// bu sayede max değerini verdim (min değer = 0)
        /// Sonra DateTime sınıfını kullanarak şuanki bilgisayar saatini aldım ardından
        /// Substract methodu ile içindeki en küçük salise değerini de çıkardım ve TotalSeconds
        /// kullanarak zamana göre değişen double tipinde bir sayı elde ettim
        /// Sonra bu ürettiğin 2 sayıyı long tipine çevirip 2 ile çarparak Kursiyer No ürettim
        /// bunu da methodun dönüş değerine yazdım
        /// Sonra Sınıfın yapıcı methodunu kullanarak KursiyerNo propertisine atadım.
        
        private long _KursiyerNoUret()
        {
            Random r = new Random();
            int number = r.Next(999999999);
            double number2 = DateTime.Now.Subtract(DateTime.MinValue).TotalSeconds;
            long sonuc = Convert.ToInt64(number2) * Convert.ToInt64(2) + Convert.ToInt64(number);
            return sonuc;
        }

        public KursiyerNoUretici()
        {
            KursiyerNo = _KursiyerNoUret();
        }

    }
}
