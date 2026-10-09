using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_handling
{
    internal class Program
    {
        class BankaHesabi
        {
            private double _bakiye;

            public BankaHesabi(double bakiye)
            {
                if (bakiye < 0)
                    throw new ArgumentException("Başlangıç bakiyesi negatif olamaz!");

                _bakiye = bakiye;
            }

            public void ParaCek(double miktar)
            {
                if (miktar > _bakiye)
                    throw new InvalidOperationException("Yetersiz bakiye!");

                _bakiye -= miktar;
            }
        }

        // kendi hata class'ını yazabilirsin
        class YetersizBakiyeException : Exception
        {
            public double Bakiye { get; private set; }

            public YetersizBakiyeException(double bakiye)
                : base($"Yetersiz bakiye! Mevcut: {bakiye} TL")
            {
                Bakiye = bakiye;
            }
        }

        // kullanım
        class BankaHesabi1
        {
            private double _bakiye = 500;

            public void ParaCek(double miktar)
            {
                if (miktar > _bakiye)
                    throw new YetersizBakiyeException(_bakiye);

                _bakiye -= miktar;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int[] dizi = new int[3];
                dizi[10] = 5;  // IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Dizi sınırı aşıldı!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Sıfıra bölme hatası!");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null nesneye erişim!");
            }
            catch (Exception e)  // diğer tüm hatalar — en sona yazılır
            {
                Console.WriteLine($"Beklenmedik hata: {e.Message}");
            }
            // Exception en geniş — tüm hataları yakalar. Spesifik hatalar önce yazılır, genel olan en sona.
            // --------------------------------------------------------------------------------------------------------

            try
            {
                BankaHesabi hesap = new BankaHesabi(1000);
                hesap.ParaCek(2000);  // hata fırlatır ,  hata fırlatma exception ve throw örneği
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"İşlem hatası: {e.Message}");
            }

            //----------------------------------------------------------------------------------------------------------

            try
            {
                BankaHesabi1 hesap = new BankaHesabi1(); // custom exception ile error handle etme , class'a exception atıyoruz.
                hesap.ParaCek(1000);
            }
            catch (YetersizBakiyeException e)
            {
                Console.WriteLine(e.Message);        // Yetersiz bakiye! Mevcut: 500 TL
                Console.WriteLine($"Bakiye: {e.Bakiye}");  // Bakiye: 500
            }
        }

    }
}
