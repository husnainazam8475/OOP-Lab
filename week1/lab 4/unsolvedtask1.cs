using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    internal class unsolvedtask1
    {
        static void pizza_points(int minOrders, int minPrice)
        {
            foreach (string line in File.ReadAllLines(@"C:\\Mac\\Home\\Desktop\\Uni\\OOP Lab\\week1\\lab 4\\customers.txt"))
            {
                string name = line.Split(' ')[0];

                string prices = line.Substring(line.IndexOf('[') + 1);
                prices = prices.Replace("]", "");

                int count = 0;

                foreach (string p in prices.Split(','))
                    if (int.Parse(p) >= minPrice)
                        count++;

                if (count >= minOrders)
                    Console.WriteLine(name);
            }
        }

        static void Main()
        {
            pizza_points(5, 20);
            Console.ReadLine();
        }
    }
}

