using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___3
{
    internal class Program
    {
        abstract class Sekil
        {
            public String Renk { get; private set; }
            public Sekil(string renk) { Renk = renk; }
            public abstract double AlanHesapla();
            public void bilgi()
            {
                Console.WriteLine("Alan: "+AlanHesapla() + " renk:" + Renk);
            }
        }
        class Daire : Sekil
        {
            private double _cap;
            public Daire(double cap,string Renk) : base(Renk)
            {
                _cap = cap;
            }
            public override double AlanHesapla()
            {
                return _cap * 3.14;
            }
            
        }
        class Kare : Sekil
        {
            private double _kenar;
            public Kare(double kenar,string renk) : base(renk)
            {
                _kenar = kenar;
            }
            public override double AlanHesapla()
            {
                return _kenar * _kenar;
            }

        }
        static void Main(string[] args)
        {
            Daire D1 = new Daire(5, "mavi");
            D1.bilgi();
            Kare K1 = new Kare(10, "siyah");
            K1.bilgi();
        }
    }
}
