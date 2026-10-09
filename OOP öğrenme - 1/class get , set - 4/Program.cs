using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_get___set___4
{
    internal class Program
    {
        class BankaHesabi
        {
            private double _bakiye;

            public string SahibiAdi { get; set; }

            public double Bakiye
            {
                get { return _bakiye; }
                private set  // sadece sınıf içinden değiştirilebilir
                {
                    if (value < 0)
                        Console.WriteLine("Hata: Bakiye negatif olamaz!");
                    else
                        _bakiye = value;
                }
            }

            public BankaHesabi(string ad, double baslangicBakiye)
            {
                SahibiAdi = ad;
                Bakiye = baslangicBakiye;
            }

            public void ParaYatir(double miktar)
            {
                if (miktar <= 0) { Console.WriteLine("Geçersiz miktar!"); return; }
                Bakiye += miktar;
                Console.WriteLine($"{miktar} TL yatırıldı. Yeni bakiye: {Bakiye}");
            }

            public void ParaCek(double miktar)
            {
                if (miktar > Bakiye)
                    Console.WriteLine("Yetersiz bakiye!");
                else
                {
                    Bakiye -= miktar;
                    Console.WriteLine($"{miktar} TL çekildi. Yeni bakiye: {Bakiye}");
                }
            }
        }
        static void Main(string[] args)
        {
            BankaHesabi BH1 = new BankaHesabi("ahmet", 5000);
            Console.WriteLine(BH1.Bakiye);
            BH1.ParaYatir(1000);
            BH1.ParaCek(2000);
        }
    }
}
