using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Birinci");
            stack.Push("İkinci");
            stack.Push("Üçüncü");

            Console.WriteLine(stack.Pop());   // Üçüncü — son giren çıkar
            Console.WriteLine(stack.Peek());  // İkinci  — çıkarmadan bak
            Console.WriteLine(stack.Count);   // 2
        }
    }
}
