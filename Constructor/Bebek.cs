using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bebek
    {
        public DateTime DoğumTarihi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }


         // ilk olarak default Constructor yazıyoruz
         public Bebek()
        {
            DoğumTarihi = DateTime.Now;
            Console.WriteLine("Ingaa");
        }

        //Diğer Constructor
        public Bebek (string ad, string soyad)
        {
            // Konsola "Ingaaaa" yazdır
            Console.WriteLine("Ingaaaa");
            // Parametreleri property'lere ata
            Ad = ad;
            Soyad = soyad;
            // Doğum Tarihini o anki tarih olarak ata
            DoğumTarihi = DateTime.Now;
        }

        public void Yazdırma()
        {
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("Doğum Tarihi: " + DoğumTarihi.ToShortDateString());
        }




    }
}
