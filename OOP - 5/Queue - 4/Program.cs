using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue___4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Birinci");
            queue.Enqueue("İkinci");
            queue.Enqueue("Üçüncü");

            Console.WriteLine(queue.Dequeue());  // Birinci — ilk giren çıkar
            Console.WriteLine(queue.Peek());     // İkinci   — çıkarmadan bak
            Console.WriteLine(queue.Count);      // 2
        }
    }
}
