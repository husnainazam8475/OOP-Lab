using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_2
{
    internal class solvedtask10
    {
        static void Main(string[] args)
        {
            float length;
            float area;
            string str;
            Console.WriteLine("enter length: ");
            str = Console.ReadLine();
            length = float.Parse( str );
            area = length * length;
            Console.WriteLine("The area is: ");
            Console.Write(area);
            Console.ReadKey();
        }
    }
}
