using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class solvedtask4
    {
        
    class student
        {
            public string name;
            public student(string n)
            {
                name = n;
            }
            public student(student s)
            {
                name = s.name;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                student s1 = new student("Hasnain");
                student s2 = new student("s1");
                s2.name = "Abdullah";
                Console.WriteLine(s1.name);
                Console.WriteLine(s2.name);
            }
        }
    }
}

