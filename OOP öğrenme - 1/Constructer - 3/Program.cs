using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer___3
{
    internal class Program
    {
        class Student
        {
            private int id;
            private String name;
            private int age;
            public void info()
            {
                Console.WriteLine(id + " " + name+ " " + age);
            }
            public Student ()
            {
                id = 100;
                name = "mehmet";
                age = 18;
            }
            public Student(int id, String Name, int age)
            {
                this.id = id;
                this.name = Name;
                this.age = age;
            }
        }

        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.info();
            Student S2 = new Student(200, "ahmet", 25);
            S2.info();
        }
    }
}
