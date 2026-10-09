using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_kopyalama
{
    internal class Program
    {
        class Araba
        {
            public string Marka { get; set; }
        }

        static void Main(string[] args)
        {
            int a = 5;
            int b = a;  // kopyalandı

            b = 10;

            Console.WriteLine(a);  // 5 — değişmedi
            Console.WriteLine(b);  // 10
            // ----------------------------------------------------------

             Araba a1 = new Araba();
             a1.Marka = "Toyota";
             Araba a2 = a1;  // adres kopyalandı, aynı nesneyi gösteriyor!
             a2.Marka = "BMW";
             Console.WriteLine(a1.Marka);  // BMW — a1 de değişti!
             Console.WriteLine(a2.Marka);  // BMW
            // `a2 = a1` deyince nesne kopyalanmaz, **aynı nesnenin adresi * *kopyalanır.İkisi aynı nesneyi gösterir.
            // Değer tipi:
            // a → [5]
            // b → [5]   // ayrı kutu
            // Referans tipi:
            // a1 → [0x001]  ──→  { Marka: "BMW" }
            // a2 → [0x001]  ──↗  // aynı kutuyu gösteriyor
        }
    }
}
