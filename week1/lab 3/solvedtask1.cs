using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    internal class solvedtask1
    {
        static void Main(string[] args)
        {
            string input;
            float marks;
            Console.Write("Enter the marks: ");
            input = Console.ReadLine();
            marks = float.Parse(input);
            if (marks > 50)
            {
                Console.WriteLine("You are passed");
            }
            else
            {
                Console.WriteLine("You are failed");
            }
            Console.Read();

        }
    }
}
