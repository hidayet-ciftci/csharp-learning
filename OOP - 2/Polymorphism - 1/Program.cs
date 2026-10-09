using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism___1
{
    internal class Program
    {
        class Sekil
        {
            public string Color { get; private set; } // dışarıdan değişirilemez sadece read.
            public Sekil(string Color)
            {
                this.Color = Color;
            }
            public virtual double alanHesapla()
            {
                Console.WriteLine(Color);
                return 0;
            }
        }
        class Daire:Sekil
        {
            private double cap;
            public Daire(double Cap,string color): base(color)
            {
                cap = Cap;
            }
            public override double alanHesapla()
            {
                Console.WriteLine(Color);
                return cap*3.14;
            }
        }
        class Kare:Sekil
        {
            private double kenar;
            public Kare(double Kenar,string color) : base(color)
            {
                kenar = Kenar;
            }
            public override double alanHesapla()
            {
                Console.WriteLine(Color);
                return kenar * kenar;
            }
        }
        class Dikdortgen : Sekil
        {
            private double en;
            private double boy;
            public Dikdortgen(double En,double Boy, string color) : base(color)
            {
                en = En;
                boy = Boy;
            }
            public override double alanHesapla()
            {
                Console.WriteLine(Color);
                return en * boy;
            }
        }
        static void Main(string[] args)
        {
            //sekil s1 = new sekil("blue");
            //Console.WriteLine(s1.alanHesapla());
            //daire d1 = new daire(10,"red");
            //Console.WriteLine(d1.alanHesapla());
            //kare k1 = new kare(5, "green");
            //Console.WriteLine(k1.alanHesapla());
            //dikdortgen dd1 = new dikdortgen(5, 10, "black");
            //Console.WriteLine(dd1.alanHesapla());

            List<Sekil> sekiller = new List<Sekil>
            {
                new Daire(20,"siyah"),
                new Kare(10,"mavi"),
                new Dikdortgen(5,3,"yesil"),
                new Sekil("beyaz"),
            };
            foreach (Sekil sinif in sekiller)
            {
                Console.WriteLine(sinif.alanHesapla());
            }

        }
    }
}
