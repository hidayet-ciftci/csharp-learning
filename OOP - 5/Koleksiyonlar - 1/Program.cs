using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar___1
{
    internal class Program
    {
        class Ogrenci
        {
            public string Ad { get; set; }
            public double Not { get; set; }

            public Ogrenci(string ad, double not)
            {
                Ad = ad;
                Not = not;
            }
        }
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();
            // Eleman ekleme
            isimler.Add("Ali");
            isimler.Add("Ayşe");
            isimler.Add("Veli");

            // isimler.Add(5); error çünkü string List -> tip belirtilmeli ve farklı tip eklenmez.
            // var isimler = new ArrayList(); -> bu kullanılırsa ArrayList , o zaman farklı tipler eklenebilir.

            // Eleman silme
            isimler.Remove("Veli");

            // Index ile erişim
            Console.WriteLine(isimler[0]);  // Ali

            // Kaç eleman var
            Console.WriteLine(isimler.Count);  // 2

            // İçinde var mı?
            Console.WriteLine(isimler.Contains("Ali"));  // true

            // Foreach ile gez
            foreach (string isim in isimler)
                Console.WriteLine(isim);
            //--------------------------------------------------------------------------------------------------------------

            List<Ogrenci> ogrenciler = new List<Ogrenci>(); // Ogrenci Class tipinde liste oluşturma

            ogrenciler.Add(new Ogrenci("Ali", 75));
            ogrenciler.Add(new Ogrenci("Ayşe", 90));
            ogrenciler.Add(new Ogrenci("Veli", 60));

            // 70 üstü geçenleri yazdır
            foreach (Ogrenci o in ogrenciler)
            {
                if (o.Not >= 70)
                    Console.WriteLine($"{o.Ad}: {o.Not}");
            }
            // Ali: 75
            // Ayşe: 90
        }
    }
}
