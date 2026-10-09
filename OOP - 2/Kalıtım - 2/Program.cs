using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım___2
{
    internal class Program
    {
        class Calisan
        {
            private string _ad;
            private double _maas;

            public string Ad => _ad;        // sadece okunabilir
            public double Maas => _maas;    // sadece okunabilir

            public Calisan(string ad, double maas)
            {
                _ad = ad;
                _maas = maas;
            }

            public virtual void BilgiYaz()
            {
                Console.WriteLine($"Ad: {_ad} | Maaş: {_maas} TL");
            }
        }

        class Muhendis : Calisan
        {
            private string _uzmanlik;

            public Muhendis(string ad, double maas, string uzmanlik)
                : base(ad, maas)        // private _ad ve _maas'a base ile erişiyoruz
            {
                _uzmanlik = uzmanlik;   // sadece Muhendis'e özel
            }

            public override void BilgiYaz()
            {
                base.BilgiYaz();        // Calisan'ın BilgiYaz'ını çalıştır
                Console.WriteLine($"Uzmanlık: {_uzmanlik}");
            }
        }

        class Mudur : Calisan
        {
            private int _ekipSayisi;

            public Mudur(string ad, double maas, int ekipSayisi)
                : base(ad, maas)
            {
                _ekipSayisi = ekipSayisi;
            }

            public override void BilgiYaz()
            {
                base.BilgiYaz();
                Console.WriteLine($"Ekip Sayısı: {_ekipSayisi}");
            }
        }
        static void Main(string[] args)
        {
            Muhendis m = new Muhendis("Ali", 50000, "Backend");
            Mudur md = new Mudur("Ayşe", 80000, 10);

            m.BilgiYaz();
            // Ad: Ali | Maaş: 50000 TL
            // Uzmanlık: Backend
            Console.WriteLine(m.Ad + " " + m.Maas);
            md.BilgiYaz();
            // Ad: Ayşe | Maaş: 80000 TL
            // Ekip Sayısı: 10
        }
    }
}
