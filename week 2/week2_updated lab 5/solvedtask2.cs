using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    class students
    {
        public string name;
        public students()
        {
            name = "Default Name";
        }
    }
    internal class solvedtask2
    {
        static void Main(string[] args)
        {
            students s = new students();
            Console.WriteLine(s.name);
        }
    }
}
