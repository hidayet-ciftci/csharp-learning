using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___2
{
    internal class Program
    {
        class Hayvan 
        {
            public string Ad { get; set; }
            public int Yas { get; set; }

            public Hayvan(string ad, int yas)
            {
                Ad = ad;
                Yas = yas;
            }

            public void BilgiYaz()
            {
                Console.WriteLine($"{Ad}, {Yas} yaşında");
            }
        }

        class Kedi : Hayvan  // Hayvan'dan miras alır
        {
            public string TuyRengi { get; set; }

            public Kedi(string ad, int yas, string tuyRengi)
                : base(ad, yas)  // Hayvan'ın constructor'ını çağırır
            {
                TuyRengi = tuyRengi;
            }

            public void Miyavla() => Console.WriteLine("Miyav!");
        }
        static void Main(string[] args)
        {
            Kedi k = new Kedi("Tekir", 3, "Gri");
            k.BilgiYaz();  
            k.Miyavla();
        }
    }
}
