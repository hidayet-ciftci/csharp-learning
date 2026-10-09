using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface__1
{
    internal class Program
    {

        // 1. INTERFACE (Sertifika - Sadece kural var, kod yok, "Ne yapabilir?")
        public interface IUcabilir
        {
            int UcusHizi { get; } // Özellik (Attribute) kuralı
            void Havalan();            // Davranış (Behavior) kuralı
        }

        public abstract class Karakter
        {
            public string Isim { get; private set; } 

            public Karakter(string isim) 
            {
                Isim = isim;
            }
            public void  KendiniTanit()
            {
            Console.WriteLine($"Selam, benim adım {Isim}.");
            }
            public abstract void Saldir();
        }

        // Büyücü bir Karakterdir (Kan bağı) VE Uçabilir (Sertifika aldı)
        public class Buyucu : Karakter, IUcabilir
        {
            // Interface'den gelen kuralları mecbur uyguluyoruz:
            public int UcusHizi { get; private set; }
            
            public Buyucu(string isim,int hiz):base(isim)
            {
                UcusHizi = hiz;
            }
            public void Havalan()
            {
                Console.WriteLine("Süpürgemle havalanıyorum! Hızım: " + UcusHizi);
            }
            public override void Saldir()
            {
                Console.WriteLine("Büyücü ateş topu fırlattı! Fiyuuuv!");
            }
        }

        static void Main(string[] args)
        {
            Buyucu B1 = new Buyucu("gandalf", 50);
            B1.KendiniTanit();
            B1.Havalan();
            B1.Saldir();
        }
    }
}
