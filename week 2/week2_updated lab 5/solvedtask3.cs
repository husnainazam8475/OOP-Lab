using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class solvedtask3
    {
        class student
        {
            public string name;
            public student(string n)
            {
                name = n;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                student s = new student("alishbah");
                Console.WriteLine(s.name);
            }
        }
    }
}

