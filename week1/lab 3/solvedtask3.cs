using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    internal class solvedtask3
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            Console.Write("Enter Number: ");
            num = int.Parse(Console.ReadLine());
            while(num != -1)
            {
                sum = sum + num;
                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the total sum is {0}", sum);
            Console.Read();
        }
    }
}
