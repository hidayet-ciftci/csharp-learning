using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_öğrenme___1
{
    internal class Program
    {
        class Student
        {
            public string name="Ali";
            public float midterm=0;
            public float final=100;
            public float Calc(float final, float midterm)
            {
                float score = ((final / 10) * 6) + ((midterm / 10) * 4);
                return score;
            }
            public void Show() {
                Console.WriteLine(name + " " + Calc(final,midterm));
            }
        }
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.Show();
        }
        
    }
}
