using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___4
{
    internal class Program
    {
        class Ogrenci : IComparable<Ogrenci>
        {
            public string Ad { get; private set; }
            public double Note { get; private set; }

            public Ogrenci(string ad, double not)
            {
                Ad = ad;
                Note = not;
            }

            // IComparable zorunlu kılar — küçük/büyük karşılaştırma
            public int CompareTo(Ogrenci other)
            {
                return this.Note.CompareTo(other.Note); // nota göre sırala 
            }
        }


        static void Main(string[] args)
            {
                List<Ogrenci> ogrenciler = new List<Ogrenci>
            {
                new Ogrenci("Ali", 75),
                new Ogrenci("Ayşe", 90),
                new Ogrenci("Veli", 60)
            };

            ogrenciler.Sort(); // IComparable olmadan bu çalışmaz!
            
            
            foreach (Ogrenci o in ogrenciler)
                Console.WriteLine($"{o.Ad}: {o.Note}");

            // Veli: 60
            // Ali: 75
            // Ayşe: 90
        }
    }
}
