using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class solvedtask5
    {
        
    class student
        {
            public string name;


        }
        class Program
        {
            static void Main(string[] args)
            {
                student student = new student();
                student.name = "Hasnain";
                student student2 = new student();
                student2.name = "Qasim";


                Console.WriteLine(student.name);
                Console.WriteLine(student2.name);
            }
        }
    }
}

