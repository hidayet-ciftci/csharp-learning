using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace interface___3
{
    internal class Program
    {
        interface IA { void Metot(); }
        interface IB { void Metot(); }

        class C : IA, IB
        {
            // Tek implement yeterli — her ikisini de karşılar
            public void Metot() => Console.WriteLine("Çalıştı!");
        }

        // Ama ayrı ayrı implement etmek istersen:
        class D : IA, IB
        {
            void IA.Metot() => Console.WriteLine("IA'dan!");  // explicit
            void IB.Metot() => Console.WriteLine("IB'den!");  // explicit
        }

        // --------------------------------------------------------------------------------------------------------------------
        interface IKayitEdilebilir { void Kaydet(); }
        interface IYazdirilebilir { void Yazdir(); }
        interface ISilinebilir { void Sil(); }

        // Fatura hem kaydedilebilir hem yazdırılabilir hem silinebilir
        class Fatura : IKayitEdilebilir, IYazdirilebilir, ISilinebilir
        {
            public void Kaydet() => Console.WriteLine("Fatura kaydedildi.");
            public void Yazdir() => Console.WriteLine("Fatura yazdırıldı.");
            public void Sil() => Console.WriteLine("Fatura silindi.");
        }

        // Rapor sadece kaydedilebilir ve yazdırılabilir
        class Rapor : IKayitEdilebilir, IYazdirilebilir
        {
            public void Kaydet() => Console.WriteLine("Rapor kaydedildi.");
            public void Yazdir() => Console.WriteLine("Rapor yazdırıldı.");
        }
        static void Main(string[] args)
        {
            // ### Özet:
            // Bir class    →  birden fazla interface implement edebilir
            // Bir interface →  başka interface'den miras alabilir
            // Çakışan metot →  tek implement yeterli, ya da explicit ile ayırt edilir
            D d = new D();
            ((IA)d).Metot();  // IA'dan!
            ((IB)d).Metot();  // IB'den!
            Fatura F = new Fatura();
            F.Kaydet();
            F.Yazdir();
            F.Sil();
            Rapor R = new Rapor();
            R.Kaydet();
            R.Yazdir();
            // hata -> R.Sil();
        }
    }
}
