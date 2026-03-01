using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    class student
    {
        public string name;
    }
    internal class solvedtask1
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.name = "Ali";
            Console.WriteLine(s.name);
        }
    }
}
