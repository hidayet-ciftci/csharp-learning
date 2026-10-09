using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface___ref___2
{
    internal class Program
    {
        interface IUcabilir
        {
            void Havalan();
        }

        class Buyucu : IUcabilir
        {
            public void BuyuYap() => Console.WriteLine("Büyü yapıyorum!");
            public void Havalan() => Console.WriteLine("Süpürgeyle uçuyorum!");
        }

        class Ejderha : IUcabilir
        {
            public void Havalan() => Console.WriteLine("Kanatlarımla uçuyorum!");
        }

  
        static void Main(string[] args)
        {
            // Interface tipiyle farklı nesneleri tutabilirsin
            IUcabilir u1 = new Buyucu();
            IUcabilir u2 = new Ejderha();

            u1.Havalan();  // Süpürgeyle uçuyorum!
            // u1.BuyuYap();  // ❌ HATA! buyucunun kendi özelliğinde olsa bile interface'de yok, erişemezsin  
            // bu duruma işte referans ile interface 'lere erişme denir.
            u2.Havalan();  // Kanatlarımla uçuyorum!

            List<IUcabilir> ucabilenler = new List<IUcabilir>
            {
                new Buyucu(),
                new Ejderha(),
                new Buyucu(),
            };

            foreach (IUcabilir nesne in ucabilenler)
            {
                nesne.Havalan();  // herkes kendi şekilde uçuyor
            }
            // Kritik nokta — sadece interface metotlarına erişebilirsin:
            // nesne.BuyuYap();  // ❌ HATA! buyucunun kendi özelliğinde olsa bile interface'de yok, erişemezsin  
        }
    }
}
