using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // CLASS — adres kopyalanır
        class NoktaClass
        {
            public int X { get; set; }
        }


        // STRUCT — değer kopyalanır
        struct NektaStruct
        {
            public int X { get; set; }
        }


        static void Main(string[] args)
        {

            NoktaClass n1 = new NoktaClass { X = 5 };
            NoktaClass n2 = n1;  // aynı nesneyi gösteriyor!
            n2.X = 10;
            Console.WriteLine(n1.X);  // 10 — n1 de değişti!


            NektaStruct s1 = new NektaStruct { X = 5 };
            NektaStruct s2 = s1;  // değer kopyalandı, bağımsız!
            s2.X = 10;
            Console.WriteLine(s1.X);  // 5 — s1 değişmedi!

            // ❌ parametresiz constructor yazamazsın (C# 9 ve öncesi)
            // ✓ parametreli constructor olabilir
            // ❌ inheritance yapamaz
            // struct Nokta3D : Nokta { }  // HATA!
            // ✓ interface implement edebilir
        }
    }
}
