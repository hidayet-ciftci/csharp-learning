using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> yaslar = new Dictionary<string, int>();

            // Ekleme
            yaslar.Add("Ali", 25);
            yaslar.Add("Ayşe", 30);
            yaslar["Veli"] = 28;  // alternatif ekleme
            // key value -> durumu
            // Erişim
            Console.WriteLine(yaslar["Ali"]);  // 25

            // Var mı kontrolü
            if (yaslar.ContainsKey("Ayşe"))
                Console.WriteLine("Ayşe var!");

            // Foreach ile gez
            foreach (KeyValuePair<string, int> kvp in yaslar)
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

            // Ali: 25
            // Ayşe: 30
            // Veli: 28
        }
    }
}
