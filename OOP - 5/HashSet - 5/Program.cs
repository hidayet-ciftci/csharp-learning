using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Ali");
            set.Add("Ayşe");
            set.Add("Ali");  // tekrar — eklenmez!

            Console.WriteLine(set.Count);  // 2, Ali bir kez var

            foreach (string s in set)
                Console.WriteLine(s);
        }
    }
}
