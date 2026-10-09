using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyon_ve_Class___1
{
    internal class Program
    {
        class Okul
        {
            public string Ad { get; private set; }
            private List<Ogrenci> _ogrenciler;  // sınıf içinde koleksiyon

            public Okul(string ad)
            {
                Ad = ad;
                _ogrenciler = new List<Ogrenci>();  // constructor'da başlat
            }

            public void OgrenciEkle(Ogrenci ogrenci)
            {
                _ogrenciler.Add(ogrenci);
                Console.WriteLine($"{ogrenci.Ad} eklendi.");
            }

            public void OgrenciCikar(Ogrenci ogrenci)
            {
                _ogrenciler.Remove(ogrenci);
            }

            public void ListeYaz()
            {
                foreach (Ogrenci o in _ogrenciler)
                    Console.WriteLine($"{o.Ad} - {o.Not}");
            }
        }

        class Ogrenci
        {
            public string Ad { get; private set; }
            public double Not { get; private set; }

            public Ogrenci(string ad, double not)
            {
                Ad = ad;
                Not = not;
            }
        }
        static void Main(string[] args)
        {
            // Kullanım
            Okul okul = new Okul("Ankara Lisesi");
            okul.OgrenciEkle(new Ogrenci("Ali", 75));
            okul.OgrenciEkle(new Ogrenci("Ayşe", 90));
            okul.ListeYaz();
            // Ali - 75
            // Ayşe - 90
        }
    }
}
