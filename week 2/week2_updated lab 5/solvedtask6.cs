using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class solvedtask6
    {

        class student
        {
            public string name;
            public float marks;
            public student()
            {
                name = "unknown";
                marks = 0;
            }
            public student(student s)
            {
                name = s.name;

                marks = s.marks;

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                student s1 = new student();
                s1.name = "Hasnain";
                s1.marks = 0;
                student s2 = new student(s1);
                s2.name = "Qasim";
                Console.WriteLine("student s1 name : " + s1.name);
                Console.WriteLine("student s2 name : " + s2.name);

            }
        }
    }
}

