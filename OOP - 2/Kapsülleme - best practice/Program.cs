using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme___best_practice
{
    internal class Program
    {
        class Abc
        {
           
            // private double deger = 55;
            // public double getDeger() { return deger; }

            // public double getDeger2 => deger;  bu da getDeger2 metodu -> deger private olan double döndürür.
            // public double getDeger3() => deger; bu da getDeger3 fonksiyon gibimsi metod -> bu da aynı deger'i döndürür.

            public void setDeger(double sayi) { deger = sayi; }
            // ------------

            private double _deger = 50;
            public double deger 
            { 
                get { return _deger; }
                set
                {
                    _deger = value;
                }
            }
        }


        static void Main(string[] args)
        {
            Abc A1 = new Abc();
            Console.WriteLine(A1.deger);
            A1.deger = 20;
            Console.WriteLine(A1.deger);


        }
    }
}
