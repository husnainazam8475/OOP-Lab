using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    internal class solvedtask5
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int idx = 0; idx < 3; idx++)
            {
                Console.Write("Enter the Number {0}:", idx);
                numbers[idx] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for (int idx = 0; idx < 3; idx++)
            {
                if (numbers[idx] > largest)
                {
                    largest = numbers[idx];
                }

            }
            Console.WriteLine("Largest is: {0}", largest);
            Console.Read();
        }
    }
}
