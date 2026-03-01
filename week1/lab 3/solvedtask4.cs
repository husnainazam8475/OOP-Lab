using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    internal class solvedtask4
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            do
            {
                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            sum = sum + 1;
            Console.WriteLine("The total sum is {0}", sum);
            Console.Read();
        }
    }
}
