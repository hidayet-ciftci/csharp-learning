using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___2
{
    internal class Program
    {
        class Employee
        {
            public string name;
            public int socialNum;
            public float Wage;
            public int Hours;
            public void displayInfo() 
            {
                Console.WriteLine(name + " " + socialNum);
            }
            public void displaySalary()
            {
                Console.WriteLine("Salary= "+Wage * Hours);
            }
        }
        static void Main(string[] args)
        {
            Employee E1 = new Employee();
            E1.name = "ahmet";
            E1.socialNum = 12345;
            E1.Wage = 10;
            E1.Hours = 8;
            E1.displayInfo();
            E1.displaySalary();
            Employee E2 = new Employee();
            Console.WriteLine("name");
            E2.name = Console.ReadLine();
            Console.WriteLine("socialNum");
            E2.socialNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Wage");
            E2.Wage = float.Parse(Console.ReadLine());
            Console.WriteLine("hours");
            E2.Hours = int.Parse(Console.ReadLine());
            E2.displayInfo();
            E2.displaySalary();
        }
    }
}
