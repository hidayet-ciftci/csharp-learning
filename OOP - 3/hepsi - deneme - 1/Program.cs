using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hepsi___deneme___1
{
    internal class Program
    {
        interface IKonusabilir { void Konus(); }         // sözleşme

        abstract class Hayvan                             // yarı dolu taslak
        {
            private string _ad;                           // encapsulation
            public string Ad => _ad;                      // kontrollü erişim

            public Hayvan(string ad) { _ad = ad; }

            public abstract void SesCikar();              // boş — child dolduracak
            public void Nefes() => Console.WriteLine("Nefes alıyor"); // dolu
        }

        class Kedi : Hayvan, IKonusabilir                // inheritance + interface
        {
            public Kedi(string ad) : base(ad) { }

            public override void SesCikar()              // polymorphism
                => Console.WriteLine("Miyav!");

            public void Konus()                          // interface implement
                => Console.WriteLine("Ben bir kediyim!");
        }
        static void Main(string[] args)
        {
        }
    }
}
