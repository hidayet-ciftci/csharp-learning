using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_project
{
    internal class Program
    {
        interface IPrim
        {
            double PrimHesapla();
        }
        interface IGorevlendirilebilir
        {
            void GorevAta(string Gorev);
        }
        abstract class Calisan:IGorevlendirilebilir,IPrim
        {
            public string Ad { get; private set; }
            public string Soyad { get; private set; }
            public double Maas { get; private set; }
            public List<string> Gorevler { get; private set; }
            public Calisan(string ad, string soyad, double maas)
            {
                Ad = ad;
                Soyad = soyad;
                Maas = maas;
                Gorevler = new List<string>();
            }

            public abstract double PrimHesapla();
            public void GorevAta(string Gorev) { Gorevler.Add(Gorev); }
            public void GorevleriListele()
            {
                foreach (string gorev in Gorevler)
                {
                    Console.WriteLine($"gorevler: {gorev}");
                }
            }
            public virtual void BilgiYaz() { Console.WriteLine($"İsim: {Ad} | Soyisim: {Soyad} | Maas: {Maas}"); }
        }
        class TamZamanli : Calisan
        {
            public string Departman { get; private set; }
            public TamZamanli(string ad,string soyad,double maas,string departman):base(ad,soyad,maas)
            {
                Departman = departman;
            }
            public override double PrimHesapla() 
            {
                return (Maas / 100*20);
            }
            public override void BilgiYaz() { Console.WriteLine($"İsim: {Ad} | Soyisim: {Soyad} | Maas: {Maas} | Departman: {Departman}"); }
        }
        class YariZamanli : Calisan
        {
            public double CalismaSaati { get; private set; }
            public YariZamanli(string ad,string soyad,double maas,double calismaSaati):base(ad,soyad,maas)
            {
                CalismaSaati = calismaSaati;
            }
            public override double PrimHesapla()
            {
                return (CalismaSaati * 50);
            }
            public override void BilgiYaz() { Console.WriteLine($"İsim: {Ad} | Soyisim: {Soyad} | Maas: {Maas} | Calisma Saati: {CalismaSaati}"); }
        }
        class Departman
        {
            public string Ad { get;private set;}
            public List<Calisan> Calisanlar { get; private set; }
            public Departman(string ad)
            {
                this.Ad = ad;
                Calisanlar = new List<Calisan>();
            }

            public void CalisanEkle(Calisan c) 
            {
                Calisanlar.Add(c);
                Console.WriteLine("calisan added");
            }
            public void CalisanListele()
            {
                foreach (Calisan calisan in Calisanlar)
                {
                    calisan.BilgiYaz();
                }
            }
            public double ToplamMaasHesapla()
            {
                double toplamMaas = 0;
                foreach (Calisan calisan in Calisanlar)
                {
                    toplamMaas += calisan.Maas;
                }
                return toplamMaas;
            }
        }
        class Sirket
        {
            private List<Departman> departmen;
            public Sirket()
            {
                departmen = new List<Departman>();
            }
            public void DepartmanEkle(Departman d)
            {
                departmen.Add(d);
                Console.WriteLine("departmen added");
            }
            public void TumCalisanlariListele()
            {
                foreach (Departman dep in departmen)
                {
                    dep.CalisanListele();
                }
            }
            public double MaxPrim()
            {
                double max=0;
                foreach (Departman dep in departmen)
                {
                    foreach (Calisan cal in dep.Calisanlar)
                    {
                    
                        if (cal.PrimHesapla() > max) { max = cal.PrimHesapla(); }
                    }
                }
                return max;
            }
            public List<Departman> GetDepartmanlar() 
            {
                return departmen;
            }
        }
        static void Main(string[] args)
        {
            Sirket S1 = new Sirket();
            
            bool exit = true;
            while(exit)
            {
                
                Console.WriteLine("yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1 -> Departman Ekle");
                Console.WriteLine("2 -> Çalışan Ekle (Yarı Zamanlı/Tam Zamanlı)");
                Console.WriteLine("3 -> Tüm Çalışanları Listele");
                Console.WriteLine("4 -> Departman Toplam Maaş Hesapla");
                Console.WriteLine("5 -> Çıkış");
                string option=Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Departman Adı giriniz: ");
                        string depName=Console.ReadLine();
                        S1.DepartmanEkle(new Departman(depName));
                        break;
                    case "2":
                        List<Departman> liste = S1.GetDepartmanlar();
                        if (liste.Count == 0) { Console.WriteLine("hiç departman yok , geri dönülüyor"); break; }
                        Console.WriteLine("Çalışan seçiniz: 1-Tam Zamanlı , 2 - Yarı Zamanlı");
                        string calisnSecimi = Console.ReadLine();
                        if (calisnSecimi == "1") 
                        { 
                            Console.WriteLine("Tam Zamanlı seçtiniz");
                            Console.WriteLine("Departmanı seçiniz:");
                            for (int i = 0; i < liste.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} -> {liste[i].Ad}");
                            }
                            int secim = Convert.ToInt32(Console.ReadLine()) - 1;
                            Console.WriteLine("Sırasıyla Ad soyad Maaş giriniz");
                            string name = Console.ReadLine();
                            string lastname = Console.ReadLine();
                            double salary = Convert.ToDouble(Console.ReadLine());
                            string department = liste[secim].Ad.ToString();
                            TamZamanli T1 = new TamZamanli(name, lastname, salary, department);
                            liste[secim].CalisanEkle(T1);


                        } else if (calisnSecimi == "2") 
                        { 
                            Console.WriteLine("Yarı Zamanlı Seçtiniz");
                            Console.WriteLine("Departmanı seçiniz:");
                            for (int i = 0; i < liste.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} -> {liste[i].Ad}");
                            }
                            int secim = Convert.ToInt32(Console.ReadLine()) - 1;
                            Console.WriteLine("Sırasıyla Ad, soyad, Maaş, saatlikÜcreti giriniz");
                            string name = Console.ReadLine();
                            string lastname = Console.ReadLine();
                            double salary = Convert.ToDouble(Console.ReadLine());
                            int calismaSaati = Convert.ToInt32(Console.ReadLine());
                            YariZamanli Y1 = new YariZamanli(name, lastname, salary, calismaSaati);
                            liste[secim].CalisanEkle(Y1);
                        } else { Console.WriteLine("Yanlış seçim yaptınız"); }
                        break;
                    case "3": S1.TumCalisanlariListele();
                        break;
                    case "4":
                        List<Departman> liste1 = S1.GetDepartmanlar();
                        Console.WriteLine("Departmanı seçiniz:");
                        for (int i = 0; i < liste1.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} -> {liste1[i].Ad}");
                        }
                        int secim1 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Toplam Maaş: "+liste1[secim1].ToplamMaasHesapla());
                        break;
                    case "5":
                        Console.WriteLine("Çıkış yapılıyor");
                        exit = false;
                        break;
                    default: Console.WriteLine("Yanlış Tuşlama yaptınız tekrar seçiniz.");
                        break;
                }
            }
            Console.WriteLine("Max prim: "+S1.MaxPrim());
        }
    }
}
